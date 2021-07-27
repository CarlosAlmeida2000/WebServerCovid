// Traer las provincias
var labelsProv = [];
var dataContg = [];
var dataFallec = [];
var dataRecup = [];

var listaprovincia = document.getElementById("lista-provincias");
$.ajax({
    type: "GET",
    contentType: "application/json; charset=utf-8",
    url: "https://localhost:5001/api/contagios_ecuador/",
    dataType: "json",
    success: function (data) {
        data.forEach((element) => {
            labelsProv.push(element.provincia);
            dataContg.push(element.contagiados);
            dataFallec.push(element.fallecidos);
            dataRecup.push(element.recuperados);

            //mostrar provincias
            $("#lista-provincias").append('<li class="item">' + element.provincia + '</li>');
        });
        dibujarChartContagiados();
        dibujarChartFallecidos();
        dibujarChartRecuperados();
    },
    error: function (data) {
        alert("Ocurrió un error al intentar traer las provincias");
    },
});
function dibujarChartContagiados() {
    var contextoProv = document
        .getElementById("canvas-contagiados")
        .getContext("2d");
    var chartContag = new Chart(contextoProv, {
        type: "line",
        data: {
            labels: labelsProv,
            datasets: [
                {
                    label: "Contagiados",
                    data: dataContg,
                },
            ],
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true,
                },
            },
        },
    });
}
function dibujarChartFallecidos() {
    var contextoProv = document
        .getElementById("canvas-fallecidos")
        .getContext("2d");
    var chartFallec = new Chart(contextoProv, {
        type: "line",
        data: {
            labels: labelsProv,
            datasets: [
                {
                    label: "Fallecidos",
                    data: dataFallec,
                },
            ],
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true,
                },
            },
        },
    });
}
function dibujarChartRecuperados() {
    var contextoProv = document
        .getElementById("canvas-recuperados")
        .getContext("2d");
    var chartRecup = new Chart(contextoProv, {
        type: "line",
        data: {
            labels: labelsProv,
            datasets: [
                {
                    label: "Recuperados",
                    data: dataRecup,
                },
            ],
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true,
                },
            },
        },
    });
}