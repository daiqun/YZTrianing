//Location url
var path = $("#path").val() + "/page/";

// This is add page
var isEdit = 0;

// This page showed style
$("#addId").css("color", "#FFFFFF");
$("#createBt").css("background-color", "gray");
$("#createBt").attr("disabled", true);

// Default contentType: "application/x-www-form-urlencoded; charset=utf-8";so we set it "application/json; charset=utf-8"
$.ajaxSetup({
    cache : false,
    dataType : "json",
    contentType : "application/json; charset=utf-8"
});

// Verify whether there are duplicate questions
$("#questionContent").on("keyup blur mouseout", function() {
    var content = $.trim($("#questionContent").val());

    $.ajax({
        url : path + "question/getByName",
        type : "POST",
        data : JSON.stringify({
            "questionContent" : content
        }),

        success : function(data) {
            // This is add res
            if (isEdit == 0) {
                if (data == 1) {
                    $("#pagePrompt").html("Problem is repeated");
                    $("#pagePrompt").show();
                    beforeAdd();
                } else {
                    $("#pagePrompt").hide();
                    $("#pagePrompt").html("");
                    checkSub();
                }
                // This is update res
            } else if (isEdit == 1) {
                if ($("#editContent").val() != content) {
                    if (data >= 1) {
                        $("#pagePrompt").html("Problem is repeated");
                        $("#pagePrompt").show();
                        beforeAdd();
                    } else {
                        $("#pagePrompt").hide();
                        $("#pagePrompt").html("");
                        checkSub();
                    }
                }
            }
        },

        error : function(xhr, ajaxOptions, thrownError) {
            console.log("false");
        }
    });
});

// Check if input is null
$(".anwser_text").on("keyup", checkSub);

// Check is submit
function checkSub() {
    var changeStyle = true;

    $(".choice_as").each(
            function() {
                if ($(this).attr("src") == $("#checked").val()) {
                    if ($.trim($("#questionContent").val()) && $.trim($("#choiceA").val())
                            && $.trim($("#choiceB").val()) && $.trim($("#choiceC").val())
                            && $.trim($("#choiceD").val())) {

                        if (!$("#pagePrompt").html()) {
                            afterAdd();
                        }
                    } else {
                        beforeAdd();
                    }

                    changeStyle = false;
                } else {
                    if (changeStyle) {
                        beforeAdd();
                    }
                }
            });
}

// Check if anwser is null
$(".choice_as").on(
        "click",
        function() {
            var inputNode = $(this).parentsUntil('ul').find('input');
            var choice = $("#correctAnwser").val();

            if ($(this).attr("src") == $("#unCheck").val()) {

                // Change checked style
                $(".anwser_text").css("background-color", "#FFFFFF");
                inputNode.css("background-color", "#D2DAE3");
                $(".choice_as").attr("src", $("#unCheck").val());
                choice = $(this).attr('id').substring(7);
                $("#correctAnwser").attr("value", choice);
                $(this).attr("src", $("#checked").val());

                if ($.trim($("#questionContent").val()) && $.trim($("#choiceA").val()) && $.trim($("#choiceB").val())
                        && $.trim($("#choiceC").val()) && $.trim($("#choiceD").val())) {

                    if (!$.trim($("#pagePrompt").html())) {
                        afterAdd();
                    }
                } else {
                    beforeAdd();
                }
            } else {
                inputNode.css("background-color", "#FFFFFF");
                $(this).attr("src", $("#unCheck").val());
                beforeAdd();
            }
        });

// Create a question check about
$("#createBt").on("click", function addQs() {
    var content = $.trim($("#questionContent").val());
    var choiceA = $.trim($("#choiceA").val());
    var choiceB = $.trim($("#choiceB").val());
    var choiceC = $.trim($("#choiceC").val());
    var choiceD = $.trim($("#choiceD").val());
    var correctAnwser = "";
    var isSubmitForm = true;

    $(".choice_as").each(function() {
        if ($(this).attr("src") == $("#checked").val()) {
            correctAnwser = $(this).attr("id").substring(7);
        }
    }, this);

    if (!content) {
        $(".vali_content").html("Question content is required");
        isSubmitForm = false;
    } else {
        $(".vali_content").html("");
    }

    if (!choiceA) {
        $(".vali_anwserA").html("Choice A is required");
        isSubmitForm = false;
    } else {
        $(".vali_anwserA").html("");
    }

    if (!choiceB) {
        $(".vali_anwserB").html("Choice B is required");
        isSubmitForm = false;
    } else {
        $(".vali_anwserB").html("");
    }

    if (!choiceC) {
        $(".vali_anwserC").html("Choice C is required");
        isSubmitForm = false;
    } else {
        $(".vali_anwserC").html("");
    }

    if (!choiceD) {
        $(".vali_anwserD").html("Choice D is required");
        isSubmitForm = false;
    } else {
        $(".vali_anwserD").html("");
    }

    if (!correctAnwser) {
        $(".correct_anwser_show").html("Correct anwser is required");
        isSubmitForm = false;
    } else {
        $(".correct_anwser_show").html("");
    }

    var anwserList = [ choiceA, choiceB, choiceC, choiceD ];
    var nary = anwserList.sort();

    if (isSubmitForm) {
        for (var i = 0; i < nary.length; i++) {
            if (nary[i] == nary[i + 1]) {
                $(".is_sample_anwser").html("Answer to the question can not be repeated");
                isSubmitForm = false;
            }
        }
    }

    if (isSubmitForm) {
        afterAdd();
        $("#addForm").submit();
    } else {
        afterAdd();
    }
});

// Before add style
function beforeAdd() {
    $("#createBt").css("background-color", "gray");
    $("#createBt").attr("value", "Create");
    $("#createBt").attr("disabled", true);
}

// After add style
function afterAdd() {
    $("#createBt").css("background-color", "#FE9901");
    $("#createBt").attr("value", "Save");
    $("#createBt").attr("disabled", false);
}

// Crumbs url
$("#questionListPage").on("click", function() {
    location.href = path + "question/show";
});

// Return to the previous page and refresh
$("#addCancel").on("click", function addCancle() {
    self.location = document.referrer;
});