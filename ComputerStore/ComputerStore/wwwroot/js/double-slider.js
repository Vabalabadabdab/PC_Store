var slider = document.getElementById('slider');

noUiSlider.create(slider, {
    start: [10000, 90000],
    connect: true,
    range: {
        'min': [0],
        'max': [100000]
    }
});

var input1 = document.getElementById("min-bar-val");
var input2 = document.getElementById("max-bar-val");
var inputs = [input1, input2];

slider.noUiSlider.on('update', function (values, handle) {
    inputs[handle].value = Math.round(values[handle]);
});