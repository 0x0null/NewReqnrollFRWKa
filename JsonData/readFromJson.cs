namespace NewReqnrollFRWK.JsonData
{
    public class readFromJson
    {
        private IConfigurationRoot _config;

        public readFromJson()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json")
                .Build();

            _config = builder;
        }

        public string getUrlValue(string key) => _config[key]!;

        public string? GetUrl()
        {
            return _config.GetSection("url")?.GetValue<string>("suacedemourl");
        }
    }
}