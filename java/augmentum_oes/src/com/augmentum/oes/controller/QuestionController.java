package com.augmentum.oes.controller;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.entity.Pagination;
import com.augmentum.oes.model.entity.Question;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.service.QuestionService;
import com.augmentum.oes.util.PropertiesUtil;
import com.augmentum.oes.util.StringUtil;

@Controller
@RequestMapping(Constants.APP_URL_QUESTION_PREFIX)
public class QuestionController extends BaseController {

    @Autowired
    private QuestionService questionService;

    /**
     * Show the question list
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.QUESTION_METHOD_SHOW, method = RequestMethod.GET)
    public ModelAndView show(
                             ModelAndView modelAndView,
                             @RequestParam(value = Constants.QUESTION_CURRENT_PAGE, defaultValue = Constants.QUESTION_CURRENT_PAGE_DEFAULT) String currentPage,
                             @RequestParam(value = Constants.QUESTION_PAGE_SORT, defaultValue = Constants.SORT_DESC) String status,
                             @RequestParam(value = Constants.QUESTION_PAGE_SIZE, defaultValue = Constants.QUESTION_PAGE_SIZE_DEFAULT) String pageSize,
                             @RequestParam(value = Constants.QUESTION_PAGE_KEYWORD, defaultValue = Constants.QUESTION_PAGE_KEYWORD_DEFAULT) String keyword
                             ) {
        String[] pageItem = PropertiesUtil.getProperty(Constants.PAGINATION_ITEM).split(Constants.COMMA);
        int CURRENT_PAGE = Constants.INT_INITIAL_VALUE;

        try {
            if (StringUtil.isEmpty(currentPage)) {
                currentPage = Constants.STRING_ONE;
            }

            CURRENT_PAGE = Integer.parseInt(currentPage);
        } catch (NumberFormatException NumEx) {
            NumEx.printStackTrace();
        }

        if (CURRENT_PAGE < Constants.INITIAL_PAGE_VALUE) {
            CURRENT_PAGE = Constants.INITIAL_PAGE_VALUE;
        }

        Pagination pagination = new Pagination();
        pagination.setCurrentPage(CURRENT_PAGE);
        List<Question> questionList = null;
        int choiceSize = Constants.INT_INITIAL_VALUE;

        try {
            if (StringUtil.isEmpty(pageSize)) {
                pageSize = Constants.QUESTION_PAGE_SIZE_DEFAULT;
            }

            choiceSize = Integer.parseInt(pageSize.trim());
        } catch (NumberFormatException numberFormatException) {
            numberFormatException.printStackTrace();
        }

        pagination.setPageSize(choiceSize);
        String searchWord = StringUtil.escapeKeyWord(keyword);

        if (StringUtil.isEmpty(searchWord)) {
            searchWord = Constants.STING_EMPTY;
        }

        questionList = questionService.findByContent(status, new Question(searchWord), pagination);
        modelAndView.addObject(Constants.QUESTION_LIST, questionList);
        modelAndView.addObject(Constants.PAGINATION, pagination);
        modelAndView.addObject(Constants.KEYWORD, keyword);
        modelAndView.addObject(Constants.SORTWAY, status);
        modelAndView.addObject(Constants.PAGE_SIZE, pagination.getPageSize());
        modelAndView.addObject(Constants.PAGEITEM, pageItem);
        modelAndView.setViewName(Constants.QUESTION_LIST_JSP);

        return modelAndView;
    }

    /**
     * Include question add and question edit
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.QUESTION_METHOD_SAVE, method = RequestMethod.POST)
    public ModelAndView save(
                             ModelAndView modelAndView,
                             Question question,
                             @RequestParam(value = Constants.PAGE_ID, defaultValue = Constants.PAGE_ID_INITIAL_VALUE) int id,
                             @RequestParam(value = Constants.QUESTION_CURRENT_PAGE, defaultValue = Constants.QUESTION_CURRENT_PAGE_DEFAULT) String currentPage,
                             @RequestParam(value = Constants.QUESTION_PAGE_SORT, defaultValue = Constants.SORT_DESC) String status,
                             @RequestParam(value = Constants.QUESTION_PAGE_SIZE, defaultValue = Constants.QUESTION_PAGE_SIZE_DEFAULT) String pageSize,
                             @RequestParam(value = Constants.QUESTION_PAGE_KEYWORD, defaultValue = Constants.QUESTION_PAGE_KEYWORD_DEFAULT) String keyword
                             ) {
        Question snapQuestion = new Question();
        User user = this.getUser();

        if (id == Constants.INT_INITIAL_VALUE) {
            snapQuestion.setUserId(user.getId());
            snapQuestion.setCreateBy(user.getUserName());
            snapQuestion.setUpdateBy(user.getUserName());
        } else {
            snapQuestion.setId(id);
            snapQuestion.setUpdateBy(user.getUserName());
        }

        snapQuestion.setQuestionContent(question.getQuestionContent());
        snapQuestion.setChoiceA(question.getChoiceA());
        snapQuestion.setChoiceB(question.getChoiceB());
        snapQuestion.setChoiceC(question.getChoiceC());
        snapQuestion.setChoiceD(question.getChoiceD());
        snapQuestion.setCorrectAnwser(question.getCorrectAnwser());

        try {
            questionService.save(snapQuestion);

            if (id == Constants.INT_INITIAL_VALUE) {
                this.setSession(Constants.SUCCESS_FLASH_MESSAGE, Constants.ADD_QUESTION_SUCCESS);
            } else {
                this.setSession(Constants.SUCCESS_FLASH_MESSAGE, Constants.EDIT_QUESTION_SUCCESS);
            }

            questionStatus(modelAndView, currentPage, status, pageSize, keyword);
            modelAndView.setView(this.setRedirectView(Constants.QUESTION_PAGE));
        } catch (ParameterException parameterException) {
            Map<String, String> validateMap = parameterException.getErrorFields();
            modelAndView.addObject(Constants.PARAMS_FIELDS, validateMap);
            questionStatus(modelAndView, currentPage, status, pageSize, keyword);

            if (id == Constants.INT_INITIAL_VALUE) {
                modelAndView.setViewName(Constants.QUESTION_ADD_JSP);
            } else {
                modelAndView.setViewName(Constants.QUESTION_EDIT_JSP);
            }
        } catch (ServiceException serviceException) {
            Map<Integer, String> errorMap = serviceException.getErrorMap();
            modelAndView.addObject(Constants.CHECK_FIELDS, errorMap.get(Constants.CHOICE_ANWSER_ERROR_CODE));
            modelAndView.addObject(Constants.CHECK_REPEATED, errorMap.get(Constants.PROBLEM_IS_REPEATED));
            modelAndView.addObject(Constants.UPDATE_FALSE_QUESTION, snapQuestion);
            questionStatus(modelAndView, currentPage, status, pageSize, keyword);

            if (id == Constants.INT_INITIAL_VALUE) {
                modelAndView.setViewName(Constants.QUESTION_ADD_JSP);
            } else {
                modelAndView.setViewName(Constants.QUESTION_EDIT_JSP);
            }
        }

        return modelAndView;
    }

    /**
     * Redirect to add page or edit page
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.QUESTION_METHOD_EDIT, method = RequestMethod.GET)
    public ModelAndView edit(
                             ModelAndView modelAndView,
                             @PathVariable int id,
                             @RequestParam(value = Constants.QUESTION_CURRENT_PAGE, defaultValue = Constants.QUESTION_CURRENT_PAGE_DEFAULT) String currentPage,
                             @RequestParam(value = Constants.QUESTION_PAGE_SORT, defaultValue = Constants.SORT_DESC) String status,
                             @RequestParam(value = Constants.QUESTION_PAGE_SIZE, defaultValue = Constants.QUESTION_PAGE_SIZE_DEFAULT) String pageSize,
                             @RequestParam(value = Constants.QUESTION_PAGE_KEYWORD, defaultValue = Constants.QUESTION_PAGE_KEYWORD_DEFAULT) String keyword
                             ) {
        questionStatus(modelAndView, currentPage, status, pageSize, keyword);

        if (id == Constants.INT_INITIAL_VALUE) {
            modelAndView.setViewName(Constants.QUESTION_ADD_JSP);
        } else {
            Question question = questionService.getById(new Question(id));
            modelAndView.addObject(Constants.THIS_QUESTION, question);
            modelAndView.setViewName(Constants.QUESTION_EDIT_JSP);
        }

        return modelAndView;
    }

    /**
     * Delete selected question
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.QUESTION_METHOD_DELETE, method = RequestMethod.GET)
    public ModelAndView delete(
                               ModelAndView modelAndView,
                               @RequestParam(value = Constants.QUESTION_DELETE_CHOICE, defaultValue = Constants.STING_EMPTY) String allId,
                               @RequestParam(value = Constants.QUESTION_CURRENT_PAGE, defaultValue = Constants.QUESTION_CURRENT_PAGE_DEFAULT) String currentPage,
                               @RequestParam(value = Constants.QUESTION_PAGE_SORT, defaultValue = Constants.SORT_DESC) String status,
                               @RequestParam(value = Constants.QUESTION_PAGE_SIZE, defaultValue = Constants.QUESTION_PAGE_SIZE_DEFAULT) String pageSize,
                               @RequestParam(value = Constants.QUESTION_PAGE_KEYWORD, defaultValue = Constants.QUESTION_PAGE_KEYWORD_DEFAULT) String keyword
                               ) {
        String[] num = allId.split(Constants.COMMA);

        if (num != null) {
            for (String str : num) {
                Question question = new Question();
                int id = Constants.INT_INITIAL_VALUE;

                try {
                    id = Integer.parseInt(str);
                } catch (NumberFormatException ex) {
                    ex.printStackTrace();
                }

                question.setId(id);
                questionService.delete(question);
            }
        }

        this.setSession(Constants.SUCCESS_FLASH_MESSAGE, Constants.Delete_QUESTION_SUCCESS);
        questionStatus(modelAndView, currentPage, status, pageSize, keyword);
        modelAndView.setView(this.setRedirectView(Constants.QUESTION_PAGE));

        return modelAndView;
    }

    /**
     * Redirect to details page
     *
     * @param request
     * @param session
     * @return
     */
    @RequestMapping(value = Constants.QUESTION_METHOD_DETAILS, method = RequestMethod.GET)
    public ModelAndView details(
                                ModelAndView modelAndView,
                                @PathVariable int id,
                                @RequestParam(value = Constants.QUESTION_CURRENT_PAGE, defaultValue = Constants.QUESTION_CURRENT_PAGE_DEFAULT) String currentPage,
                                @RequestParam(value = Constants.QUESTION_PAGE_SORT, defaultValue = Constants.SORT_DESC) String status,
                                @RequestParam(value = Constants.QUESTION_PAGE_SIZE, defaultValue = Constants.QUESTION_PAGE_SIZE_DEFAULT) String pageSize,
                                @RequestParam(value = Constants.QUESTION_PAGE_KEYWORD, defaultValue = Constants.QUESTION_PAGE_KEYWORD_DEFAULT) String keyword
                                ) {
        Question question = questionService.getById(new Question(id));
        modelAndView.addObject(Constants.THIS_QUESTION, question);
        questionStatus(modelAndView, currentPage, status, pageSize, keyword);
        modelAndView.setViewName(Constants.QUESTION_DETAILS_JSP);

        return modelAndView;
    }

    @RequestMapping(value = Constants.QUESTION_METHOD_GET_BY_NAME, method = RequestMethod.POST)
    @ResponseBody
    public int getByName(@RequestBody Question question) {
        Question tempQuestion = new Question();
        tempQuestion.setQuestionContent(StringUtil.escapeKeyWord(question.getQuestionContent()));

        return questionService.getByContent(question);
    }

    /**
     * Save pageInfo include(currentPage, status, pageSize, keyWord)
     *
     * @param modelAndView
     * @param currentPage
     * @param status
     * @param pageSize
     * @param keyWord
     */
    private void questionStatus(ModelAndView modelAndView, String currentPage, String status, String pageSize, String keyword) {
        modelAndView.addObject(Constants.KEYWORD, keyword);
        modelAndView.addObject(Constants.SORTWAY, status);
        modelAndView.addObject(Constants.PAGE_SIZE, pageSize);
        modelAndView.addObject(Constants.CURRENT_PAGE, currentPage);
    }
}