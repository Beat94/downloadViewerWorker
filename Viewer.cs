namespace ViewerNamespace;

public class Viewer
{
    string folder{get;}
    DirectoryInfo directoryInfo{get;}
    FileInfo[] fileInfo{get;}
    public Viewer(string pathString)
    {
        folder = "";

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
        return fileInfo.Length;
    }
}