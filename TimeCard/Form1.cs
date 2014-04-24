/* This application written and developed by Ryan Brown
 * and is free for public use and reuse.
 * 
 * ryan@freesimpleapps.com
 * 
 * This was developed using Microsoft Visual Studio. This is
 * the form logic.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TimeCard
{
    public partial class UI : Form
    {
        // Variables
        TimePunchHandler punch = new TimePunchHandler(); // This class will handle writing to the file
        String dirPath; // Holds the selected path
        bool isFirstEntry = true; // Returns false after the first entry is made
        String timeFormatter = "hh:mm tt"; // String to modify time display
        bool seconds, militaryTime; // Flags for seconds and 24 hour time

        public UI()
        {
            InitializeComponent();
        }

        // Open button
        private void button_fileOpen_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                dirPath = Path.GetFullPath(openFileDialog1.FileName); // Get path from browser window
                label_filePath.Text = "Path: " + dirPath; // Change label
                button_submit.Enabled = true; // Enable submit button
                textBox_entry.Focus(); // Move the cursor to the text box
            }

        }

        // Submit button - disabled until a file is opened
        private void button_submit_Click(object sender, EventArgs e)
        {
            String entry = textBox_entry.Text; // Holds the text from the text box

            // Object to handle writing to the file
            punch.addEntry(isFirstEntry, entry, dirPath, timeFormatter);

            label_success.Text = punch.displayEntry.Replace(";", " - "); // Format UI output
            textBox_entry.Clear(); // Clear the text box
            isFirstEntry = false; // Make sure that we are no longer on the first entry
        }

        // On form close:
        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dirPath != null) // Do not do this if no file was opened
            {
                // Use ";;" to mark EoF and start at next line
                System.IO.File.AppendAllText(dirPath, ";;" + System.Environment.NewLine);
            }
        }

        // 24 Hour check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (militaryTime) // Turn 24 hour time on
            {
                militaryTime = false;
                timeFormatter = timeFormatter.Replace("HH", "hh");
            }
            else // Turn 24 hour time off
            {
                militaryTime = true;
                timeFormatter = timeFormatter.Replace("hh", "HH");
            }
        }

        // Show seconds check box
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (seconds) // Disable seconds
            {
                seconds = false;
                timeFormatter = timeFormatter.Replace("mm:ss", "mm");
            }
            else // Enable seconds
            {
                seconds = true;
                timeFormatter = timeFormatter.Replace("mm", "mm:ss");
            }
        }

        // About link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://freesimpleapps.com");
        }

    }
}
