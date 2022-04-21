import { deleteItem, getById } from "../api/data.js";
import { html } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemplate = (card, isOwner, onDelete) => html`
<section id="detailsPage">
            <div class="wrapper">
                <div class="albumCover">
                    <img src="${card.imgUrl}">
                </div>
                <div class="albumInfo">
                    <div class="albumText">

                        <h1>Name: ${card.name}</h1>
                        <h3>Artist: ${card.artist}</h3>
                        <h4>Genre: ${card.genre}</h4>
                        <h4>Price: $${card.price}</h4>
                        <h4>Date: ${card.releaseDate}</h4>
                        <p>Description: ${card.description}</p>
                    </div>

                    <!-- Only for registered user and creator of the album-->
            ${isOwner ? html`<div class="actionBtn">
                                        <a href="/edit/${card._id}" class="edit">Edit</a>
                                        <a @click=${onDelete} href="javascript:void(0)" class="remove">Delete</a>
                                    </div>`
                                    : null};
                    
                    </div>
                </div>
            </div>
        </section>`;


export async function detailsPage(ctx) {
    const userData = getUserData();

    const card = await getById(ctx.params.id);

    const isOwner = userData && card._ownerId == userData.id;

    let loggedUser = false;
    if (userData) {
    loggedUser = true;
    } 

    ctx.render(detailsTemplate(card, isOwner, onDelete, loggedUser));

    async function onDelete() {
        if (confirm('Sure?')) {
            await deleteItem(ctx.params.id);
            ctx.page.redirect('/catalog');
        }
    }
};