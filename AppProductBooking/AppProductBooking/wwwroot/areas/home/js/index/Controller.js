ns('AppProductBooking.Home.Index.Controller');

AppProductBooking.Home.Index.Controller = function () {

    var base = this;

    base.Ini = function (opts) {
        'use strict';
        debugger;
        base.Control.BtnManager().click(base.Event.BtnManagerClick);
    };

    base.Parameters = {


    };

    base.Variable = {

        Map: "",

        Constante: {

        },
    };

    base.Resource = {

    };

    base.Control = {
        BtnManager: function () { return $('#btnManager'); },
        BtnRequesting: function () { return $('#btnRequesting'); },
    };

    base.Event = {

        BtnManagerClick: function () {
            debugger;
            window.location.href = '/Manager/Index';
        }
    };

    base.Ajax = {


    };

    base.Function = {

       

    };

    base.Validation = {

    };
}