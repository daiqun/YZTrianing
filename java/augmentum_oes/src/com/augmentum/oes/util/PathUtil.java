package com.augmentum.oes.util;

import com.augmentum.oes.AppContext;
import com.augmentum.oes.Constants;

public class PathUtil {
    /**
     * Back-end path
     *
     * @param path
     * @return
     */
    public static String pagePath(String path) {

        if (path == null) {
            path = Constants.STING_EMPTY;
        }

        String urlPrefix = Constants.APP_URL_PREFIX;

        if (!StringUtil.isEmpty(urlPrefix)) {
            urlPrefix += Constants.SLASH;
        }

        return AppContext.getContextPath() + Constants.SLASH + urlPrefix + path;
    }
}