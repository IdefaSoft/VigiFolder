namespace VigiFolder
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.pnlTextBoxContainer = new System.Windows.Forms.Panel();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.lblFolderPathInstructions = new System.Windows.Forms.Label();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(867, 461);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(176, 27);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Lancer l\'analyse";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(868, 424);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Effacer le texte";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(729, 424);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 31);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelectFolder.Location = new System.Drawing.Point(817, 461);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSelectFolder.MaximumSize = new System.Drawing.Size(41, 27);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(41, 27);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Checked = true;
            this.chkIncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubfolders.ForeColor = System.Drawing.SystemColors.Control;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(543, 434);
            this.chkIncludeSubfolders.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(176, 21);
            this.chkIncludeSubfolders.TabIndex = 6;
            this.chkIncludeSubfolders.Text = "Inclure les sous dossiers";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // pnlTextBoxContainer
            // 
            this.pnlTextBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnlTextBoxContainer.Location = new System.Drawing.Point(16, 461);
            this.pnlTextBoxContainer.Name = "pnlTextBoxContainer";
            this.pnlTextBoxContainer.Size = new System.Drawing.Size(793, 27);
            this.pnlTextBoxContainer.TabIndex = 9;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolderPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFolderPath.Location = new System.Drawing.Point(16, 464);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFolderPath.MaxLength = 500;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(793, 18);
            this.txtFolderPath.TabIndex = 1;
            // 
            // rtbLogs
            // 
            this.rtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rtbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbLogs.Location = new System.Drawing.Point(16, 16);
            this.rtbLogs.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.Size = new System.Drawing.Size(1027, 402);
            this.rtbLogs.TabIndex = 0;
            this.rtbLogs.Text = "";
            // 
            // lblFolderPathInstructions
            // 
            this.lblFolderPathInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFolderPathInstructions.AutoSize = true;
            this.lblFolderPathInstructions.ForeColor = System.Drawing.Color.White;
            this.lblFolderPathInstructions.Location = new System.Drawing.Point(14, 438);
            this.lblFolderPathInstructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFolderPathInstructions.Name = "lblFolderPathInstructions";
            this.lblFolderPathInstructions.Size = new System.Drawing.Size(187, 17);
            this.lblFolderPathInstructions.TabIndex = 3;
            this.lblFolderPathInstructions.Text = "Nom du dossier à surveiller :";
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.SynchronizingObject = this;
            this.fsWatcher.Changed += new System.IO.FileSystemEventHandler(this.FsWatcher_Changed);
            this.fsWatcher.Created += new System.IO.FileSystemEventHandler(this.FsWatcher_Created);
            this.fsWatcher.Deleted += new System.IO.FileSystemEventHandler(this.FsWatcher_Deleted);
            this.fsWatcher.Renamed += new System.IO.RenamedEventHandler(this.FsWatcher_Renamed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1059, 500);
            this.Controls.Add(this.lblFolderPathInstructions);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.pnlTextBoxContainer);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.chkIncludeSubfolders);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStartStop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(760, 219);
            this.Name = "Form1";
            this.Text = "VigiFolder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkIncludeSubfolders;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Panel pnlTextBoxContainer;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Label lblFolderPathInstructions;
        private System.IO.FileSystemWatcher fsWatcher;
    }
}

