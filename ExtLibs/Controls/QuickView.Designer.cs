
namespace ByAeroBeHero.Controls
{
    partial class QuickView
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
            this.labelWithPseudoOpacity1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWithPseudoOpacity2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWithPseudoOpacity1
            // 
            this.labelWithPseudoOpacity1.AutoSize = true;
            this.labelWithPseudoOpacity1.BackColor = System.Drawing.Color.Transparent;
            this.labelWithPseudoOpacity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWithPseudoOpacity1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWithPseudoOpacity1.ForeColor = System.Drawing.Color.Black;
            this.labelWithPseudoOpacity1.Location = new System.Drawing.Point(3, 0);
            this.labelWithPseudoOpacity1.Name = "labelWithPseudoOpacity1";
            this.labelWithPseudoOpacity1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWithPseudoOpacity1.Size = new System.Drawing.Size(85, 43);
            this.labelWithPseudoOpacity1.TabIndex = 0;
            this.labelWithPseudoOpacity1.Text = "地速";
            this.labelWithPseudoOpacity1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.labelWithPseudoOpacity1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWithPseudoOpacity2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelWithPseudoOpacity2
            // 
            this.labelWithPseudoOpacity2.AutoSize = true;
            this.labelWithPseudoOpacity2.BackColor = System.Drawing.Color.Black;
            this.labelWithPseudoOpacity2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWithPseudoOpacity2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelWithPseudoOpacity2.ForeColor = System.Drawing.Color.Lime;
            this.labelWithPseudoOpacity2.Location = new System.Drawing.Point(94, 0);
            this.labelWithPseudoOpacity2.Name = "labelWithPseudoOpacity2";
            this.labelWithPseudoOpacity2.Size = new System.Drawing.Size(55, 43);
            this.labelWithPseudoOpacity2.TabIndex = 2;
            this.labelWithPseudoOpacity2.Text = "0.00";
            this.labelWithPseudoOpacity2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuickView
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuickView";
            this.Size = new System.Drawing.Size(152, 43);
            this.Resize += new System.EventHandler(this.QuickView_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWithPseudoOpacity1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelWithPseudoOpacity2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
