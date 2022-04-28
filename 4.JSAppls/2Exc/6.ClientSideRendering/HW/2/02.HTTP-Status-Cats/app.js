import { render, html } from './node_modules/lit-html/lit-html.js'; 
import { cats } from './catSeeder.js';

solve();

function solve() {
  const section = document.getElementById('allCats');
  cats.forEach((cat) => (cat.info = false));

  const catCardTemplate = (cat) => html`<li>
    <img
      src="./images/${cat.imageLocation}.jpg"
      width="250"
      height="250"
      alt="Card image cap"
    />
    <div class="info">
      <button @click=${() => toggleInfo(cat)} class="showBtn">
        ${cat.info ? 'Hide' : 'Show'} status code
      </button>
      ${cat.info
        ? html`<div class="status" id=${cat.id}>
            <h4>Status Code: ${cat.statusCode}</h4>
            <p>${cat.statusMessage}</p>
          </div>`
        : null}
    </div>
  </li>`;

  const listTemplate = (cats) =>
    html`<ul>
      ${cats.map(catCardTemplate)}
    </ul>`;

  updateDOM();

  function updateDOM() {
    render(listTemplate(cats), section);
  }

  function toggleInfo(cat) {
    cat.info = !cat.info;
    updateDOM();
  }
}
