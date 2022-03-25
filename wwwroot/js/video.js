let menubtn = document.querySelector(".menu-btn");
let sidebar = document.querySelector(".side-bar");

menubtn.onclick = function() {
    sidebar.classList.toggle("show-sidebar");
};

window.onload = function() {
    menubtn.click();
};