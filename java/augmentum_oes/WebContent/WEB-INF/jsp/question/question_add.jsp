<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "../common/common_label.jsp" %>
<%@ taglib uri="/WEB-INF/block.tld" prefix="block" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>question_add</title>
    <link href="${serverPath}/css/question/question_add.css" rel="stylesheet" type="text/css" />
  </head>
  <body>
    <!-- head -->
    <block:display name="headBlock" />
    <!-- tab -->
    <block:display name="tabBlock" />
    <div class="content">
      <div class="navigation_bar">
        <span class="pass_bar"><a href="javascript:void(0)" id="questionListPage">Question Management</a></span>
        <span class="pass_bar" >></span>
        <span class="current_bar" id="oldBar"><a href="javascript:void(0)">Create Question</a></span>
      </div>
      <div class="mid_content">
        <form id="addForm" name="question" action="${path}/page/question/save" method="POST">
          <div class="mid_content_center">
            <div class="content_top">
              <span><label class="question_id_laber" id="addId">Question&nbsp;ID&nbsp;:</label></span>
              <span><label class="question_id_input" id="currentId">${falseEdit}</label></span>
            </div>
            <div class="content_mid">
              <label class="question_id_laber">Question&nbsp;:</label>
              <label>
                <textarea id="questionContent" name="questionContent" rows="7" cols="68" maxlength="200" required="required"></textarea>
              </label>
            </div>
            <div class="content_bottom">
              <label class="question_id_laber">Anwser&nbsp;:</label>
              <div class="choice_anwser">
                <ul>
                  <li>
                    <span class="anwser_img"><img id="choice_A" class="choice_as" alt="" src="${serverPath}/img/question-img/BTN_Radio_Unselected_16x16.png.png" /></span>
                    <label class="anwser_number">A</label>
                    <input id="choiceA" name="choiceA" class="anwser_text" type="text" placeholder="Please input the anwser" maxlength="45" required="required" autocomplete="off" />
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_B" class="choice_as" alt="" src="${serverPath}/img/question-img/BTN_Radio_Unselected_16x16.png.png" /></span>
                    <label class="anwser_number">B</label>
                    <input id="choiceB" name="choiceB" class="anwser_text" type="text" placeholder="Please input the anwser" maxlength="45" required="required" autocomplete="off" />
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_C" class="choice_as" alt="" src="${serverPath}/img/question-img/BTN_Radio_Unselected_16x16.png.png" /></span>
                    <label class="anwser_number">C</label>
                    <input id="choiceC" name="choiceC" class="anwser_text" type="text" placeholder="Please input the anwser" maxlength="45" required="required" autocomplete="off" />
                  </li>
                  <li>
                    <span class="anwser_img"><img id="choice_D" class="choice_as" alt="" src="${serverPath}/img/question-img/BTN_Radio_Unselected_16x16.png.png" /></span>
                    <label class="anwser_number">D</label>
                    <input id="choiceD" name="choiceD" class="anwser_text" type="text" placeholder="Please input the anwser" maxlength="45" required="required" autocomplete="off" />
                  </li>
                </ul>
              </div>
              <input id="createBt" class="create_bt" type="button" value="Create" />
              <input id="addCancel" class="cancel_bt" type="button" value="Cancel" />
            </div>
            <div class="validate_info">
              <label class="vali_content">${PARAMS_FIELDS.QUESTION_CONTENT_IS_NULL}</label>
              <label class="vali_anwserA">${PARAMS_FIELDS.CHOICE_A_IS_NULL}</label>
              <label class="vali_anwserB">${PARAMS_FIELDS.CHOICE_B_IS_NULL}</label>
              <label class="vali_anwserC">${PARAMS_FIELDS.CHOICE_C_IS_NULL}</label>
              <label class="vali_anwserD">${PARAMS_FIELDS.CHOICE_D_IS_NULL}</label>
              <label class="correct_anwser_show">${PARAMS_FIELDS.CORRECT_ANWSER_IS_NULL}</label>
              <label class="is_sample_anwser">${CHECK_FIELDS }</label>
              <label class="is_sample_question_name">${CHECK_REPEATED}</label>
            </div>
          </div>
          <input id="correctAnwser" name="correctAnwser" type="hidden" />
          <input id="unCheck" type="hidden" value="${serverPath}/img/question-img/BTN_Radio_Unselected_16x16.png.png" />
          <input id="checked" type="hidden" value="${serverPath}/img/question-img/BTN_Radio_Selected_16x16.png.png" />
          <input id="path" type="hidden" value="${pageContext.request.contextPath}" />
          <input id="addEditAnwser" name="editId" type="hidden" />
          <input id="currentChoiceId" name="id" type="hidden" value="0" />
          <input id="keyword" name="keyword" type="hidden" value="${keyword}" />
          <input id="sortWay" name="sortWay" type="hidden" value="${sortWay}" />
          <input id="pageSize" name="pageSize" type="hidden" value="${pageSize}" />
          <input id="currentPage" name="currentPage" type="hidden" value="${currentPage}" />
        </form>
      </div>
    </div>
    <!-- foot Block -->
    <block:display name="footBlock" />
    <script type="text/javascript" src="${serverPath}/js/question/question_add.js"></script>
  </body>
</html>