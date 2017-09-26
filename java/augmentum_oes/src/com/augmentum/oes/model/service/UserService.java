package com.augmentum.oes.model.service;

import java.util.List;

import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.entity.UserRole;
import com.augmentum.oes.model.entity.UserShow;

/**
 * Define user operations Logical processing
 */
public interface UserService {
    /**
     * User login
     *
     * @param userName
     * @param password
     * @return User
     */
    public User login(String userName, String password) throws ParameterException, ServiceException;

    /**
     * Add a new user or edit userInfo
     *
     * @param user
     * @param userRole
     * @return
     */
    public int save(User user, UserRole userRole);

    /**
     * Find user by name
     *
     * @param user
     * @return
     */
    public List<UserShow> findByName(User user);
}