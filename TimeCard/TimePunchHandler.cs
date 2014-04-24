/* This application written and developed by Ryan Brown
 * and is free for public use and reuse.
 * 
 * ryan@freesimpleapps.com
 * 
 * This is the class that handles writing to the csv file
 * for the TimeCard application.
 */
using System;

namespace TimeCard
{
    class TimePunchHandler
    {
        public String displayEntry; // Used for dispaly in the UI
        public String fullEntry; // Full entry for the csv file
        
        /* Description: Adds an entry to the csv file.
         * <bool firstEntry>: If true, add a date stamp to the csv file.
         * <string activeEntry>: The text for the current entry.
         * <string currentFile>: The path of the file being used.
         * <string time>: Dictates time formatting
         */
        public void addEntry(bool firstEntry, string activityEntry, string currentFile, string time)
        {
            string currentTime; // This will hold the current time

            if (firstEntry == true) // Only do this the first time an entry is created
            {
                currentTime = DateTime.Now.ToString("d MMMM yyyy"); // Create datestamp
                // Append datestamp to first line of file with a blank entry next to it
                System.IO.File.AppendAllText(currentFile, currentTime + ";;" + System.Environment.NewLine);
            }
            // Get current time with specified formatting
            currentTime = DateTime.Now.ToString(time);
            displayEntry = currentTime + ";" + activityEntry; // Build display entry
            fullEntry = displayEntry + ";" + System.Environment.NewLine; // Build csv entry

            // Write csv entry to csv
            System.IO.File.AppendAllText(currentFile, fullEntry);
        } // End addEntry
    }
}
