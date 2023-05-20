using Newtonsoft.Json;
using System;
using System.Net;
using WeatherStation;
using WeatherStation.Panels;
using static WeatherStation.WeatherApiClient;

public class Program
{
    public struct coordinate
    {
        public double lat;
        public double lon;
    }
    private static void Main(string[] args)
    {
        string apiKey = "d8f0585898c692c1e91dfcdcd7614c70";
        coordinate cordinates = SelectCity();
        WeatherApiClient weatherApiClient = new WeatherApiClient(apiKey);
        WeatherData weatherData = weatherApiClient.GetWeatherData(cordinates.lat, cordinates.lon);

        CurrentWeatherPanel currentWeatherPanel = new CurrentWeatherPanel(weatherData);
        weatherData.ReadingChanged();

    }

    public static coordinate SelectCity()
    {
        coordinate cordinates = new coordinate();

        Console.WriteLine("W jakim mieście chcesz sprawdzić pogodę? Podaj współrzędne geograficzne (np. Poznań -> lat = 52.3380 i lon = 16.9226)");
        Console.WriteLine("");
        Console.WriteLine("Podaj szerokość geograficzną:");
        double latitude;
        while (!double.TryParse(Console.ReadLine(), out latitude) || latitude < -90 || latitude > 90)
        {
            Console.WriteLine("Nieprawidłowy format szerokości geograficznej. Podaj ponownie:");
        }

        Console.WriteLine("Podaj długość geograficzną:");
        double longitude;
        while (!double.TryParse(Console.ReadLine(), out longitude) || longitude < -180 || longitude > 180)
        {
            Console.WriteLine("Nieprawidłowy format długości geograficznej. Podaj ponownie:");
        }

        cordinates.lat = latitude;
        cordinates.lon = longitude;

        return cordinates;
    }
}