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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            try
            {
                if (txtMerk.Text != "")
                {
                    lbResult.Items.Clear();
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.2dehands.be/");
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/button[1]")).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div[3]/div/form/div[2]/div[1]/div")).Click();
                    driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div[3]/div/form/div[2]/div[1]/div/select/option[5]")).Click();
                    var searchbar = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div[3]/div/form/div[1]/div/div/input"));
                    string zoekTerm = txtMerk.Text + " " + txtModel.Text;
                    searchbar.SendKeys(zoekTerm);
                    searchbar.Submit();
                    Thread.Sleep(500);

                    Boolean change = false;
                    //Bouwjaar min en max ingeven
                    if (txtBJV.Text != "")
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[4]/div/input[1]")).SendKeys(txtBJV.Text);
                        change = true; ;
                    }
                    if (txtBJT.Text != "")
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[4]/div/input[2]")).SendKeys(txtBJT.Text);
                        change = true; ;
                    }
                    if (txtPV.Text != "")
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[3]/div/input[1]")).SendKeys(txtPV.Text);
                        change = true;

                    }
                    if (txtPT.Text != "")
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[3]/div/input[2]")).SendKeys(txtPT.Text);
                        change = true;
                    }
                    if (change)
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[3]/div/button")).Click();
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/aside/div[1]/div[4]/div/button")).Click();
                    Thread.Sleep(1000);


                    var autos = driver.FindElements(By.ClassName("mp-Listing"));
                    lbResult.Items.Clear();
                    foreach (var auto in autos)
                    {
                        String titel = auto.FindElement(By.ClassName("mp-Listing-title")).Text;
                        String prijs = auto.FindElement(By.ClassName("mp-Listing-price")).Text;
                        String link = auto.FindElement(By.ClassName("mp-Listing-coverLink")).GetAttribute("href").ToString();

                        /*Joblist.Items.Add("Titel: " + jobTitel);
                        Joblist.Items.Add("Bedrijf: " + jobBedrijf);
                        Joblist.Items.Add("Locatie: " + jobLocatie);
                        //Joblist.Items.Add("Link: " + jobLink);*/
                        lbResult.Items.Add(prijs + "\t" + titel);
                        lbResult.Items.Add(link);
                        lbResult.Items.Add(" ");

                        //Toevoegen aan csbv bestand
                        var newLine = string.Format("{0},{1},{2}", prijs, titel, link);
                        csv.AppendLine(newLine);
                    }
                    File.WriteAllText(@"D:\autos.csv", csv.ToString());
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Geen merk ingegeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geen auto's gevonden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
