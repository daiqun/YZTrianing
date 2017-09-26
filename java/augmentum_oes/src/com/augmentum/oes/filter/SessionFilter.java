package com.augmentum.oes.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.augmentum.oes.Constants;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.util.PathUtil;
import com.augmentum.oes.util.StringUtil;

/**
 * Filter unLogin request
 */
public class SessionFilter implements Filter {

    protected FilterConfig config;
    private String passPages = Constants.STING_EMPTY;

    @Override
    public void init(FilterConfig config) throws ServletException {
        this.config = config;

        if (config.getInitParameter(Constants.PASS_PAGES) != null) {
            this.passPages = config.getInitParameter(Constants.PASS_PAGES);
        }
    }

    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException,
            ServletException {
        HttpServletRequest servletRequest = (HttpServletRequest) request;
        HttpServletResponse servletResponse = (HttpServletResponse) response;
        String URL = servletRequest.getRequestURI();
        String requestedURL = URL.substring(servletRequest.getContextPath().length() + Constants.INT_NUMBER_ONE);
        String[] pages = passPages.split(Constants.COMMA);
        boolean isAllow = false;

        for (String page : pages) {
            if (page.equals(requestedURL)) {
                isAllow = true;
                break;
            }
        }

        if (isAllow) {
            chain.doFilter(servletRequest, servletResponse);
        } else {
            HttpSession session = servletRequest.getSession();
            User user = (User) session.getAttribute(Constants.USER);

            if (user == null) {
                if (servletRequest.getMethod().toLowerCase().equals(Constants.GET_ACTION)) {
                    String queryString = servletRequest.getQueryString();
                    String go = requestedURL;

                    if (!StringUtil.isEmpty(queryString)) {
                        go = go + Constants.HASHTAG + servletRequest.getQueryString();
                    }

                    servletResponse.sendRedirect(PathUtil.pagePath(Constants.SAVE_LOGIN_ACTION) + go);
                } else {
                    servletResponse.sendRedirect(PathUtil.pagePath(Constants.LOGIN_ACTION));
                }
            } else {
                chain.doFilter(servletRequest, servletResponse);
            }
        }
    }

    @Override
    public void destroy() {
    }
}