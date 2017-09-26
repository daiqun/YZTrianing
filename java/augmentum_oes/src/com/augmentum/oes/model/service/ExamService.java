package com.augmentum.oes.model.service;

import java.util.List;

import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.model.entity.Exam;

public interface ExamService {
    /**
     * Create a exam
     *
     * @param exam
     * @return
     * @throws ParameterException
     */
    public int create(Exam exam) throws ParameterException;

    /**
     * FindAll exam
     *
     * @return List<Exam>
     */
    public List<Exam> findAll();
}