<%@ page import="com.augmentum.oes.util.PropertiesUtil" %>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ page import="java.lang.String" %>
<%@ page import="java.util.Map" %>
<%@ page import="java.util.HashMap" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib uri="/WEB-INF/myfunc.tld" prefix="myFunc" %>
<c:set var="user" scope="session" value="${USER}" />
<c:set var="serverPath" scope="session" value="${myFunc:getPagePath()}" />
<c:set var="path" scope="session" value="${pageContext.request.contextPath}" />
<script type="text/javascript" src="${serverPath}/js/lib/jquery-1.10.2.min.js"></script>