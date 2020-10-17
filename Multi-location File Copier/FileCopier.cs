using System;
using System.IO;
using System.Windows.Forms;
namespace Multi_location_File_Copier
{
    public partial class FileCopier : Form
    {
        public FileCopier()
        {
            InitializeComponent();
        }
        #region List functionality event handlers
        #region File list
        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int denied = 0;
                foreach (string file in ofd.FileNames)
                {
                    if (lbFiles.Items.Contains(file)) denied++;
                    else lbFiles.Items.Add(file);
                }
                if (denied > 0) MessageBox.Show($"{denied} out of the {ofd.FileNames.Length} files you selected were discarded, because they were already included in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFileRem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this file from the copy list?", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
        }
        private void btnFileClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all files from the copy list?", "Clear confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) lbFiles.Items.Clear();
        }
        #endregion
        #region Location list
        private void btnLocAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (lbLocations.Items.Contains(fbd.SelectedPath)) MessageBox.Show("This location was already added to the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else lbLocations.Items.Add(fbd.SelectedPath);
            }
        }
        private void btnLocRem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this location from the list?", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
        }
        private void btnLocClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all locations from the list?", "Clear confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) lbFiles.Items.Clear();
        }
        #endregion
        private void lbClick(object sender, MouseEventArgs e)
        {
            if ((sender as ListBox).IndexFromPoint(e.Location) == ListBox.NoMatches) (sender as ListBox).SelectedIndex = -1;
        }
        #endregion
        private void FileSubmit(object sender, EventArgs e)
        {
            if (lbFiles.Items.Count == 0) MessageBox.Show("There are no selected files to copy/move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lbLocations.Items.Count == 0) MessageBox.Show("There are no selected directories to copy/move into", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool error = false;
                foreach (string file in lbFiles.Items)
                {
                    foreach (string location in lbLocations.Items)
                    {
                        bool exists = File.Exists($"{location}\\{Path.GetFileName(file)})");
                        if (!exists)
                        {
                            if ((sender as Button).Name.Contains("Copy"))
                            {
                                try
                                {
                                    File.Copy(file, $"{location}\\{Path.GetFileName(file)}", exists ? MessageBox.Show($"The file {file} already exists in {location}. Do wou want to overwrite the file?", "Overwrite confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes : false);
                                }
                                catch(UnauthorizedAccessException ex)// handle Access denied to folder
                                {
                                    MessageBox.Show("Access denied to folder: " + location, "Unauthorized Access" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    error = true;
                                }
                            }

                            else Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(file, $"{location}\\{Path.GetFileName(file)}", exists ? MessageBox.Show($"The file {file} already exists in {location}. Do wou want to overwrite the file?", "Overwrite confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes : false);
                        }
                    }
                }
                if (error == false)
                {
                    MessageBox.Show("All files copied/moved to the selected destinations", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Not All files copied/moved to the selected destinations", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}