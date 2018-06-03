

$(function () {
    $('.js-sweetalert button').on('click', function () {
        console.log('veio aqui');
        var type = $(this).data('type');
        /*if (type === 'basic') {
            showBasicMessage();
        }
        else if (type === 'with-title') {
            showWithTitleMessage();
        }
        else if (type === 'success') {
            showSuccessMessage();
        }
        else if (type === 'confirm') {
            showConfirmMessage();
        }
        else */if (type === 'cancel') {
            showCancelMessage();
        }/*
        else if (type === 'with-custom-icon') {
            showWithCustomIconMessage();
        }
        else if (type === 'html-message') {
            showHtmlMessage();
        }
        else if (type === 'autoclose-timer') {
            showAutoCloseTimerMessage();
        }
        else if (type === 'prompt') {
            showPromptMessage();
        }
        else if (type === 'ajax-loader') {
            showAjaxLoaderMessage();
        }*/
    });
});


function showCancelMessage(id) {
    
    swal({
        title: "Você Tem Certeza?",
        text: "Você não vai poder recuperar essa informação!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Sim, deletar!",
        cancelButtonText: "Não, Mudei de idéia!",
        closeOnConfirm: false,
        closeOnCancel: false
    }, function (isConfirm) {
        if (isConfirm) {
            DeleteItem(id);
            swal("Deletado!", "Informação Deletada", "success");
        } else {
            swal("Cancelado", "Sua informação ainda existe", "error");
        }
    });
}




$('#aparecer').click(function () {
    console.log("veio pra ca");
    var selected = $("#optgroup option:selected");
        var message = "";
        selected.each(function () {
            message += $(this).text() + " " + $(this).val() + "\n";
        });
        alert(message);
    });


