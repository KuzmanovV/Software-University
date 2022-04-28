import { deleteItem, getById, getTotalLikes, getUserLike, likeItem } from "../api/data.js";
import { html } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemplate = (card, isOwner, onDelete, likes, showLikeBtn, onLike) => html`
<section id="details-page" class="details">
    <div class="book-information">
        <h3>${card.title}</h3>
        <p class="type">Type: ${card.type}</p>
        <p class="img"><img src="${card.imageUrl}"></p>
        <div class="actions">
            ${isOwner ? html`<a class="button" href="/edit/${card._id}">Edit</a>
            <a class="button" @click=${onDelete} href="javascript:void(0)">Delete</a>` : null}

            <!-- Bonus -->
            <!-- Like button ( Only for logged-in users, which are not creators of the current book ) -->
            ${showLikeBtn ? html`<a class="button" @click=${onLike}  href="javascript:void(0)">Like</a>`:null}

            <div class="likes">
                <img class="hearts" src="/images/heart.png">
                <span id="total-likes">Likes: ${likes}</span>
            </div>
        </div>
    </div>
    <div class="book-description">
        <h3>Description:</h3>
        <p>${card.description}</p>
    </div>
</section>`;

export async function detailsPage(ctx) {
    const userData = getUserData();

    //const card = await getById(ctx.params.id);

    const [card, likes, hasLike] = await Promise.all([
        getById(ctx.params.id),
        getTotalLikes(ctx.params.id),
        userData ? getUserLike(ctx.params.id, userData.id) : 0
    ]);

    const isOwner = userData && card._ownerId == userData.id;

    const showLikeBtn = userData != null && isOwner==false && hasLike==false; 
    
    ctx.render(detailsTemplate(card, isOwner, onDelete, likes, showLikeBtn, onLike));

    async function onDelete() {
        if (confirm('Sure?')) {
            await deleteItem(ctx.params.id);
            ctx.page.redirect('/');
        }
    }

    async function onLike() {
        await likeItem(ctx.params.id);
        ctx.page.redirect('/details/' + ctx.params.id);
    }
}

