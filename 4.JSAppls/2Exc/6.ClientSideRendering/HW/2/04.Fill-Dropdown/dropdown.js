import { render, html } from './node_modules/lit-html/lit-html.js';

async function solve() {
  const menu = document.querySelector('#menu');
  const form = document.querySelector('form');
  const item = document.getElementById('itemText');

  form.addEventListener('submit', onSubmit);

  const optionsTemplate = (towns) =>
    html`${towns.map(
      (town) => html`<option value=${town._id}>${town.text}</option>`
    )}`;

  updateDOM();

  async function updateDOM() {
    try {
      const towns = await getData();
      render(optionsTemplate(towns), menu);
    } catch (err) {
      alert(err.message);
    }
  }

  function onSubmit(ev) {
    ev.preventDefault();

    const town = item.value;
    item.value = '';
    
    postData(town)
      .then((isOK) => isOK && updateDOM())
      .catch((err) => alert(err.message));
  }

  async function getData() {
    const URL = 'http://localhost:3030/jsonstore/advanced/dropdown';
    const response = await fetch(URL);
    return Object.values(await response.json());
  }

  async function postData(text) {
    const URL = 'http://localhost:3030/jsonstore/advanced/dropdown';
    const options = {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({ text }),
    };
    const response = await fetch(URL, options);
    return response.ok;
  }
}

solve();
