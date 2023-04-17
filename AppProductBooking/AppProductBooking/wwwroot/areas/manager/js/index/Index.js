ns('AppProductBooking.Manager.Index');

try {

    $(document).ready(function () {
        'use strict';
        debugger;
        AppProductBooking.Manager.Page = new AppProductBooking.Manager.Index.Controller();
        AppProductBooking.Manager.Page.Ini();
    });

} catch (ex) {
    alert(ex.message);
}