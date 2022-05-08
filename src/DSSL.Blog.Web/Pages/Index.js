$(function () {
    var l = abp.localization.getResource("Blog");

    var createModal = new abp.ModalManager(abp.appPath + 'Comments/CreateModal');

    createModal.onResult(function () {

    });

    $('#NewCommentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});