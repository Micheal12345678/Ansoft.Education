function toggleSound() {
    var music = document.getElementById("audioplayer");
    var toggle = document.getElementById("toggle");
    if (music.paused) {
        music.play();
        toggle.innerHTML = "Pause";
    }
    else {
        music.pause();
        toggle.innerHTML = "Play";
    }

    var videoInfo = document.getElementById("videoInfo");
    videoInfo.innerHTML = music.volume;
}

function changeVolume(sign) {
    var videoInfo = document.getElementById("videoInfo");
    var music = document.getElementById("audioplayer");


    if (sign == '-') {
        music.volume = music.volume - 0.1;
    }
    else {
        music.volume = music.volume + 0.1;
    }

    videoInfo.innerHTML = music.volume.toString();
}