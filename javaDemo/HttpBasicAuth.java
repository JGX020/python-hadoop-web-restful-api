package hadooppythonapi;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.net.HttpURLConnection;
import java.net.URL;

import sun.misc.BASE64Encoder;


public class HttpBasicAuth {

    public static void main(String[] args) {

        try {
            URL url = new URL ("http://119.29.0.61:8000/ls");
            String encoding =null;
            byte[] b =null;
            try{
            	b="admin:TvvRvHkyr9b6ls1I".getBytes("utf-8");
            }
            catch(UnsupportedEncodingException e){	
            	e.printStackTrace();
            }
            if(b!=null){
            	encoding= new BASE64Encoder().encode(b);
            }

            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("POST");
            connection.setDoOutput(true);
            connection.setRequestProperty  ("Authorization", "Basic " + encoding);
            InputStream content = (InputStream)connection.getInputStream();
            BufferedReader in   = 
                new BufferedReader (new InputStreamReader (content));
            String line;
            while ((line = in.readLine()) != null) {
                System.out.println(line);
            }
        } catch(Exception e) {
            e.printStackTrace();
        }

    }

}