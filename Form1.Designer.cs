namespace subway
{
    partial class Form1
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
            this.ListBox_line = new System.Windows.Forms.ListBox();
            this.ListBox_subway = new System.Windows.Forms.ListBox();
            this.Btn_info = new System.Windows.Forms.Button();
            this.Btn_dijk = new System.Windows.Forms.Button();
            this.btnDepStation = new System.Windows.Forms.Button();
            this.btnDesStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(262, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "지하철 역 상세정보";
            // 
            // ListBox_line
            // 
            this.ListBox_line.FormattingEnabled = true;
            this.ListBox_line.ItemHeight = 16;
            this.ListBox_line.Location = new System.Drawing.Point(29, 77);
            this.ListBox_line.Name = "ListBox_line";
            this.ListBox_line.Size = new System.Drawing.Size(244, 324);
            this.ListBox_line.TabIndex = 1;
            this.ListBox_line.SelectedIndexChanged += new System.EventHandler(this.ListBox_line_SelectedIndexChanged);
            // 
            // ListBox_subway
            // 
            this.ListBox_subway.FormattingEnabled = true;
            this.ListBox_subway.ItemHeight = 16;
            this.ListBox_subway.Location = new System.Drawing.Point(292, 77);
            this.ListBox_subway.Name = "ListBox_subway";
            this.ListBox_subway.Size = new System.Drawing.Size(341, 324);
            this.ListBox_subway.TabIndex = 2;
            // 
            // Btn_info
            // 
            this.Btn_info.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_info.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_info.ForeColor = System.Drawing.Color.White;
            this.Btn_info.Location = new System.Drawing.Point(433, 431);
            this.Btn_info.Name = "Btn_info";
            this.Btn_info.Size = new System.Drawing.Size(75, 35);
            this.Btn_info.TabIndex = 3;
            this.Btn_info.Text = "상세정보";
            this.Btn_info.UseVisualStyleBackColor = false;
            this.Btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // Btn_dijk
            // 
            this.Btn_dijk.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_dijk.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_dijk.Location = new System.Drawing.Point(514, 431);
            this.Btn_dijk.Name = "Btn_dijk";
            this.Btn_dijk.Size = new System.Drawing.Size(109, 35);
            this.Btn_dijk.TabIndex = 4;
            this.Btn_dijk.Text = "최단거리 찾기";
            this.Btn_dijk.UseVisualStyleBackColor = false;
            this.Btn_dijk.Click += new System.EventHandler(this.Btn_dijk_Click);
            // 
            // btnDepStation
            // 
            this.btnDepStation.BackColor = System.Drawing.Color.MistyRose;
            this.btnDepStation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDepStation.Location = new System.Drawing.Point(41, 437);
            this.btnDepStation.Name = "btnDepStation";
            this.btnDepStation.Size = new System.Drawing.Size(96, 29);
            this.btnDepStation.TabIndex = 5;
            this.btnDepStation.Text = "시작역으로";
            this.btnDepStation.UseVisualStyleBackColor = false;
            this.btnDepStation.Click += new System.EventHandler(this.btnDepStation_Click);
            // 
            // btnDesStation
            // 
            this.btnDesStation.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDesStation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesStation.Location = new System.Drawing.Point(143, 437);
            this.btnDesStation.Name = "btnDesStation";
            this.btnDesStation.Size = new System.Drawing.Size(99, 29);
            this.btnDesStation.TabIndex = 6;
            this.btnDesStation.Text = "도착역으로";
            this.btnDesStation.UseVisualStyleBackColor = false;
            this.btnDesStation.Click += new System.EventHandler(this.btnDesStation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(664, 497);
            this.Controls.Add(this.btnDesStation);
            this.Controls.Add(this.btnDepStation);
            this.Controls.Add(this.Btn_dijk);
            this.Controls.Add(this.Btn_info);
            this.Controls.Add(this.ListBox_subway);
            this.Controls.Add(this.ListBox_line);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "station_info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBox_line;
        private System.Windows.Forms.ListBox ListBox_subway;
        private System.Windows.Forms.Button Btn_info;
        private System.Windows.Forms.Button Btn_dijk;
        private System.Windows.Forms.Button btnDepStation;
        private System.Windows.Forms.Button btnDesStation;
    }
}

