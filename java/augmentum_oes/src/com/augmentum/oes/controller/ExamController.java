package com.augmentum.oes.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.model.entity.Exam;
import com.augmentum.oes.model.service.ExamService;
import com.augmentum.oes.util.PropertiesUtil;

@Controller
@RequestMapping(value = Constants.APP_URL_EXAM_PREFIX)
public class ExamController extends BaseController {

    @Autowired
    private ExamService examService;

    @RequestMapping(value = Constants.EXAM_METHOD_URL_SHOW, method = RequestMethod.GET)
    public ModelAndView show() {
        ModelAndView modelAndView = new ModelAndView();
        List<Exam> examList = examService.findAll();
        modelAndView.addObject(Constants.EXAM_LIST, examList);
        modelAndView.setViewName(Constants.EXAM_JSP);

        return modelAndView;
    }

    @RequestMapping(value = Constants.EXAM_METHOD_URL_CREATE_JSP, method = RequestMethod.GET)
    public String createPage(Model model) {
        String[] examTimeSet = PropertiesUtil.getProperty(Constants.EXAM_TIME_SET).split(Constants.COMMA);
        model.addAttribute(Constants.MODEL_EXAM, new Exam());
        model.addAttribute(Constants.EXAM_TIME_CHOICE, examTimeSet);

        return Constants.EXAM_ADD_JSP;
    }

    @RequestMapping(value = Constants.EXAM_METHOD_URL_CREATE, method = RequestMethod.POST)
    @ModelAttribute
    public RedirectView create(@ModelAttribute(Constants.MODEL_EXAM) Exam exam) {
        exam.setCreateBy(this.getUserName());
        exam.setUpdateBy(this.getUserName());

        try {
            examService.create(exam);
        } catch (ParameterException parameterException) {
            parameterException.printStackTrace();
        }

        this.setSession(Constants.SUCCESS_FLASH_MESSAGE, Constants.ADD_EXAM_SUCCESS);

        return this.setRedirectView(Constants.EXAM_METHOD_URL_SHOW_PAGE);
    }
}