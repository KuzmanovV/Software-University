function solve(input) {
    let numberOfSongs = input.shift()
    let typeToPrint = input.pop()

    class Song {
        constructor(type, name, time) {
            this.type = type
            this.name = name
            this.time = time
        }
    }

    let songs = []

    for (const song of input) {
        let [type, name, time] = song.split('_')
        let newSong = new Song(type, name, time)
        songs.push(newSong)
    }

    if (typeToPrint === 'all') {
        for (const song of songs) {
            console.log(song.name);
        }
    } else {
        for (const song of songs) {
            if (song.type === typeToPrint) {
                console.log(song.name);
            }
        }
    }
}

solve([2,
    'like_Replay_3:15',
    'ban_Photoshop_3:48',
    'all'])