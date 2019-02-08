namespace subway
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSL = new System.Windows.Forms.ComboBox();
            this.comboSS = new System.Windows.Forms.ComboBox();
            this.comboTL = new System.Windows.Forms.ComboBox();
            this.comboTS = new System.Windows.Forms.ComboBox();
            this.Btn_sInfo = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_tInfo = new System.Windows.Forms.Button();
            this.webRoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HCR Dotum", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(251, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "지하철 최단거리 찾기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOURCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TARGET";
            // 
            // comboSL
            // 
            this.comboSL.Font = new System.Drawing.Font("HCR Dotum", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboSL.FormattingEnabled = true;
            this.comboSL.Location = new System.Drawing.Point(135, 67);
            this.comboSL.Name = "comboSL";
            this.comboSL.Size = new System.Drawing.Size(121, 23);
            this.comboSL.TabIndex = 3;
            this.comboSL.SelectedIndexChanged += new System.EventHandler(this.comboSL_SelectedIndexChanged);
            // 
            // comboSS
            // 
            this.comboSS.Font = new System.Drawing.Font("HCR Dotum", 8.249999F);
            this.comboSS.FormattingEnabled = true;
            this.comboSS.Location = new System.Drawing.Point(271, 67);
            this.comboSS.Name = "comboSS";
            this.comboSS.Size = new System.Drawing.Size(156, 23);
            this.comboSS.TabIndex = 4;
            // 
            // comboTL
            // 
            this.comboTL.Font = new System.Drawing.Font("HCR Dotum", 8.249999F);
            this.comboTL.FormattingEnabled = true;
            this.comboTL.Location = new System.Drawing.Point(135, 121);
            this.comboTL.Name = "comboTL";
            this.comboTL.Size = new System.Drawing.Size(121, 23);
            this.comboTL.TabIndex = 5;
            this.comboTL.SelectedIndexChanged += new System.EventHandler(this.comboTL_SelectedIndexChanged);
            // 
            // comboTS
            // 
            this.comboTS.Font = new System.Drawing.Font("HCR Dotum", 8.249999F);
            this.comboTS.FormattingEnabled = true;
            this.comboTS.Location = new System.Drawing.Point(271, 121);
            this.comboTS.Name = "comboTS";
            this.comboTS.Size = new System.Drawing.Size(156, 23);
            this.comboTS.TabIndex = 6;
            // 
            // Btn_sInfo
            // 
            this.Btn_sInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_sInfo.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_sInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_sInfo.Location = new System.Drawing.Point(452, 60);
            this.Btn_sInfo.Name = "Btn_sInfo";
            this.Btn_sInfo.Size = new System.Drawing.Size(109, 35);
            this.Btn_sInfo.TabIndex = 8;
            this.Btn_sInfo.Text = "역 상세정보";
            this.Btn_sInfo.UseVisualStyleBackColor = false;
            this.Btn_sInfo.Click += new System.EventHandler(this.Btn_sInfo_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Search.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(238, 172);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 35);
            this.Btn_Search.TabIndex = 7;
            this.Btn_Search.Text = "찾기";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(44, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(531, 353);
            this.dataGridView1.TabIndex = 11;
            // 
            // Btn_tInfo
            // 
            this.Btn_tInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_tInfo.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_tInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_tInfo.Location = new System.Drawing.Point(452, 116);
            this.Btn_tInfo.Name = "Btn_tInfo";
            this.Btn_tInfo.Size = new System.Drawing.Size(109, 35);
            this.Btn_tInfo.TabIndex = 12;
            this.Btn_tInfo.Text = "역 상세정보";
            this.Btn_tInfo.UseVisualStyleBackColor = false;
            this.Btn_tInfo.Click += new System.EventHandler(this.Btn_tInfo_Click);
            // 
            // webRoad
            // 
            this.webRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.webRoad.Font = new System.Drawing.Font("HCR Dotum", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.webRoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.webRoad.Location = new System.Drawing.Point(319, 172);
            this.webRoad.Name = "webRoad";
            this.webRoad.Size = new System.Drawing.Size(92, 35);
            this.webRoad.TabIndex = 13;
            this.webRoad.Text = "경로보기";
            this.webRoad.UseVisualStyleBackColor = false;
            this.webRoad.Click += new System.EventHandler(this.webRoad_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(619, 607);
            this.Controls.Add(this.webRoad);
            this.Controls.Add(this.Btn_tInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_sInfo);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.comboTS);
            this.Controls.Add(this.comboTL);
            this.Controls.Add(this.comboSS);
            this.Controls.Add(this.comboSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "최단거리찾기";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSL;
        private System.Windows.Forms.ComboBox comboSS;
        private System.Windows.Forms.ComboBox comboTL;
        private System.Windows.Forms.ComboBox comboTS;
        private System.Windows.Forms.Button Btn_sInfo;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_tInfo;
        private System.Windows.Forms.Button webRoad;
    }
}