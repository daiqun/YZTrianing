<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file= "../common/common_label.jsp" %>
<%@ taglib uri="/WEB-INF/block.tld" prefix="block" %>
<%@ taglib uri="/WEB-INF/escape.tld" prefix="ex" %>
<!DOCTYPE>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>exam-list</title>
    <link href="${serverPath}/css/exam/exam_list.css" rel="stylesheet" />
  </head>
  <body>
    <!-- head -->
    <block:display name="headBlock" />
    <!-- tab -->
    <block:display name="tabBlock" />
    <!-- content -->
    <div class="content">
      <div class="content_center">
        <!-- content left -->
        <div class="content_center_left">
          <a class="exam_list_btn" href="javascript:void(0);">Exam List</a>
          <a id="createExam" class="create_exam_btn" href="javascript:void(0);">Create Exam</a>
        </div>
        <!-- outline -->
        <span class="outline"></span>
        <!-- search box -->
        <span class="exam_select">
          <input class="exam_search" type="text" placeholder="Please input the keyword" />
          <a href="javascript:void(0);" class="search_icon"><img src="${serverPath}/img/question-img/ICN_Search_15x20.png.png" /></a>
        </span>
        <!-- TODO date box -->
        <!-- exam info table -->
        <div class="exam_info_table">
          <!-- table head -->
          <ul class="exam_info_table_head">
            <li class="table_head_row_num"></li>
            <li class="table_head_row_id">ID<img src="${serverPath}/img/question-img/ICN_Increase_10x15.png.png" /></li>
            <li class="table_head_row_name">Name<img src="${serverPath}/img/question-img/ICN_Decrese_10x15.png.png" /></li>
            <li class="table_head_effective_time">Effective<img src="${serverPath}/img/question-img/ICN_Decrese_10x15.png.png" /></li>
            <li class="table_head_daurtion">Duration(Mins)</li>
            <li class="table_head_creator">Creator</li>
            <li class="table_head_edit">Edit</li>
            <li class="table_head_edit_select"><img src="${serverPath}/img/question-img/ICN_Unselected_15x15.png  .png" /></li>
          </ul>
          <!-- table content -->
          <c:forEach items="${examList}" var="exam" varStatus="status" begin="0" end="9">
            <ul class="content_ul">
              <li class="content_row_num">${status.count}</li>
              <li class="content_row_id">${exam.id}</li>
              <li class="content_row_name"><a href="javascript:void(0);">${exam.examName}</a></li>
              <li class="content_row_effective_time"><ex:escape date="${exam.effectiveTime}" /></li>
              <li class="content_row_daurtion">${exam.duration}</li>
              <li class="content_row_creator">${exam.createBy}</li>
              <li class="content_row_edit"><img src="${serverPath}/img/question-img/ICN_Edit_15x15.png.png" /></li>
              <li class="content_row_edit_select"><img src="${serverPath}/img/question-img/ICN_Unselected_15x15.png  .png" /></li>
            </ul>
          </c:forEach>
          <!-- paginator_block -->
          <block:display name="paginatorBlock" />
          <!-- delete_btn -->
          <input class="delete_btn" type="button" value="Delete" />
        </div>
      </div>
    </div>
    <!-- foot Block -->
    <block:display name="footBlock" />
    <script type="text/javascript" src="${serverPath}/js/exam/exam_list.js"></script>
  </body>
</html>