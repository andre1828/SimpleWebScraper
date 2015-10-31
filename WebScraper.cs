using System.Collections.Generic;
using OpenQA.Selenium;
using SimpleBrowser.WebDriver;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SimpleWebScraper
{
    class WebScraper
    {
        public static List<string> FileLinks = new List<string>();
        public static bool images, audios, videos, documents;

        public void Seek(string url, string pathToSave)
        {

            /*Creates a SimpleBrowserDriver object and uses Navigate.GoToUrl() to access the given address*/
            IWebDriver browser = new SimpleBrowserDriver();
            browser.Navigate().GoToUrl(url);

            /*Gets page source*/
            string pageSource = browser.PageSource;


            /*Seek for image links if "Images" checkbox is checked*/
            if (images)
            {
                MatchCollection imageLinks = SeekImages(pageSource);
                /*Gets the value of all match objects and adds to the ListOfLinks*/
                FileLinks = FixLinks(url, imageLinks.Cast<Match>().Select(match => match.Value).ToList());
            }
            /*Seek for video links if "videos" checkbox is checked*/
            /*Focused on vimeo*/
            if (videos)
            {
                MatchCollection videoLinks = SeekVideos(pageSource);
                FileLinks = videoLinks.Cast<Match>().Select(match => match.Value).ToList();
            }


            /*Creates Downloader object and uses DownloadList() to download all items in ListOfLinks*/
            Downloader downloader = new Downloader();
            downloader.DownloadList(FileLinks, pathToSave);
        }

        public MatchCollection SeekImages(string pageSource)
        {
            /*Checks the page source for matches against Regex to find image links*/
            MatchCollection matches = Regex.Matches(pageSource, "(http:)?/+(\\S+?)\\.(jpg|png|gif)");    /* working regex "http://(\\S+?)\\.(jpg|png|gif)"   */
            /*IMPLEMENT MORE EFFICIENT REGEX*/
            return matches;
        }

        public MatchCollection SeekVideos(string pageSource)
        {
            /*Checks the page source for matches against Regex to find video links*/
            Match test = Regex.Match(pageSource, "(https://)\\S+.mp4");
            MessageBox.Show(test.Value);
            MatchCollection matches = Regex.Matches(pageSource, "https://.+.mp4");
            return matches;
        }

        public MatchCollection SeekPageLinks(string pageSource)
        {
            /*Checks the page source for matches against Regex to find links for other pages*/
            MatchCollection matches = Regex.Matches(pageSource, "/\\S+\\.html");
            return matches;

        }

        /*Some ridiculous attempt to handle incomplete file links*/
        public List<string> FixLinks(string Pagelink, List<string> fileLinks)
        {
            string domain = string.Empty;
            if (Pagelink.Contains(".html"))
            {
                /*Extracts domain*/
                domain = Regex.Match(Pagelink, "(\\.com|\\.br|\\.net)").ToString();
                /*Erases part of url leaving the start */
                Pagelink = Regex.Replace(Pagelink, "((\\.com|\\.br|\\.net)/.+\\.html)", string.Empty);
            }

            StreamWriter FilelinksTest = new StreamWriter(@"C:\Users\Avell G1511 MAX\Desktop\FilelinksTest.txt");
            for (int i = 0; i < fileLinks.Count; i++)
            {
                if (!fileLinks[i].Contains("http:"))
                {
                    fileLinks[i] = Pagelink + domain + fileLinks[i];
                    FilelinksTest.WriteLine(fileLinks[i]);
                }
            }
            return fileLinks;
        }

    }
}
