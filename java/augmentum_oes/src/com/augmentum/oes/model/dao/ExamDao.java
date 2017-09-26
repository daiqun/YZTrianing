package com.augmentum.oes.model.dao;

import java.util.List;

import org.springframework.stereotype.Repository;

import com.augmentum.oes.model.entity.Exam;

@Repository
public interface ExamDao {
    /**
     * Create a exam
     *
     * @param exam
     * @return
     */
    public int create(Exam exam);

    /**
     * FindAll exam
     *
     * @return List<Exam>
     */
    public List<Exam> findAll();
}