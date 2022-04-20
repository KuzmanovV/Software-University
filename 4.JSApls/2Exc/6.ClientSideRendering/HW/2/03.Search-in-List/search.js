import { render, html } from './node_modules/lit-html/lit-html.js';
import { towns as townsData } from './towns.js';

solve();

function solve() {
  const townsDIV = document.getElementById('towns');
  const searchBtn = document.querySelector('button');
  const searchText = document.getElementById('searchText');

  const towns = townsData.map((town) => ({ town, active: false }));

  searchBtn.addEventListener('click', onSearch);

  const townsListTemplate = (towns) =>
    html`<ul>
      ${towns.map(townTemplate)}
    </ul>`;

  const townTemplate = (townInfo) =>
    html`<li class=${townInfo.active ? 'active' : null}>${townInfo.town}</li>`;

  updateDOM();

  function updateDOM() {
    render(townsListTemplate(towns), townsDIV);
  }

  function onSearch() {
    const text = searchText.value.trim().toLowerCase();
    let matches = 0;

    towns.forEach((townInfo) => {
      if (text && townInfo.town.toLowerCase().includes(text)) {
        townInfo.active = true;
        matches++;
      } else {
        townInfo.active = false;
      }
    });

    document.getElementById('result').textContent = `${matches} matches found`;
    updateDOM();
  }
}
