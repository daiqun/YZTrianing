<%@ page import="com.augmentum.oes.util.CookieUtil" %>
<%@ page import="com.augmentum.oes.Constants" %>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "common/common_label.jsp" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>login</title>
    <link href="${serverPath}/css/login.css" rel="stylesheet" />
  </head>
  <body>
    ${myFunc:readCookie()}
    <div class="top">
      <img class="company_logo" alt="augmentum" src="${serverPath}/img/login-img/LOGO_Web_Login_90x180.png" />
      <span class="logo_describe">Online Exam Web System</span>
      <span class="welcome_info">Welcome to login</span>
      <div class="login_info">
        <div class="error_info" id="error_info">${CHECK_FIELDS}</div>
          <form action="${path}/page/user/login" method="POST" id="loginForm" name="user">
            <div class="rom_userInfo">
              <div class="userName_info">
                <span class="nameAndPwd_pic"><img src="${serverPath}/img/login-img/ICN_Usename_20x20.png.png" /></span>
                <input type="text" name="userName" id="userName" placeholder="Username" class="nameAndPwd" value='${SAVE_SNAP_NAME}<c:out value="${userName eq null ? returnName : userName}" ></c:out>' />
                <input name="go" type="hidden" value='<c:out value="${go eq null ? '' : go}" ></c:out>' />
                <input id="queryString" name="queryString" type="hidden" />
              </div>
              <span class="error_tab" id="userName_error_tab">
                <img src="${serverPath}/img/login-img/ICN_Client_Login_Wrong_20X20.png" />
              </span>
            </div>
            <div class="rom_userInfo">
              <div class="password_info">
                <span class="nameAndPwd_pic"><img src="${serverPath}/img/login-img/ICN_Password_20x15.png.png" /></span>
                <input type="password" name="password" id="password" placeholder="Password" class="nameAndPwd" value="${password}" />
              </div>
              <span class="error_tab" id="password_error_tab">
                <img src="${serverPath}/img/login-img/ICN_Client_Login_Wrong_20X20.png" />
              </span>
            </div>
            <input id="remenberUser" name="flag" type="hidden" value="${rememberMe}" />
            <input id="flag" type="hidden" value="${flag}" />
          </form>
        <input type="button" value="Login" class="login_bt" id="formSub" />
        <div class="login_choice">
          <span id="remenber_pwd">
            <span id="cgURL"><img src="${serverPath}/img/login-img/BTN_RemeberMe_Unselect_12X12.png.png" id="remenberMePic" /></span>
            <span class="remenber_me"><a href="javascript:void(0);">Remember me</a></span>
          </span>
          <span class="forget_pwd"><a href="javascript:void(0);">Forget password?</a></span>
        </div>
      </div>
    </div>
    <div class="foot">
      <span class="copyrightInfo">Copyright &copy; 2014 Augmentum,Inc. All Rights Reserved</span>
      <input id="noRemenberMe" type="hidden" value="${serverPath}/img/login-img/BTN_RemeberMe_Unselect_12X12.png.png" />
      <input id="remenberMe" type="hidden" value="${serverPath}/img/login-img/BTN_RemeberMe_Select_12x12.png.png" />
      <input id="path" type="hidden" value="${pageContext.request.contextPath}" />
    </div>
  </body>
  <script type="text/javascript" src="${serverPath}/js/user/login.js"></script>
</html>