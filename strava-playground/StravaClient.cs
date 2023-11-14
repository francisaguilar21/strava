internal class StravaClient : IFitnessAppClient
{
    private HttpClient httpClient;

    internal StravaClient(string apiKey)
    {
        
    }

    internal string Name { get { return "strava"; }}

}