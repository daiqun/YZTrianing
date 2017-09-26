package com.augmentum.common.taglib;

import java.io.IOException;
import java.io.StringWriter;
import java.util.Date;

import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.tagext.SimpleTagSupport;

import org.apache.commons.lang.StringEscapeUtils;

import com.augmentum.oes.util.StringUtil;

/**
 * Use of custom labels
 */
public class CustomTag extends SimpleTagSupport {

    private String content;
    private String keyword;
    private Date date;

    public void setContent(String content) {
        this.content = content;
    }

    public void setKeyword(String keyword) {
        this.keyword = keyword;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    StringWriter sw = new StringWriter();

    @Override
    public void doTag() throws JspException, IOException {

        if (content != null) {
            JspWriter out = getJspContext().getOut();
            out.println(StringEscapeUtils.escapeHtml(content));
        } else if (keyword != null) {
            JspWriter out = getJspContext().getOut();
            out.println(StringEscapeUtils.escapeHtml(keyword));
        } else if (date != null) {
            JspWriter out = getJspContext().getOut();
            out.println(StringUtil.dateFormat(date));
        } else {
            getJspBody().invoke(sw);
            getJspContext().getOut().println(sw.toString());
        }
    }
}