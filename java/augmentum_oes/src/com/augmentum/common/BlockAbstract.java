package com.augmentum.common;

import java.io.IOException;
import java.io.StringWriter;
import java.io.Writer;

import javax.servlet.jsp.PageContext;

import org.apache.log4j.Logger;

import com.augmentum.oes.Constants;

/**
 * Jsp template of this block
 */
public abstract class BlockAbstract {

    private final Logger logger = Logger.getLogger(BlockAbstract.class);

    public String template;

    public String getTemplate() {
        return template;
    }

    public void setTemplate(String template) {
        this.template = template;
    }

    abstract protected void excute(PageContext pageContext);

    public String displayBlock(PageContext pageContext) {
        excute(pageContext);
        Writer body = new StringWriter();

        try {
            if (template != null && !template.trim().equals(Constants.STING_EMPTY)) {
                pageContext.pushBody(body);
                pageContext.include(template);
                pageContext.popBody();

                return body.toString();
            }
        } catch (Exception exception) {
            logger.error(exception);
        } finally {
            try {
                body.close();
            } catch (IOException ioException) {
                logger.error(ioException);
            }
        }

        return Constants.STING_EMPTY;
    }
}