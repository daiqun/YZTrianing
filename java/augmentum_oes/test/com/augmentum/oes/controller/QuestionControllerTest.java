package com.augmentum.oes.controller;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.mock.web.MockHttpServletRequest;
import org.springframework.mock.web.MockHttpServletResponse;
import org.springframework.mock.web.MockHttpSession;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.AbstractTransactionalJUnit4SpringContextTests;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;
import com.augmentum.oes.util.PathUtil;
import com.augmentum.oes.util.SessionUtil;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(locations = { "classpath:application-context.xml", "classpath:spring-mvc.xml" })
public class QuestionControllerTest extends AbstractTransactionalJUnit4SpringContextTests {

    final String CONTEXT_PATH = "/oes";
    final String USER_CONTROLLER = "userController";
    final String MY_USER_NAME = "william.dai";
    final String MY_PASSWORD = "123456";

    @Before
    public void setUp() {
        AppContext.setContextPath(CONTEXT_PATH);
        AppContext context = AppContext.getContext();
        context.addObject(Constants.APP_CONTEXT_REQUEST, new MockHttpServletRequest());
        context.addObject(Constants.APP_CONTEXT_RESPONSE, new MockHttpServletResponse());
        context.addObject(Constants.APP_CONTEXT_SESSION, new MockHttpSession());
    }

    @Test
    public void testLogin() {
        UserController userController = (UserController) applicationContext.getBean(USER_CONTROLLER);
        ModelAndView modelAndView = new ModelAndView();
        userController.saveLogin(modelAndView, MY_USER_NAME, MY_PASSWORD, Constants.STRING_DEFAULT_VALUE, Constants.STRING_DEFAULT_VALUE, Constants.STRING_ZERO);
        RedirectView redirectView = (RedirectView) modelAndView.getView();
        Assert.assertEquals(PathUtil.pagePath(Constants.QUESTION_PAGE), redirectView.getUrl());
        Assert.assertNotNull(SessionUtil.getSession(Constants.USER));
    }

    @After
    public void tearDown() {
        AppContext context = AppContext.getContext();
        context.clear();
    }
}