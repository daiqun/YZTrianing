// Location url
var path = $("#path").val() + "/page/";

// Spliced ID format
$(".question_title a").each(function() {
    var len = $(this).html().length;
    var idLen = $(this).html();

    for (var i = 0; i < 6 - len; i++) {
        idLen = "0" + idLen;
    }

    idLen = "Q" + idLen;
    $(this).html(idLen);
}, this);

// Go to question list
$("#questionList").on("click", function() {
    location.href = path + "question/show";
});

// Page entry control
$("#pageInput").on(
        "keydown",
        function() {
            if (!(event.keyCode == 116) && !(event.keyCode == 46) && !(event.keyCode == 8) && !(event.keyCode == 37)
                    && !(event.keyCode == 39)) {
                if (!((event.keyCode >= 48 && event.keyCode <= 57) || (event.keyCode >= 96 && event.keyCode <= 105))) {
                    event.returnValue = false;
                }
            }

            if (event.keyCode == 13) {
                $('#goButton').trigger("click");
            }
        });

// Forward to selected page
$("#goButton").on(
        "click",
        function() {
            var pageNum = $.trim($("#pageInput").val());
            var currentPage = 1;

            if (pageNum) {
                currentPage = parseInt(pageNum);
            }

            var innerText = $.trim($("#questionTextSearch").val());
            var status = $("#sortFlag").val();
            var pageCount = $("#pageCount").val();
            var nowSize = $("#pageSize").val();

            if (currentPage < 1) {
                $("#pagePrompt").html("Page exceeds minimum limit");
                popShow();
            } else if (currentPage > pageCount) {
                $("#pagePrompt").html("Page exceeds maximum limit");
                popShow();
            } else {
                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=" + status + "&pageSize=" + nowSize;
            }
        });

// Page size selection
$(".select_page select").on(
        "change",
        function() {
            var pageSize = $(this).val();
            var currentPage = parseInt($("#currentPage").val());
            var innerText = $.trim($("#questionTextSearch").val());
            var status = $("#sortFlag").val();

            location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage + "&status="
                    + status + "&pageSize=" + pageSize;
        });

// Sorting mode selection
$("#sortBt").on(
        "click",
        function() {
            var currentPageSize = $("#pageSize").val();
            var currentPage = parseInt($("#currentPage").val());
            var innerText = $.trim($("#questionTextSearch").val());

            if ($("#sortWay").attr("src") == $("#rise").val()) {
                $("#sortWay").attr("src", $("#decline").val());
                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=desc" + "&pageSize=" + currentPageSize;
            } else {
                $("#sortWay").attr("src", $("#rise").val());

                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=asc" + "&pageSize=" + currentPageSize;
            }
        });

$("#createQuestion").on(
        "click",
        function() {

            var keyword = $("#questionTextSearch").val();
            var innerText = $.trim(encodeURIComponent(keyword));
            var currentPage = parseInt($("#currentPage").val());
            var status = $("#sortFlag").val();
            var pageSize = $("#pageSize").val();

            location.href = path + "question/edit/0?keyword=" + innerText + "&currentPage=" + currentPage + "&status="
                    + status + "&pageSize=" + pageSize;
        });

// Page sort initial selection
if ("asc" == $("#sortFlag").val()) {
    $("#sortWay").attr("src", $("#rise").val());
} else if ("desc" == $("#sortFlag").val()) {
    $("#sortWay").attr("src", $("#decline").val());
} else {
    $("#sortWay").attr("src", $("#decline").val());
}

// Last page
$("#leftPage").on(
        "click",
        function() {
            var currentPage = parseInt($("#currentPage").val()) - 1;
            var innerText = $.trim($("#questionTextSearch").val());
            var status = $("#sortFlag").val();
            var nowSize = $("#pageSize").val();

            if (currentPage < 1) {
                $("#pagePrompt").html("Is already the first page");
                popShow();
            } else {
                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=" + status + "&pageSize=" + nowSize;
            }
        });

// Next page
$("#rightPage").on(
        "click",
        function() {
            var currentPage = parseInt($("#currentPage").val()) + 1;
            var innerText = $.trim($("#questionTextSearch").val());
            var status = $("#sortFlag").val()
            var nowSize = $("#pageSize").val();

            if (currentPage > $("#pageCount").val()) {
                $("#pagePrompt").html("Is already the last page");
                popShow();
            } else {
                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=" + status + "&pageSize=" + nowSize;
            }
        });

// Forward to selected page
$(".page_number_list a").on(
        "click",
        function() {
            var innerText = $.trim($("#questionTextSearch").val());
            var currentPage = parseInt($(this).html());
            var status = $("#sortFlag").val()
            var pageSize = $("#pageSize").val();

            if (!isNaN($(this).html())) {

                location.href = path + "question/show?keyword=" + innerText + "&currentPage=" + currentPage
                        + "&status=" + status + "&pageSize=" + pageSize;
            }
        })

// Select delete options
$(".is_select_pic").on("click", function() {
    if ($(this).attr("src") == $("#unselect").val()) {
        $(this).attr("src", $("#selected").val());
    } else {
        $(this).attr("src", $("#unselect").val());
        $("#isSeleteAll").attr("src", $("#unselect").val());
    }
});

// Select the delete all option
$("#isSeleteAll").on("click", function() {
    if ($(this).attr("src") == $("#unselect").val()) {
        $(this).attr("src", $("#selected").val());
        $(".is_select_pic").attr("src", $("#selected").val());
    } else {
        $(this).attr("src", $("#unselect").val());
        $(".is_select_pic").attr("src", $("#unselect").val());
    }
});

// Multiple deletion
$("#deleteBtn").on(
        "click",
        function() {
            var id_all = [];

            $(".is_select_pic").each(function() {
                if ($(this).attr("src") == $("#selected").val()) {
                    id_all.push($(this).attr("id"));
                }
            }, this);

            if (!$.trim(id_all)) {
                $("#pagePrompt").html("Please select the delete option");
                popShow();
            } else {
                $("#promptMain").css("z-index", "2");
                $("#promptMain").css("visibility", "visible");
                $("#backGd").css("visibility", "visible");

                $("#leavePic,#promptNo").on("click", function() {
                    $("#promptMain").css("visibility", "hidden");
                    $("#backGd").css("visibility", "hidden");
                });

                $("#promptYes").on(
                        "click",
                        function() {
                            var keyword = $("#questionTextSearch").val();
                            var innerText = $.trim(encodeURIComponent(keyword));
                            var currentPage = parseInt($("#currentPage").val());
                            var status = $("#sortFlag").val();
                            var pageSize = $("#pageSize").val();

                            location.href = path + "question/delete?allId=" + id_all + "&keyword=" + innerText
                                    + "&currentPage=" + currentPage + "&status=" + status + "&pageSize=" + pageSize;
                        });
            }
        });

// Modify selected options
$(".question_edit").on(
        "click",
        function() {
            var id = $(this).attr("id").substring(9);
            var keyword = $("#questionTextSearch").val();
            var innerText = $.trim(encodeURIComponent(keyword));
            var currentPage = parseInt($("#currentPage").val());
            var status = $("#sortFlag").val();
            var pageSize = $("#pageSize").val();

            location.href = path + "question/edit/" + id + "?keyword=" + innerText + "&currentPage=" + currentPage
                    + "&status=" + status + "&pageSize=" + pageSize;
        });

// Search by key word
$("#searchIcon").on(
        "click",
        function() {
            var keyword = $("#questionTextSearch").val();
            var innerText = $.trim(encodeURIComponent(keyword));
            var currentPage = parseInt($("#currentPage").val());
            var status = $("#sortFlag").val();
            var pageSize = $("#pageSize").val();

            location.href = !innerText ? path + "question/show" : path + "question/show?keyword=" + innerText
                    + "&currentPage=" + currentPage + "&status=" + status + "&pageSize=" + pageSize;
        });

// Question details
$(".content_question").on(
        "click",
        function() {
            var id = $(this).attr("id").substring(9);
            var thisId = parseInt(id)
            var keyword = $("#questionTextSearch").val();
            var innerText = $.trim(encodeURIComponent(keyword));
            var currentPage = parseInt($("#currentPage").val());
            var status = $("#sortFlag").val();
            var pageSize = $("#pageSize").val();

            location.href = path + "question/details/" + thisId + "?keyword=" + innerText + "&currentPage="
                    + currentPage + "&status=" + status + "&pageSize=" + pageSize;
        });

// Move the cursor to the end of the text
$.fn.selectRange = function(start, end) {

    return this.each(function() {
        if (this.setSelectionRange) {
            this.focus();
            this.setSelectionRange(start, end);
        } else if (this.createTextRange) {
            var range = this.createTextRange();
            range.collapse(true);
            range.moveEnd('character', end);
            range.moveStart('character', start);
            range.select();
        }
    });
};

$("#questionTextSearch").selectRange(20, 50);

$("#questionTextSearch").on("keydown", function(event) {
    if (event.keyCode == 13) {
        $('#searchIcon').trigger("click");
    }
})

// Pagination display
var pageCount = $("#pageCount").val();
var currentPage = parseInt($("#currentPage").val());

if (pageCount > 5) {
    if (currentPage <= 3) {
        $("#pageNum1").html(1);
        $("#pageNum2").html(2);
        $("#pageNum3").html(3);
        $("#pageNum4").html('...');
        $("#pageNum5").html(pageCount);
    } else if (currentPage == 4) {
        $("#pageNum1").html(1);
        $("#pageNum2").html('...');
        $("#pageNum3").html(currentPage);
        $("#pageNum4").html('...');
        $("#pageNum5").html(pageCount);
    } else if (currentPage > 4) {
        $("#pageNum1").html(1);
        $("#pageNum2").html('...');
        $("#pageNum3").html(pageCount - 2);
        $("#pageNum4").html(pageCount - 1);
        $("#pageNum5").html(pageCount);
    }
} else if (pageCount == 5) {
    $("#pageNum1").html(1);
    $("#pageNum2").html(2);
    $("#pageNum3").html(3);
    $("#pageNum4").html(4);
    $("#pageNum5").html(5);
} else if (pageCount == 4) {
    $("#pageNum1").html(1);
    $("#pageNum2").html(2);
    $("#pageNum3").html(3);
    $("#pageNum4").html(4);
    $("#pageNum5").html('');
} else if (pageCount == 3) {
    $("#pageNum1").html(1);
    $("#pageNum2").html(2);
    $("#pageNum3").html(3);
    $("#pageNum4, #pageNum5").html('');
} else if (pageCount == 2) {
    $("#pageNum1").html(1);
    $("#pageNum2").html(2);
    $("#pageNum3, #pageNum4, #pageNum5").html('');
} else if (pageCount == 1) {
    $("#pageNum1").html(1);
    $("#pageNum2, #pageNum3, #pageNum4, #pageNum5").html('');
} else if (pageCount == 0) {
    $("#pageNum1, #pageNum2, #pageNum3, #pageNum4, #pageNum5").html('');
}

function popShow() {
    $("#pagePrompt").slideDown(300);

    setTimeout(function() {
        $("#pagePrompt").slideUp(300);
    }, 1500);
}

// Current page display
$(".page_number").each(function() {
    var currentPage = parseInt($("#currentPage").val());
    var thisPage = $(this).html();

    if (thisPage && parseInt(thisPage) == currentPage) {
        $(this).css("color", "#FE9901");
    }
}, this);