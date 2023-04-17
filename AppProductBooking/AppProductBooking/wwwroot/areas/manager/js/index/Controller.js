ns('AppProductBooking.Manager.Index.Controller');

AppProductBooking.Manager.Index.Controller = function () {

    var base = this;

    base.Ini = function (opts) {
        'use strict';
        debugger;

        base.Control.BtnBackManager().click(base.Event.BtnBackManagerClick);
        base.Control.BtnNextManager().click(base.Event.BtnNextManagerClick);
    };

    base.Parameters = {

        ValidateEmail: function (email) {
            var data = {
                Email: email,
            };
            return data;
        },

    };

    base.Variable = {

        Map: "",
        UrlContent: "/",

        Constante: {

        },
    };

    base.Resource = {

    };

    base.Control = {
        BtnBackManager: function () { return $('#btnBackManager'); },
        BtnNextManager: function () { return $('#btnNextManager'); },
        TxtEmailManager: function () { return $('#txtEmailManager'); },
    };

    base.Event = {

        BtnBackManagerClick: function () {
            window.location.href = base.Variable.UrlContent + "Home/Index";
        },

        BtnNextManagerClick: function () {
            debugger;
            if (!base.Validation.EmailManager()) {
                toastr.success("Ingreso correctamente,espere un momento...","Completado");
            }
        },
    };

    base.Ajax = {

        ExistsEmail: function (pEntidad) {
            $.ajax({
                url: base.Validation.UrlContent + "Manager/ExistsEmail",
                data: pEntidad,
                method: 'GET',
                dataType: 'json',
                success: function (response) {
                    var objData = jQuery.parseJSON(response);
                    debugger;
                },
                failure: function (msg) {
                    console.log("entro a la funcion failure");
                    console.log(msg);
                },
                error: function () {
                    console.log("ERROR: No se ha podido obtener la información");
                },
            });
        },

    };

    base.Function = {

        IsEmptyOrNull: function (value) {
            var isCorrect = false;

            if (value == null || value == undefined || value == "" || value == " ") {
                isCorrect = true
            }
            return isCorrect;
        },

        IsValidEmail: function (email) {
            var regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
            return regex.test(email);
        },
    };

    base.Validation = {

        EmailManager: function () {
            var isCorrect = false;
            var email = base.Control.TxtEmailManager().val();

            if (base.Function.IsEmptyOrNull(email)) {
                isCorrect = true;
                base.Control.TxtEmailManager().focus();
                toastr.info("Ingrese un correo electrónico.","Validación");
            }
            else if (!base.Function.IsValidEmail(email)) {
                isCorrect = true;
                base.Control.TxtEmailManager().focus();
                toastr.info("El correo electrónico ingresado es inválido.", "Validación");
            }
            else if (base.Ajax.ExistsEmail(email)) {
                isCorrect = true;
                base.Control.TxtEmailManager().focus();
                toastr.info("El correo electrónico ya esta registado,intente con otro.", "Validación");
            }
            return isCorrect;
        },
    };
}