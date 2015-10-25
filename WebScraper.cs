using System.Collections.Generic;
using OpenQA.Selenium;
using SimpleBrowser.WebDriver;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleWebScraper
{
    class WebScraper
    {
        public static List<string> ListOfLinks = new List<string>();

        public void Seek(string url, string pathToSave)
        {
            
            /*Creates a SimpleBrowserDriver object and uses Navigate.GoToUrl() to access the given address*/
            IWebDriver browser = new SimpleBrowserDriver();
            browser.Navigate().GoToUrl(url);


            /*Gets page source*/
            string pageSource = browser.PageSource;

            /*Seek for image links specifically*/
            MatchCollection imageLinks = SeekImages(pageSource);

            /*Gets the value of all match objects and adds to the ListOfImagesLink*/
            ListOfLinks = imageLinks.Cast<Match>().Select(match => match.Value).ToList();

            /**/
            Downloader downloader = new Downloader();
            downloader.DownloadList(ListOfLinks, pathToSave);
        }

        public MatchCollection SeekImages(string pageSource)
        {
            /*Checks the page source for matches against Regex to find image links*/
            MatchCollection matches = Regex.Matches(pageSource, "http://(\\S+?)\\.(jpg|png|gif)"); // working regex : "http://(\\S+?)\\.(jpg|png|gif)"
            return matches;
        }
    }
}
