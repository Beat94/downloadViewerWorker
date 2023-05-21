using System.Text.Json;
using System.Text.Json.Serialization;

namespace downloadViewerWorker;

public class ConfigLoader
{
    public bool error{get;}
    public string errorMsg{get;}
    public Folders? folders {get; set;}

    public ConfigLoader(string jsonFileName)
    {
        if(string.IsNullOrEmpty(File.ReadAllText(jsonFileName)))
        {
            this.error = true;
            this.errorMsg = "ConfigFile is null or empty";
        }
        else
        {
            string jsonString = File.ReadAllText(jsonFileName);
            this.folders = JsonSerializer.Deserialize<Folders>(jsonString);
            this.errorMsg = "";
        }
    }

    public string GetDownloadFolder()
    {
        string output = "";

        foreach (Folder folder in folders.folders)
        {
            if (folder.name.ToLower() == "downloads" || folder.name.ToLower() == "download")
            {
                output = folder.settings.savelocation;
            }
        }

        return output;
    }

    public string GetDownloadLink()
    {
        string output = "";

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