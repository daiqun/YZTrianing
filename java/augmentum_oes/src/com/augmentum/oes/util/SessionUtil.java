package com.augmentum.oes.util;

import java.lang.reflect.Method;

import org.apache.log4j.Logger;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;
import com.augmentum.oes.controller.UserController;

public class SessionUtil {

    private final static Logger logger = Logger.getLogger(UserController.class);
    /**
     * Get session in thread local
     *
     * @return
     */
    private static Object getSessionInThread() {
        Object session = AppContext.getContext().getObject(Constants.APP_CONTEXT_SESSION);

        return session;
    }

    /**
     * Invoke setAttribute method
     *
     * @param key
     * @param object
     */
    public static void setSession(String key, Object object) {
        Object session = getSessionInThread();

        if (session == null) {
            return;
        }

        try {
            Class<?>[] param = new Class[Constants.SESSION_PARAM_NUMBER];
            param[Constants.INT_INITIAL_VALUE] = String.class;
            param[Constants.INT_NUMBER_ONE] = Object.class;
            Method method = session.getClass().getMethod(Constants.SESSION_METHOD_SETATTRIBUTE, param);
            Object[] objects = new Object[Constants.SESSION_PARAM_NUMBER];
            objects[Constants.INT_INITIAL_VALUE] = key;
            objects[Constants.INT_NUMBER_ONE] = object;
            method.invoke(session, objects);
        } catch (Exception ex) {
            logger.error(ex);
        }
    }

    /**
     * Invoke getAttribute method
     *
     * @param key
     * @return
     */
    public static Object getSession(String key) {
        Object session = getSessionInThread();

        if (session == null) {
            return null;
        }

        try {
            Class<?>[] param = new Class[Constants.SESSION_PARAM_NUMBER_ONE];
            param[Constants.INT_INITIAL_VALUE] = String.class;
            Method method = session.getClass().getMethod(Constants.SESSION_METHOD_GETATTRIBUTE, param);
            Object[] objects = new Object[Constants.SESSION_PARAM_NUMBER_ONE];
            objects[Constants.INT_INITIAL_VALUE] = key;
            Object returnValue = method.invoke(session, objects);

            return returnValue;
        } catch (Exception ex) {
            logger.error(ex);
        }

        return null;
    }

    /**
     * Invoke removeAttribute method
     *
     * @param key
     */
    public static void removeSession(String key) {
        Object session = getSessionInThread();

        if (session == null) {
            return;
        }

        try {
            Class<?>[] param = new Class[Constants.SESSION_PARAM_NUMBER_ONE];
            param[Constants.INT_INITIAL_VALUE] = String.class;
            Method method = session.getClass().getMethod(Constants.SESSION_METHOD_REMOVE_ATTRIBUTE, param);
            Object[] objects = new Object[Constants.SESSION_PARAM_NUMBER_ONE];
            objects[Constants.INT_INITIAL_VALUE] = key;
            method.invoke(session, objects);
        } catch (Exception ex) {
            logger.error(ex);
        }
    }

    /**
     * Invoke invalidate method
     */
    public static void invalidate() {
        Object session = getSessionInThread();

        if (session == null) {
            return;
        }

        try {
            Method method = session.getClass().getMethod(Constants.SESSION_METHOD_INVALIDATE);
            method.invoke(session);
        } catch (Exception ex) {
            logger.error(ex);
        }
    }
}