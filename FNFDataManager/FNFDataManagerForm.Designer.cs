namespace FNFDataManager
{
    partial class FNFDataManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxDirectory = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshViews = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnSaveSong = new System.Windows.Forms.Button();
            this.pnlNeed = new System.Windows.Forms.Panel();
            this.lblSongStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trvwDirectoryListing = new System.Windows.Forms.TreeView();
            this.lblCheckDir = new System.Windows.Forms.Label();
            this.btCheckDir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlAttributes = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNeedsVoices = new System.Windows.Forms.CheckBox();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlNotesSections = new System.Windows.Forms.Panel();
            this.edSection = new System.Windows.Forms.Label();
            this.edCurrentSectTime = new System.Windows.Forms.Label();
            this.edCurrentTime = new System.Windows.Forms.Label();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.noteBar = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtxtConsole = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlNeed.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlAttributes.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlNotesSections.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.noteBar)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FNF Directory";
            // 
            // txtbxDirectory
            // 
            this.txtbxDirectory.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxDirectory.Location = new System.Drawing.Point(8, 21);
            this.txtbxDirectory.Name = "txtbxDirectory";
            this.txtbxDirectory.Size = new System.Drawing.Size(388, 23);
            this.txtbxDirectory.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 498);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshViews);
            this.tabPage1.Controls.Add(this.btnCreateNew);
            this.tabPage1.Controls.Add(this.btnSaveSong);
            this.tabPage1.Controls.Add(this.pnlNeed);
            this.tabPage1.Controls.Add(this.lblCheckDir);
            this.tabPage1.Controls.Add(this.btCheckDir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbxDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshViews
            // 
            this.btnRefreshViews.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshViews.Location = new System.Drawing.Point(211, 51);
            this.btnRefreshViews.Name = "btnRefreshViews";
            this.btnRefreshViews.Size = new System.Drawing.Size(103, 23);
            this.btnRefreshViews.TabIndex = 8;
            this.btnRefreshViews.Text = "Refresh Views";
            this.btnRefreshViews.UseVisualStyleBackColor = true;
            this.btnRefreshViews.Visible = false;
            this.btnRefreshViews.Click += new System.EventHandler(this.btnRefreshViews_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNew.Location = new System.Drawing.Point(402, 51);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(103, 23);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Visible = false;
            // 
            // btnSaveSong
            // 
            this.btnSaveSong.Location = new System.Drawing.Point(8, 51);
            this.btnSaveSong.Name = "btnSaveSong";
            this.btnSaveSong.Size = new System.Drawing.Size(103, 23);
            this.btnSaveSong.TabIndex = 6;
            this.btnSaveSong.Text = "Save Song";
            this.btnSaveSong.UseVisualStyleBackColor = true;
            this.btnSaveSong.Visible = false;
            this.btnSaveSong.Click += new System.EventHandler(this.btnSaveSong_Click);
            // 
            // pnlNeed
            // 
            this.pnlNeed.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNeed.Controls.Add(this.lblSongStatus);
            this.pnlNeed.Controls.Add(this.button1);
            this.pnlNeed.Controls.Add(this.trvwDirectoryListing);
            this.pnlNeed.Location = new System.Drawing.Point(8, 77);
            this.pnlNeed.Name = "pnlNeed";
            this.pnlNeed.Size = new System.Drawing.Size(497, 388);
            this.pnlNeed.TabIndex = 5;
            this.pnlNeed.Visible = false;
            // 
            // lblSongStatus
            // 
            this.lblSongStatus.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSongStatus.Location = new System.Drawing.Point(380, 368);
            this.lblSongStatus.Name = "lblSongStatus";
            this.lblSongStatus.Size = new System.Drawing.Size(113, 16);
            this.lblSongStatus.TabIndex = 6;
            this.lblSongStatus.Text = "N/A";
            this.lblSongStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Song";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trvwDirectoryListing
            // 
            this.trvwDirectoryListing.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.trvwDirectoryListing.Location = new System.Drawing.Point(3, 3);
            this.trvwDirectoryListing.Name = "trvwDirectoryListing";
            this.trvwDirectoryListing.Size = new System.Drawing.Size(490, 360);
            this.trvwDirectoryListing.TabIndex = 0;
            // 
            // lblCheckDir
            // 
            this.lblCheckDir.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckDir.ForeColor = System.Drawing.Color.Red;
            this.lblCheckDir.Location = new System.Drawing.Point(394, 3);
            this.lblCheckDir.Name = "lblCheckDir";
            this.lblCheckDir.Size = new System.Drawing.Size(115, 16);
            this.lblCheckDir.TabIndex = 4;
            this.lblCheckDir.Text = "Unchecked";
            this.lblCheckDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCheckDir
            // 
            this.btCheckDir.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btCheckDir.Location = new System.Drawing.Point(402, 22);
            this.btCheckDir.Name = "btCheckDir";
            this.btCheckDir.Size = new System.Drawing.Size(103, 23);
            this.btCheckDir.TabIndex = 3;
            this.btCheckDir.Text = "Check Dir";
            this.btCheckDir.UseVisualStyleBackColor = true;
            this.btCheckDir.Click += new System.EventHandler(this.btCheckDir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlAttributes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Song Attributes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.Controls.Add(this.label6);
            this.pnlAttributes.Controls.Add(this.cbxNeedsVoices);
            this.pnlAttributes.Controls.Add(this.txtBPM);
            this.pnlAttributes.Controls.Add(this.label5);
            this.pnlAttributes.Controls.Add(this.txtP2);
            this.pnlAttributes.Controls.Add(this.txtP1);
            this.pnlAttributes.Controls.Add(this.label4);
            this.pnlAttributes.Controls.Add(this.txtSpeed);
            this.pnlAttributes.Controls.Add(this.label3);
            this.pnlAttributes.Controls.Add(this.txtName);
            this.pnlAttributes.Controls.Add(this.label2);
            this.pnlAttributes.Location = new System.Drawing.Point(0, 0);
            this.pnlAttributes.Name = "pnlAttributes";
            this.pnlAttributes.Size = new System.Drawing.Size(512, 470);
            this.pnlAttributes.TabIndex = 0;
            this.pnlAttributes.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(497, 66);
            this.label6.TabIndex = 11;
            this.label6.Text =
                "Note: When leaving \".ogg file\" as something that doesn\'t exist in assets/music,\r\n" +
                "it will not progress the song at all.\r\n\r\nBe warned!\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxNeedsVoices
            // 
            this.cbxNeedsVoices.Location = new System.Drawing.Point(6, 48);
            this.cbxNeedsVoices.Name = "cbxNeedsVoices";
            this.cbxNeedsVoices.Size = new System.Drawing.Size(148, 24);
            this.cbxNeedsVoices.TabIndex = 10;
            this.cbxNeedsVoices.Text = "Needs Voices";
            this.cbxNeedsVoices.UseVisualStyleBackColor = true;
            this.cbxNeedsVoices.CheckedChanged += new System.EventHandler(this.cbxNeedsVoices_CheckedChanged);
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(338, 20);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(100, 23);
            this.txtBPM.TabIndex = 8;
            this.txtBPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBPM.TextChanged += new System.EventHandler(this.txtBPM_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(335, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "BPM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(287, 20);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(45, 23);
            this.txtP2.TabIndex = 6;
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP2.TextChanged += new System.EventHandler(this.txtP2_TextChanged);
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(236, 20);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(45, 23);
            this.txtP1.TabIndex = 5;
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP1.TextChanged += new System.EventHandler(this.txtP1_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(233, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Player 1 and 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(121, 20);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(118, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = ".ogg File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlNotesSections);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(515, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes/Sections";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlNotesSections
            // 
            this.pnlNotesSections.Controls.Add(this.label7);
            this.pnlNotesSections.Controls.Add(this.edSection);
            this.pnlNotesSections.Controls.Add(this.edCurrentSectTime);
            this.pnlNotesSections.Controls.Add(this.edCurrentTime);
            this.pnlNotesSections.Controls.Add(this.pnlNotes);
            this.pnlNotesSections.Location = new System.Drawing.Point(0, 0);
            this.pnlNotesSections.Name = "pnlNotesSections";
            this.pnlNotesSections.Size = new System.Drawing.Size(514, 470);
            this.pnlNotesSections.TabIndex = 0;
            this.pnlNotesSections.Visible = false;
            // 
            // edSection
            // 
            this.edSection.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.edSection.Location = new System.Drawing.Point(295, 392);
            this.edSection.Name = "edSection";
            this.edSection.Size = new System.Drawing.Size(208, 23);
            this.edSection.TabIndex = 3;
            this.edSection.Text = "Current Section: 0";
            // 
            // edCurrentSectTime
            // 
            this.edCurrentSectTime.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.edCurrentSectTime.Location = new System.Drawing.Point(295, 438);
            this.edCurrentSectTime.Name = "edCurrentSectTime";
            this.edCurrentSectTime.Size = new System.Drawing.Size(216, 23);
            this.edCurrentSectTime.TabIndex = 2;
            this.edCurrentSectTime.Text = "Current Section Time: 0";
            // 
            // edCurrentTime
            // 
            this.edCurrentTime.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.edCurrentTime.Location = new System.Drawing.Point(295, 415);
            this.edCurrentTime.Name = "edCurrentTime";
            this.edCurrentTime.Size = new System.Drawing.Size(208, 23);
            this.edCurrentTime.TabIndex = 1;
            this.edCurrentTime.Text = "Current Time: 0";
            // 
            // pnlNotes
            // 
            this.pnlNotes.BackColor = System.Drawing.Color.Gray;
            this.pnlNotes.BackgroundImage = global::FNFDataManager.Properties.Resources.noteBackplate;
            this.pnlNotes.Controls.Add(this.noteBar);
            this.pnlNotes.Location = new System.Drawing.Point(0, 0);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(295, 470);
            this.pnlNotes.TabIndex = 0;
            // 
            // noteBar
            // 
            this.noteBar.Image = global::FNFDataManager.Properties.Resources.bar;
            this.noteBar.Location = new System.Drawing.Point(0, 0);
            this.noteBar.Name = "noteBar";
            this.noteBar.Size = new System.Drawing.Size(288, 3);
            this.noteBar.TabIndex = 1;
            this.noteBar.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtxtConsole);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(515, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Console";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtxtConsole
            // 
            this.rtxtConsole.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtConsole.Location = new System.Drawing.Point(0, 0);
            this.rtxtConsole.Name = "rtxtConsole";
            this.rtxtConsole.ReadOnly = true;
            this.rtxtConsole.Size = new System.Drawing.Size(511, 472);
            this.rtxtConsole.TabIndex = 0;
            this.rtxtConsole.Text = "";
            this.rtxtConsole.TextChanged += new System.EventHandler(this.rtxtConsole_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(301, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Editor is coming soon!";
            // 
            // FNFDataManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 494);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(352, 339);
            this.Name = "FNFDataManagerForm";
            this.Text = "FNFDataManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlNeed.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlAttributes.ResumeLayout(false);
            this.pnlAttributes.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnlNotesSections.ResumeLayout(false);
            this.pnlNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.noteBar)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btCheckDir;
        private System.Windows.Forms.TextBox txtbxDirectory;
        private System.Windows.Forms.Label lblCheckDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView trvwDirectoryListing;
        private System.Windows.Forms.Panel pnlNeed;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtxtConsole;
        private System.Windows.Forms.Label lblSongStatus;
        private System.Windows.Forms.Button btnSaveSong;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnRefreshViews;
        private System.Windows.Forms.Panel pnlAttributes;
        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Panel pnlNotesSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBPM;
        private System.Windows.Forms.CheckBox cbxNeedsVoices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox noteBar;
        private System.Windows.Forms.Label edCurrentTime;
        private System.Windows.Forms.Label edCurrentSectTime;
        private System.Windows.Forms.Label edSection;
        private System.Windows.Forms.Label label7;
    }
}