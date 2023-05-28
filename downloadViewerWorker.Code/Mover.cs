using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace downloadViewerWorker;

public class Mover
{
    public ConfigLoader configLoader {get;}
    public Viewer viewer{get;}
    public Mode mode{get;}

    public Mover(Viewer viewer, ConfigLoader configLoader, Mode mode)
    { 
        this.viewer = viewer;
        this.configLoader = configLoader;
        this.mode = mode;
    }

    
}
