import { html, render } from './node_modules/lit-html/lit-html.js';

solve();

function solve() {
  const form = document.querySelector('form');
  const root = document.querySelector('#root');

  const templateUL = (towns) =>
    html`<ul>
      ${towns.map((town) => html`<li>${town}</li>`)}
    </ul>`;

  form.addEventListener('submit', (ev) => {
    ev.preventDefault();
    const formData = new FormData(form);
    const towns = formData.get('towns').split(', ');

    const filledUL = templateUL(towns);

    render(filledUL, root);
  });
}
