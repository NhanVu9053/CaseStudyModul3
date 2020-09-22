var role = role || {};

role.delete = function (id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Bạn có muốn xóa tài khoản này không?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Không'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Có'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/UsersManager/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {

                        if (data) {
                            window.location = "/UsersManager/Index";
                        }
                    }
                });
            }
        }
    });
}

$(document).ready(function () {
    $("#tbUser").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 2,
                    "orderable": false
                },
            ]
        }
    );
});