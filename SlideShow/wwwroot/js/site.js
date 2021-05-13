// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var mode = "on";
var sequence = "sequential";
var picIndex = 0;
$(".carousel-item").first().addClass("active");

function setPlay() {
    mode = "on";
    sequence = "sequential";

    document.getElementById("pause").style.display = "block";
    document.getElementById("play").style.display = "none";
    $('#carouselExampleControls').carousel('cycle');
}
function setPause() {
    mode = "off";
    sequence = "sequential";
    document.getElementById("play").style.display = "block";
    document.getElementById("pause").style.display = "none";
    document.getElementById("random").style.display = "block";
    document.getElementById("sequential").style.display = "none";
    $('#carouselExampleControls').carousel('pause');
}
function setSequential() {
    if (mode == "on") {
        sequence = "sequential";
        document.getElementById("random").style.display = "block";
        document.getElementById("sequential").style.display = "none";
        $('#carouselExampleControls').carousel('cycle');
    }
}

// https://stackoverflow.com/questions/20436561/bootstrap3-carousel-picking-random-next-slide
function setRandom() {
    if (mode == "on") {
        sequence = "random";
        document.getElementById("sequential").style.display = "block";
        document.getElementById("random").style.display = "none";
        // remove data-interval from carousel
        $('#carouselExampleControls').carousel('pause');

        picindex = Math.floor((Math.random() * $('.carousel-item').length));
        var rand = picindex;
        $('#carouselExampleControls').carousel(picindex);
        $('#carouselExampleControls').fadeIn(1000);
        interval = setInterval(function () {
            if (sequence != "random") {
                clearInterval(interval);
            }
            while (rand == picindex) {
                rand = Math.floor((Math.random() * $('.carousel-item').length));
            }
            picindex = rand;
            $('#carouselExampleControls').carousel(rand);
        }, 2000);

    }
    
}

function reSet() {
    document.getElementById("pause").style.display = "block";
    document.getElementById("play").style.display = "none";
    document.getElementById("random").style.display = "block";
    document.getElementById("sequential").style.display = "none";
}



