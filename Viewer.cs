namespace ViewerNamespace;

public class Viewer
{
    string folder{get;}
    public Viewer(string foldername)
    {
        folder = foldername;
    }

    public string getFolder(){
        return folder;
    }
}