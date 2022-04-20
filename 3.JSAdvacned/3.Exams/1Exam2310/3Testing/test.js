let { assert } = require('chai');

const library = {
    calcPriceOfBook(nameOfBook, year) {

        let price = 20;
        if (typeof nameOfBook != "string" || !Number.isInteger(year)) {
            throw new Error("Invalid input");
        } else if (year <= 1980) {
            let total = price - (price * 0.5);
            return `Price of ${nameOfBook} is ${total.toFixed(2)}`;
        }
        return `Price of ${nameOfBook} is ${price.toFixed(2)}`;
    },

    findBook: function (booksArr, desiredBook) {
        if (booksArr.length == 0) {
            throw new Error("No books currently available");
        } else if (booksArr.find(e => e == desiredBook)) {
            return "We found the book you want.";
        } else {
            return "The book you are looking for is not here!";
        }

    },
    arrangeTheBooks(countBooks) {
        const countShelves = 5;
        const availableSpace = countShelves * 8;

        if (!Number.isInteger(countBooks) || countBooks < 0) {
            throw new Error("Invalid input");
        } else if (availableSpace >= countBooks) {
            return "Great job, the books are arranged.";
        } else {
            return "Insufficient space, more shelves need to be purchased.";
        }
    }
};

describe("Library …", () => {
    describe("calcPriceOfBook(nameOfBook, year) …", () => {
        it("Not valid input …", () => {
            assert.throw(() => library.calcPriceOfBook(1, 1111), Error, "Invalid input");
            assert.throw(() => library.calcPriceOfBook('name', 'test'), Error, "Invalid input");
        });
        it("discount year", () => {
            assert.equal(library.calcPriceOfBook('name', 1980), `Price of name is 10.00`);
            assert.equal(library.calcPriceOfBook('name', 1970), `Price of name is 10.00`);
        });
        it("wt discount year", () => {
            assert.equal(library.calcPriceOfBook('name', 1988), `Price of name is 20.00`);
        });
    });
    describe("findBook(booksArr, desiredBook) …", () => {
        it("Not valid arr …", () => {
            assert.throw(() => library.findBook([], 'desiredBook'), Error, "No books currently available");
        });
        it("Found …", () => {
            assert.equal(library.findBook(['a', 'b'], 'b'), "We found the book you want.");
        });
        it("Not found …", () => {
            assert.equal(library.findBook(['a', 'b'], 'c'), "The book you are looking for is not here!");
        });
    });
    describe("arrangeTheBooks(countBooks) …", () => {
        it("Not valid inp …", () => {
            assert.throw(() => library.arrangeTheBooks('a'), Error, "Invalid input");
            assert.throw(() => library.arrangeTheBooks(-1), Error, "Invalid input");
        });
        it("Available …", () => {
            assert.equal(library.arrangeTheBooks(39), "Great job, the books are arranged.");
            assert.equal(library.arrangeTheBooks(40), "Great job, the books are arranged.");
        });
        it("Not available …", () => {
            assert.equal(library.arrangeTheBooks(41), "Insufficient space, more shelves need to be purchased.");
        });
    });
});
