// Back-end URL
var path = $("#path").val() + "/page/";

// Server url
var serverPath = $("#serverPath").val();

var ICN_Keep = serverPath + "/img/exam-img/ICN_Keep_12x20.png";
var ICN_Expand = serverPath + "/img/exam-img/ICN_Expand_12x20.png";

$(".first_bar").css("background-color", "#FFFFFF");
$(".second_bar").css("background-color", "#D2DAE3");

// Add a exam
$("#addBtn").on("click", function() {
    var examName = $.trim($("#examName").val());
    var examDescription = $.trim($("#description").val());
    var duration = $.trim($("#duration").val());
    var questionQuantity = $.trim($("#questionQuantity").val());
    var questionPoints = $.trim($("#questionPoints").val());
    var totalScore = $.trim($("#totalScore").val());
    var passCriteria = $.trim($("#passCriteria").val());
    var datePicker = $("#datePicker").val();

    // Exam time
    var timePicker = $("#timePicker").val();
    var Effective = datePicker + " " + timePicker;
    var date = new Date(Effective);
    $("#effectiveTime").val(date);
    var isSubmit = true;

    if (!examName || !duration || !questionQuantity || !questionPoints || !totalScore || !passCriteria || !date) {
        $("#pagePrompt").html("Exam information is not complete");
        $("#pagePrompt").slideDown(300);

        setTimeout(function() {
            $("#pagePrompt").slideUp(300);
        }, 1500);

        isSubmit = false;
    }

    if (isSubmit) {
        $("#addExam").submit();
    }
});

// Calculate the total score
$("#questionQuantity, #questionPoints").on("keyup", function() {
    var questionQuantity = $("#questionQuantity").val();
    var questionPoints = $("#questionPoints").val();
    $("#totalScore").val(questionQuantity * questionPoints);
});

// Return to the exam list page
$(".navigation_bar_exam_manage").on("click", function() {
    self.location = document.referrer;
});