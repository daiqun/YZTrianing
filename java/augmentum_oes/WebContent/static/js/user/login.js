// If return back just now page
var queryString = location.hash;
document.getElementById("queryString").value = queryString;
console.log($("#queryString").val());

// If show the error info
var error = $("#error_info").html();

if ($.trim(error) != "") {
    $("#error_info").css("visibility", "visible");
} else if ($.trim(error) == null) {
    $("#error_info").css("visibility", "hidden");
}

// Keydown submit login
document.onkeydown = function(e) {
    var ev = document.all ? window.event : e;

    if (ev.keyCode == 13) {
        $("#formSub").trigger("click");
    }
}

// Change remember style
$("#remenberMePic, .remenber_me").on("click", function() {

    if ($("#remenberMePic").attr("src") == $("#noRemenberMe").val()) {
        $("#remenberMePic").attr("src", $("#remenberMe").val());
        $("#remenberUser").val("1");
    } else {
        $("#remenberMePic").attr("src", $("#noRemenberMe").val());
        $("#remenberUser").val("0");
    }
});

if ($("#remenberUser").val() == "1") {
    $("#remenberMePic").attr("src", $("#remenberMe").val());
} else {
    $("#remenberMePic").attr("src", $("#noRemenberMe").val());
}

// Login submit
$("#formSub").on("click", function num() {
    var userName = $.trim($("#userName").val());
    var password = $.trim($("#password").val());

    var isSubmitForm = true;

    if (!userName) {
        $("#userName_error_tab").css("visibility", "visible");
        $("#error_info").html("UserName is null");
        $("#error_info").css("visibility", "visible");
        isSubmitForm = false;
    }

    if (!password) {
        $("#password_error_tab").css("visibility", "visible");
        $("#error_info").html("Password is null");
        $("#error_info").css("visibility", "visible");
        isSubmitForm = false;
    }

    if (isSubmitForm) {
        $("#loginForm").submit();
    }
});

$("#userName, #password").on("focus mouseout", function() {
    if ($("#userName").val()) {
        $("#userName_error_tab").css("visibility", "hidden");
        $("#error_info").css("visibility", "hidden");
    }

    if ($("#password")) {
        $("#password_error_tab").css("visibility", "hidden");
        $("#error_info").css("visibility", "hidden");
    }
});