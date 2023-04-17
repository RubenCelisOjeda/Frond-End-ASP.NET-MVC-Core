ns('AppProductBooking.Home.Index');

try {

    $(document).ready(function () {
        'use strict';
        debugger;
        AppProductBooking.Home.Page = new AppProductBooking.Home.Index.Controller();
        AppProductBooking.Home.Page.Ini();
    });

} catch (ex) {
    alert(ex.message);
}