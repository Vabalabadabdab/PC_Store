

$('.link').click(function (link) {
    $('html, body').stop().animate({
        scrollTop: $($(this).attr('href')).offset().top - 120
    }, 300);
});

function goBack() {
    window.history.back();
}

function showSliderValue(slider, labelId) {
    document.getElementById(labelId).innerText = slider.value + "/5";
}

function getUrlPage() {
    var inp = document.getElementsByName("currentPage");
    inp.value = window.location.href;
}

