

document.getElementById('crear_cuenta').addEventListener('click', () => {

    let data_name = document.getElementById('crearcuenta-name').value;
    let data_email = document.getElementById('crearcuenta-email').value;
    let data_password = document.getElementById('crearcuenta-password').value;

    let data = new FormData();
    data.append('name', data_name);
    data.append('email', data_email);
    data.append('password', data_password);


    fetch('CrearCuenta/GenerarCuenta', {
        method: 'POST',
        body: data,
    })
        //Exito
        .then(response => response.json())  // convertir a json
        .then(resp => {
            console.log(resp.respuesta);
            console.log(resp.resp);
        })
    .catch(err => console.error('Solicitud fallida', err)); // Capturar errores

})