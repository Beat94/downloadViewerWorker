using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace downloadViewerWorker.Code
{
    public class Mover
    {
        ConfigLoader configLoader;
        Viewer viewer;

        public Mover(Viewer viewer, ConfigLoader configLoader)
        { 
            this.viewer = viewer;
            this.configLoader = configLoader;
        }
    }
}
