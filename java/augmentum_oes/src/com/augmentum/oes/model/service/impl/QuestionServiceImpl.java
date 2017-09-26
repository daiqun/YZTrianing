package com.augmentum.oes.model.service.impl;

import java.util.HashSet;
import java.util.List;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.dao.QuestionDao;
import com.augmentum.oes.model.entity.Pagination;
import com.augmentum.oes.model.entity.Question;
import com.augmentum.oes.model.service.QuestionService;
import com.augmentum.oes.util.StringUtil;

/**
 * To achieve question operation logic processing
 */
@Service
public class QuestionServiceImpl implements QuestionService {

    @Autowired
    private QuestionDao questionDao;

    public void setQuestionDao(QuestionDao questionDao) {
        this.questionDao = questionDao;
    }

    @Override
    public Question getById(Question question) {
        return questionDao.getById(question);
    }

    @Override
    public List<Question> findByContent(String status, Question question, Pagination pagination) {
        pagination.setTotalCount(questionDao.getCountByContent(question));

        if (pagination.getCurrentPage() >= pagination.getPageCount()) {
            pagination.setCurrentPage(pagination.getPageCount());
        }

        if (StringUtil.isEmpty(status)) {
            status = Constants.SORT_DESC;
        }

        return questionDao.findByContent(status, question, pagination);
    }

    @Override
    public void save(Question question) throws ParameterException, ServiceException {
        ParameterException parameterException = new ParameterException();
        ServiceException serviceException = new ServiceException();

        if (StringUtil.isEmpty(question.getQuestionContent())) {
            parameterException.addErrorField(Constants.QUESTION_CONTENT_IS_NULL, Constants.QUESTION_CONTENT_IS_NULL);
        }

        if (StringUtil.isEmpty(question.getChoiceA())) {
            parameterException.addErrorField(Constants.CHOICE_A_IS_NULL, Constants.CHOICE_A_IS_NULL);
        }

        if (StringUtil.isEmpty(question.getChoiceB())) {
            parameterException.addErrorField(Constants.CHOICE_B_IS_NULL, Constants.CHOICE_B_IS_NULL);
        }

        if (StringUtil.isEmpty(question.getChoiceC())) {
            parameterException.addErrorField(Constants.CHOICE_C_IS_NULL, Constants.CHOICE_C_IS_NULL);
        }

        if (StringUtil.isEmpty(question.getChoiceD())) {
            parameterException.addErrorField(Constants.CHOICE_D_IS_NULL, Constants.CHOICE_D_IS_NULL);
        }

        if (StringUtil.isEmpty(question.getCorrectAnwser())) {
            parameterException.addErrorField(Constants.CORRECT_ANWSER_IS_NULL, Constants.CORRECT_ANWSER_IS_NULL);
        }

        if (parameterException.hasErrorField()) {
            throw parameterException;
        }

        Set<String> anwsers = new HashSet<String>();
        anwsers.add(question.getChoiceA());
        anwsers.add(question.getChoiceB());
        anwsers.add(question.getChoiceC());
        anwsers.add(question.getChoiceD());

        if (anwsers.size() < Constants.QUESTION_SIZE) {
            serviceException.addError(Constants.CHOICE_ANWSER_ERROR_CODE, Constants.ANWSER_REPEATED);
        }

        int questionId = question.getId();
        int selectQuestionRes = questionDao.getByContent(question);

        // Check question is repeated
        Question qs = questionDao.getById(new Question(questionId));

        if (questionId > Constants.INT_INITIAL_VALUE) {
            // Update question condition
            if (selectQuestionRes >= Constants.INT_NUMBER_ONE) {
                if (question.getQuestionContent().equals(qs.getQuestionContent())) {
                    questionDao.update(question);
                } else {
                    serviceException.addError(Constants.PROBLEM_IS_REPEATED, Constants.QUESTION_NAME_REPEATED);
                }
            } else {
                questionDao.update(question);
            }
        } else {
            // Add question condition
            if (selectQuestionRes == Constants.INT_INITIAL_VALUE) {
                questionDao.create(question);
            } else {
                serviceException.addError(Constants.PROBLEM_IS_REPEATED, Constants.QUESTION_NAME_REPEATED);
            }
        }

        if (serviceException.hasErrorField()) {
            throw serviceException;
        }
    }

    @Override
    public void delete(Question question) {
        questionDao.delete(question);
    }

    @Override
    public int getByContent(Question question) {
        return questionDao.getByContent(question);
    }

    @Override
    public List<Question> testPaper(int questionQuantity) {
        return questionDao.testPaper(questionQuantity);
    }
}