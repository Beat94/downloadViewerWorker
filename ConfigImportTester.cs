namespace ViewerNamespace;

public class ConfigImportTester{
    public ConfigLoader configLoader{get;set;}
    public ConfigImportTester(ConfigLoader configLoader){
        this.configLoader = configLoader;
    }

    public string showConfig(){
        string output = "";
        output += "picture \n";
        output += "SaveLocation: " + configLoader.configElementFolder.picture.savelocation;
        return output;
    }

    public void loadConfigFrom(){

    }
}