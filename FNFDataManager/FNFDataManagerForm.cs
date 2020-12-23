using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FridayNightFunkin;

namespace FNFDataManager
{
    public partial class FNFDataManagerForm : Form
    {
        public static FNFSong Song = null;

        public static Thread editorLoop = null;
        
        public static RichTextBox consoleOutput = null;

        private string pathToSong = "";
        private bool directoryExists = false;
        public FNFDataManagerForm()
        {
            InitializeComponent();

            KeyPreview = true;
            
            CheckForIllegalCrossThreadCalls = false;
            consoleOutput = rtxtConsole;

            Console.SetOut(new ConsoleLogging());
            Console.WriteLine("Console Output Hooked!");

            /*Console.WriteLine("Starting editor loop...");
            MainEditorLoop();
            Console.WriteLine("Started!");*/
        }

        private void btCheckDir_Click(object sender, EventArgs e)
        {
            directoryExists = Directory.Exists(txtbxDirectory.Text);
            if (directoryExists)
            {
                lblCheckDir.ForeColor = Color.Lime;
                lblCheckDir.Text = @"Exists";
                Console.WriteLine($"Found \"{txtbxDirectory.Text}\"!");
                RefreshProperties();
                return;
            }
            Console.WriteLine($"Directory \"{txtbxDirectory.Text}\" not found!");
            lblCheckDir.ForeColor = Color.Red;
            lblCheckDir.Text = @"Check Console!";
            RefreshProperties();
        }

        private void RefreshProperties()
        {
            pnlNeed.Visible = directoryExists;
            btnCreateNew.Visible = directoryExists;
            btnRefreshViews.Visible = directoryExists;
            btnSaveSong.Visible = Song != null;
            pnlAttributes.Visible = Song != null;
            pnlNotesSections.Visible = Song != null;
            if (directoryExists)
            {
                // pnlNeed Logic
                trvwDirectoryListing.Nodes.Clear();
                foreach (string s in Directory.GetDirectories($@"{txtbxDirectory.Text}\assets\data"))
                {
                    // linq magic
                    // in simple terms, convert a list of files into a TreeNode[],
                    // then make a new TreeNode with the children of the one we made
                    var children = Directory.GetFiles(s).Select(child => new TreeNode(LeadingPath(child)));
                    trvwDirectoryListing.Nodes.Add(new TreeNode(LeadingPath(s),children.ToArray()));
                }

                if (Song != null)
                {
                    // pnlAttributes Logic
                    txtSpeed.Text = $"{Song.Speed}";
                    txtName.Text = $"{Song.SongName}";
                    txtBPM.Text = $"{Song.Bpm}";
                    txtP1.Text = $"{Song.Player1}";
                    txtP2.Text = $"{Song.Player2}";
                    cbxNeedsVoices.Checked = Song.NeedVoices;
                    // pnlNotesSections logic
                }
            }
        }

        private string LeadingPath(string path) => path.Split('\\').Last();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Song != null)
                {
                    Popup pog = new Popup("You have unsaved changes!", $"Do you wish to save {Song.SongName}?", "Yes",
                        "No", true,
                        pathToSong);
                    pog.ShowDialog();
                    if (pog.result)
                    {
                        Song.SaveSong(pathToSong);
                        MessageBox.Show("Saved!", "FNFDataManager");
                    }

                    Song = null;
                }
                Song = new FNFSong(
                    $@"{txtbxDirectory.Text}\assets\data\{trvwDirectoryListing.SelectedNode.Parent.Text}\{trvwDirectoryListing.SelectedNode.Text}");
                lblSongStatus.ForeColor = Color.Lime;
                lblSongStatus.Text = @"Loaded!";
                pathToSong =
                    $@"{txtbxDirectory.Text}\assets\data\{trvwDirectoryListing.SelectedNode.Parent.Text}\{trvwDirectoryListing.SelectedNode.Text}";
                Console.WriteLine("Loaded " + Song.SongName + " with " + Song.Sections.Count + " sections.");
                RefreshProperties();
            }
            catch (Exception ex)
            {
                lblSongStatus.ForeColor = Color.Red;
                lblSongStatus.Text = @"Check Console!";
                Console.WriteLine($@"Failure to load song {trvwDirectoryListing.SelectedNode.Text}.{Environment.NewLine}Exception: {ex}");
            }
        }

        private void btnSaveSong_Click(object sender, EventArgs e)
        {
            if (Song == null)
                return;
            Song.SaveSong(pathToSong);
            MessageBox.Show("Saved!", "FNFDataManager");
        }

        private void rtxtConsole_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtxtConsole.SelectionStart = rtxtConsole.Text.Length;
            // scroll it automatically
            rtxtConsole.ScrollToCaret();
        }

        private void btnRefreshViews_Click(object sender, EventArgs e)
        {
            RefreshProperties();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Song.SongName = txtName.Text;
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            Song.Speed = long.Parse(txtSpeed.Text);
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {
            Song.Player1 = txtP1.Text;
        }

        private void txtP2_TextChanged(object sender, EventArgs e)
        {
            Song.Player2 = txtP2.Text;
        }

        private void txtBPM_TextChanged(object sender, EventArgs e)
        {
            Song.Bpm = long.Parse(txtBPM.Text);
        }

        private void cbxNeedsVoices_CheckedChanged(object sender, EventArgs e)
        {
            Song.NeedVoices = cbxNeedsVoices.Checked;
        }
        

        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (tabControl1.SelectedTab != tabPage3 || Song == null)
                return base.ProcessCmdKey(ref msg, keyData);
            switch (keyData)
            {
                case Keys.Space:
                    if (editorPlaying)
                    {
                        Console.WriteLine("Stopped playing...");
                        editorPlaying = !editorPlaying;
                        watch.Stop();
                    }
                    else
                    {
                        Console.WriteLine("Started playing...");
                        editorPlaying = !editorPlaying;
                        watch.Start();
                    }
                    break;
                case Keys.W:
                    if (editorPlaying)
                        editorPlaying = false;
                    watch.Stop();
                   
                    break;
                case Keys.S:
                    if (editorPlaying)
                        editorPlaying = false;
                    watch.Stop();
                    
                    break;
                case Keys.R:
                    watch.Reset();
                    editorPlaying = false;
                   
                    break;
            }
            return true;
        }*/
    }
 }