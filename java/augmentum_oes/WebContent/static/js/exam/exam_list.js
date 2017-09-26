//Location url
var path = $("#path").val() + "/page/";

$(".first_bar").css("background-color", "#FFFFFF");
$(".second_bar").css("background-color", "#D2DAE3");

// Into create exam page
$("#createExam").on("click", function() {
    location.href = path + "exam/create_page";
});