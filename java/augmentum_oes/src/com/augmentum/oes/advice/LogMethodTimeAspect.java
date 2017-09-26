package com.augmentum.oes.advice;

import org.apache.log4j.Logger;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.ProceedingJoinPoint;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;

public class LogMethodTimeAspect {

    private final Logger LOGGER = Logger.getLogger(LogMethodTimeAspect.class);

    public void doBefore(JoinPoint point) {
        // System.out.println(Constants.LOG_BEGIN_METHOD + point.getTarget().getClass().getName() + Constants.POINT + point.getSignature().getName());
    }

    public void doAfter(JoinPoint point) {
        // System.out.println(Constants.LOG_END_METHOD + point.getTarget().getClass().getName() + Constants.POINT + point.getSignature().getName());
    }

    public Object doAround(ProceedingJoinPoint point) throws Throwable {
        long startTime = System.currentTimeMillis();

        // Invoke aim method
        Object returnVale = point.proceed();
        String methodName = point.getSignature().getName();
        long endTime = System.currentTimeMillis();

        // Print time
        StringBuilder sb = new StringBuilder();
        sb.append(AppContext.getContext().getUserName());
        sb.append(Constants.COLON);

        // PageName + ClassName
        sb.append(point.getTarget().getClass().getSimpleName());
        sb.append(Constants.COLON);
        sb.append(methodName);
        sb.append(Constants.COLON);
        sb.append(endTime - startTime);
        LOGGER.info(sb.toString());

        return returnVale;
    }

    public void doThrowing(JoinPoint point, Throwable ex) {
        // System.out.println("method " + point.getTarget().getClass().getName() + "." + point.getSignature().getName() + " throw exception");
        // System.out.println(ex.getMessage());
    }
}