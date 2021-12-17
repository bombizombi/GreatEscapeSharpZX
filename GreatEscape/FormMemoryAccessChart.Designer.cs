namespace GreatEscape
{
    partial class FormMemoryAccessChart
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
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            this.pictureBoxLines = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLines)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxChart.Location = new System.Drawing.Point(125, 12);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.pictureBoxChart.Size = new System.Drawing.Size(1175, 109);
            this.pictureBoxChart.TabIndex = 0;
            this.pictureBoxChart.TabStop = false;
            this.pictureBoxChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxChart_Paint);
            // 
            // pictureBoxLines
            // 
            this.pictureBoxLines.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxLines.Location = new System.Drawing.Point(125, 153);
            this.pictureBoxLines.Name = "pictureBoxLines";
            this.pictureBoxLines.Size = new System.Drawing.Size(1142, 431);
            this.pictureBoxLines.TabIndex = 1;
            this.pictureBoxLines.TabStop = false;
            this.pictureBoxLines.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "clear lines";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMemoryAccessChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 615);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxLines);
            this.Controls.Add(this.pictureBoxChart);
            this.Name = "FormMemoryAccessChart";
            this.Text = "FormMemoryAccessChart";
            this.Load += new System.EventHandler(this.FormMemoryAccessChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxChart;
        private PictureBox pictureBoxLines;
        private Button buttonClear;
    }
}