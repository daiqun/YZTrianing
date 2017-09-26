package com.dw.util;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.dw.exception.DBException;

public class DBUtil {

    /**
     * Get database connection
     * @return conn
     */
    public static Connection getConnection() {
        Connection conn = null;

        try {
            //1.Load driver
            Class.forName(PropertiesUtil.getProperty("jdbc.driver"));
            //2.Get Connection connection object
            String jdbcURL = PropertiesUtil.getProperty("jdbc.url");
            conn = DriverManager.getConnection(jdbcURL, PropertiesUtil.getProperty("jdbc.username"), PropertiesUtil.getProperty("jdbc.password"));
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        } catch (SQLException e) {
            e.printStackTrace();
            throw new DBException();
        }

        return conn;
    }

    /**
     * Close database connection
     * @param res
     * @param pst
     * @param conn
     */
    public static void close(ResultSet res, PreparedStatement pst, Connection conn) {
      //5.Release resources
        try {
            if (res !=null) {
                res.close();
            }

            if (pst != null) {
                pst.close();
            }

            if (conn != null) {
                conn.close();
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}