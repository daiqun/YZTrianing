<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "../common/common_label.jsp" %>
<link href="${serverPath}/css/common/head.css" rel="stylesheet" />
<div class="head">
  <img class="augmentumLogo" alt="userShowFlag" src="${serverPath}/img/question-img/LOGO_Web_40x240.png" />
  <span class="logoDescribe">Online Exam Web System</span>
  <div class="head_user_choice">
    <a class="language" href="javascript:void(0);">中文</a>
    <div class="user_choice_info">
      <img src="${serverPath}/img/question-img/ICN_Web_PersonalInformation_20x20.png  .png" />
      <a class="name_show" href="javascript:void(0);"><c:out value="${user.userName}" /></a>
      <a id="logout" class="logout" href="javascript:void(0);">Logout</a>
    </div>
  </div>
</div>
<input id="path" type="hidden" value="${pageContext.request.contextPath}" />
<script type="text/javascript" src="${serverPath}/js/common/head.js"></script>