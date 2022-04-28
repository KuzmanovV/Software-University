// LOAD ALL BOOKS button is kinda useless,
// because after every action DOM has been updated.

import { render, html } from '../node_modules/lit-html/lit-html.js';
import { getAllBooks } from './api/data.js';
import { displayTemplates } from './showTemplates.js';

updateDOM();

export function updateDOM() {
  getAllBooks()
    .then((books) => {
      displayTemplates(books);
    })
    .catch((err) => alert(err));
}

export { render, html };
