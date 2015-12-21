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

                    //orginal code - don't need it
                    //if (bananaSplits.Length < 2) // If we get less than 2 results, discard them
                    //    continue;
                    //else if (bananaSplits.Length == 2) // Easy part. If there are 2 results, add them to the dictionary
                    //    resultStore.Add(bananaSplits[0].Trim(), bananaSplits[1].Trim());
                    //else if (bananaSplits.Length > 2)
                    //    SplitItGood(splitMe, allTheThings); // Hard part. If there are more than 2 results, use the method below.
                }
            }
        }

        //Not needed either.
        //public void SplitItGood(string stringInput, Dictionary<string, string> dictInput)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    List<string> fish = new List<string>(); // This list will hold the keys and values as we find them
        //    bool hasFirstValue = false;

        //    foreach (char c in stringInput) // Iterate through each character in the input
        //    {
        //        if (c != ':') // Keep building the string until we reach a colon
        //            sb.Append(c);
        //        else if (c == ':' && !hasFirstValue)
        //        {
        //            fish.Add(sb.ToString().Trim());
        //            sb.Clear();
        //            hasFirstValue = true;
        //        }
        //        else if (c == ':' && hasFirstValue)
        //        {

        //            // Below, the StringBuilder currently has something like this:
        //            // "    235235         Some Text Here"
        //            // We trim the leading whitespace, then split at the first sign of a double space
        //            string[] bananaSplit = sb.ToString()
        //                                     .Trim()
        //                                     .Split(new string[] { "  " },
        //                                            StringSplitOptions.RemoveEmptyEntries);

        //            // Add both results to the list
        //            fish.Add(bananaSplit[0].Trim());
        //            fish.Add(bananaSplit[1].Trim());
        //            sb.Clear();
        //        }
        //    }

        //    fish.Add(sb.ToString().Trim()); // Add the last result to the list

        //    for (int i = 0; i < fish.Count; i += 2)
        //    {
        //        // This for loop assumes that the amount of keys and values added together
        //        // is an even number. If it comes out odd, then one of the lines on the input
        //        // text file wasn't parsed correctly or wasn't generated correctly.
        //        dictInput.Add(fish[i], fish[i + 1]);
        //    }
        //}

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
                resultStore.Add(date, int.Parse(txtResult.Text).ToString() + " " + "mg/l");
                
                
                //open file & append
                sw = File.AppendText(@"bloodsugar.txt");
                //iterate and write to the file
                foreach (KeyValuePair<double, string> pair in resultStore)
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
                //3. close
                if (sw != null)
                    sw.Close();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            ReadIt();

        }
    }
}
