<%-- <%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="com.augmentum.oes.util.ConstansUtil"%>
<%@ page import="com.augmentum.oes.model.User"%>
<% 
    String path = request.getContextPath();
    String basePath = request.getScheme() + "://" + request.getServerName()
    + ":" + request.getServerPort() + path;
%>
<%User use = (User)session.getAttribute(ConstansUtil.USER); %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>question-add</title>
    <link href="<%=path %>/static/css/question-include.css" rel="stylesheet" type="text/css" />
    <link href="<%=path %>/static/css/question-add.css" rel="stylesheet" type="text/css" />
  </head>

  <body>
    <div id="top">
      <img alt="augmentum_logo" src="<%=path %>/static/img/question-img/LOGO_Web_40x240.png" id="augmentum_logo" />
      <span class="logo_describe">Online Exam Web System</span>
      <div id="user_show">
        <span id="user_show_user_flag"><img src="<%=path %>/static/img/question-img/ICN_Web_PersonalInformation_20x20.png  .png" /></span>
        <span id="user_show_user_name"><a href="javascript:void(0);"><%=use.getUserName()%></a></span>
        <span id="user_show_logout"><a href="javascript:void(0);" id="logout">Logout</a></span>
      </div>
      <span id="language"><a href="javascript:void(0);">中文</a></span>
    </div>

    <div id="tab">
      <a id="question_manage" href="javascript:void(0);">Question Management</a>
      <a id="exam_manage" href="javascript:void(0);">Exam Management</a>
    </div>

    <div id="mid">
      <div id="navigation_bar">
        <span class="pass_bar"><a href="javascript:void(0)">Question Management</a></span>
        <span class="pass_bar">></span>
        <span class="current_bar"><a href="javascript:void(0)">Create Question</a></span>
      </div>
      <div id="mid_content">
        <form id="add_form" action="QuestionServlet.do?action=addQuestion" method="POST">
        <div id="mid_content_center">
            <div id="content_top">
              <span>
                <label class="question_id_laber">Question&nbsp;ID&nbsp;:</label>
              </span>
              <span>
                <label class="question_id_input" id="question_id_display">Q002089</label>
              </span>
            </div>
            <div id="content_mid">
              <label class="question_id_laber">Question&nbsp;:</label>
              <label>
                <textarea name="question_content" rows="7" cols="68" maxlength="200"></textarea>
              </label>
            </div>
            <div id="content_bottom">
              <label class="question_id_laber" id="question_id_laber_style">Anwser&nbsp;:</label>
              <div id="chice_anwser">
                <ul>
                  <li>
                    <span class="anwser_img"><img class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">A</label>
                    <input name="anwser_a" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">B</label>
                    <input name="anwser_b" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">C</label>
                    <input name="anwser_c" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">D</label>
                    <input name="anwser_d" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                </ul>
              </div>
              <input id="create_bt" class="create_bt" type="button" value="Create">
              <input class="cancel_bt" type="button" value="Cancel">
              <input id="unCheck" type="hidden" value="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png">
              <input id="checked" type="hidden" value="<%=basePath %>/static/img/question-img/BTN_Radio_Selected_16x16.png.png">
              <input name="current_anwser" type="hidden" >
            </div>
        </div>
        </form>
      </div>
      <div id="bottom">
        <span class="copyright_info">Copyright &copy; 2014 Augmentum.Inc All Rights Reserved</span>
      </div>
    </div>
    <script type="text/javascript" src="<%=path %>/static/js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#logout").on("click", function (event) {

                location.href = "DashboardServlet.do?action=logout";
          }); 
        });

        $(function () {
            $(".choice_as").on("click", function () {

                if($(this).attr("src") == $("#unCheck").val()){
                    $(".choice_as").attr("src", $("#unCheck").val());
                    $(this).attr("src", $("#checked").val());
                }else{
                    $(this).attr("src", $("#unCheck").val());
                }
            });
        });

        $(function () {
            $("#create_bt").on("click", function () {
                $("#add_form").submit();
            });
        })
    </script>
  </body>
</html> --%>