

document.getElementById('ingreso_credenciales').addEventListener('click', () => {

    let data_email = document.getElementById('login-email').value;
    let data_password = document.getElementById('login-contrasenia').value;
    let data_token = document.getElementById('login-token').value; //"7ea2a9ae-c306-4553-ab20-776a46706b89";

    let data = new FormData();
    data.append('email', data_email);
    data.append('password', data_password);
    data.append('token', data_token);


    fetch('Login/ingresarSesion', {
        method: 'POST',
        body: data,
    })
        //Exito
        .then(response => response.json())  // convertir a json
        .then(resp => {
            console.log(resp.resp);
        })
        .catch(err => console.error('Solicitud fallida', err)); // Capturar errores

})