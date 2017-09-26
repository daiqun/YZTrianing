package com.augmentum.oes.advice;

import org.aopalliance.intercept.MethodInterceptor;
import org.aopalliance.intercept.MethodInvocation;
import org.apache.log4j.Logger;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;
import com.augmentum.oes.model.service.impl.UserServiceImpl;

/**
 * Dynamic proxy class invoke aim method implements MethodInterceptor interface and do around advice
 */
public class LogMethodAroundTime implements MethodInterceptor {

    private static final Logger LOGGER = Logger.getLogger(UserServiceImpl.class);

    @Override
    public Object invoke(MethodInvocation invocation) throws Throwable {
        long startTime = System.currentTimeMillis();

        // Invoke aim method
        Object returnValue = invocation.proceed();
        String methodName = invocation.getMethod().getName();
        long endTime = System.currentTimeMillis();

        // Print time
        StringBuilder sb = new StringBuilder();
        sb.append(AppContext.getContext().getUserName());
        sb.append(Constants.COLON);

        // PageName + ClassName
        sb.append(invocation.getMethod().getDeclaringClass().getName());
        sb.append(Constants.COLON);
        sb.append(methodName);
        sb.append(Constants.COLON);
        sb.append(endTime - startTime);
        LOGGER.info(sb.toString());

        return returnValue;
    }
}