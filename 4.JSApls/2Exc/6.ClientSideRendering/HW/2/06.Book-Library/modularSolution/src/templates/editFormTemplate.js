import { updateBook } from '../api/data.js';
import { html, updateDOM } from '../app.js';

export const editFormTemplate = (book) =>
  html`<form @submit=${onEditFormSubmit} bookId=${book.id} id="edit-form">
    <input type="hidden" name="id" />
    <h3>Edit book</h3>
    <label>TITLE</label>
    <input
      type="text"
      name="title"
      placeholder="Title..."
      value=${book.title}
    />
    <label>AUTHOR</label>
    <input
      type="text"
      name="author"
      placeholder="Author..."
      value=${book.author}
    />
    <input type="submit" value="Save" />
  </form>`;

function onEditFormSubmit(ev) {
  ev.preventDefault();
  const form = document.querySelector('#edit-form');
  const formData = new FormData(form);

  const title = formData.get('title');
  const author = formData.get('author');

  form.reset();

  if (title == '' || author == '') {
    alert('Fill missing fields');
    return;
  }

  updateBook(form.getAttribute('bookId'), { title, author })
    .catch((err) => alert(err.message))
    .finally(() => updateDOM());
}
