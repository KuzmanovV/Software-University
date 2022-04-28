import { createBook } from "../api/data.js";
import { html, updateDOM } from "../app.js";

export const addFormTemplate = () =>
  html`<form @submit=${onAddFormSubmit} id="add-form">
    <h3>Add book</h3>
    <label>TITLE</label>
    <input type="text" name="title" placeholder="Title..." />
    <label>AUTHOR</label>
    <input type="text" name="author" placeholder="Author..." />
    <input type="submit" value="Submit" />
  </form>`;

function onAddFormSubmit(ev) {
  ev.preventDefault();
  const form = document.querySelector('#add-form');
  const formData = new FormData(form);

  const title = formData.get('title');
  const author = formData.get('author');

  form.reset();

  if (title == '' || author == '') {
    alert('Fill missing fields');
    return;
  }

  createBook({ title, author })
    .then(() => updateDOM())
    .catch((err) => alert(err.message));
}
