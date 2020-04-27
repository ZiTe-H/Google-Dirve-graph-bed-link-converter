namespace Google_Dirve_graph_bed_link_converter
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
            this.btn_Convent = new System.Windows.Forms.Button();
            this.tb_LinkImport = new System.Windows.Forms.TextBox();
            this.tb_LinkExport = new System.Windows.Forms.TextBox();
            this.rbtn_ExportLinkType1 = new System.Windows.Forms.RadioButton();
            this.rbtn_ExportLinkType2 = new System.Windows.Forms.RadioButton();
            this.gb_ExportLinkType = new System.Windows.Forms.GroupBox();
            this.lb_LinkExample = new System.Windows.Forms.Label();
            this.gb_ImportLinkType = new System.Windows.Forms.GroupBox();
            this.rbtn_ImportLinkType2 = new System.Windows.Forms.RadioButton();
            this.rbtn_ImportLinkType1 = new System.Windows.Forms.RadioButton();
            this.gb_ExportLinkType.SuspendLayout();
            this.gb_ImportLinkType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Convent
            // 
            this.btn_Convent.Location = new System.Drawing.Point(581, 234);
            this.btn_Convent.Name = "btn_Convent";
            this.btn_Convent.Size = new System.Drawing.Size(147, 42);
            this.btn_Convent.TabIndex = 0;
            this.btn_Convent.Text = "Convent";
            this.btn_Convent.UseVisualStyleBackColor = true;
            this.btn_Convent.Click += new System.EventHandler(this.btn_Convent_Click);
            // 
            // tb_LinkImport
            // 
            this.tb_LinkImport.Location = new System.Drawing.Point(12, 12);
            this.tb_LinkImport.Multiline = true;
            this.tb_LinkImport.Name = "tb_LinkImport";
            this.tb_LinkImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_LinkImport.Size = new System.Drawing.Size(553, 96);
            this.tb_LinkImport.TabIndex = 2;
            // 
            // tb_LinkExport
            // 
            this.tb_LinkExport.Location = new System.Drawing.Point(12, 132);
            this.tb_LinkExport.Multiline = true;
            this.tb_LinkExport.Name = "tb_LinkExport";
            this.tb_LinkExport.ReadOnly = true;
            this.tb_LinkExport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_LinkExport.Size = new System.Drawing.Size(553, 96);
            this.tb_LinkExport.TabIndex = 2;
            // 
            // rbtn_ExportLinkType1
            // 
            this.rbtn_ExportLinkType1.AutoSize = true;
            this.rbtn_ExportLinkType1.Checked = true;
            this.rbtn_ExportLinkType1.Location = new System.Drawing.Point(20, 29);
            this.rbtn_ExportLinkType1.Name = "rbtn_ExportLinkType1";
            this.rbtn_ExportLinkType1.Size = new System.Drawing.Size(88, 16);
            this.rbtn_ExportLinkType1.TabIndex = 3;
            this.rbtn_ExportLinkType1.TabStop = true;
            this.rbtn_ExportLinkType1.Text = "view (default)";
            this.rbtn_ExportLinkType1.UseVisualStyleBackColor = true;
            this.rbtn_ExportLinkType1.CheckedChanged += new System.EventHandler(this.rbtn_LinkType1_CheckedChanged);
            // 
            // rbtn_ExportLinkType2
            // 
            this.rbtn_ExportLinkType2.AutoSize = true;
            this.rbtn_ExportLinkType2.Location = new System.Drawing.Point(20, 60);
            this.rbtn_ExportLinkType2.Name = "rbtn_ExportLinkType2";
            this.rbtn_ExportLinkType2.Size = new System.Drawing.Size(69, 16);
            this.rbtn_ExportLinkType2.TabIndex = 3;
            this.rbtn_ExportLinkType2.Text = "download";
            this.rbtn_ExportLinkType2.UseVisualStyleBackColor = true;
            this.rbtn_ExportLinkType2.CheckedChanged += new System.EventHandler(this.rbtn_LinkType2_CheckedChanged);
            // 
            // gb_ExportLinkType
            // 
            this.gb_ExportLinkType.Controls.Add(this.rbtn_ExportLinkType2);
            this.gb_ExportLinkType.Controls.Add(this.rbtn_ExportLinkType1);
            this.gb_ExportLinkType.Location = new System.Drawing.Point(581, 132);
            this.gb_ExportLinkType.Name = "gb_ExportLinkType";
            this.gb_ExportLinkType.Size = new System.Drawing.Size(147, 96);
            this.gb_ExportLinkType.TabIndex = 5;
            this.gb_ExportLinkType.TabStop = false;
            this.gb_ExportLinkType.Text = "Export Link Type";
            // 
            // lb_LinkExample
            // 
            this.lb_LinkExample.AutoSize = true;
            this.lb_LinkExample.Location = new System.Drawing.Point(10, 264);
            this.lb_LinkExample.Name = "lb_LinkExample";
            this.lb_LinkExample.Size = new System.Drawing.Size(306, 12);
            this.lb_LinkExample.TabIndex = 6;
            this.lb_LinkExample.Text = "結果範例：https://drive.google.com/uc?export=view&id=FILEID";
            // 
            // gb_ImportLinkType
            // 
            this.gb_ImportLinkType.Controls.Add(this.rbtn_ImportLinkType2);
            this.gb_ImportLinkType.Controls.Add(this.rbtn_ImportLinkType1);
            this.gb_ImportLinkType.Location = new System.Drawing.Point(581, 12);
            this.gb_ImportLinkType.Name = "gb_ImportLinkType";
            this.gb_ImportLinkType.Size = new System.Drawing.Size(147, 96);
            this.gb_ImportLinkType.TabIndex = 5;
            this.gb_ImportLinkType.TabStop = false;
            this.gb_ImportLinkType.Text = "Import Link Type";
            // 
            // rbtn_ImportLinkType2
            // 
            this.rbtn_ImportLinkType2.AutoSize = true;
            this.rbtn_ImportLinkType2.Location = new System.Drawing.Point(20, 60);
            this.rbtn_ImportLinkType2.Name = "rbtn_ImportLinkType2";
            this.rbtn_ImportLinkType2.Size = new System.Drawing.Size(119, 16);
            this.rbtn_ImportLinkType2.TabIndex = 3;
            this.rbtn_ImportLinkType2.Text = "取得檔案共用連結";
            this.rbtn_ImportLinkType2.UseVisualStyleBackColor = true;
            this.rbtn_ImportLinkType2.CheckedChanged += new System.EventHandler(this.rbtn_LinkType2_CheckedChanged);
            // 
            // rbtn_ImportLinkType1
            // 
            this.rbtn_ImportLinkType1.AutoSize = true;
            this.rbtn_ImportLinkType1.Checked = true;
            this.rbtn_ImportLinkType1.Location = new System.Drawing.Point(20, 29);
            this.rbtn_ImportLinkType1.Name = "rbtn_ImportLinkType1";
            this.rbtn_ImportLinkType1.Size = new System.Drawing.Size(90, 16);
            this.rbtn_ImportLinkType1.TabIndex = 3;
            this.rbtn_ImportLinkType1.TabStop = true;
            this.rbtn_ImportLinkType1.Text = "共用 (default)";
            this.rbtn_ImportLinkType1.UseVisualStyleBackColor = true;
            this.rbtn_ImportLinkType1.CheckedChanged += new System.EventHandler(this.rbtn_LinkType1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 287);
            this.Controls.Add(this.lb_LinkExample);
            this.Controls.Add(this.gb_ImportLinkType);
            this.Controls.Add(this.gb_ExportLinkType);
            this.Controls.Add(this.tb_LinkExport);
            this.Controls.Add(this.tb_LinkImport);
            this.Controls.Add(this.btn_Convent);
            this.Name = "Form1";
            this.Text = "Google Dirve Graph bed link-converter";
            this.gb_ExportLinkType.ResumeLayout(false);
            this.gb_ExportLinkType.PerformLayout();
            this.gb_ImportLinkType.ResumeLayout(false);
            this.gb_ImportLinkType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convent;
        private System.Windows.Forms.TextBox tb_LinkImport;
        private System.Windows.Forms.TextBox tb_LinkExport;
        private System.Windows.Forms.RadioButton rbtn_ExportLinkType1;
        private System.Windows.Forms.RadioButton rbtn_ExportLinkType2;
        private System.Windows.Forms.GroupBox gb_ExportLinkType;
        private System.Windows.Forms.Label lb_LinkExample;
        private System.Windows.Forms.GroupBox gb_ImportLinkType;
        private System.Windows.Forms.RadioButton rbtn_ImportLinkType2;
        private System.Windows.Forms.RadioButton rbtn_ImportLinkType1;
    }
}

