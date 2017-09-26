// Location url
var path = $("#path").val() + "/page/";

// This is not add page
var isEdit = 1;

// Currently selected ID
var trueAnwser = $("#editCorrectAnwser").val();

// Change style
$("#createBt").attr("value", "Edit");
$("#oldBar a").html("Edit Question");
$("#currentId").html(formatID());
$("#addId").css("color", "#0A0A0A");

// Assignment for current form
$("#currentChoiceId").val($("#editId").val());
$("#questionIdDisplay").html($("#editId").val());
$("#questionContent").html(htmlEncode($("#editContent").val()));
$("#choiceA").attr("value", $("#editChoiceA").val());
$("#choiceB").attr("value", $("#editChoiceB").val());
$("#choiceC").attr("value", $("#editChoiceC").val());
$("#choiceD").attr("value", $("#editChoiceD").val());

// Check whether to modify
$(".anwser_text, #questionContent").on(
        "keyup",
        function() {
            if ($.trim($("#questionContent").val()) != $.trim($("#editContent").val())
                    || $.trim($("#choiceA").val()) != $.trim($("#editChoiceA").val())
                    || $.trim($("#choiceB").val()) != $.trim($("#editChoiceB").val())
                    || $.trim($("#choiceC").val()) != $.trim($("#editChoiceC").val())
                    || $.trim($("#choiceD").val()) != $.trim($("#editChoiceD").val())) {

                if ($.trim($("#questionContent").val()) && $.trim($("#choiceA").val()) && $.trim($("#choiceB").val())
                        && $.trim($("#choiceC").val()) && $.trim($("#choiceD").val())) {

                    if (!$.trim($("#pagePrompt").html())) {
                        afterModify();
                    }
                } else {
                    beforeModify();
                }
            } else {
                beforeModify();
            }
        });

// Check whether to modify
$(".choice_as").on(
        "click",
        function() {
            if ($(this).attr("id").substring(7) != $("#editCorrectAnwser").val()) {
                if ($(this).attr("src") == $("#checked").val()) {
                    if ($.trim($("#questionContent").val()) && $.trim($("#choiceA").val())
                            && $.trim($("#choiceB").val()) && $.trim($("#choiceC").val())
                            && $.trim($("#choiceD").val())) {

                        if (!$.trim($("#pagePrompt").html())) {
                            afterModify();
                        }
                    } else {
                        beforeModify();
                    }
                }
            } else {
                beforeModify();
            }
        });

// Each checked style
$(".choice_as").each(function() {
    var inputNode = $(this).parent().parent().find("input");

    if ($(this).attr("id").substring(7) == trueAnwser) {
        $(this).attr("src", $("#checked").val());
        $("#correctAnwser").attr("value", trueAnwser);
        $("#addEditAnwser").attr("value", $("#editId").val());
        inputNode.css("background-color", "#D2DAE3");
    }
}, this);

//Before modify style
function beforeModify() {
    $("#createBt").css("background-color", "gray");
    $("#createBt").attr("value", "Edit");
    $("#createBt").attr("disabled", true);
}

// After modify style
function afterModify() {
    $("#createBt").css("background-color", "#FE9901");
    $("#createBt").attr("value", "Save");
    $("#createBt").attr("disabled", false);
}

// Prevent JS injection
function htmlEncode(str) {
    var s = "";

    if (str.length == 0) {
        return "";
    }

    s = str.replace(/&/g, "&amp;");
    s = s.replace(/</g, "&lt;");
    s = s.replace(/>/g, "&gt;");
    s = s.replace(/ /g, " ");
    s = s.replace(/\'/g, "'");
    s = s.replace(/\"/g, '"');
    s = s.replace(/\n/g, "<br>");

    return s;
}

// Format ID
function formatID() {
    var len = $("#editId").val().length;
    var idLen = $("#editId").val();

    for (var i = 0; i < 6 - len; i++) {
        idLen = "0" + idLen;
    }

    idLen = "Q" + idLen;

    return idLen;
}