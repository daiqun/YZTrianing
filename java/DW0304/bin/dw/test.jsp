<%@ page import="java.util.Map"%>
<%@ page import="java.util.HashMap"%>
<%@ page import="com.augmentum.oes.util.ConstansUtil"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>login</title>
  </head>

  <style type="text/css">
    .showRes {
      color: red;
    }
  </style>

  <script type="text/javascript">
    function login() {
        var loginForm = document.getElementById("loginForm");
        var loginName = document.getElementById("userName").value;
        var password = document.getElementById("password").value;

        var isSubmitForm = true;

      if (!loginName) {
          var userNameCheck = document.getElementById("userNameCheck");
          userNameCheck.innerHTML = "userName is required";
          isSubmitForm = false;
      } else {
          document.getElementById("userNameCheck").innerHTML = null;
      }

      if (!password) {
          var passwordCheck = document.getElementById("passwordCheck");
          passwordCheck.innerHTML = "password is required";
          isSubmitForm = false;
      } else {
          document.getElementById("passwordCheck").innerHTML = null;
      }

      if (isSubmitForm) {
          loginForm.submit();
      }
    }
  </script>
  <body>

    <%
        Map<String, String> errorFields = (Map<String, String>)request.getAttribute(ConstansUtil.ErrorFields);
        if (errorFields == null) {
            errorFields = new HashMap<String, String>();
        }
    %>

    <form action="LoginServlet" method="POST" id="loginForm">

      userName : <input type="text" name="userName" id="userName" />
      <label class="showRes" id="userNameCheck">
        <%=errorFields.get("userNameRes") == null ? "" : errorFields.get("userNameRes")%>
      </label><br />

      password : <input type="password" name="password" id="password" />
      <label class="showRes" id="passwordCheck">
        <%=errorFields.get("passwordRes") == null ? "" : errorFields.get("passwordRes")%>
      </label><br />
      <input type="button" value="登录" onclick="login()" />

    </form>

    <%
        String promptMessage = (String)request.getAttribute(ConstansUtil.PromptFields); 
        if (promptMessage != null) {
            out.print(promptMessage);
        }
    %>
  </body>
</html>