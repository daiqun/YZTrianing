<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<link href="${serverPath}/css/common/tab.css" rel="stylesheet" />
<div class="tab">
  <a id="questionManage" class="first_bar" href="javascript:void(0);">Question Management</a>
  <a id="examManage" class="second_bar" href="javascript:void(0);">Exam Management</a>
  <span class="page_prompt" id="pagePrompt"><c:out value="${SUCCESS_FLASH_MESSAGE}"></c:out></span>
  <c:remove var="SUCCESS_FLASH_MESSAGE" scope="session" />
</div>
<input id="path" type="hidden" value="${pageContext.request.contextPath}" />
<script type="text/javascript" src="${serverPath}/js/common/tab_block.js"></script>