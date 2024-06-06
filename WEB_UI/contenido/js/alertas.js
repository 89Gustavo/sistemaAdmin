
function succes(redirecciona, textoAlerta) {
    Swal.fire({
        title: "SUCCES!",
        text: textoAlerta,
        icon: "success"
    }).then(function() {
        window.location = redirecciona
    });
}

function cerrar() {
    Swal.fire({
        title: "SUCCES!",
        text: 'Sessin Cerrada',
        icon: "success"
    }).then(function () {
        window.location = "../Login.aspx"
    });
}

function warging(reddireccion, textoAlerta) {
    Swal.fire({
        icon: "warning",
        title: "Informacion",
        text: textoAlerta
       // timer: 1500
    }).then(function () {
        window.location = reddireccion
    });
    //return false;
}