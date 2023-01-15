using System.Text.Json;
using System.Text.Json.Serialization;

namespace ViewerNamespace;

public class ConfigLoader
{
    /*
     * json Serialize desirialize:
     * https://learn.microsoft.com/de-de/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0
     *
     * https://www.newtonsoft.com/json/help/html/deserializeobject.htm
     */

    //string jsonFileName{get;}

    public bool error{get;}
    public string errorMsg{get;}

    public ConfigLoader(string jsonFileName)
    {
        if(String.IsNullOrEmpty(File.ReadAllText(jsonFileName)))
        {
            this.error = true;
            this.errorMsg = "ConfigFile is null or empty";
        }
        else
        {
            string jsonString = File.ReadAllText(jsonFileName);
            ConfigElementFolder configElementFolder = JsonSerializer.Deserialize<ConfigElementFolder>(jsonString);
        }

    }
}