package com.augmentum.oes.model.entity;

import java.io.Serializable;
import java.util.Date;

public class Exam extends BaseTime implements Serializable {

    private static final long serialVersionUID = -3007275672494233789L;

    private int id;
    private String examName;
    private String description;
    private Date effectiveTime;
    private String duration;
    private int questionQuantity;
    private int questionPoints;
    private int totalScore;
    private int passCriteria;
    private String notice;
    private String rules;
    private int status;
    private String SysInformation;
    private String contactUs;
    private int isDelete;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getExamName() {
        return examName;
    }

    public void setExamName(String examName) {
        this.examName = examName;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Date getEffectiveTime() {
        return effectiveTime;
    }

    public void setEffectiveTime(Date effectiveTime) {
        this.effectiveTime = effectiveTime;
    }

    public String getDuration() {
        return duration;
    }

    public void setDuration(String duration) {
        this.duration = duration;
    }

    public int getQuestionQuantity() {
        return questionQuantity;
    }

    public void setQuestionQuantity(int questionQuantity) {
        this.questionQuantity = questionQuantity;
    }

    public int getQuestionPoints() {
        return questionPoints;
    }

    public void setQuestionPoints(int questionPoints) {
        this.questionPoints = questionPoints;
    }

    public int getTotalScore() {
        return totalScore;
    }

    public void setTotalScore(int totalScore) {
        this.totalScore = totalScore;
    }

    public int getPassCriteria() {
        return passCriteria;
    }

    public void setPassCriteria(int passCriteria) {
        this.passCriteria = passCriteria;
    }

    public String getNotice() {
        return notice;
    }

    public void setNotice(String notice) {
        this.notice = notice;
    }

    public String getRules() {
        return rules;
    }

    public void setRules(String rules) {
        this.rules = rules;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public String getSysInformation() {
        return SysInformation;
    }

    public void setSysInformation(String sysInformation) {
        SysInformation = sysInformation;
    }

    public String getContactUs() {
        return contactUs;
    }

    public void setContactUs(String contactUs) {
        this.contactUs = contactUs;
    }

    public int getIsDelete() {
        return isDelete;
    }

    public void setIsDelete(int isDelete) {
        this.isDelete = isDelete;
    }

    public Exam() {
    }

    public Exam(int id, String examName, String description, Date effectiveTime, String duration, int questionQuantity,
            int questionPoints, int totalScore, int passCriteria, String notice, String rules, int status,
            String sysInformation, String contactUs, Integer isDelete, Date createTime, Date updateTime,
            String createBy, String updateBy) {
        this.id = id;
        this.examName = examName;
        this.description = description;
        this.effectiveTime = effectiveTime;
        this.duration = duration;
        this.questionQuantity = questionQuantity;
        this.questionPoints = questionPoints;
        this.totalScore = totalScore;
        this.passCriteria = passCriteria;
        this.notice = notice;
        this.rules = rules;
        this.status = status;
        this.SysInformation = sysInformation;
        this.contactUs = contactUs;
        this.isDelete = isDelete;
        this.createTime = createTime;
        this.updateTime = updateTime;
        this.createBy = createBy;
        this.updateBy = updateBy;
    }
}