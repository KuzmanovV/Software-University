import { editItem, getById } from "../api/data.js";
import { html } from "../lib.js";
//import { notify } from "../notify.js";

const editTemplate = (onSubmit, card) => html`
<section id="edit-listing">
    <div class="container">

        <form @submit=${onSubmit} id="edit-form">
            <h1>Edit Car Listing</h1>
            <p>Please fill in this form to edit an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand" .value="${card.brand}">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model" .value="${card.model}">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description" .value="${card.description}">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year" .value="${card.year}">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl" .value="${card.imageUrl}">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price" .value="${card.price}">

            <hr>
            <input type="submit" class="registerbtn" value="Edit Listing">
        </form>
    </div>
</section>`;

export async function editPage(ctx) {
    const card = await getById(ctx.params.id);

    ctx.render(editTemplate(onSubmit, card));

    async function onSubmit(event) {
        event.preventDefault();
        const formData = new FormData(event.target);

        const brand = formData.get('brand').trim();
        const model = formData.get('model').trim();
        const description = formData.get('description').trim();
        const year = Number(formData.get('year').trim());
        const imageUrl = formData.get('imageUrl').trim();
        const price = Number(formData.get('price').trim());

        if (Number(year)||Number(price)|| year < 0 || price < 0 || brand=='' || model==''||description==''||year=='',imageUrl==''||price=='') {
            //return notify('All fields are requred!');
            return alert('All fields are requred!');
        };

        await editItem(ctx.params.id, {
            brand,
            model,
            description,
            year,
            imageUrl,
            price,
        });
        ctx.page.redirect(`/details/${ctx.params.id}`);
    };
};