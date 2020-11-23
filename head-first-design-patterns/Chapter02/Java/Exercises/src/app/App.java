package app;

import java.awt.*;
import javax.swing.*;

import weather.CurrentConditionsDisplay;
import weather.ForecastDisplay;
import weather.WeatherData;

public class App {
    public static void main(String[] args) throws Exception {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

        weatherData.setMeasurements(80, 65, 30.4f);
        weatherData.setMeasurements(82, 70, 29.2f);

        App app = new App();
        app.go();

        System.in.read();
    }
    
    JFrame frame;

    public void go() {
        frame = new JFrame();

        JButton button = new JButton("shouldd i do it?");
        button.addActionListener(event -> System.out.println("don't do it, you might regret it!"));
        button.addActionListener(event -> System.out.println("come on, do it"));
    }
}