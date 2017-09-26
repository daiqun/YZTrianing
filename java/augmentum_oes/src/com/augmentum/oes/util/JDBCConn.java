package com.augmentum.oes.util;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.DBException;

public class JDBCConn {

    public static Connection getConnection() {
        Connection conn = null;

        try {
            Class.forName(PropertiesUtil.getProperty(Constants.JDBC_DRIVER));
            String jdbcURL = PropertiesUtil.getProperty(Constants.JDBC_URL);
            conn = DriverManager.getConnection(jdbcURL, PropertiesUtil.getProperty(Constants.JDBC_USERNAME),
                    PropertiesUtil.getProperty(Constants.JDBC_PASSWORD));
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            throw new DBException();
        } catch (SQLException e) {
            e.printStackTrace();
            throw new DBException();
        }

        return conn;
    }

    public static void close(ResultSet res, PreparedStatement pst, Connection conn) {

        try {
            if (res != null) {
                res.close();
            }

            if (pst != null) {
                pst.close();
            }

            if (conn != null) {
                conn.close();
            }
        } catch (SQLException sqlException) {
            sqlException.printStackTrace();
            throw new DBException();
        }
    }
}