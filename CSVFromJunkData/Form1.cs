using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace CSVFromJunkData
{
    public partial class Container : Form
    {
        string _source = "";
        string _destination = "";
        string _fileName = "";

        public Container()
        {
            _fileName = "\\outputFile.csv";
            InitializeComponent();
        }

        /// <summary>
        /// Takes the input data and parses it from tab delimited to
        /// comma delimited
        /// </summary>
        /// <returns>whether or not the file was successfully created</returns>
        protected bool TabDelimCSV()
        {

            try
            {
                int cols = 0;
                Int32.TryParse(txtCols.Text, out cols);

                StreamReader txt;
                StreamWriter csv;

                txt = File.OpenText(_source);
                csv = File.CreateText(_destination + _fileName);

                StringBuilder sb = new StringBuilder();

                try
                {
                    string val = "";
                    string[] dataVals = new string[cols];

                    while (txt.Peek() > -1)
                    {
                        val = txt.ReadLine().Trim();

                        if (!string.IsNullOrWhiteSpace(val))
                        {
                            dataVals = val.Split(cbSpaces.Checked ? ' ' : '\t');

                            for (int i = 0; i < dataVals.Length - 1; i++)
                            {
                                if (!string.IsNullOrEmpty(dataVals[i]))
                                {
                                    sb.Append(FormatVals(dataVals[i]) + ',');
                                }
                            }
                        }

                        sb.Append(FormatVals(dataVals[dataVals.Length - 1]));
                        csv.WriteLine(sb.ToString());
                        sb.Remove(0, sb.Length);
                    }

                    return true;
                }
                catch (IndexOutOfRangeException e)
                {
                    MessageBox.Show("CSV Builder has encountered an error: \n" + e.Message);
                    return false;
                }
                finally
                {
                    csv.Close();
                    txt.Close();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("An error occured while writing the file: \n" + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Takes the input data and builds column delimited rows
        /// </summary>
        /// <returns>whether or not the file was successfully created</returns>
        protected bool MakeCSV()
        {
            int cols = 0;
            Int32.TryParse(txtCols.Text, out cols);

            StreamReader txt;
            StreamWriter csv;

            try
            {
                txt = File.OpenText(_source);
                csv = File.CreateText(_destination + _fileName);
                StringBuilder sb = new StringBuilder();

                int fileLength = 0;

                while (txt.ReadLine() != null)
                {
                    fileLength++;
                }

                txt.BaseStream.Position = 0;
                txt.DiscardBufferedData();

                try
                {
                    string val = "";
                    string[] dataVals = new string[fileLength];

                    int index = 0;

                    while (txt.Peek() > -1)
                    {
                        val = txt.ReadLine().Trim();

                        if (!string.IsNullOrWhiteSpace(val))
                        {
                            val = FormatVals(val);
                            dataVals[index] = val;
                            index++;
                        }
                    }

                    string[] modVals = new string[index];
                    Array.Copy(dataVals, modVals, index);

                    for (int i = 0; i < modVals.Length - 1; i = i + (cols))
                    {
                        for (int j = 0; j < cols - 1; j++)
                        {
                            sb.Append(modVals[i + j] + ',');
                        }

                        sb.Append(modVals[i + (cols - 1)]);
                        csv.WriteLine(sb.ToString());
                        sb.Remove(0, sb.Length);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    MessageBox.Show("It looks like this is the wrong number of columns! \n" + e.Message);
                    return false;
                }
                finally
                {
                    csv.Close();
                    txt.Close();
                }

                return true;
            }
            catch (IOException e)
            {
                MessageBox.Show("An error occured while writing the file: \n" + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Get the source file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSource_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialogSource.ShowDialog();

            if (res == DialogResult.OK)
            {
                _source = openFileDialogSource.FileName;
                txtSource.Text = _source;
            }
        }

        /// <summary>
        /// Get the destination folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult res = fbd.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtDestination.Text = fbd.SelectedPath;
                _destination = fbd.SelectedPath;
            }
          
        }

        /// <summary>
        /// If all the information is present, build the correct csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilename.Text))
            {
                _fileName = string.Format("\\{0}.csv", txtFilename.Text);
            }

            if (string.IsNullOrEmpty(_source) || string.IsNullOrEmpty(_destination))
            {
                MessageBox.Show("Please supply both a source and a destination");
            }
            else
            {
                if (rbNewLine.Checked)
                {
                    if (MakeCSV())
                    {
                        NotifyComplete();
                    }
                }
                else
                {
                    if (TabDelimCSV())
                    {
                        NotifyComplete();
                    }
                }
            }

        }

        private void NotifyComplete()
        {
            DialogResult dialog = MessageBox.Show("Do you want to open the file?", "Success", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Process.Start(_destination + _fileName);
            }
        }

        private string FormatVals(string val)
        {
            //If removing commas
            if (chRemoveComma.Checked)
            {
                val = val.Replace(",", "");
            }

            //If removing non-comma chars
            if (chRemove.Checked)
            {
                val = Regex.Replace(val, @"[^,\s\w]|_", "");
            }

            //If format as strings or not removing commas, but val has a comma
            if (chFormat.Checked || (!chRemoveComma.Checked && val.Contains(',')))
            {
                val = string.Format("\"{0}\"", val);
            }

            return val;
        }

    }//Class
}//Namespace
