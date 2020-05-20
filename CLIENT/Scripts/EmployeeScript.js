var table = null;
$(document).ready(function () {
    table = $('#table').DataTable({
        "processing": true,
        "serverside": true,
        "filter": true,
        "orderMulti": false,
        "lengthMenu": [[5, 10, 25, 50, 100], [5, 10, 25, 50, 100]],
        "ajax": {
            "url": "/Departments/LoadData",
            "type": "GET",
            "datatype": "json"
        },
        "columnDefs":
            [{
                "targets": [4],
                "searchable": false,
                "orderable": false
            }],
        "columns": [
            { "data": "name", "name": "name", "autoWidth": true },
            { "data": "email", "name": "email", "autoWidth": true },
            { "data": "location", "name": "location", "autoWidth": true },
            { "data": "phone", "name": "phone", "autoWidth": true },
            {
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-info" href="#" onclick="GetById(' + full.id + ')">Edit</a> <a class="btn btn-danger" href="#" onclick="Delete(' + full.id + ')">Delete</a>';
                }
            }
        ]
    });
});