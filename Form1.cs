using OpenQA.Selenium;
using SimpleBrowser.WebDriver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_Text();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //happens as soon as the user starts typing
        }

        private void textBox_Text()
        {
            //IMPLEMENT TEXTBOX WATERMARK 
            textBox1.Text = "Paste your URL here...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebScraper ws = new WebScraper();
            IWebDriver browser = new SimpleBrowserDriver();
            try
            {
                browser.Navigate().GoToUrl(textBox1.Text);
            }
            catch (System.UriFormatException)
            {

                MessageBox.Show("That is not a valid URL!");
                return;
            }
            if (Directory.Exists(textBox2.Text))
            {
                if (Images.Checked || Audios.Checked || Videos.Checked || Documents.Checked)
                {
                    ws.Seek(textBox1.Text, textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Please choose at least one filter option!");
                }
            }
            else
            {
                MessageBox.Show("invalid path !");
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowserdialog = new FolderBrowserDialog();
            folderbrowserdialog.Description = "Please select a folder to save the files";
            folderbrowserdialog.ShowDialog();
            textBox2.Text = folderbrowserdialog.SelectedPath + "\\";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Images_CheckedChanged(object sender, EventArgs e)
        {
            if (Images.Checked) { WebScraper.images = true; }
        }

        private void Videos_CheckedChanged(object sender, EventArgs e)
        {
            if (Videos.Checked) { WebScraper.videos = true; }
        }

        private void Audios_CheckedChanged(object sender, EventArgs e)
        {
            if (Audios.Checked) { WebScraper.audios = true; }
        }

        private void Documents_CheckedChanged(object sender, EventArgs e)
        {
            if (Documents.Checked) { WebScraper.documents = true; }
        }
    }

  
}
