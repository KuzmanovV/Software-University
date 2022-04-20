function getArticleGenerator(articles) {
    let arr = articles;
    let contentE = document.getElementById('content');
    
    return () => {
        if (arr.length != 0) {
            let art = document.createElement('article');
            contentE.appendChild(art);
            return art.textContent += articles.shift();
        }
    }
}
