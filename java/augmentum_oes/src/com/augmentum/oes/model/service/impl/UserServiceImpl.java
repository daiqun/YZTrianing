package com.augmentum.oes.model.service.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.ParameterException;
import com.augmentum.oes.exception.ServiceException;
import com.augmentum.oes.model.dao.UserDao;
import com.augmentum.oes.model.dao.UserRoleDao;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.entity.UserRole;
import com.augmentum.oes.model.entity.UserShow;
import com.augmentum.oes.model.service.UserService;
import com.augmentum.oes.util.StringUtil;

/**
 * To achieve user operation logic processing
 */
@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private UserDao userDao;

    @Autowired
    private UserRoleDao userRoleDao;

    public void setUserDao(UserDao userDao) {
        this.userDao = userDao;
    }

    public void setUserRoleDao(UserRoleDao userRoleDao) {
        this.userRoleDao = userRoleDao;
    }

    @Override
    public User login(String userName, String password) throws ParameterException, ServiceException {
        ParameterException parameterException = new ParameterException();

        //If param is null?
        if (StringUtil.isEmpty(userName)) {
            parameterException.addErrorField(Constants.USERNAME_IS_NULL, Constants.USERNAME_IS_REQUIRED);
        }

        if (StringUtil.isEmpty(password)) {
            parameterException.addErrorField(Constants.PASSWORD_IS_NULL, Constants.PASSWORD_IS_REQUIRED);
        }

        if (parameterException.hasErrorField()) {
            throw parameterException;
        }

        //If params is error?
        User user = userDao.getByName(userName);

        if (user == null) {
            throw new ServiceException(Constants.LOGIN_IS_ERROR);
        }

        if (!password.equals(user.getPassword())) {
            throw new ServiceException(Constants.LOGIN_IS_ERROR);
        }

        return user;
    }

    @Override
    public int save(User user, UserRole userRole) {
        int row = userDao.create(user);

        if (row > Constants.INT_INITIAL_VALUE) {
            userRole.setUserId(row);
            userRoleDao.create(userRole);
        }

        return row;
    }

    @Override
    public List<UserShow> findByName(User user) {
        return userDao.findByName(user);
    }
}