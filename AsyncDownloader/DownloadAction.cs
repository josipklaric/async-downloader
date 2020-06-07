using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDownloader
{
    public class DownloadAction
    {
        public DownloadAction(string fileToDownload, string fileRepository)
        {

        }

        public ActionType ActionKind { get; set; }

        public string FileToDownload { get; set; }

        public string FileRepository { get; set; }


    }
}
