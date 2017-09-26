<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
    <form id="addForm" action="question.do?action=add" method="POST">
        <div id="midContentCenter">
            <div id="contentTop">
              <span>
                <label class="question_id_laber">Question&nbsp;ID&nbsp;:</label>
              </span>
              <span>
                <label class="question_id_input" id="questionIdDisplay"></label>
              </span>
            </div>
            <div id="contentMid">
              <label class="question_id_laber">Question&nbsp;:</label>
              <label>
                <textarea id="questionContent" name="question_content" rows="7" cols="68" maxlength="200"></textarea>
              </label>
            </div>
            <div id="content_bottom">
              <label class="question_id_laber" id="question_id_laber_style">Anwser&nbsp;:</label>
              <div id="choiceAnwser">
                <ul>
                  <li>
                    <span class="anwser_img"><img id="choice_A" class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">A</label>
                    <input id="choiceA" name="anwser_a" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_B" class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">B</label>
                    <input id="choiceB" name="anwser_b" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_C" class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">C</label>
                    <input id="choiceC" name="anwser_c" class="anwser_text" type="text" placeholder="Please input the anwser">
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_D" class="choice_as" alt="" src="<%=basePath %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png"></span>
                    <label class="anwser_number">D</label>
                    <input id="choiceD" name="anwser_d" class="anwser_text" type="text" placeholder="Please input the anwser">
                    <input id="correctAnwser" name="correctAnwser" type="hidden" >
                  </li>
                </ul>
              </div>
              <input id="createBt" class="create_bt" type="button" value="Create">
              <input class="cancel_bt" type="button" value="Cancel">
              <input id="unCheck" type="hidden" value="<%=path %>/static/img/question-img/BTN_Radio_Unselected_16x16.png.png">
              <input id="checked" type="hidden" value="<%=path %>/static/img/question-img/BTN_Radio_Selected_16x16.png.png">
              <input id="addEditAnwser" name="editId" type="hidden">
            </div>
        </div>
        </form>
        
        <script type="text/javascript">
        $(function () {
            $(".choice_as").on("click", function () {

                if($(this).attr("src") == $("#unCheck").val()){
                    $(".choice_as").attr("src", $("#unCheck").val());
                    var choice = $("#correctAnwser").val();
                    choice = $(this).attr('id').substring(7);
                    $("#correctAnwser").attr("value", choice);
                    $(this).attr("src", $("#checked").val());
                }else{
                    $(this).attr("src", $("#unCheck").val());
                }
            });

            $("#createBt").on("click", function () {
                $("#addForm").submit();
            });
        });
        </script>
</body>
</html>