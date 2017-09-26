package com.dw.util;

import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

public class PropertiesUtil {
    private static Properties p = null;

    static {
        InputStream in = null;
        in = PropertiesUtil.class.getClassLoader().getResourceAsStream("app.properties");
        p = new Properties();

        try {
            p.load(in);
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            if (in != null) {
                try {
                    in.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
    }

    public static String getProperty(String key) {
        return p.getProperty(key);
    }
}