package com.augmentum.oes.util;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import org.codehaus.jackson.JsonParser;
import org.codehaus.jackson.JsonProcessingException;
import org.codehaus.jackson.map.DeserializationContext;
import org.codehaus.jackson.map.JsonDeserializer;

import com.augmentum.oes.Constants;
import com.augmentum.oes.exception.DBException;

/**
 * Json to Date
 */
public class JsonToDateUtil extends JsonDeserializer<Date> {

    @Override
    public Date deserialize(JsonParser jsonParser, DeserializationContext arg1) throws IOException, JsonProcessingException {
        SimpleDateFormat format = new SimpleDateFormat(Constants.DATE_FORMATE);
        String date = jsonParser.getText();

        if (date == null || date.toString().equals(Constants.STING_EMPTY)) {
            return null;
        }

        try {
            return format.parse(date);

        } catch (ParseException e) {
            throw new DBException();
        }
    }
}