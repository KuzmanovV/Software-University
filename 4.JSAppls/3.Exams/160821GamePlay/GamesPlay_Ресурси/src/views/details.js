import { deleteItem, getById } from "../api/data.js";
import { html } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemplate = (card, isOwner, onDelete, loggedUser) => html`
<section id="game-details">
    <h1>Game Details</h1>
    <div class="info-section">
        <div class="game-header">
            <img class="game-img" src="${card.imageUrl}" />
            <h1>${card.title}</h1>
            <span class="levels">MaxLevel: ${card.maxLevel}</span>
            <p class="type">${card.category}</p>
        </div>
        <p class="text">
            ${card.summary}
        </p>

        <!-- Bonus ( for Guests and Users ) -->
        <div class="details-comments">
            <h2>Comments:</h2>
            <ul>
                <!-- list all comments for current game (If any) -->
                <li class="comment">
                    <p>Content: I rate this one quite highly.</p>
                </li>
                <li class="comment">
                    <p>Content: The best game.</p>
                </li>
            </ul>
            <!-- Display paragraph: If there are no games in the database -->
            <p class="no-comment">No comments.</p>
        </div>

        <!-- Edit/Delete buttons ( Only for creator of this game )  -->
        ${isOwner ? html`<div class="buttons">
                            <a href="/edit/${card._id}" class="button">Edit</a>
                            <a @click=${onDelete} href="javascript:void(0)" class="button">Delete</a>
                        </div>`
                    : null};
    </div>

    <!-- Bonus -->
    <!-- Add Comment ( Only for logged-in users, which is not creators of the current game ) -->
    ${(loggedUser && !isOwner) ? html`<article class="create-comment">
                <label>Add new comment:</label>
                <form  @submit=${onSubmit} class="form">
                    <textarea name="comment" placeholder="Comment......"></textarea>
                    <input class="btn submit" type="submit" value="Add Comment">
                </form>
            </article>`
            : null}
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
            ctx.page.redirect('/');
        }
    }
};

//Bonus
function onSubmit(event, game) {
    event.preventDefault();
        const formData = new FormData(event.target);

        const comment = formData.get('comment').trim();

        if (comment == '') {
            //return notify('All fields are requred!');
            return alert('All fields are requred!');
        };

        // await editItem({
        //     game.id,
        //     comment,
        // });
}

