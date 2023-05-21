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

    
}
