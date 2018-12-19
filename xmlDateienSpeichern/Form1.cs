using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace xmlDateienSpeichern
{
    public partial class Form1 : Form
    {
     
        private int icounter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Daten daten = new Daten();
                daten.PRUFNAME = "TEST1";
                daten.PRUFAUTOMAT = "Maschine1";
                daten.FERTIGUNGSAUFTRAG = "2018-11-22";
                daten.STATUS = "Gültig";
                icounter++;
                daten.DATUM= System.DateTime.Now.ToString("yyMMd")+Convert.ToString(icounter);
                string path = @"C:\Users\Admin\Documents\Visual Studio 2015\Projects\xmlDateienSpeichern\" + daten.DATUM + ".xml";
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    File.Create(path).Dispose();
                    xmlSave.SaveData(daten, path);

                }

            
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString(),"Fehler");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
