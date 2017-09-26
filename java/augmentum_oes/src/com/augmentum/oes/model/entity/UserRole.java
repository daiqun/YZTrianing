package com.augmentum.oes.model.entity;

import java.io.Serializable;
import java.util.Date;

/**
 * User role Joint primary key
 */
public class UserRole extends BaseTime implements Serializable {

    private static final long serialVersionUID = -8765996123469333629L;

    private int id;
    private int userId;
    private int roleId;

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

    public int getRoleId() {
        return roleId;
    }

    public void setRoleId(int roleId) {
        this.roleId = roleId;
    }

    public UserRole() {
    }

    public UserRole(int id, int userId, int roleId, Date createTime, Date updateTime, String createBy, String updateBy) {
        this.id = id;
        this.userId = userId;
        this.roleId = roleId;
        this.createTime = createTime;
        this.updateTime = updateTime;
        this.createBy = createBy;
        this.updateBy = updateBy;
    }
}