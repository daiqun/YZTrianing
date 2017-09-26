package com.augmentum.oes.model.dao.jdbc.mysql;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.List;

import org.apache.commons.lang.StringEscapeUtils;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.PreparedStatementCreator;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.jdbc.support.GeneratedKeyHolder;
import org.springframework.jdbc.support.KeyHolder;

import com.augmentum.oes.Constants;
import com.augmentum.oes.model.dao.QuestionDao;
import com.augmentum.oes.model.entity.Pagination;
import com.augmentum.oes.model.entity.Question;

/**
 * To achieve the question's create, delete, update and select
 */
public class QuestionDaoImpl implements QuestionDao {

    private JdbcTemplate jdbcTemplate;

    public void setJdbcTemplate(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Question> findByContent(String status, final Question question, Pagination pagination) {
        String sql = Constants.QUERY_CONTENT + Constants.QUERY_BY_CONTENT_LIKE;

        if (Constants.SORT_DESC.equals(status)) {
            sql += Constants.SORT_BY_ID_DESC;
        } else if (Constants.SORT_ASC.equals(status)) {
            sql += Constants.SORT_BY_ID_ASC;
        }

        sql += Constants.LIMIT + pagination.getOffset() + Constants.COMMA + pagination.getPageSize();
        String con = StringEscapeUtils.escapeSql(question.getQuestionContent());
        Object[] obj = new Object[] { Constants.PERCENT_SIGN + con + Constants.PERCENT_SIGN };

        RowMapper<Question> rowMapper = new RowMapper<Question>() {

            @Override
            public Question mapRow(ResultSet res, int rowNum) throws SQLException {
                return resToQuestion(res);
            }
        };

        return jdbcTemplate.query(sql, obj, rowMapper);
    }

    @Override
    public Question getById(final Question question) {
        String sql = Constants.QUERY_CONTENT + Constants.QUERY_BY_QUESTION_ID;
        Object[] obj = new Object[] { question.getId() };

        RowMapper<Question> rowMapper = new RowMapper<Question>() {

            @Override
            public Question mapRow(ResultSet res, int rowNum) throws SQLException {
                return resToQuestion(res);
            }
        };

        List<Question> questions = jdbcTemplate.query(sql, obj, rowMapper);

        return questions != null && questions.size() > Constants.INT_INITIAL_VALUE ? questions.get(Constants.INT_INITIAL_VALUE) : null;
    }

    private Question resToQuestion(ResultSet res) throws SQLException {
        Question question = new Question();
        question.setId(res.getInt(Constants.INT_NUMBER_ONE));
        question.setQuestionContent(res.getString(Constants.INT_NUMBER_TWO));
        question.setChoiceA(res.getString(Constants.INT_NUMBER_THREE));
        question.setChoiceB(res.getString(Constants.INT_NUMBER_FOUR));
        question.setChoiceC(res.getString(Constants.INT_NUMBER_FIVE));
        question.setChoiceD(res.getString(Constants.INT_NUMBER_SIX));
        question.setCorrectAnwser(res.getString(Constants.INT_NUMBER_SEVEN));

        return question;
    }

    @Override
    public int create(final Question question) {
        KeyHolder keyHolder = new GeneratedKeyHolder();

        jdbcTemplate.update(new PreparedStatementCreator() {

            @Override
            public PreparedStatement createPreparedStatement(Connection connection) throws SQLException {
                String sql = Constants.ADD_QUESTION;
                PreparedStatement pst = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
                pst.setInt(Constants.INT_NUMBER_ONE, question.getUserId());
                pst.setString(Constants.INT_NUMBER_TWO, question.getQuestionContent());
                pst.setString(Constants.INT_NUMBER_THREE, question.getChoiceA());
                pst.setString(Constants.INT_NUMBER_FOUR, question.getChoiceB());
                pst.setString(Constants.INT_NUMBER_FIVE, question.getChoiceC());
                pst.setString(Constants.INT_NUMBER_SIX, question.getChoiceD());
                pst.setString(Constants.INT_NUMBER_SEVEN, question.getCorrectAnwser());
                pst.setString(Constants.INT_NUMBER_EIGHT, question.getCreateBy());
                pst.setString(Constants.INT_NUMBER_NINE, question.getUpdateBy());

                return pst;
            }
        }, keyHolder);
        question.setId(keyHolder.getKey().intValue());

        return keyHolder.getKey().intValue();
    }

    @Override
    public void delete(final Question question) {
        String sql = Constants.DELETE_QUESTION_SQL;
        Object[] obj = new Object[] { question.getId() };

        jdbcTemplate.update(sql, obj);
    }

    @Override
    public void update(final Question question) {
        String sql = Constants.EDIT_QUESTION;
        Object[] obj = new Object[] { question.getQuestionContent(), question.getChoiceA(), question.getChoiceB(),
                question.getChoiceC(), question.getChoiceD(), question.getCorrectAnwser(), question.getUpdateBy(),
                question.getId() };

        jdbcTemplate.update(sql, obj);
    }

    @Override
    public int getCount() {
        String sql = Constants.COUNT_QUESTION + Constants.QUERY_QUESTION_EXIST;

        return jdbcTemplate.queryForInt(sql);
    }

    @Override
    public int getCountByContent(final Question question) {
        String sql = Constants.COUNT_QUESTION + Constants.QUERY_BY_CONTENT;
        String con = StringEscapeUtils.escapeSql(question.getQuestionContent());
        Object[] obj = new Object[] { Constants.PERCENT_SIGN + con + Constants.PERCENT_SIGN };

        return jdbcTemplate.queryForInt(sql, obj);
    }

    @Override
    public int getByContent(Question question) {
        return Constants.INT_INITIAL_VALUE;
    }

    @Override
    public List<Question> testPaper(int questionQuantity) {
        return null;
    }
}