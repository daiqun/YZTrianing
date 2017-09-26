package com.augmentum.oes.util;

import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.text.SimpleDateFormat;
import java.util.Date;

import sun.misc.BASE64Encoder;

import com.augmentum.oes.Constants;

public final class StringUtil {
    /**
     * Date whether none
     *
     * @param data
     * @return isEmpty
     */
    public static boolean isEmpty(String data) {
        return data == null || data.equals(Constants.STING_EMPTY);
    }

    /**
     * First code up
     */
    public static String captureName(String name) {
        char[] cs = name.toCharArray();
        cs[Constants.INT_INITIAL_VALUE] -= Constants.INT_NUMBER_32;

        return String.valueOf(cs);
    }

    /**
     * Format current time
     *
     * @return
     */
    public static String currentTime() {
        SimpleDateFormat dateFormat = new SimpleDateFormat(Constants.DATE_FORMATE);

        return dateFormat.format(new Date());
    }

    /**
     * Format time
     *
     * @return
     */
    public static String dateFormat(Date date) {
        SimpleDateFormat dateFormat = new SimpleDateFormat(Constants.EXAM_DATE_FORMATE);

        return dateFormat.format(date);
    }

    /**
     * EncoderByMd5
     *
     * @param str
     * @return
     * @throws NoSuchAlgorithmException
     * @throws UnsupportedEncodingException
     */
    public static String EncoderByMd5(String str) throws NoSuchAlgorithmException, UnsupportedEncodingException {
        MessageDigest md5 = MessageDigest.getInstance(Constants.MD5);
        BASE64Encoder base64en = new BASE64Encoder();
        String newstr = base64en.encode(md5.digest(str.getBytes(Constants.UTF_8)));

        return newstr;
    }

    /**
     * Check password
     *
     * @param newpasswd
     * @param oldpasswd
     * @return
     * @throws NoSuchAlgorithmException
     * @throws UnsupportedEncodingException
     */
    public static boolean checkpassword(String newpasswd, String oldpasswd) throws NoSuchAlgorithmException, UnsupportedEncodingException {
        return EncoderByMd5(newpasswd).equals(oldpasswd);
    }

    /**
     * Format keyword
     *
     * @param keyword
     * @return keyword
     */
    public static String escapeKeyWord(String keyword) {
        return keyword.replace(Constants.QUESTION_MARK, Constants.ESCAPE_THE_QUESTION_MARK)
                .replace(Constants.PERCENT_SIGN, Constants.ESCAPE_THE_PERCENT_SIGN)
                .replace(Constants.UNDERLINE, Constants.ESCAPE_THE_UNDERLINE)
                .replace(Constants.LEFT_BRACKETS, Constants.ESCAPE_THELEFT_BRACKETS)
                .replace(Constants.RIGHT_BRACKETS, Constants.ESCAPE_THERIGHT_BRACKETS)
                .replace(Constants.SEMICOLON, Constants.ESCAPE_THESEMICOLON);
    }

    /**
     * EscapeHTML keyword
     *
     * @param html
     * @return html
     */
    public static String escapeHTML(String html) {
        return html.replace(Constants.APOSTROPHE, Constants.ESCAPE_APOSTROPHE)
                .replace(Constants.VERSUS, Constants.ESCAPSE_VERSUS)
                .replace(Constants.LESS_THAN, Constants.ESCAPE_LESS_THAN)
                .replace(Constants.MORE_THAN, Constants.ESCAPE_MORE_THAN)
                .replace(Constants.SPACE, Constants.ESCAPE_SPACE);
    }
}