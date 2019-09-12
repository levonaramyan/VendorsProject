$(document).ready(function () {
    let search = { Page: 1, ItemsCount: 10, Name: '', TypeId: 0, CityId: 0 };

    $("#search-button").click(function (e) {
        frm = $("#search-form");
        e.preventDefault();
        search.ItemsCount = $("#ItemsCount").children("option:selected").val();
        search.Name = $("#Name").val();
        search.Page = 1;
        search.CityId = $("#CityId").children("option:selected").val();
        search.TypeId = $("#TypeId").children("option:selected").val();

        $.ajax({
            type: frm.attr('method'),
            url: urlObj.GetFilteredTableUrl,
            data: frm.serialize(),
            success: function (data) {
                console.log('Submission was successful.');
                console.log(data);
            },
            error: function (data) {
                console.log('An error occurred.');
                console.log(data);
            },
        });
    });

    //$('#table_id').DataTable({
    //    ajax: {
    //        url: urlObj.TableAjax,
    //        dataSrc: ''
    //    },
    //    columns: [
    //        { data: 'name' },
    //        { data: 'type' },
    //        { data: 'city' }
    //    ],
    //    initComplete: function () {

    //        oTable.buttons().container()
    //            .appendTo($('#table_id_wrapper .col-sm-6:eq(0)'));
    //    }
    //});


});