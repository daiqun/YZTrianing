package com.augmentum.oes.model.service;

import java.util.List;

import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.entity.Pagination;
import com.augmentum.oes.model.entity.Question;

/**
 * Define question operations Logical processing
 */
public interface QuestionService {
    /**
     * Get question by content
     *
     * @param question
     * @return
     */
    public int getByContent(Question question);

    /**
     * Search question by questionId
     *
     * @param question
     * @return Question
     */
    public Question getById(Question question);

    /**
     * Search question by Fuzzy content
     *
     * @param status
     * @param question
     * @param pagination
     * @return
     */
    public List<Question> findByContent(String status, Question question, Pagination pagination);

    /**
     * Save question(add/edit)
     *
     * @param question
     */
    public void save(Question question) throws ParameterException, ServiceException;

    /**
     * Delete question by questionId
     *
     * @param question
     */
    public void delete(Question question);

    /**
     * Randomly extract the problem
     *
     * @param questionQuantity
     * @return
     */
    public List<Question> testPaper(int questionQuantity);
}