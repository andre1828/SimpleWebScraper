using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
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
                    string FileName = link.Remove(0, link.LastIndexOf("/"));
                    WebClient wc = new WebClient();
                    wc.DownloadFileTaskAsync(new System.Uri(link), pathToSave + FileName);
                }


                DialogResult dialog = MessageBox.Show("Want to open folder with images?", "Done :D", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", pathToSave);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Found nothing _(._.)_");
            }


        }

    }
}
