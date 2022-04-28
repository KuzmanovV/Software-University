import { getByYear } from "../api/data.js";
import { html } from "../lib.js";

const byYearTemplate = () => html`
<section id="search-cars">
    <h1>Filter by year</h1>

    <div class="container">
        <input id="search-input" type="text" name="search" placeholder="Enter desired production year">
        <button @click=${onClick} class="button-list">Search</button>
    </div>

    <h2>Results:</h2>
    <div class="listings">

        <!-- Display all records -->


        <!-- Display if there are no matches -->
        <p class="no-cars"> No results.</p>
    </div>
</section>`;

function onClick(event) {
    return cars = getByYear(year);
}

const card = (car) => html`
<div class="listing">
    <div class="preview">
        <img src="${car.imageUrl}">
    </div>
    <h2>${car.brand} ${car.model}</h2>
    <div class="info">
        <div class="data-info">
            <h3>Year: ${car.year}</h3>
            <h3>Price: ${car.price} $</h3>
        </div>
        <div class="data-buttons">
            <a href="/details/${car._id}" class="button-carDetails">Details</a>
        </div>
    </div>
</div>`;

export async function byYearPage(ctx) {
    //Guard redirecting
    // if (getUserData()) {
    //     return ctx.page.redirect('/memes');
    // }
    
    ctx.render(byYearTemplate());
}