package com.augmentum.common.taglib;

import java.io.IOException;

import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.tagext.TagSupport;

import org.springframework.context.ApplicationContext;

import com.augmentum.common.BlockAbstract;
import com.augmentum.oes.util.SpringUtil;

/**
 * Read block template
 */
public class BlockTaglib extends TagSupport {

    private static final long serialVersionUID = -4464193449956108191L;

    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public int doStartTag() throws JspException {
        return SKIP_BODY;
    }

    @Override
    public int doEndTag() throws JspException {
        // Use spring manage taglib beans
        ApplicationContext appContext = SpringUtil.getApplicationContext();

        // Get bean about current block
        BlockAbstract block = (BlockAbstract) appContext.getBean(name);

        // Resolve template content
        String content = block.displayBlock(pageContext);

        // Output the contents of the analysis
        JspWriter out = pageContext.getOut();

        try {
            out.println(content);
        } catch (IOException ioException) {
            ioException.printStackTrace();
        }

        return EVAL_PAGE;
    }

    @Override
    public void release() {
        super.release();
    }
}