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
    public ILogger _logger{get;}

    public Mover(Viewer viewer, ConfigLoader configLoader, Mode mode, ILogger _logger)
    { 
        this.viewer = viewer;
        this.configLoader = configLoader;
        this.mode = mode;
        this._logger = _logger;
    }

    public void relocateFiles()
    {
        if(mode.Equals(Mode.productive))
        {
            //move files
        }
        else if(mode.Equals(Mode.debug))
        {
            // shows where it would move files and gives additional Informations
        }
        else
        {
            // Don't manipulate files - write only where the files would be moved
        }
    }

    public void moverCountFiles()
    {
        if (viewer.countFiles() > 0) 
        { 
            foreach (FileInfo file in viewer.fileInfo)
            {
                _logger.LogInformation(file.ToString());
            }
        }

        _logger.LogInformation(cit.showConfig());
    }
}
