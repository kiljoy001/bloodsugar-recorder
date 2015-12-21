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
using System.Collections.Specialized;

namespace bloodsugar_recorder
{
    public partial class Form1 : Form
    {
        //initalizing a new ordered dictionary with 2 strings with date stored as OLE Automation date (ToOADate() method)
        OrderedDictionary resultStore = new OrderedDictionary();

        //orignal from stackoverflow: http://stackoverflow.com/questions/13478607/parse-text-file-into-dictionary
        public void ReadIt()
        {
            // Open the file into a streamreader
            using (System.IO.StreamReader sr = new System.IO.StreamReader("bloodsugar.txt"))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    string splitMe = sr.ReadLine();
                    string[] OADatetxt = splitMe.Split(new char[] { ' ' }); //Split at space
                    //Adding the split string into the dictionary by parsing it as a double (OADate is a double) and the sugar measurement as 
                    //a string.
                  
                    resultStore.Add(double.Parse(OADatetxt[0].Trim()), OADatetxt[1].Trim());
            
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lblEnterData_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try {
                //create a variable to store the value of the date & time
                double date = DateTime.Now.ToOADate();
                
                
                //Add testDate value to the dictionary, parse input form the textbox to make sure that it is number
                resultStore.Add(date, int.Parse(txtResult.Text).ToString());
                
                
                //open file & append
                sw = File.AppendText(@"bloodsugar.txt");
                //iterate and write to the file
                // this is buggy - seems to produce duplicates, don't need to loop just need to add the last item in the dictionary
                // to the file.
                foreach (System.Collections.DictionaryEntry pair in resultStore)
                {
                    sw.WriteLine(pair.Key +" "+ pair.Value);
                    MessageBox.Show("Entry Saved!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                // close file
                if (sw != null)
                    sw.Close();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            ReadIt();

        }

        private void btnShowDict_Click(object sender, EventArgs e)
        {
            ReadIt();
            foreach (System.Collections.DictionaryEntry pair in resultStore)
            {
                //iterates over entire dictionary and displays all test results to a text box
                listBResult.Items.Add(DateTime.FromOADate(double.Parse(pair.Key.ToString())) + " " + pair.Value + " " + "mg/l" + "\n");
            }
        }
    }
}
