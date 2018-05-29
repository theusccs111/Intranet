$(function () {
    $('.js-basic-example').DataTable({
        responsive: true
    });

    //Exportable table
    $('.js-exportable').DataTable({
        dom: 'Bfrtip',
        responsive: true,
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });
});


/*$(document).ready(function () {

    $('#myDataTable').dataTable({
        "bServerSide": true,
        "sAjaxSource": "Home/AjaxHandler",
        "bProcessing": true,
        "aoColumns": [
                        { "sName": "ID",
                            "bSearchable": false,
                            "bSortable": false,
                            "fnRender": function (oObj) {
                                return '<a href=\"Details/' + 
                                oObj.aData[0] + '\">View</a>';
                            }
                        },
                        { "sName": "COMPANY_NAME" },
                        { "sName": "ADDRESS" },
                        { "sName": "TOWN" }
                    ]
    });
}); */