namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigSetParams
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigSetParams));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_RTL_ALT = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NUM_movelength = new System.Windows.Forms.NumericUpDown();
            this.tboxWriteV = new System.Windows.Forms.TextBox();
            this.RTL_ALT_P = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.lblMoveDistance = new System.Windows.Forms.Label();
            this.myButton2 = new ByAeroBeHero.Controls.MyButton();
            this.Btn_ = new ByAeroBeHero.Controls.MyButton();
            this.lblAllMove = new System.Windows.Forms.Label();
            this.chb_AllMove = new System.Windows.Forms.CheckBox();
            this.lblCheckSpeech = new System.Windows.Forms.Label();
            this.CHK_enablespeech = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.CHK_speechwaypoint = new System.Windows.Forms.CheckBox();
            this.CHK_speechotherParams = new System.Windows.Forms.CheckBox();
            this.CHK_speechflightParams = new System.Windows.Forms.CheckBox();
            this.lblChangeRow = new System.Windows.Forms.Label();
            this.lblVNo = new System.Windows.Forms.Label();
            this.lblVVNo = new System.Windows.Forms.Label();
            this.chbShow_AllParams = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SPRAY_WRAP_EN = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblControlParams = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPCParams = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSDParams = new System.Windows.Forms.Label();
            this.pSetParams = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblShowParams = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pSetParams.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_RTL_ALT
            // 
            resources.ApplyResources(this.lbl_RTL_ALT, "lbl_RTL_ALT");
            this.lbl_RTL_ALT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RTL_ALT.ForeColor = System.Drawing.Color.Black;
            this.lbl_RTL_ALT.Name = "lbl_RTL_ALT";
            // 
            // NUM_movelength
            // 
            this.NUM_movelength.BackColor = System.Drawing.SystemColors.Window;
            this.NUM_movelength.DecimalPlaces = 1;
            resources.ApplyResources(this.NUM_movelength, "NUM_movelength");
            this.NUM_movelength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.Name = "NUM_movelength";
            this.toolTip1.SetToolTip(this.NUM_movelength, resources.GetString("NUM_movelength.ToolTip"));
            this.toolTip2.SetToolTip(this.NUM_movelength, resources.GetString("NUM_movelength.ToolTip1"));
            this.NUM_movelength.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.ValueChanged += new System.EventHandler(this.NUM_movelength_ValueChanged);
            // 
            // tboxWriteV
            // 
            resources.ApplyResources(this.tboxWriteV, "tboxWriteV");
            this.tboxWriteV.Name = "tboxWriteV";
            this.toolTip1.SetToolTip(this.tboxWriteV, resources.GetString("tboxWriteV.ToolTip"));
            this.tboxWriteV.TextChanged += new System.EventHandler(this.tboxWriteV_TextChanged);
            this.tboxWriteV.Resize += new System.EventHandler(this.tboxWriteV_Resize);
            // 
            // RTL_ALT_P
            // 
            this.RTL_ALT_P.BackColor = System.Drawing.Color.Black;
            this.RTL_ALT_P.DecimalPlaces = 1;
            resources.ApplyResources(this.RTL_ALT_P, "RTL_ALT_P");
            this.RTL_ALT_P.ForeColor = System.Drawing.Color.White;
            this.RTL_ALT_P.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RTL_ALT_P.Max = 1F;
            this.RTL_ALT_P.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RTL_ALT_P.Min = 0F;
            this.RTL_ALT_P.Name = "RTL_ALT_P";
            this.RTL_ALT_P.ParamName = null;
            this.toolTip1.SetToolTip(this.RTL_ALT_P, resources.GetString("RTL_ALT_P.ToolTip"));
            this.toolTip2.SetToolTip(this.RTL_ALT_P, resources.GetString("RTL_ALT_P.ToolTip1"));
            this.RTL_ALT_P.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RTL_ALT_P.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // lblMoveDistance
            // 
            resources.ApplyResources(this.lblMoveDistance, "lblMoveDistance");
            this.lblMoveDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveDistance.ForeColor = System.Drawing.Color.Black;
            this.lblMoveDistance.Name = "lblMoveDistance";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.SystemColors.Control;
            this.myButton2.BGGradBot = System.Drawing.Color.Transparent;
            this.myButton2.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.BUT_refreshpart_Click);
            // 
            // Btn_
            // 
            this.Btn_.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_.BGGradBot = System.Drawing.Color.Transparent;
            this.Btn_.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_, "Btn_");
            this.Btn_.Name = "Btn_";
            this.Btn_.UseVisualStyleBackColor = false;
            this.Btn_.Click += new System.EventHandler(this.BUT_writePIDS_Click);
            // 
            // lblAllMove
            // 
            resources.ApplyResources(this.lblAllMove, "lblAllMove");
            this.lblAllMove.BackColor = System.Drawing.Color.Transparent;
            this.lblAllMove.ForeColor = System.Drawing.Color.Black;
            this.lblAllMove.Name = "lblAllMove";
            // 
            // chb_AllMove
            // 
            resources.ApplyResources(this.chb_AllMove, "chb_AllMove");
            this.chb_AllMove.Name = "chb_AllMove";
            this.chb_AllMove.UseVisualStyleBackColor = true;
            this.chb_AllMove.CheckedChanged += new System.EventHandler(this.chb_AllMove_CheckedChanged);
            // 
            // lblCheckSpeech
            // 
            resources.ApplyResources(this.lblCheckSpeech, "lblCheckSpeech");
            this.lblCheckSpeech.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckSpeech.ForeColor = System.Drawing.Color.Black;
            this.lblCheckSpeech.Name = "lblCheckSpeech";
            // 
            // CHK_enablespeech
            // 
            resources.ApplyResources(this.CHK_enablespeech, "CHK_enablespeech");
            this.CHK_enablespeech.BackColor = System.Drawing.Color.Transparent;
            this.CHK_enablespeech.ForeColor = System.Drawing.Color.Black;
            this.CHK_enablespeech.Name = "CHK_enablespeech";
            this.CHK_enablespeech.UseVisualStyleBackColor = false;
            this.CHK_enablespeech.CheckedChanged += new System.EventHandler(this.CHK_enablespeech_CheckedChanged);
            // 
            // CHK_speechwaypoint
            // 
            resources.ApplyResources(this.CHK_speechwaypoint, "CHK_speechwaypoint");
            this.CHK_speechwaypoint.BackColor = System.Drawing.Color.Transparent;
            this.CHK_speechwaypoint.ForeColor = System.Drawing.Color.Black;
            this.CHK_speechwaypoint.Name = "CHK_speechwaypoint";
            this.CHK_speechwaypoint.UseVisualStyleBackColor = false;
            this.CHK_speechwaypoint.CheckedChanged += new System.EventHandler(this.CHK_speechwaypoint_CheckedChanged);
            // 
            // CHK_speechotherParams
            // 
            resources.ApplyResources(this.CHK_speechotherParams, "CHK_speechotherParams");
            this.CHK_speechotherParams.BackColor = System.Drawing.Color.Transparent;
            this.CHK_speechotherParams.ForeColor = System.Drawing.Color.Black;
            this.CHK_speechotherParams.Name = "CHK_speechotherParams";
            this.CHK_speechotherParams.UseVisualStyleBackColor = false;
            this.CHK_speechotherParams.CheckedChanged += new System.EventHandler(this.CHK_speechotherParams_CheckedChanged);
            // 
            // CHK_speechflightParams
            // 
            resources.ApplyResources(this.CHK_speechflightParams, "CHK_speechflightParams");
            this.CHK_speechflightParams.BackColor = System.Drawing.Color.Transparent;
            this.CHK_speechflightParams.ForeColor = System.Drawing.Color.Black;
            this.CHK_speechflightParams.Name = "CHK_speechflightParams";
            this.CHK_speechflightParams.UseVisualStyleBackColor = false;
            this.CHK_speechflightParams.CheckedChanged += new System.EventHandler(this.CHK_speechflightParams_CheckedChanged);
            // 
            // lblChangeRow
            // 
            resources.ApplyResources(this.lblChangeRow, "lblChangeRow");
            this.lblChangeRow.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeRow.ForeColor = System.Drawing.Color.Black;
            this.lblChangeRow.Name = "lblChangeRow";
            // 
            // lblVNo
            // 
            resources.ApplyResources(this.lblVNo, "lblVNo");
            this.lblVNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVNo.ForeColor = System.Drawing.Color.Black;
            this.lblVNo.Name = "lblVNo";
            // 
            // lblVVNo
            // 
            resources.ApplyResources(this.lblVVNo, "lblVVNo");
            this.lblVVNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVVNo.ForeColor = System.Drawing.Color.Black;
            this.lblVVNo.Name = "lblVVNo";
            // 
            // chbShow_AllParams
            // 
            resources.ApplyResources(this.chbShow_AllParams, "chbShow_AllParams");
            this.chbShow_AllParams.Name = "chbShow_AllParams";
            this.chbShow_AllParams.UseVisualStyleBackColor = true;
            this.chbShow_AllParams.CheckedChanged += new System.EventHandler(this.chbShow_AllParams_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.SPRAY_WRAP_EN);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lblChangeRow);
            this.panel4.Controls.Add(this.lblVNo);
            this.panel4.Controls.Add(this.Btn_);
            this.panel4.Controls.Add(this.tboxWriteV);
            this.panel4.Controls.Add(this.RTL_ALT_P);
            this.panel4.Controls.Add(this.lblVVNo);
            this.panel4.Controls.Add(this.myButton2);
            this.panel4.Controls.Add(this.lbl_RTL_ALT);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // SPRAY_WRAP_EN
            // 
            resources.ApplyResources(this.SPRAY_WRAP_EN, "SPRAY_WRAP_EN");
            this.SPRAY_WRAP_EN.Name = "SPRAY_WRAP_EN";
            this.SPRAY_WRAP_EN.OffValue = 0D;
            this.SPRAY_WRAP_EN.OnValue = 1D;
            this.SPRAY_WRAP_EN.ParamName = null;
            this.SPRAY_WRAP_EN.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblControlParams);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lblControlParams
            // 
            resources.ApplyResources(this.lblControlParams, "lblControlParams");
            this.lblControlParams.BackColor = System.Drawing.Color.Transparent;
            this.lblControlParams.ForeColor = System.Drawing.Color.Black;
            this.lblControlParams.Name = "lblControlParams";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblAllMove);
            this.panel1.Controls.Add(this.lblMoveDistance);
            this.panel1.Controls.Add(this.chb_AllMove);
            this.panel1.Controls.Add(this.NUM_movelength);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblPCParams);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // lblPCParams
            // 
            resources.ApplyResources(this.lblPCParams, "lblPCParams");
            this.lblPCParams.BackColor = System.Drawing.Color.Transparent;
            this.lblPCParams.ForeColor = System.Drawing.Color.Black;
            this.lblPCParams.Name = "lblPCParams";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.CHK_speechotherParams);
            this.panel2.Controls.Add(this.CHK_speechflightParams);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lblCheckSpeech);
            this.panel2.Controls.Add(this.CHK_enablespeech);
            this.panel2.Controls.Add(this.CHK_speechwaypoint);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblSDParams);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // lblSDParams
            // 
            resources.ApplyResources(this.lblSDParams, "lblSDParams");
            this.lblSDParams.BackColor = System.Drawing.Color.Transparent;
            this.lblSDParams.ForeColor = System.Drawing.Color.Black;
            this.lblSDParams.Name = "lblSDParams";
            // 
            // pSetParams
            // 
            this.pSetParams.BackColor = System.Drawing.Color.LightGray;
            this.pSetParams.Controls.Add(this.panel8);
            this.pSetParams.Controls.Add(this.chbShow_AllParams);
            resources.ApplyResources(this.pSetParams, "pSetParams");
            this.pSetParams.Name = "pSetParams";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblShowParams);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // lblShowParams
            // 
            resources.ApplyResources(this.lblShowParams, "lblShowParams");
            this.lblShowParams.BackColor = System.Drawing.Color.Transparent;
            this.lblShowParams.ForeColor = System.Drawing.Color.Black;
            this.lblShowParams.Name = "lblShowParams";
            // 
            // ConfigSetParams
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pSetParams);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "ConfigSetParams";
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pSetParams.ResumeLayout(false);
            this.pSetParams.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_RTL_ALT;
        private Controls.MyButton Btn_;
        private Controls.MyButton myButton2;
        private Controls.MavlinkNumericUpDown RTL_ALT_P;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown NUM_movelength;
        private System.Windows.Forms.Label lblMoveDistance;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblCheckSpeech;
        private System.Windows.Forms.CheckBox CHK_enablespeech;
        private System.Windows.Forms.CheckBox CHK_speechwaypoint;
        private System.Windows.Forms.CheckBox CHK_speechflightParams;
        private System.Windows.Forms.CheckBox CHK_speechotherParams;
        private System.Windows.Forms.Label lblAllMove;
        private System.Windows.Forms.CheckBox chb_AllMove;
        private System.Windows.Forms.Label lblVVNo;
        private System.Windows.Forms.TextBox tboxWriteV;
        private System.Windows.Forms.Label lblVNo;
        private System.Windows.Forms.Label lblChangeRow;
        private Controls.MavlinkCheckBox SPRAY_WRAP_EN;
        private System.Windows.Forms.CheckBox chbShow_AllParams;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblControlParams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPCParams;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblSDParams;
        private System.Windows.Forms.Panel pSetParams;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblShowParams;
    }
}
