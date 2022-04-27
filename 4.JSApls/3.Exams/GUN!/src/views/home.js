import { html } from "../lib.js";
import { getAll } from "../api/data.js";

const homeTemplate = () => html`
<section id="main">
            <div id="welcome-container">
                <h1>Welcome To Car Tube</h1>
                <img class="hero" src="/images/car-png.webp" alt="carIntro">
                <h2>To see all the listings click the link below:</h2>
                <div>
                    <a href="/catalog" class="button">Listings</a>
                </div>
            </div>
        </section>`;

// const card = (game) => html`
// <div class="game">
//     <div class="image-wrap">
//         <img src="${game.imageUrl}">
//     </div>
//     <h3>${game.title}</h3>
//     <div class="rating">
//         <span>☆</span><span>☆</span><span>☆</span><span>☆</span><span>☆</span>
//     </div>
//     <div class="data-buttons">
//         <a href="/details/${game._id}" class="btn details-btn">Details</a>
//     </div>
// </div>`;

export async function homePage(ctx) {
    //Guard redirecting
    // if (getUserData()) {
    //     return ctx.page.redirect('/memes');
    // }
    // const games = await getNewest();

    ctx.render(homeTemplate());
}