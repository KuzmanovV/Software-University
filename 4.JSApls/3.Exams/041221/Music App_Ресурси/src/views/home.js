import { html } from "../lib.js";
import { getAll } from "../api/data.js";

const homeTemplate = () => html`
<section id="welcomePage">
            <div id="welcome-message">
                <h1>Welcome to</h1>
                <h1>My Music Application!</h1>
            </div>

            <div class="music-img">
                <img src="./images/musicIcons.webp">
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