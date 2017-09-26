package com.augmentum.oes.model.dao;

import java.util.List;

import org.springframework.stereotype.Repository;

import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.entity.UserShow;

/**
 * Define the create, delete, update and select of the user
 */
@Repository
public interface UserDao {
    /**
     * Get user by name
     *
     * @param userName
     * @return SELECT USER BY NAME
     */
    public User getByName(String userName);

    /**
     * Add a new user
     *
     * @param user
     * @return RETURN_GENERATED_KEYS
     */
    public int create(User user);

    /**
     * Find user by name
     *
     * @param user
     * @return List<User>
     */
    public List<UserShow> findByName(User user);
}