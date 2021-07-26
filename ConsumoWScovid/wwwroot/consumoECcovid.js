// Traer las provincias
var labelsProv = [];
var dataProv = [];

$.ajax({
    type: "GET",
    contentType: "application/json; charset=utf-8",
    url: "https://localhost:5001/api/contagios_ecuador/",
    dataType: "json",
    success: function (data) {
        data.forEach((element) => {
            labelsProv.push(element.provincia);
            dataProv.push(element.problacion_total);
            console.log(element.provincia);
        });
        //dibujarChartProvincias();
    },
    error: function (data) {
        alert("Ocurrió un error al intentar traer las provincias");
    },
});