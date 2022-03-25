let menubtn = document.querySelector(".menu-btn");
let sidebar = document.querySelector(".side-bar");
let menuTexts = document.querySelectorAll(".menu-text");
let videoscontainer = document.querySelector(".videos-container");


menubtn.onclick = function() {
    sidebar.classList.toggle("resize-sidebar");
    videoscontainer.classList.toggle("widen-videos-container");
    for (let i = 0; i < menuTexts.length; i++) {
        menuTexts[i].classList.toggle("hide-text");
    }
}