using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace downloadViewerWorker;

public class Mover
{
    ConfigLoader configLoader;
    Viewer viewer;
    Mode mode;

    public Mover(Viewer viewer, ConfigLoader configLoader, Mode mode)
    { 
        this.viewer = viewer;
        this.configLoader = configLoader;
        this.mode = mode;
    }

    public void relocateFiles()
    {
        if(mode.equals(Mode.productive))
        {
            //move files
        }
        else if(mode.equals(Mode.debug))
        {
        
        }
        else
        {
            //Don't manipulate files - write only where the files would be moved
        }
    }
}
