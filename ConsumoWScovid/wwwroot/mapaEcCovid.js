$.ajax({
    type: "GET",
    contentType: "application/json; charset=utf-8",
    url: "https://localhost:5001/api/contagios_ecuador/",
    dataType: "json",
    success: function (data) {
        var i = 0;
        data.forEach( (element) => {
            
            var path_tag = document.getElementsByTagName('path');
            path_tag[i].getElementsByTagName('title')[0].textContent = element.provincia 
                + "\nContagiados: " + element.contagiados + "\nFallecidos: " 
                + element.fallecidos + "\nRecuperados: " 
                + element.recuperados;
            i++;
        } );
    },
    error: function (data) {
        
    },
});