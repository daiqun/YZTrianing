<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "../common/common_label.jsp" %>
<%@ include file= "../common/prompt_window.jsp" %>
<%@ taglib uri="/WEB-INF/escape.tld" prefix="ex" %>
<%@ taglib uri="/WEB-INF/block.tld" prefix="block" %>
<%@ taglib uri="/WEB-INF/myfunc.tld" prefix="myFunc" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>question_list</title>
    <link href="${serverPath}/css/question/question_list.css" rel="stylesheet" />
  </head>
  <body>
    <!-- head -->
    <block:display name="headBlock" />
    <!-- tab -->
    <block:display name="tabBlock" />
    <!-- content -->
    <div class="mid">
      <div class="mid_content">
        <div class="mid_content_left">
          <a id="questionList" class="question_list" href="javascript:void(0);">Question List</a>
          <a id="createQuestion" class="create_question" href="javascript:void(0);">Create Question</a>
        </div>
        <span class="outline"></span>
        <span class="question_search">
          <input id="questionTextSearch" class="question_text_search" type="text" placeholder="Search by descriptions" value="<ex:escape keyword="${keyword}" />">
          <a href="javascript:void(0);" id="searchIcon" class="search_icon"><img src="${serverPath}/img/question-img/ICN_Search_15x20.png.png" /></a>
        </span>
        <div class="mid_content_right">
          <div class="content_head">
            <ul class="table_title">
              <li class="question_id"><a href="javascript:void(0);"></a></li>
              <li class="question_title"><span id="sortBt" class="sort_bt">ID<span id="sort_style" class="sort_style"><img id="sortWay" src="${serverPath}/img/question-img/ICN_Increase_10x15.png.png" /></span></span></li>
              <li class="question_description"><a class="descripe" href="javascript:void(0);">Descritions</a></li>
              <li class="edit_question"><a class="edit_qs" href="javascript:void(0);">Edit</a></li>
              <li class="is_select"><a id="seleQs" class="select_all" href="javascript:void(0);"><img src="${serverPath}/img/question-img/ICN_Unselected_15x15.png  .png" id="isSeleteAll" /></a></li>
            </ul>
          </div>
          <!-- question content -->
          <block:display name="questionContentBlock" />
          <!-- paginator_block -->
          <block:display name="paginatorBlock" />
          <input id="deleteBtn" class="delete_btn" type="button" value="Delete" />
        </div>
      </div>
    </div>
    <!-- foot Block -->
    <block:display name="footBlock" />
    <input id="unselect" type="hidden" value="${serverPath}/img/question-img/ICN_Unselected_15x15.png  .png" />
    <input id="selected" type="hidden" value="${serverPath}/img/question-img/ICN_Selected_15x15.png.png" />
    <input id="rise" type="hidden" value="${serverPath}/img/question-img/ICN_Decrese_10x15.png.png" />
    <input id="decline" type="hidden" value="${serverPath}/img/question-img/ICN_Increase_10x15.png.png" />
    <input id="sortFlag" type="hidden" value="${sortWay}" />
    <input id="pageSize" type="hidden" value="${pageSize}" />
    <input id="pageCount" type="hidden" value="${pagination.pageCount}" />
    <input id="currentPage" type="hidden" value="${pagination.currentPage}" />
    <input id="choiceDeleteNum" type="hidden" />
    <input id="path" type="hidden" value="${pageContext.request.contextPath}" />
    <script type="text/javascript" src="${serverPath}/js/question/question_list.js"></script>
    ${myFunc:clearSession("SUCCESS_FLASH_MESSAGE")}
  </body>
</html>