namespace ViewerNamespace;

public class Viewer
{
    public string folder{get;}
    public DirectoryInfo directoryInfo{get;}
    public FileInfo[] fileInfo{get;}

    public Viewer(string pathString)
    {
        string folder = "";

        if(Directory.Exists(pathString))
        {
            folder = pathString;
            directoryInfo = new DirectoryInfo(folder);
            fileInfo = directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly);
        }
    }

    public string getFolder(){
        return folder;
    }

    public int countFiles(){
        if (fileInfo != null)
        {
            return fileInfo.Length;
        }
        else
        { 
            return 0;
        }
    }
}