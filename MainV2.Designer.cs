﻿using System;
namespace ByAeroBeHero
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuInitConfig = new System.Windows.Forms.ToolStripButton();
            this.MenuConfigTune = new System.Windows.Forms.ToolStripButton();
            this.MenuSimulation = new System.Windows.Forms.ToolStripButton();
            this.MenuTerminal = new System.Windows.Forms.ToolStripButton();
            this.MenuHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new ByAeroBeHero.Controls.ToolStripConnectionControl();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.MenuDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Black;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuInitConfig,
            this.MenuConfigTune,
            this.MenuSimulation,
            this.MenuTerminal,
            this.MenuHelp,
            this.toolStripConnectionControl,
            this.MenuConnect,
            this.MenuDonate});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Stretch = false;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // MenuFlightData
            // 
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.ForeColor = System.Drawing.Color.White;
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.ForeColor = System.Drawing.Color.White;
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightPlanner.Name = "MenuFlightPlanner";
            this.MenuFlightPlanner.Click += new System.EventHandler(this.MenuFlightPlanner_Click);
            // 
            // MenuInitConfig
            // 
            resources.ApplyResources(this.MenuInitConfig, "MenuInitConfig");
            this.MenuInitConfig.ForeColor = System.Drawing.Color.White;
            this.MenuInitConfig.Margin = new System.Windows.Forms.Padding(0);
            this.MenuInitConfig.Name = "MenuInitConfig";
            this.MenuInitConfig.Click += new System.EventHandler(this.MenuSetup_Click);
            // 
            // MenuConfigTune
            // 
            resources.ApplyResources(this.MenuConfigTune, "MenuConfigTune");
            this.MenuConfigTune.ForeColor = System.Drawing.Color.White;
            this.MenuConfigTune.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConfigTune.Name = "MenuConfigTune";
            this.MenuConfigTune.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MenuConfigTune.Click += new System.EventHandler(this.MenuTuning_Click);
            // 
            // MenuSimulation
            // 
            resources.ApplyResources(this.MenuSimulation, "MenuSimulation");
            this.MenuSimulation.ForeColor = System.Drawing.Color.Black;
            this.MenuSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.MenuSimulation.Name = "MenuSimulation";
            this.MenuSimulation.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MenuSimulation.Click += new System.EventHandler(this.MenuSimulation_Click);
            // 
            // MenuTerminal
            // 
            resources.ApplyResources(this.MenuTerminal, "MenuTerminal");
            this.MenuTerminal.ForeColor = System.Drawing.Color.Black;
            this.MenuTerminal.Margin = new System.Windows.Forms.Padding(0);
            this.MenuTerminal.Name = "MenuTerminal";
            this.MenuTerminal.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MenuTerminal.Click += new System.EventHandler(this.MenuTerminal_Click);
            // 
            // MenuHelp
            // 
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            this.MenuHelp.ForeColor = System.Drawing.Color.White;
            this.MenuHelp.Margin = new System.Windows.Forms.Padding(0);
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // toolStripConnectionControl
            // 
            this.toolStripConnectionControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripConnectionControl.BackColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            this.toolStripConnectionControl.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // MenuConnect
            // 
            this.MenuConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.ForeColor = System.Drawing.Color.Black;
            this.MenuConnect.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // MenuDonate
            // 
            resources.ApplyResources(this.MenuDonate, "MenuDonate");
            this.MenuDonate.ForeColor = System.Drawing.Color.White;
            this.MenuDonate.Name = "MenuDonate";
            this.MenuDonate.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MenuDonate.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // MainV2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton MenuFlightData;
        private System.Windows.Forms.ToolStripButton MenuFlightPlanner;
        private System.Windows.Forms.ToolStripButton MenuInitConfig;
        private System.Windows.Forms.ToolStripButton MenuSimulation;
        private System.Windows.Forms.ToolStripButton MenuConfigTune;
        private System.Windows.Forms.ToolStripButton MenuTerminal;
        public System.Windows.Forms.ToolStripButton MenuConnect;

        private System.Windows.Forms.ToolStripButton MenuHelp;
        private Controls.ToolStripConnectionControl toolStripConnectionControl;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem MenuDonate;
        public System.Windows.Forms.MenuStrip MainMenu;
        public System.IO.Ports.SerialPort serialPort1;
    }
}