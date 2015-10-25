using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebScraper
{
    class Downloader
    {
        public void DownloadList(List<String> list, string pathToSave)
        {
            if (list.Count > 0)
            {
                foreach (string link in list)
                {
                    WebClient wc = new WebClient();
                    string FileName = link.Remove(0, link.LastIndexOf("/"));
                    wc.DownloadFileTaskAsync(link, pathToSave + FileName);
                }
                MessageBox.Show("Done :D");
            }
            else
            {
                MessageBox.Show("Found nothing _(._.)_");
            }
        }  
    }
}
