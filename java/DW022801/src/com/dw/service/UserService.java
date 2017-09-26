package com.dw.service;

import com.dw.dao.UserDao;
import com.dw.entity.User;
import com.dw.exception.ParameterException;
import com.dw.exception.ServiceException;
import com.dw.util.StringUtil;

public class UserService {

    /**
     *
     * @param userName
     * @param password
     * @return
     * @throws ParameterException Data format verification
     * @throws ServiceException Database processing verification
     */
    public User login(String userName, String password) throws ParameterException, ServiceException {
        //Data format check (without database)
        ParameterException parameterException = new ParameterException();

        if (StringUtil.isEmpty(userName)) {
            parameterException.addErrorField("userNameRes", "userName is required!");
        }

        if (StringUtil.isEmpty(password)) {
            parameterException.addErrorField("passwordRes", "password is required!");
        }

        //Determine if there is an error message
        if (parameterException.isErrorField()) {
            throw parameterException;
        }

        //User information check (via database)
        UserDao userDao = new UserDao();
        User user = userDao.getUserByName(userName);

        if (user == null) {
            throw new ServiceException(100, "UserName error!");
        }

        if (!password.equals(user.getPassword())) {
            throw new ServiceException(101, "Password error!");
        }

        return user;
    }
}