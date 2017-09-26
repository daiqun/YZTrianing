package com.augmentum.oes.controller;

import java.util.List;
import java.util.Map;

import org.apache.log4j.Logger;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.entity.UserRole;
import com.augmentum.oes.model.entity.UserShow;
import com.augmentum.oes.model.service.UserService;
import com.augmentum.oes.util.CookieUtil;
import com.augmentum.oes.util.StringUtil;

@Controller
@RequestMapping(Constants.APP_URL_USER_PREFIX)
public class UserController extends BaseController {

    @Autowired
    private UserService userService;

    private final Logger logger = Logger.getLogger(UserController.class);

    /**
     * Check user is login
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.LOGIN_METHOD_LOGIN, method = RequestMethod.GET)
    public ModelAndView login(
                              ModelAndView modelAndView,
                              @RequestParam(value = Constants.LOGIN_SAVE_URL, defaultValue = Constants.STRING_DEFAULT_VALUE) String go
                              ) {
        User user = this.getUser();

        if (user != null) {
            modelAndView.setView(this.setRedirectView(Constants.QUESTION_PAGE));
        } else {
            // Sign in to the center
            if (StringUtil.isEmpty(go)) {
                go = Constants.STING_EMPTY;
            }

            modelAndView.addObject(Constants.LOGIN_SAVE_URL, go);
            modelAndView.setViewName(Constants.LOGIN_JSP);
        }

        return modelAndView;
    }

    /**
     * Validate user login/save the browse URL status
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.LOGIN_METHOD_LOGIN, method = RequestMethod.POST)
    public ModelAndView saveLogin(
                                  ModelAndView modelAndView,
                                  @RequestParam(value = Constants.SAVELOGIN_FORM_PARAM_USERNAME, defaultValue = Constants.STRING_DEFAULT_VALUE) String userName,
                                  @RequestParam(value = Constants.SAVELOGIN_FORM_PARAM_PASSWORD, defaultValue = Constants.STRING_DEFAULT_VALUE) String password,
                                  @RequestParam(value = Constants.LOGIN_SAVE_URL, defaultValue = Constants.STRING_DEFAULT_VALUE) String go,
                                  @RequestParam(value = Constants.ECHO_URL, defaultValue = Constants.STRING_DEFAULT_VALUE) String queryString,
                                  @RequestParam(value = Constants.REMENBER_ME_FLAG, defaultValue = Constants.STRING_ZERO) String flag
                                  ) {

        try {
            User user = userService.login(userName, password);

            if (user == null) {
                flag = Constants.STRING_ZERO;
            }

            CookieUtil.addCookie(userName, password);
            modelAndView.addObject(Constants.COOKIE_REMENBER_ME, flag);
            user.setPassword(null);
            this.setSession(Constants.USER, user);

            if (!StringUtil.isEmpty(queryString)) {
                // To determine whether to bring back the link after #
                if (queryString.startsWith(Constants.HASHTAG)) {
                    queryString = queryString.substring(Constants.INT_NUMBER_ONE);
                }

                go = go + Constants.QUESTION_MARK + queryString;
            }

            modelAndView.setView(StringUtil.isEmpty(go) ? this.setRedirectView(Constants.QUESTION_PAGE) : new RedirectView(AppContext.getContextPath() + Constants.SLASH + go));
        } catch (ParameterException parameterException) {
            Map<String, String> errorFields = parameterException.getErrorFields();
            modelAndView.addObject(Constants.PARAMS_FIELDS, errorFields);
            modelAndView.setViewName(Constants.LOGIN_JSP);
            logger.info(Constants.LOGIN_PARAM_PROPERTY, parameterException);
        } catch (ServiceException serviceException) {
            modelAndView.addObject(Constants.CHECK_FIELDS, serviceException.getMessage());
            modelAndView.addObject(Constants.SAVE_SNAP_NAME, userName);
            modelAndView.setViewName(Constants.LOGIN_JSP);
            logger.warn(Constants.LOGIN_PARAM_ERROR, serviceException);
        }

        return modelAndView;
    }

    /**
     * User logout to destroy session
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.LOGIN_METHOD_LOGOUT, method = RequestMethod.GET)
    public ModelAndView logout(ModelAndView modelAndView) {
        modelAndView.addObject(Constants.RETURN_NAME, this.getUserName());
        this.invalidate();
        modelAndView.setView(this.setRedirectView(Constants.LOGIN_PAGE));

        return modelAndView;
    }

    /**
     * Add a new user
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.USER_CREATE_METHOD, method = RequestMethod.POST)
    public ModelAndView createUser(
                                   ModelAndView modelAndView,
                                   @ModelAttribute(Constants.USER_PARAM) User user,
                                   @ModelAttribute(Constants.USER_ROLE_PARAM) UserRole userRole
                                   ) {
        String userName = this.getUserName();

        if (!StringUtil.isEmpty(userName)) {

            // Give user value
            user.setCreateBy(userName);
            user.setUpdateBy(userName);

            // Give user role info
            userRole.setCreateBy(userName);
            userRole.setUpdateBy(userName);

            // Invoke the save method
            userService.save(user, userRole);
            modelAndView.setView(this.setRedirectView(Constants.USER_LIST_PAGE));
        }

        return modelAndView;
    }

    /**
     * Find user by name
     *
     * @param user
     * @return List<UserShow> id, userName, userType
     */
    @RequestMapping(value = Constants.USER_LIST_FIND_BY_NAME, method = RequestMethod.POST)
    @ResponseBody
    public List<UserShow> findUserByName(@RequestBody User user) {
        return userService.findByName(user);
    }
}