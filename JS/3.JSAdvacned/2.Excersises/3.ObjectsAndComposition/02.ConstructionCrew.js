function cc(workerInput) {
    if (workerInput.dizziness === true) {
        workerInput.levelOfHydrated += .1*workerInput.weight*workerInput.experience;
        workerInput.dizziness=false;
    }

    return workerInput
}

console.log(cc({
    weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true
}
));