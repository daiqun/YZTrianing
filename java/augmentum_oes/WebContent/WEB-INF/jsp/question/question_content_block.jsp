<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="/WEB-INF/escape.tld" prefix="ex" %>
<div class="question_content">
<c:forEach items="${questionList}" var="status" varStatus="vs">
<div class="content">
  <ul class="table_title">
    <li class="question_id"><a href="javascript:void(0);">${vs.count}</a></li>
    <li class="question_title"><a href="javascript:void(0);">${status.id}</a></li>
    <li class="question_description">
      <a href="javascript:void(0);" title="<ex:escape content='${status.questionContent}' />" class="content_question" id="qsContent${status.id}">
      <ex:escape content="${status.questionContent}" />
      </a>
    </li>
    <li class="edit_question">
      <a class="question_edit" id="question_${status.id}" href="javascript:void(0);">
        <img src="${serverPath}/img/question-img/ICN_Edit_15x15.png.png" />
      </a>
    </li>
    <li class="is_select">
      <a href="javascript:void(0);">
        <img id="${status.id}" src="${serverPath}/img/question-img/ICN_Unselected_15x15.png  .png" class="is_select_pic" />
      </a>
    </li>
  </ul>
</div>
</c:forEach>
</div>