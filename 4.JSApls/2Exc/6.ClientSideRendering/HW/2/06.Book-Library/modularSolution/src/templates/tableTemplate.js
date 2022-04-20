import { getBook, deleteBook } from '../api/data.js';
import { html, updateDOM } from '../app.js';
import { displayEditForm } from '../showTemplates.js';

export const tableTemplate = (books) =>
  html`<button id="loadBooks" @click=${updateDOM}>LOAD ALL BOOKS</button>
  <table>
    <thead>
      <tr>
        <th>Title</th>
        <th>Author</th>
        <th>Action</th>
      </tr>
    </thead>
    <tbody>
      ${books.map(
        (book) => html`
          <tr>
            <td>${book.title}</td>
            <td>${book.author}</td>
            <td id=${book.id}>
              <button @click=${onClickEditBook}>Edit</button>
              <button @click=${onClickDeleteBook}>Delete</button>
            </td>
          </tr>
        `
      )}
      </tr>
    </tbody>
  </table>`;

function onClickEditBook(ev) {
  getBook(ev.target.parentElement.id)
    .then((book) => {
      displayEditForm(book);
    })
    .catch((err) => alert(err.message));
}

function onClickDeleteBook(ev) {
  deleteBook(ev.target.parentElement.id)
    .then(() => updateDOM())
    .catch((err) => alert(err.message));
}
