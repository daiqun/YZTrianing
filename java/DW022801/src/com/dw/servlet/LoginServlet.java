package com.dw.servlet;

import java.io.IOException;
import java.util.Map;

import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.dw.entity.User;
import com.dw.exception.ParameterException;
import com.dw.exception.ServiceException;
import com.dw.service.UserService;
import com.dw.util.ConstansUtil;

public class LoginServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static final String LOGIN_PAGE = "/WEB-INF/jsp/login.jsp";

    public LoginServlet() {
        super();
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.getRequestDispatcher(LOGIN_PAGE).forward(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String userName = request.getParameter("userName");
        String password = request.getParameter("password");

        try {
            User user = null;
            UserService userService = new UserService();
            user = userService.login(userName, password);
            user.setPassword(null);
            request.getSession().setAttribute(ConstansUtil.USER, user);
            response.sendRedirect(request.getContextPath() + "/DashboardServlet");
        } catch (ParameterException parameterException) {
            Map<String, String> errorFields = parameterException.getErrorFields();
            request.setAttribute(ConstansUtil.ErrorFields, errorFields);
            request.getRequestDispatcher(LOGIN_PAGE).forward(request, response);
        } catch (ServiceException serviceException) {
            request.setAttribute(ConstansUtil.PromptFields, serviceException.getMessage()+ "错误代码：" + serviceException.getCode());
            request.getRequestDispatcher(LOGIN_PAGE).forward(request, response);
        }
    }

    @Override
    public void init(ServletConfig config) throws ServletException {
        super.init(config);
        String ip = config.getInitParameter("ip");
        System.out.println(ip);
    }

    @Override
    public void destroy() {
        super.destroy();
    }
}