package com.augmentum.oes.util;

import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

/**
 * Implements ApplicationContextAware Automatically inject all beans
 * this class is aware in sping, so this class had load application-context.xml config
 *
 */
public class SpringUtil implements ApplicationContextAware {

    private static ApplicationContext applicationContext = null;

    /**
     * ApplicationContext like beanFactory/Spring automatically injects all beans
     */
    @Override
    public void setApplicationContext(ApplicationContext application) throws BeansException {
        applicationContext = application;
    }

    public static ApplicationContext getApplicationContext() {
        return applicationContext;
    }

    public static Object getBean(String beanId) {
        ApplicationContext applicationContext = getApplicationContext();

        return applicationContext.getBean(beanId);
    }
}