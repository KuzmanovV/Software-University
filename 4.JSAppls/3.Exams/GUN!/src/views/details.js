import { deleteItem, getById } from "../api/data.js";
import { html } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemplate = (card, isOwner, onDelete) => html`
<section id="listing-details">
            <h1>Details</h1>
            <div class="details-info">
                <img src="${card.imageUrl}">
                <hr>
                <ul class="listing-props">
                    <li><span>Brand:</span>${card.brand}</li>
                    <li><span>Model:</span>${card.model}</li>
                    <li><span>Year:</span>${card.year}</li>
                    <li><span>Price:</span>${card.price}$</li>
                </ul>

                <p class="description-para">${card.description}</p>

                        ${isOwner ? html`<div class="buttons">
                            <a href="/edit/${card._id}" class="button-list">Edit</a>
                            <a @click=${onDelete} href="javascript:void(0)" class="button-list">Delete</a>
                        </div>`
                        : null};

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