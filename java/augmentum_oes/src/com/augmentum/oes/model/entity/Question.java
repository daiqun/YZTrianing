package com.augmentum.oes.model.entity;

import java.io.Serializable;
import java.util.Date;

/**
 * Question entity
 */
public class Question extends BaseTime implements Serializable {

    private static final long serialVersionUID = -637586927125485202L;

    private int id;
    private int userId;
    private String questionContent;
    private String choiceA;
    private String choiceB;
    private String choiceC;
    private String choiceD;
    private String correctAnwser;
    private Integer isDelete;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public String getQuestionContent() {
        return questionContent;
    }

    public void setQuestionContent(String questionContent) {
        this.questionContent = questionContent;
    }

    public String getChoiceA() {
        return choiceA;
    }

    public void setChoiceA(String choiceA) {
        this.choiceA = choiceA;
    }

    public String getChoiceB() {
        return choiceB;
    }

    public void setChoiceB(String choiceB) {
        this.choiceB = choiceB;
    }

    public String getChoiceC() {
        return choiceC;
    }

    public void setChoiceC(String choiceC) {
        this.choiceC = choiceC;
    }

    public String getChoiceD() {
        return choiceD;
    }

    public void setChoiceD(String choiceD) {
        this.choiceD = choiceD;
    }

    public String getCorrectAnwser() {
        return correctAnwser;
    }

    public void setCorrectAnwser(String correctAnwser) {
        this.correctAnwser = correctAnwser;
    }

    public Integer getIsDelete() {
        return isDelete;
    }

    public void setIsDelete(Integer isDelete) {
        this.isDelete = isDelete;
    }

    public Question(int id) {
        this.id = id;
    }

    public Question() {
    }

    public Question(String questionContent) {
        this.questionContent = questionContent;
    }

    public Question(int id, int userId, String questionContent, String choiceA, String choiceB, String choiceC,
            String choiceD, String correctAnwser, Integer isDelete, Date createTime, Date updateTime, String createBy,
            String updateBy) {
        this.id = id;
        this.userId = userId;
        this.questionContent = questionContent;
        this.choiceA = choiceA;
        this.choiceB = choiceB;
        this.choiceC = choiceC;
        this.choiceD = choiceD;
        this.correctAnwser = correctAnwser;
        this.isDelete = isDelete;
        this.createTime = createTime;
        this.updateTime = updateTime;
        this.createBy = createBy;
        this.updateBy = updateBy;
    }
}