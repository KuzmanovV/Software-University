import * as api from './api.js';

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

const endPoints = {
    all: '/data/games?sortBy=_createdOn%20desc',
    create: '/data/games',
    byId: '/data/games/',
    delete: '/data/games/',
    edit: '/data/games/',
    // myItems: (userId) => `/data/books?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`,
}

export async function  getAll() {
    return api.get(endPoints.all);
}

export async function createItem(data) {
    return api.post(endPoints.create, data);
}

export async function  getById(id) {
    return api.get(endPoints.byId+id);
}

export async function deleteItem(id) {
    return api.del(endPoints.delete+id);
}

export async function editItem(id, data) {
    return api.put(endPoints.edit+id, data);
}

// export async function getMyItems(userId) {
//     return api.get(endPoints.myItems(userId));
// }

// export async function likeItem(itemId) {
//     return api.post('/data/likes', {itemId});
// };
// window.likeItem = likeItem;

// export async function getTotalLikes(itemId) {
//     return api.get(`/data/likes?where=bookId%3D%22${itemId}%22&distinct=_ownerId&count`);
// }
// // window.getTotalLikes = getTotalLikes;

// export async function getUserLike(itemId, userId) {
//     return api.get(`/data/likes?where=bookId%3D%22${itemId}%22%20and%20_ownerId%3D%22${userId}%22&count`);
// }
// window.getUserLike = getUserLike;
