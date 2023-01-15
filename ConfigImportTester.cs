namespace ViewerNamespace;

public class ConfigImportTester{
    public ConfigLoader configLoader{get;set;}
    public ConfigImportTester(ConfigLoader configLoader){
        this.configLoader = configLoader;
    }

    public void showConfig(){
        Console.WriteLine("picture:");
        Console.WriteLine("SaveLocation: " + configLoader.configElementFolder.picture.savelocation);
    }

    public void loadConfigFrom(){

    }
}