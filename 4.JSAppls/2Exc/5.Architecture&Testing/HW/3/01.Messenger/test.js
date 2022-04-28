const { chromium } = require('playwright-chromium');
const { expect } = require('chai');

let mockData = {
1:{"author":"Spami","content":"Hello, are you there?"},
2:{"author":"Garry","content":"Yep, whats up :?"},
3:{"author":"Spami","content":"How are you? Long time no see? :)"},
4:{"author":"George","content":"Hello, guys! :))"},
5:{"author":"Spami","content":"Hello, George nice to see you! :)))"}
};

function json(data) {
    return {
        status: 200,
        headers: {
            'Access-Control-Allow-Origin': '*',
            'ContentType': 'application/json'
        },
        body: JSON.stringify(data)
    };
}

let testMessage = {
        6:{
            author:"Peter",
            content:"Hello, it\'s me",
            _id: 6
    },
        7:{
            author:"John",
            content:"Hi, whats up :?",
            _id: 7
        }
    }
describe('Tests', async function() {
    this.timeout(6000); //60000

    let page, browser;

    before(async () => { browser = await chromium.launch({headless: false, slowMo: 500}); });
        // browser = await chromium.launch();  
    after(async () => { await browser.close(); });
    beforeEach(async () => { page = await browser.newPage(); });
    afterEach(async () => { await page.close(); });

    it('load messages', async () => {
        await page.route('**/jsonstore/messenger', route => {
            route.fulfill(json(mockData));
        });

        await page.goto('http://localhost:5500');

        const [response] = await Promise.all([
            page.waitForResponse('**/jsonstore/messenger'),
            page.click('text=Refresh')
        ]);
                
        let area = await response.json();
        //console.log(area)
        expect(area).to.eql(mockData);
        
    });

    it('show messages in area', async () => {
        await page.route('**/jsonstore/messenger', route => {
            route.fulfill(json(mockData))
        });

        await page.goto('http://localhost:5500');

        const [response] = await Promise.all([
            page.waitForResponse('**/jsonstore/messenger'),
            page.click('text=Refresh')
        ]);
                
        let areaText = await page.$eval('#messages', (textArea) => textArea.value);
        //console.log(areaText);

        let text = Object.values(mockData)
        .map(t => `${t.author}: ${t.content}`)
        .join('\n');

        expect(areaText).to.eql(text);
        
    });

    it('create messages', async () => {
        let requestData = undefined;
        let expected = {
            author:"Peter",
            content:"Hello, it\'s me"
        }
        await page.route('**/jsonstore/messenger', (route, request)=> {
            if(request.method() == 'POST') {
                requestData = request.postData();
                route.fulfill(json(testMessage));
            }
            
        });

        await page.goto('http://localhost:5500');

        await page.fill('#author', expected.author);
        await page.fill('#content', expected.content);

        const [response] = await Promise.all([
            page.waitForResponse('**/jsonstore/messenger'),
            page.click('text=Send')
        ]);
                
        let areaExp = JSON.parse(requestData);
        //console.log(areaExp)
        expect(areaExp).to.eql(expected);
        
    });

    it('cleat input fields', async () => {
        let requestData = undefined;
        let expected = {
            author:"Peter",
            content:"Hello, it\'s me"
        }
        await page.route('**/jsonstore/messenger', (route, request)=> {
            if(request.method() == 'POST') {
                requestData = request.postData();
                route.fulfill(json(testMessage));
            }
            
        });

        await page.goto('http://localhost:5500');

        await page.fill('#author', expected.author);
        await page.fill('#content', expected.content);

        const [response] = await Promise.all([
            page.waitForResponse('**/jsonstore/messenger'),
            page.click('text=Send')
        ]);

        let authorFields = await page.$eval('#author', a => a.value);
        let contentFields = await page.$eval('#content', c => c.value);
                
        expect(authorFields).to.equal('');
        expect(contentFields).to.equal('');    
    });
   
});

