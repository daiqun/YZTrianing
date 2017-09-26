package com.augmentum.oes.model.entity;

import com.augmentum.oes.Constants;
import com.augmentum.oes.util.PropertiesUtil;

/**
 * Pagination temporary tables
 */
public class Pagination {

    private int totalCount;
    private int pageSize;
    private int pageCount;
    private int currentPage;
    private int offset;

    public int getTotalCount() {
        return totalCount;
    }

    public void setTotalCount(int totalCount) {
        this.totalCount = totalCount;
    }

    public int getPageSize() {

        if (pageSize == Constants.INT_INITIAL_VALUE) {
            String size = PropertiesUtil.getProperty(Constants.KEY_PAGE_SIZE);
            pageSize = Integer.parseInt(size);
        }

        return pageSize;
    }

    public void setPageSize(int pageSize) {
        this.pageSize = pageSize;
    }

    public int getPageCount() {

        if (totalCount < Constants.INT_NUMBER_ONE) {
            pageCount = Constants.INT_INITIAL_VALUE;

            return pageCount;
        }

        pageCount = (totalCount - Constants.INT_NUMBER_ONE) / getPageSize() + Constants.INT_NUMBER_ONE;

        return pageCount;
    }

    public int getCurrentPage() {

        if (currentPage < Constants.INT_NUMBER_ONE) {
            currentPage = Constants.INT_NUMBER_ONE;
        }

        return currentPage;
    }

    public void setCurrentPage(int currentPage) {
        this.currentPage = currentPage;
    }

    /**
     * Get limit(m, n) m value
     *
     * @return offset
     */
    public int getOffset() {
        offset = (getCurrentPage() - Constants.INT_NUMBER_ONE) * getPageSize();

        return offset;
    }

    public boolean isFirstPage() {

        if (this.currentPage <= Constants.INT_NUMBER_ONE) {
            return true;
        }

        return false;
    }

    public boolean isLastPage() {

        if (this.currentPage >= this.getPageCount()) {
            return true;
        }

        return false;
    }
}