package com.augmentum.oes.model.service.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.model.dao.ExamDao;
import com.augmentum.oes.model.entity.Exam;
import com.augmentum.oes.model.service.ExamService;
import com.augmentum.oes.util.StringUtil;

@Service
public class ExamServiceImpl implements ExamService {

    @Autowired
    private ExamDao examDao;

    @Override
    public int create(Exam exam) throws ParameterException {
        ParameterException parameterException = new ParameterException();

        if (StringUtil.isEmpty(exam.getExamName()) || exam.getEffectiveTime() == null
                || StringUtil.isEmpty(exam.getDuration())
                || exam.getQuestionQuantity() == Constants.INT_INITIAL_VALUE
                || exam.getQuestionPoints() == Constants.INT_INITIAL_VALUE
                || exam.getTotalScore() == Constants.INT_INITIAL_VALUE
                || exam.getPassCriteria() == Constants.INT_INITIAL_VALUE) {

            parameterException.addErrorField(Constants.EXAM_MUST_REQUIRED, Constants.EXAM_REQUIRED_IS_NULL);
        }

        if (parameterException.hasErrorField()) {
            throw parameterException;
        }

        return examDao.create(exam);
    }

    @Override
    public List<Exam> findAll() {
        return examDao.findAll();
    }
}