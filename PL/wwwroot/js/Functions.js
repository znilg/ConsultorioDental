
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#ImagenPreview').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}
//---------------------------------------------------------------------------------------------------------------------------------------------------------------
function SoloNumeros(e, controlId) {

    var caracter = e.key;

    if (!/[^0-9]/g.test(caracter)) {
        $('#' + controlId).text("");
        return true;
    }
    else {
        $('#' + controlId).text("Solo acepta números.");
        $('#' + controlId).css({ "color": "red" });
        return false;
    }
}
//----------------------------------------------------------------------------------------------------------------------------------------------------------------
function SoloLetras(e, controlId) {

    var caracter = e.key;

    if (!/^[a-zA-Z ]*$/g.test(caracter)) {
        $('#' + controlId).text("Solo acepta letras.");
        $('#' + controlId).css({ "color": "red" });
        return false;
    }
    else {
        $('#' + controlId).text("");
        return true;
    }
}

//----------------------------------------------------------------------------------------------------------------------------------------------------------------
function ValidarPassword() {
    var txtPassword = $("#txtPassword");
    var regexToPassword = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@@$!%*#?&])[A-Za-z\d@@$!%*#?&]{8,}$";
    if (regexToPassword.test(txtPassword.val())) {

        $('#txtPassword').css('border-color', 'green');
    }
    else {
        $('#txtPassword').css('border-color', 'red');
    }

}

//----------------------------------------------------------------------------------------------------------------------------------------------------------------

function ValidarEmail() {
    var txtEmail = $("#txtEmail");
    var regexToEmail = /^(([^<>()[\]\\.,;:\s@@"]+(\.[^<>()[\]\\.,;:\s@@"]+)*)|(".+"))@@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (regexToEmail.test(txtEmail.val())) {
        //Es un email correcto
        $('#txtEmail').css('border-color', 'green');
    }
    else {
        $('#txtEmail').css('border-color', 'red');
    }

}


//----------------------------------------------------------------------------------------------------------------------------------------------------------------

document.addEventListener('DOMContentLoaded', function () {
    habilitarTextBoxByClass(); // Llamar a la función al cargar la página
});

function habilitarTextBoxByClass() {

    var textbox = document.getElementsByClassName("classFromTextBox");
    var checkbox = document.getElementsByClassName("form-check-input");

    for (var i = 0; i < checkbox.length; i++) {

        if (checkbox[i].checked) {
            textbox[i].disabled = false;
        }
        else {
            textbox[i].disabled = true;
        }

    }
}

function habilitarTextbox(checkBoxId, textBoxId) {

    var textbox = document.getElementById(textBoxId);
    var checkbox = document.getElementById(checkBoxId);

    if (checkbox.checked) {
        textbox.disabled = false;
    }
    else {
        textbox.disabled = true;
    }
}


var contador = 0;

function agregarFormulario(listExamsCompls) {
    var container = document.getElementById("divByExamCompl");
    var nuevoFormulario = document.createElement("div");
    nuevoFormulario.innerHTML = `
                <div class="row" id="divExamCompl${contador}">
                    <div class="col-md-3">
                        <select class="form-select" data-val="true" data-val-required="The IdTipoExamCompl field is required." id="ddlTipoExamCompl${contador}" name="ExamComplementario.TipoExamCompl.IdTipoExamCompl"><option value="">Seleccionar Tipo de Examen</option>
         
                        </select>
                    </div>
                    <div class="col-md-8" id="divForImageExamCompl${contador}">
                        <input autocomplete="off" class="form-control" data-val="true" data-val-required="The Imagen field is required." id="imgExamCompl${contador}" name="ExamComplementario.Imagen" type="file" value="">
                    </div>
                    <div class="col-md-1" id="divForBtnExamCompl${contador}">
                        <button class="btn btn-danger" type="button" onclick="eliminarFormulario(${contador})">Eliminar</button>
                    </div>
                </div>
                <br id="br${contador}">
            `;

    container.appendChild(nuevoFormulario);

    var nameSelect = "ddlTipoExamCompl" + contador;
    var select = document.getElementById(nameSelect);

    for (var i = 0; i < listExamsCompls.length; i++) {
        var newOption = document.createElement("option");
        newOption.value = i + 1;
        newOption.text = listExamsCompls[i].tipo;
        select.appendChild(newOption);
    }
    contador++;
}
function eliminarFormulario(id) {
    var formulario = document.getElementById(`divExamCompl${id}`);
    var br = document.getElementById(`br${id}`);
    formulario.remove();
    br.remove();
}