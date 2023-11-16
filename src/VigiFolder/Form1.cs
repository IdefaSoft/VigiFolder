using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace VigiFolder
{
    public partial class Form1 : Form
    {
        private string lang = "en";
        private Dictionary<string, Dictionary<string, string>> langs = new Dictionary<string, Dictionary<string, string>>
        {
          { "fr", new Dictionary<string, string> { 
            { "noDataExportMsg", "Veuillez attendre que des données soient présentes avant de pouvoir les exporter" },
            { "noDataExportTitle", "Pas de données à exporter" },
            { "startAnalysis", "Lancer l'analyse" },
            { "stopAnalysis", "Arrêter l'analyse" },
            { "emptyPathMsg", "Le chemin spécifié est vide" },
            { "emptyPathTitle", "Chemin d'accès vide" },
            { "invalidPathMsg", "Le chemin spécifié est invalide" },
            { "invalidPathTitle", "Chemin d'accès invalide" },
            { "filePath", "Chemin d'accès"},
            { "changed", "Fichier modifié à"},
            { "deleted", "Fichier supprimé à"},
            { "renamed", "Fichier renommé à"},
            { "created", "Fichier créé à"},
            { "error", "Erreur" }
          }},
          { "en", new Dictionary<string, string> { 
            { "noDataExportMsg", "Please wait for data to be available before exporting them" },
            { "noDataExportTitle", "No data to export" },
            { "startAnalysis", "Start analysis" },
            { "stopAnalysis", "Stop analysis" },
            { "emptyPathMsg", "The specified path is empty" },
            { "emptyPathTitle", "Empty path" },
            { "invalidPathMsg", "The specified path is invalid" },
            { "invalidPathTitle", "Invalid path" },
            { "filePath", "File path"},
            { "changed", "File changed at"},
            { "deleted", "File deleted at"},
            { "renamed", "File renamed at"},
            { "created", "File created at"},
            { "error", "Error" }
           }},
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void WriteTextWithColor(string text, Color color)
        {
            int startPosition = rtbLogs.TextLength;
            rtbLogs.AppendText(text);
            int endPosition = rtbLogs.TextLength;

            rtbLogs.Select(startPosition, endPosition - startPosition);
            rtbLogs.SelectionColor = color;
        }

        private void WriteTextWithFormat(string text, FontStyle format)
        {
            int startPosition = rtbLogs.TextLength;
            rtbLogs.AppendText(text);
            int endPosition = rtbLogs.TextLength;

            rtbLogs.Select(startPosition, endPosition - startPosition);
            rtbLogs.SelectionFont = new Font(rtbLogs.Font, format);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == langs[lang]["startAnalysis"])
            {
                if (txtFolderPath.Text == "")
                {
                    MessageBox.Show(langs[lang]["emptyPathMsg"], langs[lang]["emptyPathTitle"], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    fsWatcher.Path = txtFolderPath.Text;
                }
                catch
                {
                    MessageBox.Show(langs[lang]["invalidPathMsg"], langs[lang]["invalidPathTitle"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fsWatcher.EnableRaisingEvents = true;
                if (chkIncludeSubfolders.Checked == true)
                {
                    fsWatcher.IncludeSubdirectories = true;
                }
                else
                {
                    fsWatcher.IncludeSubdirectories = false;
                }
                btnStartStop.Text = langs[lang]["stopAnalysis"];
                btnStartStop.BackColor = Color.Red;
            }
            else
            {
                fsWatcher.EnableRaisingEvents = false;
                btnStartStop.Text = langs[lang]["startAnalysis"];
                btnStartStop.BackColor = Color.FromArgb(51, 176, 94);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbLogs.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (rtbLogs.Text != "")
            {
                using (var save = new SaveFileDialog())
                {
                    save.Filter = "Document|*.rtf";
                    save.CheckPathExists = true;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (save.FileName.Contains(".rtf"))
                        {
                            rtbLogs.SaveFile(save.FileName);
                        }
                        else
                        {
                            rtbLogs.SaveFile(save.FileName + ".rtf");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(langs[lang]["noDataExportMsg"], langs[lang]["noDataExportTitle"], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var open = new FolderBrowserDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = open.SelectedPath + @"\";
                }
            }
        }
        private void FsWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("HH:mm:ss : ");
            WriteTextWithColor($"{langs[lang]["changed"]} {date}\n" +
                               $"{langs[lang]["filePath"]} : {e.FullPath}\n\n", Color.Orange);
        }

        private void FsWatcher_Created(object sender, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("HH:mm:ss : ");
            WriteTextWithColor($"{langs[lang]["created"]} {date}\n" +
                               $"{langs[lang]["filePath"]} : {e.FullPath}\n\n", Color.Green);
        }

        private void FsWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("HH:mm:ss : ");
            WriteTextWithColor($"{langs[lang]["deleted"]} {date}\n" +
                               $"{langs[lang]["filePath"]}  : {e.FullPath}\n\n", Color.OrangeRed);
        }

        private void FsWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            string date = DateTime.Now.ToString("HH:mm:ss : ");
            WriteTextWithColor($"{langs[lang]["renamed"]} {date}\n" +
                               $"{langs[lang]["filePath"]}  : {e.FullPath}\n" +
                               $"{e.OldName} => {e.Name}\n\n", Color.SteelBlue);
        }

        private void FsWatcher_Error(object sender, ErrorEventArgs e)
        {
            WriteTextWithColor($"{langs[lang]["error"]}: {e.GetException().Message}", Color.Red);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbLogs.SelectionBackColor = rtbLogs.BackColor;
            if (!CultureInfo.CurrentCulture.Name.Contains("fr-"))
            {
                btnClear.Text = "Clear the text";
                btnExport.Text = "Export";
                btnStartStop.Text = "Start analysis";
                lblFolderPathInstructions.Text = "Name of the folder to monitor";
                chkIncludeSubfolders.Text = "Include subfolders";
                fsWatcher.Error += FsWatcher_Error;
            }
            else
            {
                lang = "fr";
            }
        }
    }
}
