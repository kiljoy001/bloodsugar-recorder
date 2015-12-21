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
using System.Windows.Forms.DataVisualization.Charting;


namespace bloodsugar_recorder
{
    public partial class Form1 : Form
    {
        //initalizing a new ordered dictionary with 2 strings with date stored as OLE Automation date (ToOADate() method)
        OrderedDictionary resultStore = new OrderedDictionary();

        //orignal from stackoverflow: http://stackoverflow.com/questions/13478607/parse-text-file-into-dictionary
        public void ReadIt()
        {
            //Clear the dictionary first
            resultStore.Clear();
            // Open the file into a streamreader
            using (System.IO.StreamReader sr = new System.IO.StreamReader("bloodsugar.txt"))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    string splitMe = sr.ReadLine();
                    string[] OADatetxt = splitMe.Split(new char[] { ' ' }); //Split at space
                    //Check if there is a duplicate key in the dictionary and then overwrite the value if it exists
                    //if (resultStore.Contains(OADatetxt[0].Trim()))
                    //{
                    //    //updates the duplicate with a new value
                    //    resultStore[OADatetxt[0].Trim()] = OADatetxt[1].Trim();
                    //}
                    //else
                    //{ 
                    //Adding the split string into the dictionary by parsing it as a double (OADate is a double) and the sugar measurement as 
                    //a string.
                    resultStore.Add(double.Parse(OADatetxt[0].Trim()), OADatetxt[1].Trim());
                    //}
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
                //create a variable to store the test result, makes sure that it is a number being entered
                int testResult = int.Parse(txtResult.Text);

                //Add testDate value to the dictionary
                resultStore.Add(date, testResult);
                
                
                //open file & append
                sw = File.AppendText(@"bloodsugar.txt");
                
                //write to
                sw.WriteLine(date + " " + testResult);
                MessageBox.Show("Entry Saved!");
                
                
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
            DateTime lastYear = DateTime.Now.AddYears(-120);
            DateTime thisDate = DateTime.Now;
            chrBloodS.ChartAreas.Add("Blood Sugar Levels");
            //declaring the Xvalue type to be date time
            chrBloodS.Series[0].XValueType = ChartValueType.DateTime;
            //Chart's minimun date set to 120 years before todays date
            chrBloodS.ChartAreas["Date"].AxisX.Minimum = lastYear.ToOADate();
            chrBloodS.ChartAreas["Date"].AxisX.Maximum = thisDate.ToOADate();
            foreach (System.Collections.DictionaryEntry pair in resultStore)
            {
                //creating a new datetime object that takes the key from the dictionary and then converts it to a string to be parsed as a double to be used for fromOADate (total hack).
                System.DateTime x = DateTime.FromOADate(double.Parse(pair.Key.ToString()));
                DataPoint chartData = new DataPoint()
                {
                    AxisLabel = "Series",
                    YValues = new double[] { (int)pair.Value }
                };

            }
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
