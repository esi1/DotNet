$(function () {
    var pwdLinkHover = $("#pwdLink").hover(onCloseLogin);
    var resetPwd = $("#resetPwd").click(onResetPassword);
    function onCloseLogin() {
        $('div[data-login-user-area]').removeClass('open');
    }
    function onResetPassword() {
        var email = $(".modal-dialog .reset-email").val();
        var antiforegry = $('[name= "__RequestVerificationToken"]').val();
        var url = "/Account/ForgotPasswordConfirmation";
        $.post("/Account/ForgotPassword", { __RequestVerificationToken:
        antiforegry, email: email },
        function (data) {
            location.href = url;
        }).fail(function (xhr, status, error) {
            location.href = url;
        });
    }
});