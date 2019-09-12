jQuery.fn.extend({
    disable: function (state) {
        return this.each(function () {
            var $this = $(this);
            $this.toggleClass('disabled', state);
        });
    }
});

var search = { Page: 1, ItemsCount: 10, Name: '', TypeId: 0, City: 0 };
var maxPage = 1;

$(document).ready(function () {

    $("#search-button").click(function (e) {
        frm = $("#search-form");
        e.preventDefault();
        search.ItemsCount = $("#ItemsCount").children("option:selected").val();
        search.Name = $("#Name").val();
        search.Page = 1;
        maxPage = 1;
        search.City = $("#City").val();
        search.TypeId = $("#TypeId").val();
        console.log(search);

        $("#btn-prev").disable(true);
        $("#btn-first").disable(true);
        $("#btn-next").disable(true);
        $("#btn-last").disable(true);

        $.ajax({
            type: frm.attr('method'),
            url: urlObj.GetFilteredTableUrl,
            data: frm.serialize(),
            success: function (data) {
                console.log('Submission was successful.');
                console.log(data);
                RefreshTable(data.vendors);
                maxPage = data.pages;
                if (maxPage > 1) {
                    $("#btn-next").disable(false);
                    $("#btn-last").disable(false);
                }
                console.log('the number of pages is ' + maxPage);
                $("#page-num").text(1);
            },
            error: function (data) {
                alert('Could not retrieve data from the server!');
                console.log('An error occurred.');
                console.log(data);
            },
        });
    });

    $("#search-button").click();

    $("#btn-prev").click(function (e) {
        search.Page = +$('#page-num').text() - 1;
        GoToPage(search);
    });

    $("#btn-first").click(function (e) {
        search.Page = 1;
        GoToPage(search);
    });

    $("#btn-next").click(function (e) {
        search.Page = +$('#page-num').text() + 1;
        GoToPage(search);
    });

    $("#btn-last").click(function (e) {
        search.Page = maxPage;
        GoToPage(search);
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

function RefreshTable(data) {
    let tb = $("#table-body");
    tb.empty();
    console.log('table body is removed!');
    for (let i = 0; i < data.length; i++) {
        // Create table row elements
        let tr = document.createElement('tr');

        // Create table columns
        let tdName = document.createElement('td');
        let tdType = document.createElement('td');
        let tdCity = document.createElement('td');

        // Append columns to the row
        tdName.innerHTML = data[i].name;
        tdType.innerHTML = data[i].type;
        tdCity.innerHTML = data[i].city;

        //appending columns to the row
        tr.appendChild(tdName);
        tr.appendChild(tdType);
        tr.appendChild(tdCity);

        // Appending the created row to the table body
        tb.append(tr);
        console.log('The table is rebuilt!');
    }
}

function GoToPage(search) {
    $("#btn-prev").disable(true);
    $("#btn-first").disable(true);
    $("#btn-next").disable(true);
    $("#btn-last").disable(true);

    console.log(JSON.stringify(search));

    $.ajax({
        type: 'POST',
        url: urlObj.GetFilteredTableUrl,
        data: search,
        success: function (data) {
            console.log('Submission was successful.');
            console.log(data);
            RefreshTable(data.vendors);
            maxPage = data.pages;
            if (search.Page < maxPage) {
                $("#btn-next").disable(false);
                $("#btn-last").disable(false);
            }
            if (search.Page > 1) {
                $("#btn-prev").disable(false);
                $("#btn-first").disable(false);
            }
            $("#page-num").text(search.Page);
        },
        error: function (data) {
            alert('Could not retrieve data from the server!');
            console.log('An error occurred.');
            console.log(data);
        },
    });
}