var token = getCookie("Token");
let table = new DataTable('#usuarios', {
    ajax: {
        url: `https://localhost:7112/api/Usuario/Usuarios`,
        dataSrc: "data.items",
        headers: { "Authorization": "Bearer " + token }
    },
    columns: [
        { data: 'id', title: 'Id' },
        { data: 'nombre', title: 'Nombre' },
        { data: 'dni', title: 'Dni' },
        { data: 'cuil', title: 'Cuil' },
        { data: 'roleId', title: 'Role' },
    ]
});

function AgregarUsuario() {
    $.ajax({
        type: "GET",
        url: "/Usuarios/UsuariosAddPartial",
        'dataType': "html",
        success: function (resultado) {
            $('#usuariosAddPartial').html(resultado);
            $('#usuarioModal').modal('show');
        }

    });
}