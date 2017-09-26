<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "question_add.jsp" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>question_edit</title>
  </head>
  <body>
    <input id="editId" type="hidden" value='<c:out value="${thisQuestion.id eq null ? update_fail_question.id : thisQuestion.id}"></c:out>' />
    <input id="editContent" type="hidden" value="<c:out value="${thisQuestion.questionContent eq null ? update_fail_question.questionContent : thisQuestion.questionContent}"></c:out>" />
    <input id="editChoiceA" type="hidden" value="<c:out value="${thisQuestion.choiceA eq null ? update_fail_question.choiceA : thisQuestion.choiceA}"></c:out>" />
    <input id="editChoiceB" type="hidden" value="<c:out value="${thisQuestion.choiceB eq null ? update_fail_question.choiceB : thisQuestion.choiceB}"></c:out>" />
    <input id="editChoiceC" type="hidden" value="<c:out value="${thisQuestion.choiceC eq null ? update_fail_question.choiceC : thisQuestion.choiceC}"></c:out>" />
    <input id="editChoiceD" type="hidden" value="<c:out value="${thisQuestion.choiceD eq null ? update_fail_question.choiceD : thisQuestion.choiceD}"></c:out>" />
    <input id="editCorrectAnwser" type="hidden" value="<c:out value="${thisQuestion.correctAnwser eq null ? update_fail_question.correctAnwser : thisQuestion.correctAnwser}"></c:out>" />
    <input id="checked" type="hidden" value="${serverPath}/img/question-img/BTN_Radio_Selected_16x16.png.png" />
    <script type="text/javascript" src="${serverPath}/js/question/question_edit.js"></script>
  </body>
</html>