<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<link href="${serverPath}/css/common/paginator.css" rel="stylesheet" />
<div class="page_bar">
  <a id="leftPage" class="front_page" href="javascript:void(0);"><img src="${serverPath}/img/question-img/BTN_PageLeft_20x15.png.png" /></a>
  <span class="page_number_list">
    <a id="pageNum1" class="page_number" href="javascript:void(0);"></a>
    <a id="pageNum2" class="page_number" href="javascript:void(0);"></a>
    <a id="pageNum3" class="page_number" href="javascript:void(0);"></a>
    <a id="pageNum4" class="page_number" href="javascript:void(0);"></a>
    <a id="pageNum5" class="page_number" href="javascript:void(0);"></a>
  </span>
  <a id="rightPage" class="next_page" href="javascript:void(0);"><img src="${serverPath}/img/question-img/BTN_PageRight_20x15.png .png" /></a>
  <span class="perpage_info">Per&nbsp;&nbsp;page</span>
  <span class="select_page">
    <select>
    <c:forEach items="${pageItem}" var="item" varStatus="i">
      <option value="${item}" <c:if test="${item eq pageSize}">selected</c:if>>${item}</option>
    </c:forEach>
    </select>
  </span>
  <span><input id="pageInput" class="page_input" type="text" value="${pagination.currentPage}" /></span>
  <span><input id="goButton" class="go_btn" type="button" value="Go" /></span>
</div>