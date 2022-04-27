const Gen = require('../models/Gen');


async function getAllGens() {
    return Gen.find({}).lean();
}

async function getGensByUser(userId) {
    return Gen.find({owner: userId}).lean();
}

async function getGenById(id) {
    return Gen.findById(id).lean();
}

async function getGenAndUsers(id) {
    return Gen.findById(id).populate('owner').populate('buddies').lean();
}

async function createGen(gen) {
    const result = new Gen(gen);
    await result.save();
}

async function updateGen(id, gen) {
    const existing = await Gen.findById(id);

    existing.title = gen.title;
    existing.keyword = gen.keyword;
    existing.location = gen.location;
    existing.tidateme = gen.date;
    existing.image = gen.image;
    existing.description = gen.description;

    await existing.save();
}

async function deleteById(id) {
    await Gen.findByIdAndDelete(id);
}

async function getPostsByAuthor(userId){
    return Gen.find({author: userId});
}

// async function joinGen(genId, userId) {
//     const gen = await Gen.findById(genId);

//     if (gen.buddies.includes(userId)) {
//         throw new Error('User is already a part of the trip.');
//     }

//     gen.buddies.push(userId);
//     await gen.save();
// }

async function vote(genId, userId, value) {
    const post = await Gen.findById(genId);

    if (post.votes.includes(userId)) {
        throw new Error('User has already voted.');
    }

    post.votes.push(userId);
    post.rating += value;

    await post.save();
}

module.exports = {
    getAllGens,
    getGenById,
    createGen,
    getGenAndUsers,
    updateGen,
    deleteById,
    //joinGen,
    getGensByUser,
    vote,
    getPostsByAuthor,
};