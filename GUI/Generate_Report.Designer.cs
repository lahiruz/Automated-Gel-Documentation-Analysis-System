namespace GUI
{
    partial class Generate_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Report));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkseverity = new System.Windows.Forms.Button();
            this.ReportImageId = new System.Windows.Forms.ComboBox();
            this.patientId = new System.Windows.Forms.ComboBox();
            this.deseaseType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desease_Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkseverity
            // 
            this.checkseverity.Location = new System.Drawing.Point(214, 168);
            this.checkseverity.Name = "checkseverity";
            this.checkseverity.Size = new System.Drawing.Size(102, 23);
            this.checkseverity.TabIndex = 7;
            this.checkseverity.Text = "Check Severity";
            this.checkseverity.UseVisualStyleBackColor = true;
            this.checkseverity.Click += new System.EventHandler(this.checkseverity_Click);
            // 
            // ReportImageId
            // 
            this.ReportImageId.FormattingEnabled = true;
            this.ReportImageId.Location = new System.Drawing.Point(178, 47);
            this.ReportImageId.Name = "ReportImageId";
            this.ReportImageId.Size = new System.Drawing.Size(138, 21);
            this.ReportImageId.TabIndex = 8;
            this.ReportImageId.SelectedValueChanged += new System.EventHandler(this.imageId_SelectedValueChanged);
            // 
            // patientId
            // 
            this.patientId.FormattingEnabled = true;
            this.patientId.Location = new System.Drawing.Point(178, 80);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(138, 21);
            this.patientId.TabIndex = 9;
            // 
            // deseaseType
            // 
            this.deseaseType.FormattingEnabled = true;
            this.deseaseType.Items.AddRange(new object[] {
            "DMD",
            "STROKE",
            "HD"});
            this.deseaseType.Location = new System.Drawing.Point(178, 115);
            this.deseaseType.Name = "deseaseType";
            this.deseaseType.Size = new System.Drawing.Size(138, 21);
            this.deseaseType.TabIndex = 10;
            this.deseaseType.SelectedIndexChanged += new System.EventHandler(this.deseaseType_SelectedIndexChanged);
            this.deseaseType.SelectedValueChanged += new System.EventHandler(this.deseaseType_SelectedValueChanged);
            // 
            // Generate_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 222);
            this.Controls.Add(this.deseaseType);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.ReportImageId);
            this.Controls.Add(this.checkseverity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generate_Report";
            this.Text = "Generate_Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Generate_Report_FormClosed);
            this.Load += new System.EventHandler(this.Generate_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkseverity;
        private System.Windows.Forms.ComboBox ReportImageId;
        private System.Windows.Forms.ComboBox patientId;
        private System.Windows.Forms.ComboBox deseaseType;
    }
}