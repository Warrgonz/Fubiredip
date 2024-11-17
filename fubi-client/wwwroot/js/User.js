// Data table con los usuarios
    $(document).ready(function () {
        $('#user-table').DataTable({
            data: [],  
            columns: [
                { title: "#" },
                { title: "Identificación" },
                { title: "Nombre Completo" },
                { title: "Correo Electrónico" },
                { title: "Teléfono"},
                { title: "Fecha de Nacimiento" },
                { title: "Rol" },
                { title: "Estado" },
                { title: "Acciones" }
            ],
            language: {
                emptyTable: "No hay datos disponibles en la tabla",
                url: "https://cdn.datatables.net/plug-ins/1.13.5/i18n/es-ES.json"
            }
        });
    });

// Mostrar el preview de la imagen del usuario.

function previewImage(event) {
    const file = event.target.files[0];
    const reader = new FileReader();

    reader.onload = function (e) {
        // Cambiar la fuente de la imagen al archivo cargado
        document.getElementById('profilePic').src = e.target.result;
    };

    // Leer el archivo como una URL de imagen
    if (file) {
        reader.readAsDataURL(file);
    }
}