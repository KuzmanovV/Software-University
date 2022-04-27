const Trip = require('../models/Trip');
const User = require('../models/User');
//TODO Change service name and funcs names.

async function getAllTrips() {
    return Trip.find({}).lean();
}

// async function getTripsByUser(userId) {
//     return Trip.find({owner: userId}).lean();
// }

async function getTripById(id) {
    return Trip.findById(id).lean();
}

async function getTripAndUsers(id) {
    return Trip.findById(id).populate('author').lean();
}

async function createTrip(trip) {
    const result = new Trip(trip);
    await result.save();
}

async function updateTrip(id, trip) {
    const existing = await Trip.findById(id);

    existing.title = trip.title;
    existing.technique = trip.technique,
    existing.picture = trip.picture;
    existing.certificate = trip.certificate;

    await existing.save();
}

async function deleteById(id) {
    await Trip.findByIdAndDelete(id);
}

async function joinTrip(tripId, userId) {
    const trip = await Trip.findById(tripId);

    if (trip.usersShared.includes(userId)) {
        throw new Error('User has already shared the publication.');
    }

    trip.usersShared.push(userId);
    await trip.save();
}

// async function getPostsByAuthor(userId){
//     return Gen.find({author: userId});
// }

// async function vote(genId, userId, value) {
//     const post = await Gen.findById(genId);

//     if (post.votes.includes(userId)) {
//         throw new Error('User has already voted.');
//     }

//     post.votes.push(userId);
//     post.rating += value;

//     await post.save();
// }

module.exports = {
    getAllTrips,
    getTripById,
    createTrip,
    getTripAndUsers,
    updateTrip,
    deleteById,
    joinTrip,
    //getTripsByUser,
};