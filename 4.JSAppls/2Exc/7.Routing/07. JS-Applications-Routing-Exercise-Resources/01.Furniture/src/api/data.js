import * as api from './api.js';

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

const endPoints = {
    all: '/data/catalog',
    byId: '/data/catalog/',
    myItems: (userId) => `/data/catalog?where=_ownerId%3D%22${userId}%22`,
    create: '/data/catalog',
    edit: '/data/catalog/',
    delete: '/data/catalog/',
}

export async function  getAll() {
    return api.get(endPoints.all);
}

export async function  getById(id) {
    return api.get(endPoints.byId+id);
}

export async function getMyItems(userId) {
    return api.get(endPoints.myItems(userId));
}

export async function createItem(data) {
    return api.post(endPoints.create, data);
}

export async function editItem(id, data) {
    return api.put(endPoints.edit+id, data);
}

export async function deleteItem(id) {
    return api.del(endPoints.delete+id);
}

