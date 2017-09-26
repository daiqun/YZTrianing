package com.augmentum.oes.util;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.net.URLDecoder;
import java.net.URLEncoder;

import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;

public class CookieUtil {
    /**
     * Add cooike
     *
     * @param userName
     * @param password
     * @throws IOException
     */
    public static void addCookie(String userName, String password) {

        if (!StringUtil.isEmpty(userName) && !StringUtil.isEmpty(password)) {
            HttpServletRequest request = (HttpServletRequest) AppContext.getContext().getObject(Constants.APP_CONTEXT_REQUEST);
            HttpServletResponse response = (HttpServletResponse) AppContext.getContext().getObject(Constants.APP_CONTEXT_RESPONSE);
            Cookie nameCookie;

            try {
                nameCookie = new Cookie(Constants.COOKIE_USERNAME, URLEncoder.encode(userName, Constants.UTF_8));
                Cookie pswCookie = new Cookie(Constants.COOKIE_PASSWORD, password);
                nameCookie.setPath(request.getContextPath() + Constants.SLASH);
                pswCookie.setPath(request.getContextPath() + Constants.SLASH);
                String rememberMe = request.getParameter(Constants.COOKIE_REMENBER_ME);

                if (Constants.STRING_ONE.equals(rememberMe)) {
                    nameCookie.setMaxAge(Constants.INT_SEVEN * Constants.INT_TWENTY_FOUR * Constants.INT_SIXTY * Constants.INT_SIXTY);
                    pswCookie.setMaxAge(Constants.INT_SEVEN * Constants.INT_TWENTY_FOUR * Constants.INT_SIXTY * Constants.INT_SIXTY);
                } else {
                    //nameCookie.setMaxAge(Constants.INT_ZERO);
                    pswCookie.setMaxAge(Constants.INT_ZERO);
                }

                response.addCookie(nameCookie);
                response.addCookie(pswCookie);
            } catch (UnsupportedEncodingException exception) {
                exception.printStackTrace();
            }

        }
    }

    /**
     * Read cookie in login
     */
    public static void readCookie() {
        HttpServletRequest request = (HttpServletRequest) AppContext.getContext().getObject(Constants.APP_CONTEXT_REQUEST);
        String userName = Constants.STRING_DEFAULT_VALUE;
        String password = Constants.STRING_DEFAULT_VALUE;
        Object res = request.getAttribute(Constants.CHECK_FIELDS);
        Cookie[] cookies = request.getCookies();

        if (cookies != null && cookies.length > Constants.INT_INITIAL_VALUE) {
            if (res == null) {
                for (int i = Constants.INT_INITIAL_VALUE; i < cookies.length; i++) {
                    try {
                        if (cookies[i].getName().equals(Constants.COOKIE_USERNAME)) {
                            userName = cookies[i].getValue();
                            request.setAttribute(Constants.COOKIE_USERNAME, URLDecoder.decode(userName, Constants.UTF_8));
                        }

                        if (cookies[i].getName().equals(Constants.COOKIE_PASSWORD)) {
                            password = cookies[i].getValue();
                            request.setAttribute(Constants.COOKIE_PASSWORD, URLDecoder.decode(password, Constants.UTF_8));
                            request.setAttribute(Constants.COOKIE_REMENBER_ME_STRING, Constants.STRING_ONE);
                        }
                    } catch (UnsupportedEncodingException EncodingException) {
                        EncodingException.printStackTrace();
                    }
                }
            }
        }
    }
}