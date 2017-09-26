package com.augmentum.oes.model.dao.jdbc.mysql;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.List;

import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.PreparedStatementCreator;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.jdbc.support.GeneratedKeyHolder;
import org.springframework.jdbc.support.KeyHolder;

import com.augmentum.oes.Constants;
import com.augmentum.oes.model.dao.UserDao;
import com.augmentum.oes.model.entity.User;
import com.augmentum.oes.model.entity.UserShow;
import com.augmentum.oes.util.StringUtil;

/**
 * To achieve the user's create, delete, update and select
 */
public class UserDaoImpl implements UserDao {

    private JdbcTemplate jdbcTemplate;

    public void setJdbcTemplate(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public User getByName(final String userName) {

        if (StringUtil.isEmpty(userName)) {
            return null;
        }

        String sql = Constants.USER_LOGIN;
        // Set parameters
        Object[] obj = new Object[] { userName };

        RowMapper<User> rowMapper = new RowMapper<User>() {

            @Override
            public User mapRow(ResultSet res, int rowNum) throws SQLException {
                User user = new User();
                user.setId(res.getInt(Constants.INT_NUMBER_ONE));
                user.setUserName(res.getString(Constants.INT_NUMBER_TWO));
                user.setPassword(res.getString(Constants.INT_NUMBER_THREE));

                return user;
            }
        };
        List<User> users = jdbcTemplate.query(sql, obj, rowMapper);

        return users != null && users.size() > Constants.INT_INITIAL_VALUE ? users.get(Constants.INT_INITIAL_VALUE) : null;
    }

    @Override
    public int create(final User user) {
        KeyHolder keyHolder = new GeneratedKeyHolder();

        jdbcTemplate.update(new PreparedStatementCreator() {

            @Override
            public PreparedStatement createPreparedStatement(Connection connection) throws SQLException {
                String sql = Constants.CREATE_USER;
                PreparedStatement pst = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
                pst.setString(Constants.INT_NUMBER_ONE, user.getUserName());
                pst.setString(Constants.INT_NUMBER_TWO, user.getPassword());
                pst.setString(Constants.INT_NUMBER_THREE, user.getCreateBy());
                pst.setString(Constants.INT_NUMBER_FOUR, user.getUpdateBy());
                pst.setString(Constants.INT_NUMBER_FIVE, user.getGender());
                pst.setString(Constants.INT_NUMBER_SIX, user.getPhoneNumber());
                pst.setString(Constants.INT_NUMBER_SEVEN, user.getEmail());
                pst.setString(Constants.INT_NUMBER_EIGHT, user.getChineseName());

                return pst;
            }
        }, keyHolder);

        return keyHolder.getKey().intValue();
    }

    @Override
    public List<UserShow> findByName(User user) {
        String sql = Constants.SQL_FIND_USERSHOW_BY_NAME;
        Object[] obj = new Object[] { Constants.PERCENT_SIGN + user.getUserName() + Constants.PERCENT_SIGN };

        RowMapper<UserShow> rowMapper = new RowMapper<UserShow>() {

            @Override
            public UserShow mapRow(ResultSet res, int rowNum) throws SQLException {
                UserShow userShow = new UserShow();
                userShow.setId(res.getInt(Constants.INT_NUMBER_ONE));
                userShow.setUserName(res.getString(Constants.INT_NUMBER_TWO));
                userShow.setUserType(res.getString(Constants.INT_NUMBER_THREE));

                return userShow;
            }
        };

        List<UserShow> users = jdbcTemplate.query(sql, obj, rowMapper);

        return users != null && users.size() > Constants.INT_INITIAL_VALUE ? users : null;
    }
}