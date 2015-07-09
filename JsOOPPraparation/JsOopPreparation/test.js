function solve() {

    var player = (function () {

        var player = {
            init: function (name) {
                this.name = name;
                this.playlists = [];

                return this;
            },
            addPlaylist: function (playlistToAdd) {
                if(typeof (playlistToAdd.id)==='undefined'|| !playlistToAdd.name){
                    throw new Error();
                };
                this.playlists.push(playlistToAdd);
                return this;
            },
            getPlaylistById: function (id) {
                var foundPlaylist;
                var isIdFound = this.playlists.some(function (playlist) {
                    if( playlist.id === id){
                        foundPlaylist= playlist;
                    }
                    return playlist.id === id;
                });
                if (isIdFound) {
                    return foundPlaylist;
                } else {
                    return null;
                }
            },
            removePlaylist: function (id) {
                var indexOfPlayList;
                this.playlists.forEach(function (playlist) {
                    if( playlist.id === id){
                        indexOfPlayList=this.playlists.indexOf(playlist);
                    }
                });
                if (indexOfPlayList== undefined) {
                    throw new Error();
                }
                this.playlists.splice(indexOfPlayList,1);
                return this;
            }

        };
        return player;
    }());

    var playList = (function () {
        var id = 0;

        var playList = {
            init: function (name) {
                this.name = name;
                this.id = id;
                id += 1;

                return this;
            }
        };
        return playList;
    }());

    var playable = (function () {
        var id = 0;
        var playable = {
            init: function (title, author) {
                this.title;
                this.author = author;
                this.id = id;
                id += 1;
            },
            play: function () {
                return this.id + '. ' + this.title + '-' + this.author;
            }
        };
        return playable;
    }());

    var audio = (function (parent) {
        var audio = Object.create(parent);
        Object.defineProperty(audio, 'init', {
            value: function (title, author, lenght) {
                parent.init.call(this, title, author);
                this.length = lenght;
                return this;
            }
        });
        Object.defineProperty(audio, 'length', {
            get: function () {
                return this.length;
            },
            set: function (value) {
                if (value < 0) {
                    throw new Error();
                }
                this.length = value;
            }
        });
        Object.defineProperty(audio, 'play', {
            value: function () {
                return parent.play.call(this) + ' - ' + this.length;
            }
        });
        return audio;
    }(playable));

    var module = {
        getPlayer: function (name) {
            return Object.create(player)
                .init(name);
            // returns a new player instance with the provided name
        },
        getPlaylist: function (name) {

            return Object.create(playList).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
            //returns a new audio instance with the provided title, author and length
        },
        getVideo: function (title, author, imdbRating) {
            //returns a new video instance with the provided title, author and imdbRating
        }
    };
    return module;
}