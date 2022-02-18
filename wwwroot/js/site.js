// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ShowHideSideBar(){
    let sideBar = document.getElementById("sideBar");
    if(sideBar.style.visibility === "visible"){
        sideBar.style.visibility = "hidden";
        sideBar.style.width = 0;
    }else{
        sideBar.style.visibility = "visible";
        sideBar.style.width = "17%";
    }
}