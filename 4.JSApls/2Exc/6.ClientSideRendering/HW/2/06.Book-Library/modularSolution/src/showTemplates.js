import { render } from './app.js';
import { addFormTemplate } from './templates/addFormTemplate.js';
import { editFormTemplate } from './templates/editFormTemplate.js';
import { tableTemplate } from './templates/tableTemplate.js';

const body = document.querySelector('#content');
const section = document.querySelector('#form');

export function displayTemplates(books) {
  render(tableTemplate(books), body);
  render(addFormTemplate(), section);
}

export function displayEditForm(book) {
  render(editFormTemplate(book), section);
}

