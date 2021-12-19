using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
    public partial class Indeed : Form
    {
        public Indeed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            try
            {
                if (jobSearch.Text != "")
                {
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://be.indeed.com/");
                    var what = driver.FindElement(By.Id("text-input-what"));
                    what.SendKeys(jobSearch.Text);
                    var where = driver.FindElement(By.Id("text-input-where"));
                    where.SendKeys(locatieSearch.Text);
                    what.Submit();


                    // Afgelopen 3 dagen selecteren
                    driver.FindElement(By.ClassName("yosegi-FilterPill-dropdownPillContainer")).Click();
                    driver.FindElement(By.PartialLinkText("Afgelopen 3 dagen")).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(By.ClassName("popover-x-button-close")).Click();

                    var jobs = driver.FindElements(By.ClassName("resultWithShelf"));
                    Joblist.Items.Clear();
                    foreach (var job in jobs)
                    {
                        String jobTitel = job.FindElement(By.ClassName("jobTitle")).Text;
                        if (jobTitel.StartsWith("nieuw"))
                            jobTitel = jobTitel.Remove(0, 5);
                        String jobBedrijf = job.FindElement(By.ClassName("companyName")).Text;
                        String jobLocatie = job.FindElement(By.ClassName("companyLocation")).Text;
                        String jobLink = driver.FindElement(By.ClassName("sponsoredJob")).GetAttribute("href").ToString();

                        Joblist.Items.Add("Titel: " + jobTitel);
                        Joblist.Items.Add("Bedrijf: " + jobBedrijf);
                        Joblist.Items.Add("Locatie: " + jobLocatie);
                        Joblist.Items.Add("Link: " + jobLink);
                        Joblist.Items.Add("");

                        var newLine = string.Format("{0},{1},{2},{3}", jobTitel, jobBedrijf, jobLocatie, jobLink);
                        csv.AppendLine(newLine);
                    }
                    File.WriteAllText(@"D:\jobs.csv", csv.ToString());
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Geen job ingegeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geen jobs gevonden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
            
        }
    }
}
