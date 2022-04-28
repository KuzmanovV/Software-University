// LOAD ALL BOOKS button is kinda useless,
// because after every action DOM has been updated.

import { render, html } from './node_modules/lit-html/lit-html.js';

solve();

function solve() {
  const body = document.querySelector('#content');
  const section = document.querySelector('#form');

  const tableTemplate = (books) =>
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

  const addFormTemplate = () =>
    html`<form @submit=${onAddFormSubmit} id="add-form">
      <h3>Add book</h3>
      <label>TITLE</label>
      <input type="text" name="title" placeholder="Title..." />
      <label>AUTHOR</label>
      <input type="text" name="author" placeholder="Author..." />
      <input type="submit" value="Submit" />
    </form>`;

  const editFormTemplate = (book) =>
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

  updateDOM();

  async function getAllBooks() {
    const URL = 'http://localhost:3030/jsonstore/collections/books';
    const response = await fetch(URL);
    const booksData = await response.json();
    const ids = Object.keys(booksData);
    const books = ids.reduce((books, id) => {
      books.push({
        id: id,
        ...booksData[id],
      });
      return books;
    }, []);

    return books;
  }

  async function getBook(id) {
    const URL = 'http://localhost:3030/jsonstore/collections/books/' + id;
    const response = await fetch(URL);
    const book = await response.json();
    return { ...book, id };
  }

  async function deleteBook(id) {
    const URL = 'http://localhost:3030/jsonstore/collections/books/' + id;
    const response = await fetch(URL, { method: 'DELETE' });
    if (response.ok !== true) {
      throw new Error('Error deleting book');
    }
  }

  async function createBook(data) {
    const URL = 'http://localhost:3030/jsonstore/collections/books/';
    const response = await fetch(URL, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    });
    if (response.ok !== true) {
      throw new Error('Error creating book');
    }
  }

  function updateDOM() {
    getAllBooks()
      .then((books) => {
        displayTable(books);
        displayAddForm();
      })
      .catch((err) => alert(err));
  }

  function displayTable(books) {
    render(tableTemplate(books), body);
  }

  function displayAddForm() {
    render(addFormTemplate(), section);
  }

  function displayEditForm(book) {
    render(editFormTemplate(book), section);
  }

  function onClickDeleteBook(ev) {
    deleteBook(ev.target.parentElement.id)
      .then(() => updateDOM())
      .catch((err) => alert(err.message));
  }

  function onClickEditBook(ev) {
    getBook(ev.target.parentElement.id)
      .then((book) => {
        displayEditForm(book);
      })
      .catch((err) => alert(err.message));
  }

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

    editBook(form.getAttribute('bookId'), { title, author })
      .catch((err) => alert(err.message))
      .finally(() => updateDOM());
  }

  async function editBook(id, book) {
    const URL = 'http://localhost:3030/jsonstore/collections/books/' + id;
    const response = await fetch(URL, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(book),
    });
    if (response.ok !== true) {
      throw new Error('Error editing book');
    }
  }
}
