package com.example.victorgabriel.cda;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

/**
 * Created by Victor Gabriel on 04/07/2017.
 */

public class Dados_mapa extends BaseURL {

    String lng;
    String lat;
    String data;

    public void setLng(String lng)
    {
        this.lng = lng;
    }
    public void setLat(String lat)
    {
        this.lat = lat;
    }
    public void setData(String data)
    {
        this.data = data;
    }

    public String getLng() {
        return lng;
    }


    public String getData() {

        return data;
    }

    public String getLat() {
        
        return lat;
    }
}
