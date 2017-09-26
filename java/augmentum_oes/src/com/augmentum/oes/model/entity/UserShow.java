package com.augmentum.oes.model.entity;

/**
 * Show the userInfo in manager
 */
public class UserShow {

    private int id;
    private String userName;
    private String userType;

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

    public String getUserType() {
        return userType;
    }

    public void setUserType(String userType) {
        this.userType = userType;
    }

    public UserShow() {
    }

    public UserShow(int id, String userName, String userType) {
        this.id = id;
        this.userName = userName;
        this.userType = userType;
    }
}