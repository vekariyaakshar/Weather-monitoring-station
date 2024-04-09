namespace weathermontitoringsystem_Library
{
    public class Weather_Station
    {
        public IDisplay CreateDisplay(string displayType)
        {
            Weather_Data weatherData = Weather_Data.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditions_Display(weatherData);
                case "Statistics":
                    return new Statistics_Display(weatherData);
                case "Forecast":
                    return new Forecast_Display(weatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}