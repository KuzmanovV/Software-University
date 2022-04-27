import { editItem, getById } from "../api/data.js";
import { html } from "../lib.js";
//import { notify } from "../notify.js";

const editTemplate = (card, onSubmit) => html`
<section id="edit-page" class="auth">
    <form @submit=${onSubmit} id="edit">
        <div class="container">

            <h1>Edit Game</h1>
            <label for="leg-title">Legendary title:</label>
            <input type="text" id="title" name="title" .value=${card.title}>

            <label for="category">Category:</label>
            <input type="text" id="category" name="category" .value=${card.category}>

            <label for="levels">MaxLevel:</label>
            <input type="number" id="maxLevel" name="maxLevel" min="1" .value=${card.maxLevel}>

            <label for="game-img">Image:</label>
            <input type="text" id="imageUrl" name="imageUrl"  .value=${card.imageUrl}>

            <label for="summary">Summary:</label>
            <textarea name="summary" id="summary">${card.summary}</textarea>
            <input class="btn submit" type="submit"  value="Edit Game">

        </div>
    </form>
</section>`;    

export async function editPage(ctx) {
    const card = await getById(ctx.params.id);
    
    ctx.render(editTemplate(card, onSubmit));

    async function onSubmit(event) {
        event.preventDefault();
        const formData = new FormData(event.target);

        const title = formData.get('title').trim();
        const category = formData.get('category').trim();
        const maxLevel = formData.get('maxLevel').trim();
        const imageUrl = formData.get('imageUrl').trim();
        const summary = formData.get('summary').trim();

        if (title == '' || summary == '' || imageUrl == '' || category == '' || maxLevel == '') {
            //return notify('All fields are requred!');
            return alert('All fields are requred!');
        };

        await editItem(ctx.params.id, {
            title,
            category,
            maxLevel,
            imageUrl,
            summary,
        });
        ctx.page.redirect(`/details/${ctx.params.id}`);
    };
};