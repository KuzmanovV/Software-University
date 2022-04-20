import { render, html } from './node_modules/lit-html/lit-html.js';

solve().catch((err) => alert(err.message));

async function solve() {
  document.querySelector('#searchBtn').addEventListener('click', onClick);
  const tableBody = document.querySelector('tbody');
  const tableBodyTemplate = (persons) =>
    html`${persons.map(
      (person) =>
        html`<tr
          value="${person._id}"
          class=${person.selected ? 'select' : null}
        >
          <td>${person.firstName} ${person.lastName}</td>
          <td>${person.email}</td>
          <td>${person.course}</td>
        </tr>`
    )}`;

  const persons = await getPersons();

  updateDOM();

  function onClick() {
    const searchWordInput = document.querySelector('#searchField');
    const word = searchWordInput.value.trim().toLowerCase();
    searchWordInput.value = '';
    updateDOM(word);
  }

  async function getData() {
    const URL = 'http://localhost:3030/jsonstore/advanced/table';
    const response = await fetch(URL);
    return Object.values(await response.json());
  }

  async function updateDOM(word) {
    persons.forEach((person) => {
      const personData = Object.values(person).slice(0, -1);

      const doesMatchExist = personData.some((info) =>
        info.toLowerCase().includes(word)
      );

      if (word && doesMatchExist) {
        person.selected = true;
      } else {
        person.selected = false;
      }
    });

    render(tableBodyTemplate(persons), tableBody);
  }

  async function getPersons() {
    const data = await getData();
    const persons = data.map(addSelectProperty);
    return persons;
  }

  function addSelectProperty(person) {
    person.selected = false;
    return person;
  }
}
