// Back-end URL
var path = $("#path").val() + "/page/";

// Logout
$("#logout").on("click", function() {
    location.href = path + "user/logout";
});