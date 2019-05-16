﻿using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sonic_06_Toolkit
{
    public partial class ADX_Studio : Form
    {
        public ADX_Studio()
        {
            InitializeComponent();
        }

        public static string ignoreLoop = "";
        public static string removeLoop = "";
        public static string downmix = "MONO";
        public static double vol = 1.0;

        void ADX_Studio_Load(object sender, EventArgs e)
        {
            Global.adxState = "adx";

            clb_ADX.Items.Clear();

            if (Directory.GetFiles(Global.currentPath, "*.adx").Length > 0)
            {
                modes_ADXtoWAV.Checked = true;
                modes_WAVtoADX.Checked = false;
                options_Volume.Visible = false;
                options_Looping.Visible = false;
                options_DownmixToMono.Visible = false;
            }
            else if (Directory.GetFiles(Global.currentPath, "*.wav").Length > 0)
            {
                modes_ADXtoWAV.Checked = false;
                modes_WAVtoADX.Checked = true;
                options_Volume.Visible = true;
                options_Looping.Visible = true;
                options_DownmixToMono.Visible = true;
            }
            else { MessageBox.Show("There are no encodable files in this directory.", "No files available", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
        }

        void Btn_SelectAll_Click(object sender, EventArgs e)
        {
            //Checks all available checkboxes.
            for (int i = 0; i < clb_ADX.Items.Count; i++) clb_ADX.SetItemChecked(i, true);
            btn_Convert.Enabled = true;
        }

        private void Btn_DeselectAll_Click(object sender, EventArgs e)
        {
            //Unchecks all available checkboxes.
            for (int i = 0; i < clb_ADX.Items.Count; i++) clb_ADX.SetItemChecked(i, false);
            btn_Convert.Enabled = false;
        }

        void Btn_Convert_Click(object sender, EventArgs e)
        {
            //In the odd chance that someone is ever able to click Extract without anything selected, this will prevent that.
            if (clb_ADX.CheckedItems.Count == 0) MessageBox.Show("Please select a file.", "No files specified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Global.adxState == "adx")
            {
                try
                {
                    Global.adxState = "adx";

                    var convertDialog = new Status();
                    var parentLeft = Left + ((Width - convertDialog.Width) / 2);
                    var parentTop = Top + ((Height - convertDialog.Height) / 2);
                    convertDialog.Location = new System.Drawing.Point(parentLeft, parentTop);
                    convertDialog.Show();

                    #region Getting selected ADX files...
                    //Gets all checked boxes from the CheckedListBox and builds a string for each ADX.
                    foreach (string selectedADX in clb_ADX.CheckedItems)
                    {
                        var checkedBuildSession = new StringBuilder();
                        checkedBuildSession.Append(Path.Combine(Global.currentPath, selectedADX));

                        #region Converting ADX files...
                        //Sets up the BASIC application and executes the converting process.
                        var convertSession = new ProcessStartInfo(Properties.Settings.Default.adx2wavFile, "\"" + checkedBuildSession.ToString() + "\" \"" + Path.GetDirectoryName(checkedBuildSession.ToString()) + @"\" + Path.GetFileNameWithoutExtension(checkedBuildSession.ToString()) + ".wav\"");
                        convertSession.WorkingDirectory = Global.currentPath;
                        convertSession.WindowStyle = ProcessWindowStyle.Hidden;
                        var Convert = Process.Start(convertSession);
                        Convert.WaitForExit();
                        Convert.Close();

                        Global.adxState = null;
                        #endregion
                    }
                    #endregion

                    convertDialog.Close();
                }
                catch { MessageBox.Show("An error occurred when encoding the selected ADX files.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (Global.adxState == "wav")
            {
                try
                {
                    Global.adxState = "wav";

                    var convertDialog = new Status();
                    var parentLeft = Left + ((Width - convertDialog.Width) / 2);
                    var parentTop = Top + ((Height - convertDialog.Height) / 2);
                    convertDialog.Location = new System.Drawing.Point(parentLeft, parentTop);
                    convertDialog.Show();

                    #region Getting selected WAV files...
                    //Gets all checked boxes from the CheckedListBox and builds a string for each WAV.
                    foreach (string selectedWAV in clb_ADX.CheckedItems)
                    {
                        var checkedBuildSession = new StringBuilder();
                        checkedBuildSession.Append(Path.Combine(Global.currentPath, selectedWAV));

                        #region Converting WAV files...
                        //Sets up the BASIC application and executes the converting process.
                        var convertSession = new ProcessStartInfo(Properties.Settings.Default.criconverterFile, "\"" + checkedBuildSession.ToString() + "\" \"" + Path.GetDirectoryName(checkedBuildSession.ToString()) + @"\" + Path.GetFileNameWithoutExtension(checkedBuildSession.ToString()) + ".adx\" -codec=adx -volume=" + vol + " -downmix=" + downmix + ignoreLoop + removeLoop);
                        convertSession.WorkingDirectory = Global.currentPath;
                        convertSession.WindowStyle = ProcessWindowStyle.Hidden;
                        var Convert = Process.Start(convertSession);
                        Convert.WaitForExit();
                        Convert.Close();

                        Global.adxState = null;
                        #endregion
                    }
                    #endregion

                    convertDialog.Close();
                }
                catch { MessageBox.Show("An error occurred when encoding the selected WAV files.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("ADX State set to invalid value: " + Global.adxState + "\nLine information: " + new System.Diagnostics.StackTrace(true).GetFrame(1).GetFileLineNumber(), "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Clb_ADX_SelectedIndexChanged(object sender, EventArgs e)
        {
            clb_ADX.ClearSelected(); //Removes the blue highlight on recently checked boxes.

            //Enables/disables the Encode button, depending on whether a box has been checked.
            if (clb_ADX.CheckedItems.Count > 0)
            {
                btn_Convert.Enabled = true;
            }
            else
            {
                btn_Convert.Enabled = false;
            }
        }

        void Modes_ADXtoWAV_CheckedChanged(object sender, EventArgs e)
        {
            if (modes_ADXtoWAV.Checked == true)
            {
                Global.adxState = "adx";

                clb_ADX.Items.Clear();

                #region Getting ADX files to convert...
                foreach (string ADX in Directory.GetFiles(Global.currentPath, "*.adx", SearchOption.TopDirectoryOnly))
                {
                    if (File.Exists(ADX))
                    {
                        clb_ADX.Items.Add(Path.GetFileName(ADX));
                    }
                }
                #endregion

                modes_WAVtoADX.Checked = false;
                options_Volume.Visible = false;
                options_Looping.Visible = false;
                options_DownmixToMono.Visible = false;
                btn_Convert.Enabled = false;

                if (Directory.GetFiles(Global.currentPath, "*.adx").Length == 0)
                {
                    MessageBox.Show("There are no ADX files to encode in this directory.", "No ADX files available", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Directory.GetFiles(Global.currentPath, "*.wav").Length == 0)
                    {
                        Close();
                    }
                    else
                    {
                        modes_ADXtoWAV.Checked = false;
                        modes_WAVtoADX.Checked = true;
                    }
                }
            }
        }

        void Modes_WAVtoADX_CheckedChanged(object sender, EventArgs e)
        {
            if (modes_WAVtoADX.Checked == true)
            {
                Global.adxState = "wav";

                clb_ADX.Items.Clear();

                #region Getting WAV files to convert...
                foreach (string WAV in Directory.GetFiles(Global.currentPath, "*.wav", SearchOption.TopDirectoryOnly))
                {
                    if (File.Exists(WAV))
                    {
                        clb_ADX.Items.Add(Path.GetFileName(WAV));
                    }
                }
                #endregion

                modes_ADXtoWAV.Checked = false;
                options_Volume.Visible = true;
                options_Looping.Visible = true;
                options_DownmixToMono.Visible = true;
                btn_Convert.Enabled = false;

                if (Directory.GetFiles(Global.currentPath, "*.wav").Length == 0)
                {
                    MessageBox.Show("There are no WAV files to encode in this directory.", "No WAV files available", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Directory.GetFiles(Global.currentPath, "*.adx").Length == 0)
                    {
                        Close();
                    }
                    else
                    {
                        modes_ADXtoWAV.Checked = true;
                        modes_WAVtoADX.Checked = false;
                    }
                }
            }
        }

        #region Volume Control
        void Volume_5_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_5.Checked == true)
            {
                vol = 5.0;
                volume_4.Checked = false;
                volume_3.Checked = false;
                volume_2.Checked = false;
                volume_1.Checked = false;
                volume_0.Checked = false;

                MessageBox.Show("Using a volume greater than 1.0 will likely produce noise in original ADX files.", "Sound Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Volume_4_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_4.Checked == true)
            {
                volume_5.Checked = false;
                vol = 4.0;
                volume_3.Checked = false;
                volume_2.Checked = false;
                volume_1.Checked = false;
                volume_0.Checked = false;

                MessageBox.Show("Using a volume greater than 1.0 will likely produce noise in original ADX files.", "Sound Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Volume_3_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_3.Checked == true)
            {
                volume_5.Checked = false;
                volume_4.Checked = false;
                vol = 3.0;
                volume_2.Checked = false;
                volume_1.Checked = false;
                volume_0.Checked = false;

                MessageBox.Show("Using a volume greater than 1.0 will likely produce noise in original ADX files.", "Sound Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Volume_2_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_2.Checked == true)
            {
                volume_5.Checked = false;
                volume_4.Checked = false;
                volume_3.Checked = false;
                vol = 2.0;
                volume_1.Checked = false;
                volume_0.Checked = false;

                MessageBox.Show("Using a volume greater than 1.0 will likely produce noise in original ADX files.", "Sound Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Volume_1_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_1.Checked == true)
            {
                volume_5.Checked = false;
                volume_4.Checked = false;
                volume_3.Checked = false;
                volume_2.Checked = false;
                vol = 1.0;
                volume_0.Checked = false;
            }
        }

        void Volume_0_CheckedChanged(object sender, EventArgs e)
        {
            if (volume_0.Checked == true)
            {
                volume_5.Checked = false;
                volume_4.Checked = false;
                volume_3.Checked = false;
                volume_2.Checked = false;
                volume_1.Checked = false;
                vol = 0.0;
            }
        }
        #endregion

        void Looping_Ignore_CheckedChanged(object sender, EventArgs e)
        {
            if (looping_Ignore.Checked == true)
            {
                ignoreLoop = " -lpoff";
            }
            else { ignoreLoop = ""; }
        }

        void Looping_Remove_CheckedChanged(object sender, EventArgs e)
        {
            if (looping_Remove.Checked == true)
            {
                removeLoop = " -nodelterm";
            }
            else { removeLoop = ""; }
        }

        void Options_DownmixToStereo_CheckedChanged(object sender, EventArgs e)
        {
            if (options_DownmixToMono.Checked == true)
            {
                downmix = "MONO";
            }
            else { downmix = "STEREO"; }
        }
    }
}
