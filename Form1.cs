using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapsBeginner
{
    public partial class Form1 : Form
    {
        /* TODO: Chris
         * Issue - c# you seem to be using an unsupported browser
         * Fix - To fix this, it seems there needs to be a registry change. We need to do this
         * progmatically, mostly so I can get practice with c# programming.
         */
        String page = "https://www.google.com/maps/place/8407+River+Park+Rd,+Bowie,+MD+20715/@39.004516,-76.7518843,17z/data=!3m1!4b1!4m5!3m4!1s0x89b7e93b757e2835:0x8bff0b5a04cc610e!8m2!3d39.0045119!4d-76.7496903";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitApplication exitApplication = new ExitApplication();
            exitApplication.SaveData();
            exitApplication.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            setup_Page();
        }

        private void setup_Page()
        {
            browser_Google.Navigate(page);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setup_Page();
        }

        // Set a registry DWORD value.
        private void SetRegistryDword(string key_name, string value_name, int value)
        {
            // Open the key.
            RegistryKey key =
                Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey(key_name,
                    RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the desired value.
            key.SetValue(value_name, value, RegistryValueKind.DWord);

            key.Close();
        }
    }
    class MyBrowser
    {
        String page = "";

        public string Page { get => page; set => page = value; }
    }
    class XMLData
    {
        public void Add()
        {

        }
        public void Remove()
        {

        }
        public string Retrieve()
        {
            return "test";
        }
    }
    public class ExitApplication
    {
        public void SaveData()
        {

        }
        public void Exit()
        {
            Application.Exit();
        }
    }
}
