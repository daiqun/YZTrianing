package com.augmentum.oes.model.dao;

import java.util.List;

import org.apache.ibatis.annotations.Param;
import org.springframework.stereotype.Repository;

import com.augmentum.oes.Constants;
import com.augmentum.oes.model.entity.Pagination;
import com.augmentum.oes.model.entity.Question;

/**
 * Define the create, delete, update and select of the question
 */
@Repository
public interface QuestionDao {
    /**
     * Get question count by content
     *
     * @param question
     * @return
     */
    public int getByContent(Question question);

    /**
     * Page query based on question content
     *
     * @param status
     * @param question
     * @param pagination
     * @return List<Question>
     */
    public List<Question> findByContent(@Param(value = Constants.QUESTION_DAO_QUESTION_STATUS) String status,
            @Param(value = Constants.QUESTION_DAO_QUESTION_ENTITY) Question question,
            @Param(value = Constants.PAGINATION) Pagination pagination);

    /**
     * Query by question content
     *
     * @param question
     * @return Question
     */
    public Question getById(Question question);

    /**
     * Add question
     *
     * @param question
     */
    public int create(Question question);

    /**
     * Edit question
     *
     * @param question
     */
    public void update(Question question);

    /**
     * Get question count
     *
     * @return questionCount
     */
    public int getCount();

    /**
     * Get question count by question content
     *
     * @param question
     * @return questionCount by content
     */
    public int getCountByContent(Question question);

    /**
     * Delete question
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