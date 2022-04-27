import { createItem } from "../api/data.js";
import { html } from "../lib.js";
//import { notify } from "../notify.js";

const createTemplate = (onSubmit) => html`
<section id="create-listing">
    <div class="container">
        <form @submit=${onSubmit} id="create-form">
            <h1>Create Car Listing</h1>
            <p>Please fill in this form to create an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price">

            <hr>
            <input type="submit" class="registerbtn" value="Create Listing">
        </form>
    </div>
</section>`;

export function createPage(ctx) {
    ctx.render(createTemplate(onSubmit));

    async function onSubmit(event) {
        event.preventDefault();
        const formData = new FormData(event.target);

        // const title = formData.get('title').trim();
        // const category = formData.get('category').trim();
        // const maxLevel = formData.get('maxLevel').trim();
        const brand = formData.get('brand').trim();
        const model = formData.get('model').trim();
        const description = formData.get('description').trim();
        const year = Number(formData.get('year').trim());
        const imageUrl = formData.get('imageUrl').trim();
        const price = Number(formData.get('price').trim());
        // const summary = formData.get('summary').trim();

        if (Number(year)||Number(price)|| year < 0 || price < 0 || brand=='' || model==''||description==''||year=='',imageUrl==''||price=='') {
            //return notify('All fields are requred!');
            return alert('Price and Year must be positive numbers!');
        };

        await createItem({
            brand,
            model,
            description,
            year,
            imageUrl,
            price,
        });
        ctx.page.redirect('/catalog');
    };
};