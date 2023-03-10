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
        //output += configToString("lol");
        return output;
    }

    // should i import whole configloader in getFileEnding-Function
    public string getFileEndings(string folder)
    {
        string output = "";
        //foreach()

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
        
        //error - check if config-loader-part is correct
        output += msgToString("Savelocation: " + configLoader.folders.folder.ElementAt(0).name);
        /*
        if(folder.Equals("picture"))
        {
            output += msgToString("Savelocation: " + configLoader.folders.folder[0].name);
            output += msgToString("Fileending");
            foreach(string ende in configLoader.configElementFolder.picture.ending)
            {
                output += msgToString(ende);
            }
        }
        else if(folder.Equals("document"))
        {
            output += msgToString("Savelocation: " + configLoader.configElementFolder.document.savelocation);
            foreach(string ende in configLoader.configElementFolder.document.ending)
            {
                output += msgToString(ende);
            }
        }
        else if(folder.Equals("music"))
        {
            output += msgToString("Savelocation: " + configLoader.configElementFolder.music.savelocation);
            //Add fileendings
            foreach(string ende in configLoader.configElementFolder.music.ending)
            {
                output += msgToString(ende);
            }
        }
        else if(folder.Equals("download"))
        {
            output += msgToString("Savelocation: " + configLoader.configElementFolder.download.savelocation);
            //Add fileendings
            foreach(string ende in configLoader.configElementFolder.download.ending)
            {
                output += msgToString(ende);
            }
        }
        else
        {
            output += msgToString("Savelocation for " + folder + " not found.");
        }
        */
        return output;
    }
}