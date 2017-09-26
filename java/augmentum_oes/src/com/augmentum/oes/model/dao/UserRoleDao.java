package com.augmentum.oes.model.dao;

import org.springframework.stereotype.Repository;

import com.augmentum.oes.model.entity.UserRole;

/**
 * Define the user role management
 */
@Repository
public interface UserRoleDao {
    /**
     * Give role to user
     *
     * @param userRole
     */
    public int create(UserRole userRole);
}