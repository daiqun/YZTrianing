package com.augmentum.oes.model.entity;

import java.io.Serializable;
import java.util.Date;

/**
 * User entity
 */
public class User extends BaseTime implements Serializable {

    private static final long serialVersionUID = -4134374605569183644L;

    private int id;
    private String userName;
    private String password;
    private String gender;
    private String phoneNumber;
    private String email;
    private String chineseName;
    private String avatar;
    private Date lastLoginTime;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getChineseName() {
        return chineseName;
    }

    public void setChineseName(String chineseName) {
        this.chineseName = chineseName;
    }

    public String getAvatar() {
        return avatar;
    }

    public void setAvatar(String avatar) {
        this.avatar = avatar;
    }

    public Date getLastLoginTime() {
        return lastLoginTime;
    }

    public void setLastLoginTime(Date lastLoginTime) {
        this.lastLoginTime = lastLoginTime;
    }

    public User() {
    }

    public User(int id, String userName, String password, String gender, String phoneNumber, String email,
            String chineseName, String avatar, Date lastLoginTime, Date createTime, Date updateTime, String createBy,
            String updateBy) {
        this.id = id;
        this.userName = userName;
        this.password = password;
        this.gender = gender;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.chineseName = chineseName;
        this.avatar = avatar;
        this.lastLoginTime = lastLoginTime;
        this.createTime = createTime;
        this.updateTime = updateTime;
        this.createBy = createBy;
        this.updateBy = updateBy;
    }
}