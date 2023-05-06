using System.Text.Json;
using System.Text.Json.Serialization;

namespace ViewerNamespace;

public class ConfigLoader
{
    public bool error{get;}
    public string errorMsg{get;}
    public Folders? folders {get; set;}

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
            this.folders = JsonSerializer.Deserialize<Folders>(jsonString);
        }

    }
}