namespace GUI
{
    partial class HD_SEVERITY
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageOnSet = new System.Windows.Forms.TextBox();
            this.totalScore = new System.Windows.Forms.TextBox();
            this.functionalScore = new System.Windows.Forms.TextBox();
            this.SaveFunction = new System.Windows.Forms.Button();
            this.Cancelfunction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age On Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "UHDRS Total Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "UHDRS Functional Score";
            // 
            // ageOnSet
            // 
            this.ageOnSet.Location = new System.Drawing.Point(195, 89);
            this.ageOnSet.Name = "ageOnSet";
            this.ageOnSet.Size = new System.Drawing.Size(161, 20);
            this.ageOnSet.TabIndex = 5;
            this.ageOnSet.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ageOnSet_PreviewKeyDown);
            // 
            // totalScore
            // 
            this.totalScore.Location = new System.Drawing.Point(195, 125);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(161, 20);
            this.totalScore.TabIndex = 6;
            this.totalScore.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.totalScore_PreviewKeyDown);
            // 
            // functionalScore
            // 
            this.functionalScore.Location = new System.Drawing.Point(195, 162);
            this.functionalScore.Name = "functionalScore";
            this.functionalScore.Size = new System.Drawing.Size(161, 20);
            this.functionalScore.TabIndex = 7;
            this.functionalScore.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.functionalScore_PreviewKeyDown);
            // 
            // SaveFunction
            // 
            this.SaveFunction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFunction.Location = new System.Drawing.Point(195, 204);
            this.SaveFunction.Name = "SaveFunction";
            this.SaveFunction.Size = new System.Drawing.Size(75, 23);
            this.SaveFunction.TabIndex = 8;
            this.SaveFunction.Text = "Save";
            this.SaveFunction.UseVisualStyleBackColor = true;
            this.SaveFunction.Click += new System.EventHandler(this.SaveFunction_Click);
            // 
            // Cancelfunction
            // 
            this.Cancelfunction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelfunction.Location = new System.Drawing.Point(281, 204);
            this.Cancelfunction.Name = "Cancelfunction";
            this.Cancelfunction.Size = new System.Drawing.Size(75, 23);
            this.Cancelfunction.TabIndex = 9;
            this.Cancelfunction.Text = "Clear";
            this.Cancelfunction.UseVisualStyleBackColor = true;
            this.Cancelfunction.Click += new System.EventHandler(this.Cancelfunction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // patientId
            // 
            this.patientId.Location = new System.Drawing.Point(195, 55);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(161, 20);
            this.patientId.TabIndex = 4;
            this.patientId.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.patientId_PreviewKeyDown);
            // 
            // HD_SEVERITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.Cancelfunction);
            this.Controls.Add(this.SaveFunction);
            this.Controls.Add(this.functionalScore);
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.ageOnSet);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HD_SEVERITY";
            this.Text = "HD_SEVERITY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HD_SEVERITY_FormClosed);
            this.Load += new System.EventHandler(this.HD_SEVERITY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageOnSet;
        private System.Windows.Forms.TextBox totalScore;
        private System.Windows.Forms.TextBox functionalScore;
        private System.Windows.Forms.Button SaveFunction;
        private System.Windows.Forms.Button Cancelfunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientId;
    }
}