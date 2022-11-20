namespace ViewerNamespace;

public class Viewer
{
    string folder{get;}
    public Viewer(string pathString)
    {
        folder = "";

        if(Directory.Exists(pathString))
        {
            folder = pathString;
        }
        
    }

    public string getFolder(){
        return folder;
    }
}