
namespace ByAeroBeHero.Controls
{
    partial class FlightInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.lblData = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(30, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称|";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpData
            // 
            this.tlpData.ColumnCount = 2;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpData.Controls.Add(this.lblName, 0, 0);
            this.tlpData.Controls.Add(this.lblData, 1, 0);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(0, 0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 1;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.Size = new System.Drawing.Size(120, 28);
            this.tlpData.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblData.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(39, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(78, 28);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "数据";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlightInfo
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpData);
            this.Name = "FlightInfo";
            this.Size = new System.Drawing.Size(120, 28);
            this.Resize += new System.EventHandler(this.QuickView_Resize);
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
