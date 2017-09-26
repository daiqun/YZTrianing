package com.augmentum.oes.util;

import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

import com.augmentum.oes.Constants;

/**
 * Read the local file by InputStream
 */
public final class PropertiesUtil {

    private static Properties properties = null;

    static {
        InputStream inputStream = null;
        // Properties.getClass().getResourceAsStream(name)
        inputStream = PropertiesUtil.class.getClassLoader().getResourceAsStream(Constants.JDBC_PROPERTIES);
        properties = new Properties();

        try {
            properties.load(inputStream);
        } catch (IOException ioException) {
            ioException.printStackTrace();
        } finally {
            if (inputStream != null) {
                try {
                    inputStream.close();
                } catch (IOException exception) {
                    exception.printStackTrace();
                }
            }
        }
    }

    public static String getProperty(String key) {
        return properties.getProperty(key);
    }

    /**
     * Load static properties
     *
     * @param url
     * @return url
     */
    public static String getStaticUrl() {
        return properties.getProperty(Constants.STATIC_URL);
    }
}