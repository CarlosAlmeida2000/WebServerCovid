// Traer las provincias
var labelsProv = [];
var dataProv = [];

var listaprovincia = document.getElementById("lista-provincias");
$.ajax({
    type: "GET",
    contentType: "application/json; charset=utf-8",
    url: "https://localhost:5001/api/contagios_ecuador/",
    dataType: "json",
    success: function (data) {
        data.forEach((element) => {
            labelsProv.push(element.provincia);
            dataProv.push(element.problacion_total);

            //mostrar provincias
            $("#lista-provincias").append("<li>" + element.provincia + "</li>");
        });
        mostrarProvincias();
        //dibujarChartProvincias();
    },
    error: function (data) {
        alert("Ocurrió un error al intentar traer las provincias");
    },
});
