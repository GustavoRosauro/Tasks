let idGeral = 0;
let idchecked = 0;
$(document).ready(() => {
    $("#Delete").click(() => {
        $.ajax({
            url: "/Task/Delete",
            data: { id: idGeral },
            success: function () {
                window.location.reload();
            }
        });
    });
    $("#confirm").click(() => {
        $.ajax({
            url: "/Task/SaveTask",
            data: { id: idchecked },
            success: function () {
                window.location.reload();
            }
        });
    });
    $("#confirm").hide();
    $('.btn-success').click(() => {
        idGeral = 0;
        $("#Titulo").val("");
        $("#Descricao").val("");
        $("#Delete").prop("disabled", true);
        $("#Titulo").removeClass('vermelho');
        $("#Descricao").removeClass('vermelho');
        $("#ModalAdd").modal("show");
    });
    $("#CreateTask").click(() => {
        if ($("#Titulo").val() === "") {
            $("#Titulo").addClass('vermelho');
            return;
        }
        else if ($("#Descricao").val() === "") {
            $("#Descricao").addClass('vermelho');
            return;
        }
        else if (idGeral !== 0) {
            $.ajax({
                url: "/Task/Edit",
                data: {
                    Id: idGeral,
                    Titulo: $("#Titulo").val(),
                    Descricao: $("#Descricao").val()
                },
                success: function () {
                    window.location.reload();
                }
            });
        }
        else {
            $.ajax({
                url: "/Task/Create",
                data: {
                    Titulo: $("#Titulo").val(),
                    Descricao: $("#Descricao").val()
                },
                success: () => {
                    window.location.reload();
                }
            });
        }
    });
    $(function () {
        $("#table input").keyup(function () {
            var index = $(this).parent().index();
            var nth = "#table td:nth-child(" + (index + 1).toString() + ")";
            var valor = $(this).val().toUpperCase();
            $("#table tbody tr").show();
            $(nth).each(function () {
                if ($(this).text().toUpperCase().indexOf(valor) < 0) {
                    $(this).parent().hide();
                }
            });
        });

        $("#tabela input").blur(function () {
            $(this).val("");
        });
    });
});
function Edit(id) {
    idGeral = id;
    $("#Delete").prop("disabled", false);
    $.ajax({
        url: "/Task/Search",
        data: { id: idGeral },
        success: function (data) {
            $("#Titulo").val(data.Titulo);
            $("#Descricao").val(data.Descricao);
        }
    });
    $("#ModalAdd").modal("show");
}
function Check(id) {
    if ($("input:checked").length > 0) {
        $("#confirm").show();
        idchecked = id;
        $("input:not(:checked)").prop("disabled", true);
    }
    else {
        $("input:not(:checked)").prop("disabled", false);
        $("#confirm").hide();
    }
}
