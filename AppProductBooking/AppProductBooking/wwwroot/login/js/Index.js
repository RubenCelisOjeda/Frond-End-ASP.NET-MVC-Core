ns('AppProductBooking.Login.Index');

try {

    $(document).ready(function () {
        'use strict';
        debugger;
        AppProductBooking.Login.Page = new AppProductBooking.Login.Index.Controller();
        AppProductBooking.Login.Page.Ini();
    });

} catch (ex) {
    alert(ex.message);
}