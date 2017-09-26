package com.augmentum.oes.util;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

import org.codehaus.jackson.JsonGenerator;
import org.codehaus.jackson.JsonProcessingException;
import org.codehaus.jackson.map.JsonSerializer;
import org.codehaus.jackson.map.SerializerProvider;

import com.augmentum.oes.Constants;

/**
 * Date to json
 */
public class DateToJsonUtil extends JsonSerializer<Date> {

    @Override
    public void serialize(Date value, JsonGenerator jsonGe, SerializerProvider provider) throws IOException,
            JsonProcessingException {
        SimpleDateFormat formatter = new SimpleDateFormat(Constants.DATE_FORMATE);
        String formattedDate = formatter.format(value);
        jsonGe.writeString(formattedDate);
    }
}