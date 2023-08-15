namespace FastForwardSC.API.Settings
{
    public class DatabaseSettings
    {
        public readonly static string SectionKey = "DatabaseSettings";

        public string ConnectionString { get; set; } = @"Server=127.0.0.1,1434;Database=Master;User Id=SA;Password=Shopping!";
    }
}
