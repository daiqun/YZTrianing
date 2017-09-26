package com.augmentum.oes.controller;

import org.apache.log4j.Logger;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.util.PathUtil;
import com.augmentum.oes.util.SessionUtil;

/**
 * Extract public method
 */
public abstract class BaseController {

    private final Logger logger = Logger.getLogger(BaseController.class);

    /**
     * Catch exception from dao --> controller --> spring container
     *
     * @param e
     * @return
     */
    @ExceptionHandler(Exception.class)
    public ModelAndView handleException(Exception ex) {
        logger.error(ex.getMessage(), ex);
        ModelAndView modelAndview = new ModelAndView(new RedirectView(AppContext.getContextPath()
                + Constants.FIVE_HUNDRED_PAGE));

        return modelAndview;
    }

    /**
     * Get user
     *
     * @return
     */
    protected User getUser() {
        return AppContext.getContext().getUser();
    }

    /**
     * Get login userName
     *
     * @return
     */
    public String getUserName() {
        User user = getUser();

        if (user != null) {
            return user.getUserName();
        }

        return Constants.STING_EMPTY;
    }

    /**
     * Get login userId
     *
     * @return
     */
    public int getUserId() {
        User user = getUser();

        if (user != null) {
            return user.getId();
        }

        return Constants.INT_INITIAL_VALUE;
    }

    protected RedirectView setRedirectView(String path) {
        return new RedirectView(PathUtil.pagePath(path));
    }

    protected void setSession(String key, Object object) {
        SessionUtil.setSession(key, object);
    }

    protected void getSession(String key) {
        SessionUtil.getSession(key);
    }

    protected void removeSession(String key) {
        SessionUtil.removeSession(key);
    }

    protected void invalidate() {
        SessionUtil.invalidate();
    }
}