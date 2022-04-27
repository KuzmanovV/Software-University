const Trip = require('../models/Trip');
//TODO Change service name and funcs names.

async function getAllTrips() {
    return Trip.find({}).lean();
}

async function getTripsByUser(userId) {
    return Trip.find({author: userId}).lean();
}

async function getTripById(id) {
    return Trip.findById(id).lean();
}

async function getTripAndUsers(id) {
    return Trip.findById(id).populate('author').lean();             //.populate('buddies')
}

async function createTrip(trip) {
    const result = new Trip(trip);
    await result.save();
}

async function updateTrip(id, trip) {
    const existing = await Trip.findById(id);

    existing.headline = trip.headline;
    existing.location = trip.location;
    existing.name = trip.name;
    existing.description = trip.description;
    existing.author = trip.author;
    //existing.usersApplied = trip.usersApplied;
    
    await existing.save();
}

async function deleteById(id) {
    await Trip.findByIdAndDelete(id);
}

async function joinTrip(tripId, userId) {
    const trip = await Trip.findById(tripId);

    if (trip.buddies.includes(userId)) {
        throw new Error('User is already a part of the trip.');
    }

    trip.buddies.push(userId);
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
    getTripsByUser
};