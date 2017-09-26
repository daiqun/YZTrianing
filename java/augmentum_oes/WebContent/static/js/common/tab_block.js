// Front-end url
var path = $("#path").val() + "/page/";

// Go to question manage page
$("#questionManage").on("click", function() {
    location.href = path + "question/show";
});

// Go to exam manage page
$("#examManage").on("click", function() {
    location.href = path + "exam/show";
});

// Validation information display
if ($.trim($("#pagePrompt").html())) {
    $("#pagePrompt").slideDown(300);

    setTimeout(function() {
        $("#pagePrompt").slideUp(300);
    }, 1500);
}