package com.dw.exception;

public class ServiceException extends Exception {
    private static final long serialVersionUID = 286653777697423297L;
    //Exception number
    private int code;
    //Exception information
    private String message;

    //Business logic exception handling
    public ServiceException(String message) {
        super();
        this.message = message;
    }

    public ServiceException(int code, String message) {
        super();
        this.code = code;
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
}