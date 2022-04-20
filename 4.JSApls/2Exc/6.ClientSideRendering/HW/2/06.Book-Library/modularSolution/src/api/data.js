import * as api from './api.js';

// don't need that for this task, no users
export const login = api.login;
export const register = api.register;
export const logout = api.logout;
//

export async function getAllBooks() {
  const booksData = await api.get('/jsonstore/collections/books');
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

export async function getBook(id) {
  const book = await api.get('/jsonstore/collections/books/' + id);
  return { ...book, id };
}

export async function createBook(data) {
  return api.post('/jsonstore/collections/books', data);
}

export async function updateBook(id, data) {
  return api.put('/jsonstore/collections/books/' + id, data);
}

export async function deleteBook(id) {
  return api.del('/jsonstore/collections/books/' + id);
}
