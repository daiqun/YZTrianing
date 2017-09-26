<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="/WEB-INF/block.tld" prefix="block" %>
<%@ include file= "../common/common_label.jsp" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>exam-add</title>
    <link href="${serverPath}/css/exam/exam_add.css" rel="stylesheet" />
  </head>
  <body>
    <!-- head -->
    <block:display name="headBlock" />
    <!-- tab -->
    <block:display name="tabBlock" />
    <!-- content -->
    <div class="content">
      <!-- navigation bar -->
      <span class="navigation_bar">
        <a class="navigation_bar_exam_manage" href="javascript:void(0);">Exam Management</a>
        <span>></span>
        <a class="navigation_bar_create_exam" href="javascript:void(0);">Create Exam</a>
      </span>
      <!-- content center -->
      <div class="content_center">
        <form:form action="${path}/page/exam/create" id="addExam" modelAttribute="exam" method="post">
          <!-- create property info -->
          <ul class="exam_create_info">
            <li class="exam_create_info_create_name">Create Name&nbsp;:<i>*</i>
              <form:input path="examName" cssClass="exam_name_input " />
            </li>
            <li class="exam_create_info_description">Description&nbsp;:
              <form:textarea path="description" cssClass="exam_description_input" />
            </li>
            <li class="exam_create_info_effective">Effective&nbsp;:<i>*</i>
              <form:hidden path="effectiveTime" id="effectiveTime" />
              <input id="datePicker" class="datepicker_btn" type="date" />
              <input id="timePicker" class="include_timepicker" type="time" />
            </li>
            <li class="exam_create_info_duration">Duration&nbsp;:<i>*</i>
              <span class="exam_duration_input">
                <form:input path="duration" cssClass="exam_duration" />
                <a href="javascript:void(0);" class="duration_pic" tabindex="-1"></a>
              </span>min
            </li>
            <li class="exam_create_info_question_setting">
              <label class="question_setting_lable">Question Setting&nbsp;:<i>*</i></label>
              <ul class="exam_settings">
                <li class="exam_settings_question_quantity">Question Quantity&nbsp;:
                  <form:input path="questionQuantity" />
                </li>
                <li class="exam_settings_question_points">Question Points&nbsp;:
                  <form:input path="questionPoints" />
                </li>
                <li class="exam_settings_total_score">Total Score&nbsp;:
                  <form:input path="totalScore" readonly="true" />
                </li>
                <li class="exam_settings_pass_criteria">Pass Criteria&nbsp;:
                  <form:input path="passCriteria" />
                </li>
              </ul>
            </li>
          </ul>
        </form:form>
        <!-- create and cancel btn -->
        <span class="create_and_cancel">
          <input id="addBtn" class="create_btn" type="button" value="Create" />
          <input id="cancelBtn" class="cancel_btn" type="button" value="Cancel" />
        </span>
      </div>
    </div>
    <!-- foot Block -->
    <block:display name="footBlock" />
    <input id="path" type="hidden" value="${pageContext.request.contextPath}" />
    <input id="serverPath" type="hidden" value="${serverPath}" />
    <script type="text/javascript" src="${serverPath}/js/exam/exam_add.js"></script>
  </body>
</html>