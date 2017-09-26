package com.augmentum.oes.exception;

import java.util.HashMap;
import java.util.Map;

/**
 * Capture all parameter exception information
 */
public class ParameterException extends Exception {

    private static final long serialVersionUID = -787963084209538745L;

    Map<String, String> errorFields = new HashMap<String, String>();

    public Map<String, String> getErrorFields() {
        return errorFields;
    }

    public void setErrorFields(Map<String, String> errorFields) {
        this.errorFields = errorFields;
    }

    public void addErrorField(String fieldName, String result) {
        errorFields.put(fieldName, result);
    }

    public boolean hasErrorField() {
        return !errorFields.isEmpty();
    }
}