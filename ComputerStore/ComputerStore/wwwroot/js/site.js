// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


window.onscroll = function () {
    var currentScrollPos = window.pageYOffset;
    if (0 == currentScrollPos) {
        document.getElementById("navbar").style.backgroundColor = "rgba(0, 0, 0, 0)";
    } else {
        document.getElementById("navbar").style.backgroundColor = "rgba(51,51,51, 0.9)";
    }
}