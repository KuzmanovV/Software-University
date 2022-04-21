import { html } from "../lib.js";

const searchTemplate = (isClicked, onSearch) => html`
<section id="searchPage">
    <h1>Search by Name</h1>

    <div class="search">
        <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
        <button @click=${onSearch} class="button-list">Search</button>
    </div>

    <h2>Results:</h2>

    <!--Show after click Search button-->
    ${isClicked ? html`<div class="search-result">
    <p class="no-result">No result.</p>`
                                    : null};
        <!--If have matches-->

        <!--If there are no matches-->
        
    </div>
</section>>`;



// <div class="card-box">
//     <img src="./images/BrandiCarlile.png">
//     <div>
//         <div class="text-center">
//             <p class="name">Name: In These Silent Days</p>
//             <p class="artist">Artist: Brandi Carlile</p>
//             <p class="genre">Genre: Low Country Sound Music</p>
//             <p class="price">Price: $12.80</p>
//             <p class="date">Release Date: October 1, 2021</p>
//         </div>
//         <div class="btn-group">
//             <a href="#" id="details">Details</a>
//         </div>
//     </div>
// </div>


// const card = (car) => html`
// <div class="listing">
//     <div class="preview">
//         <img src="${car.imageUrl}">
//     </div>
//     <h2>${car.brand} ${car.model}</h2>
//     <div class="info">
//         <div class="data-info">
//             <h3>Year: ${car.year}</h3>
//             <h3>Price: ${car.price} $</h3>
//         </div>
//         <div class="data-buttons">
//             <a href="/details/${car._id}" class="button-carDetails">Details</a>
//         </div>
//     </div>
// </div>`;

export async function searchPage(ctx) {
    //Guard redirecting
    // if (getUserData()) {
    //     return ctx.page.redirect('/memes');
    // }
let isClicked = false;
function onSearch() {
    isClicked = true;
};
    ctx.render(searchTemplate(onSearch, isClicked));
}