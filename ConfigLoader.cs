using System.Text.Json;

namespace ViewerNamespace;

public class ConfigLoader
{
    /*
     * json Serialize desirialize:
     * https://learn.microsoft.com/de-de/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0
     */

    string jsonString = File.ReadAllText("config.json");
    ConfigElement configElement = JsonSerializer.Deserialize<ConfigElement>(jsonString);
    

    // jsonString muss noch geparsed oder serialisiert (?) werden
    ConfigElement download = new ConfigElement(jsonString.download.savelocation);
    
}