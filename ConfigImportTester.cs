namespace ViewerNamespace;

public class ConfigImportTester{
    public ConfigLoader configLoader{get;set;}
    public ConfigImportTester(ConfigLoader configLoader){
        this.configLoader = configLoader;
    }

    public string showConfig(){
        string output = "";
        output += configToString("picture");
        output += configToString("document");
        output += configToString("music");
        output += configToString("download");
        output += configToString("lol");
        return output;
    }

    private string msgToString(string msg)
    {
        return msg + "\n";
    }

    private string configToString(string folder)
    {
        string output = "";
        output += msgToString(folder);

        output += folder.Equals("picture") ? output += msgToString("Savelocation: " + configLoader.configElementFolder.picture.savelocation) : "" ;
        output += folder.Equals("document") ? output += msgToString("Savelocation: " + configLoader.configElementFolder.document.savelocation) : "";
        output += folder.Equals("music") ? output += msgToString("Savelocation: " + configLoader.configElementFolder.music.savelocation) : "";
        output += folder.Equals("download") ? output += msgToString("Savelocation: " + configLoader.configElementFolder.download.savelocation) : "";
        
        output += !folder.Equals("picture") && !folder.Equals("document") && !folder.Equals("music") && !folder.Equals("download") ? output += msgToString("Savelocation for " + folder + " not found.") : "";
                
        return output;
    }
}