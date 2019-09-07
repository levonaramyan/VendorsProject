$("#Cr-Vend-But").click(function (e) {
    e.preventDefault();
    $('#dialogContent').load(this.href, function () {
        $('#dialogDiv').modal({
            backdrop: 'static',
            keyboard: true
        }, 'show').on('show.bs.modal', function () {
            setTimeout(function () {

            }, 500);
        });
    });
    return false;
});

$(document).on('click', '#btnAdd', function (e) {
    e.preventDefault();

    var form = $("#Create-Vendor-Submit");
    var url = urlObj.CreateUrl;

    $.ajax({
        type: "POST",
        url: url,
        data: form.serialize(),
        success: function (result) {
            if (result.success) {
                $('#dialogDiv').modal('hide');
                swal({
                    title: "Success!",
                    type: "success",
                    closeOnClickOutside: false,
                    delay: 500
                });
                setTimeout(function () {
                    location.reload();
                }, 1200);
            } else {
                console.log("Error saving data!");
                $('#dialogContent').html(result);
            }
        }
    });
});