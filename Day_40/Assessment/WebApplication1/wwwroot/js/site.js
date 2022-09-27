// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function fun1() {
    mycrp.style.background = 'rgb(204, 140, 20)';
    mycrp.style.color = 'white'
}
var mycrp = document.getElementByClassName('navbar-brand');
mycrp.addEventListener("mouseover", fun1);