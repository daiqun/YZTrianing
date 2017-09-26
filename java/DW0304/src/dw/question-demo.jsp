<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="com.augmentum.oes.util.ConstansUtil"%>
<%@ page import="com.augmentum.oes.entity.User"%>
<% 
    String path = request.getContextPath();
    String basePath = request.getScheme() + "://" + request.getServerName()
    + ":" + request.getServerPort() + path + "/";
%>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>welcome</title>
    <link href="<%=path %>/static/css/question-include.css" rel="stylesheet" />
  </head>

  <body>
    <div id="top">
      <img alt="augmentum_logo" src="static/img/question-img/LOGO_Web_40x240.png" id="augmentum_logo" />
      <span class="logo_describe">Online Exam Web System</span>

      <div id="user_show">
        <span id="user_show_user_flag"><img src="static/img/question-img/ICN_Web_PersonalInformation_20x20.png  .png" /></span>
        <span id="user_show_user_name"><a href="javascript:void(0);">用户名</a></span>
        <span id="user_show_logout"><a href="javascript:void(0);" id="logout">Logout</a></span>
      </div>
      <span id="language"><a href="javascript:void(0);">中文</a></span>
    </div>

    <div id="tab">
      <a id="question_manage" href="javascript:void(0);">Question Management</a>
      <a id="exam_manage" href="javascript:void(0);">Exam Management</a>
    </div>

    <div id="mid">
      <div id="mid_content">
        <!-- to do -->
      </div>
      <div id="bottom">
        <span class="copyright_info">Copyright &copy; 2014 Augmentum.Inc All Rights Reserved</span>
      </div>
    </div>

    <script type="text/javascript">
        var logout = document.getElementById("logout");

        logout.addEventListener("click", function (event) {

            location.href = "DashboardServlet.do?action=logout";
      }, false)
    </script>
  </body>
</html>