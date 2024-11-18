// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function DeleteNews(url) {
    swal({
        title: "Are You Sure?",
        text: "Once Deleted, You will not be able to recover this News Item",
        icon: "warning",
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "Delete",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.error(
                            'Successfully DELETED!',
                            'NEWS ITEM',
                            {
                                timeOut: 700,
                                fadeOut: 700,
                                onHidden: function () {
                                    location.reload();
                                }
                            }
                        );

                    } else {

                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

function DeleteArticle(url) {
    swal({
        title: "Are You Sure?",
        text: "Once Deleted, You will not be able to recover this Article",
        icon: "warning",
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "Delete",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.error(
                            'Successfully DELETED!',
                            'ARTICLE',
                            {
                                timeOut: 700,
                                fadeOut: 700,
                                onHidden: function () {
                                    location.reload();
                                }
                            }
                        );

                    } else {

                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}