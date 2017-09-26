<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="com.dw.util.ConstansUtil"%>
<%@ page import="com.dw.entity.User"%>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>welcome</title>
  </head>

  <body>
    <%User use = (User)session.getAttribute(ConstansUtil.USER); %>
    welcome: <%=use.getUserName() %>
  </body>
</html>