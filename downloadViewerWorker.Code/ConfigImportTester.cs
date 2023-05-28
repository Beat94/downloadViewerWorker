namespace downloadViewerWorker;

public class ConfigImportTester{
    public ConfigLoader configLoader{get;set;}
    public ConfigImportTester(ConfigLoader configLoader){
        this.configLoader = configLoader;
    }

    public string showConfig(){
        string output = "";

        for(int index = 0; index < configLoader.folders.folders.Count; index++)
        {
            output += configToString(index);
        }

        return output;
    }

    // should i import whole configloader in getFileEnding-Function
    public string getFileEndings(int indexFolder)
    {
        string output = "";
        output += configLoader.folders.folders[indexFolder].settings.ending;

        return output;
    }

    private string msgToString(string msg)
    {
        return msg + "\n";
    }

    private string configToString(int indexFolder)
    {
        string output = "";
        output += msgToString(configLoader.folders.folders[indexFolder].name);
        output += msgToString("Savelocation: " + configLoader.folders.folders[indexFolder].settings.savelocation);
        
        return output;
    }
}