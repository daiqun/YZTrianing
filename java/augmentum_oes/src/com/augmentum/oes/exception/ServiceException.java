package com.augmentum.oes.exception;

import java.util.HashMap;
import java.util.Map;

/**
 * Capture all data validation exception information
 */
public class ServiceException extends Exception {

    private static final long serialVersionUID = 286653777697423297L;

    private int code;
    private String message;
    private Map<Integer, String> errorMap = new HashMap<Integer, String>();

    public ServiceException() {
    }

    public ServiceException(String message) {
        this.message = message;
    }

    public int getCode() {
        return code;
    }

    public void setCode(int code) {
        this.code = code;
    }

    @Override
    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public Map<Integer, String> getErrorMap() {
        return errorMap;
    }

    public void setErrorMap(Map<Integer, String> errorMap) {
        this.errorMap = errorMap;
    }

    public void addError(Integer fieldName, String result) {
        errorMap.put(fieldName, result);
    }

    public boolean hasErrorField() {
        return !errorMap.isEmpty();
    }
}