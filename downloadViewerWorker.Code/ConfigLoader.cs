using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;

namespace downloadViewerWorker;

public class ConfigLoader
{
    public bool error{get;}
    public string errorMsg{get;}
    public Folders? folders {get; set;}
    private ILogger _logger;

    public ConfigLoader(string jsonFileName, ILogger _logger)
    {
        this._logger = _logger;
        try
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
        catch(Exception e)
        {
            _logger.LogError(e.Message);
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