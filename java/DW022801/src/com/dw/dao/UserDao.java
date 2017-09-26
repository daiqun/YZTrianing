package com.dw.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.dw.entity.User;
import com.dw.exception.DBException;
import com.dw.util.DBUtil;

public class UserDao {

    public User getUserByName(String userName) {
        if (userName == null || userName.equals("")) {
            return null;
        }

        Connection conn = null;
        PreparedStatement pst = null;
        ResultSet res = null;
        User user = null;

        try {
            conn = DBUtil.getConnection();
            pst = conn.prepareStatement("SELECT * FROM user WHERE user_name = ?");
            pst.setString(1, userName);
            res = pst.executeQuery();

            if (res.next()) {
                user = new User();
                user.setId(res.getInt("id"));
                user.setUserName(res.getString("user_name"));
                user.setPassword(res.getString("password"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
            throw new DBException();
        } finally {
            DBUtil.close(res, pst, conn);
        }

        return user;
    }
}