<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ include file= "../common/common_label.jsp"%>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>question_add</title>
    <link href="${path}/static/css/question_include.css" rel="stylesheet" type="text/css" />
  </head>
  <body>
    <div id="top">
      <img alt="Augmentum_Logo" src="${path}/static/img/question-img/LOGO_Web_40x240.png" id="augmentumLogo" />
      <span class="logoDescribe">Online Exam Web System</span>
      <div id="userShow">
        <span id="userShowFlag"><img src="${path}/static/img/question-img/ICN_Web_PersonalInformation_20x20.png  .png" /></span>
        <span id="userNameShow"><a href="javascript:void(0);">${user.userName}</a></span>
        <span id="userLogout"><a href="javascript:void(0);" id="logout">Logout</a></span>
      </div>
      <span id="language"><a href="javascript:void(0);">中文</a></span>
    </div>
    <div id="tab">
      <a id="questionManage" href="javascript:void(0);">Question Management</a>
      <a id="examManage" href="javascript:void(0);">Exam Management</a>
    </div>
    <div id="mid">
      <div id="navigationBar">
        <span class="pass_bar"><a href="javascript:void(0)" id="questionListPage">Question Management</a></span>
        <span class="pass_bar">></span>
        <span class="current_bar"><a href="javascript:void(0)" id="reload">Create Question</a></span>
      </div>
      <div id="midContent">
        <!-- to do -->
      </div>
      <div id="bottom">
        <span class="copyrightInfo">Copyright &copy; 2014 Augmentum.Inc All Rights Reserved</span>
      </div>
    </div>
    <script type="text/javascript">
        $(function () {
            $("#logout").on("click", function (event) {
                location.href = "logout.action";
          });
        });

        $(function () {
            $("#questionListPage").on("click",function (){
                location.href = "showQuestion.action";
            });

            $("#reload").on("click",function (){
                location.reload();
            });
        })
    </script>
  </body>
</html>