using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study_Forms_App
{
    public partial class YouTube : Form
    {
        public YouTube()
        {
            InitializeComponent();
        }

        private void btnYTSearch_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            try
            {
                if (txtYTSearch.Text != "")
                {
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.youtube.com/");
                    Thread.Sleep(3000);

                    //Accepteren van cookies
                    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[5]/div[2]/ytd-button-renderer[2]/a")).Click();
                    var search = driver.FindElement(By.XPath("//input[@id=\"search\"]"));
                    search.Click();
                    search.SendKeys(txtYTSearch.Text);
                    search.Submit();

                    // Sorteren op nieuwste
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[1]/div[2]/ytd-search-sub-menu-renderer/div[1]/div/ytd-toggle-button-renderer/a/tp-yt-paper-button/yt-icon")).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[1]/div[2]/ytd-search-sub-menu-renderer/div[1]/iron-collapse/div/ytd-search-filter-group-renderer[5]/ytd-search-filter-renderer[2]/a/div/yt-formatted-string")).Click();
                    Thread.Sleep(500);

                    var videos = driver.FindElements(By.Id("dismissible"));
                    int i = 0;
                    lbResults.Items.Clear();
                    foreach (var video in videos)
                        {
                            lbResults.Items.Add(video.FindElement(By.CssSelector("a#video-title")).Text);
                            lbResults.Items.Add(video.FindElement(By.CssSelector("a#video-title")).GetAttribute("href").ToString());
                            lbResults.Items.Add("");
                            var newLine = string.Format("{0},{1}", video.FindElement(By.CssSelector("a#video-title")).Text, video.FindElement(By.CssSelector("a#video-title")).GetAttribute("href").ToString());
                            csv.AppendLine(newLine);
                            i++;
                            if (i == 5)
                            {
                                break;
                            }
                        }
                    File.WriteAllText(@"D:\youtube.csv", csv.ToString());
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Geen zoekterm ingegeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geen videos gevonden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
