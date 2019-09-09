$(document).ready(function () {
    $('#table_id').DataTable({
        ajax: {
            url: urlObj.TableAjax,
            dataSrc: ''
        },
        columns: [
            { data: 'name' },
            { data: 'type' },
            { data: 'city' }
        ],
        initComplete: function () {

            oTable.buttons().container()
                .appendTo($('#table_id_wrapper .col-sm-6:eq(0)'));
        }
    });
});