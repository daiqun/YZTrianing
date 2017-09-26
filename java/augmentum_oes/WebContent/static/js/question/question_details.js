// Location url
var path = $("#path").val() + "/page/";

// This is not add page
var isEdit = 1;

// Current choice id
var currentId = $("#editId").val();

// Remove previous page binding event
$("#addCancel").unbind();

// Modify crumb style
$("#oldBar a").html("Question List");
$("#oldBar").append("<span class='pass_bar' id='addBar'>></span>");
$("#questionListPage").clone(true).appendTo("#addBar");
$("#addBar").css("margin", "0 0 0 10px");
$("#reload").css("color", "#0A0A0A");
$("#addBar a").attr("id", "thisID");
$("#thisID").css("margin", "0 0 0 10px");
$("#thisID").html(formatID());
$("#thisID").unbind("click");

// Modify return button style
$("#addCancel").removeAttr("value");
$("#addCancel").attr("value", "Delete");
$("#addCancel").attr("id", "deleteThis");

// Modify ID display style
$("#questionIdDisplay, #questionContent, .anwser_text").css("border", "1px solid white");

// Change style in modify
$("#questionIdDisplay, #questionContent, .anwser_text").on("focus", function detailsStyle() {
    $(this).css("border", "1px solid #2E4358");
    $(this).css("outline", "none");
});

// Change style after modify
$("#questionIdDisplay, #questionContent, .anwser_text").on("blur", function() {
    $(this).css("border", "1px solid white");
});

// Delete display
$("#deleteThis").on("click", function deleteThis() {
    $("#promptMain").css("z-index", "2");
    $("#promptMain").css("visibility", "visible");
    $("#backGd").css("visibility", "visible");
});

// Delete or leave
$("#leavePic, #promptNo").on("click", function() {
    $("#promptMain").css("visibility", "hidden");
    $("#backGd").css("visibility", "hidden");
});

// Choice delete
$("#promptYes").on(
        "click",
        function() {
            var deleteId = $("#editId").val();
            var keyword = $("#keyword").val();
            var innerText = $.trim(encodeURIComponent(keyword));
            var currentPage = parseInt($("#currentPage").val());
            var status = $("#sortWay").val();
            var pageSize = $("#pageSize").val();

            location.href = path + "question/delete?allId=" + deleteId + "&keyword=" + innerText + "&currentPage="
                    + currentPage + "&status=" + status + "&pageSize=" + pageSize;
        });