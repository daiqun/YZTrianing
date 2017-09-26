package com.augmentum.oes.model.dao.jdbc.mysql;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;

import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.PreparedStatementCreator;
import org.springframework.jdbc.support.GeneratedKeyHolder;
import org.springframework.jdbc.support.KeyHolder;

import com.augmentum.oes.Constants;
import com.augmentum.oes.model.dao.UserRoleDao;
import com.augmentum.oes.model.entity.UserRole;

/**
 * To achieve the user role create, delete, update and select
 */
public class UserRoleDaoImpl implements UserRoleDao {

    private JdbcTemplate jdbcTemplate;

    public void setJdbcTemplate(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public int create(final UserRole userRole) {
        KeyHolder keyHolder = new GeneratedKeyHolder();
        jdbcTemplate.update(new PreparedStatementCreator() {

            @Override
            public PreparedStatement createPreparedStatement(Connection connection) throws SQLException {
                String sql = Constants.GIVE_USER_ROLE;
                PreparedStatement pst = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
                pst.setInt(1, userRole.getUserId());
                pst.setInt(2, userRole.getRoleId());
                pst.setString(3, userRole.getCreateBy());
                pst.setString(4, userRole.getUpdateBy());

                return pst;
            }
        }, keyHolder);

        return keyHolder.getKey().intValue();
    }
}