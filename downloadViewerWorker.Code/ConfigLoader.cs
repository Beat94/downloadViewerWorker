using System.Text.Json;
using System.Text.Json.Serialization;

namespace ViewerNamespace;

public class ConfigLoader
{
    public bool error{get;}
    public String errorMsg{get;}
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
            String jsonString = File.ReadAllText(jsonFileName);
            this.folders = JsonSerializer.Deserialize<Folders>(jsonString);
        }

    }

    public String GetDownloadLink()
    {
        String output = "";

        foreach (Folder folder in folders.folders) 
        {
            if (folder.name.ToLower().Equals("downloads") || folder.name.ToLower().Equals("download"))
            {
                output = folder.settings.savelocation;
            }
        }
        
        return output;
    }
}