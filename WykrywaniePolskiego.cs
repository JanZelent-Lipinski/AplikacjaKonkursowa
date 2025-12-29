using Google.Apis.Services;
using Google.Apis.Translate.v2;
using dotenv.net;



public class WykrywaniePolskiego
{
    private readonly TranslateService _service;

    public WykrywaniePolskiego()
    {
        DotEnv.Load();
        string? apiKey = Environment.GetEnvironmentVariable("GOOGLE_API_KEY");

        _service = new TranslateService(new BaseClientService.Initializer
        {
            ApiKey = apiKey
        });
    }


    public bool CzyPolski(string tekst)
    {
        var request = _service.Detections.List(new[] { tekst });
        var response = request.Execute();

        if (response?.Detections == null || response.Detections.Count == 0)
            return false;


        var lang = response.Detections[0][0].Language;

        return lang == "pl";
    }
}

public class Config
{
    public string? GoogleApiKey { get; set; }
}
