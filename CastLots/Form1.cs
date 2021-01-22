using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastLots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string techName = "";
        int number;
        string[] technoList = {"Html","Css","Javascript","ReactJs","VueJs","TypeScript","Boostrap","Jquery","Ajax","ElasticSearch","Redis","Docker","OOP","EntityFramework","Linq","Postgresql",".NetMVC"
                ,"ConsoleApp","Web Servis,Api,WCF","Mikroservis Mimarisi","3.Party Component","MSSQL","TSQL","SAPCrystalReport","AWS",".Net Core","Rest Api","SOAP","JSON","XML","Protractor","Design Patterns","Algorithms","Selenium","Apium"
        };

        private void buttonStart_Click(object sender, EventArgs e)
        {

            Random rndNumber = new Random();
            number = rndNumber.Next(0, 35);
            
            for (int i = 0; i < technoList.Length; i++)
            {
                techName = technoList[number];
                labelText.Text = techName;
            }
        }
    }
}
