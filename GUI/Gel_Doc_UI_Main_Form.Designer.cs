namespace GUI
{
    partial class Gel_Doc_UI_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gel_Doc_UI_Main_Form));
            this.tabControlPrediction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.patientDetails = new System.Windows.Forms.Label();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.comboBox_Deseace_Name = new System.Windows.Forms.ComboBox();
            this.clearPatientDetailsBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Patient_Name = new System.Windows.Forms.TextBox();
            this.textBox_PATIENT_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.imageId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.value16 = new System.Windows.Forms.ComboBox();
            this.value15 = new System.Windows.Forms.ComboBox();
            this.value14 = new System.Windows.Forms.ComboBox();
            this.value13 = new System.Windows.Forms.ComboBox();
            this.value12 = new System.Windows.Forms.ComboBox();
            this.value11 = new System.Windows.Forms.ComboBox();
            this.value10 = new System.Windows.Forms.ComboBox();
            this.value9 = new System.Windows.Forms.ComboBox();
            this.value8 = new System.Windows.Forms.ComboBox();
            this.value7 = new System.Windows.Forms.ComboBox();
            this.value6 = new System.Windows.Forms.ComboBox();
            this.value5 = new System.Windows.Forms.ComboBox();
            this.value4 = new System.Windows.Forms.ComboBox();
            this.value3 = new System.Windows.Forms.ComboBox();
            this.value2 = new System.Windows.Forms.ComboBox();
            this.value1 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.openImageBtn = new System.Windows.Forms.Button();
            this.showPathText = new System.Windows.Forms.TextBox();
            this.clearImageDetailsBtn = new System.Windows.Forms.Button();
            this.processImageBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageGenerateResult = new System.Windows.Forms.TabPage();
            this.genResLabel = new System.Windows.Forms.Label();
            this.genResBtn = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControlPrediction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageGenerateResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrediction
            // 
            this.tabControlPrediction.Controls.Add(this.tabPage1);
            this.tabControlPrediction.Controls.Add(this.tabPage2);
            this.tabControlPrediction.Controls.Add(this.tabPageGenerateResult);
            this.tabControlPrediction.Location = new System.Drawing.Point(0, 1);
            this.tabControlPrediction.Name = "tabControlPrediction";
            this.tabControlPrediction.SelectedIndex = 0;
            this.tabControlPrediction.Size = new System.Drawing.Size(640, 371);
            this.tabControlPrediction.TabIndex = 0;
            this.tabControlPrediction.SelectedIndexChanged += new System.EventHandler(this.tabControlPrediction_SelectedIndexChanged);
            this.tabControlPrediction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.patientDetails);
            this.tabPage1.Controls.Add(this.comboBox_Sex);
            this.tabPage1.Controls.Add(this.comboBox_Deseace_Name);
            this.tabPage1.Controls.Add(this.clearPatientDetailsBtn);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.textBox_Age);
            this.tabPage1.Controls.Add(this.textBox_Patient_Name);
            this.tabPage1.Controls.Add(this.textBox_PATIENT_id);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // patientDetails
            // 
            this.patientDetails.AutoSize = true;
            this.patientDetails.BackColor = System.Drawing.Color.Transparent;
            this.patientDetails.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patientDetails.Location = new System.Drawing.Point(42, 22);
            this.patientDetails.Name = "patientDetails";
            this.patientDetails.Size = new System.Drawing.Size(186, 26);
            this.patientDetails.TabIndex = 75;
            this.patientDetails.Text = "Enter Patient Details";
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Sex.Location = new System.Drawing.Point(288, 183);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Sex.TabIndex = 74;
            this.comboBox_Sex.Text = "Select Sex";
            // 
            // comboBox_Deseace_Name
            // 
            this.comboBox_Deseace_Name.FormattingEnabled = true;
            this.comboBox_Deseace_Name.Items.AddRange(new object[] {
            "DMD",
            "HD",
            "SCA 1",
            "SCA 2",
            "SCA 3",
            "STROKE"});
            this.comboBox_Deseace_Name.Location = new System.Drawing.Point(288, 221);
            this.comboBox_Deseace_Name.Name = "comboBox_Deseace_Name";
            this.comboBox_Deseace_Name.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Deseace_Name.TabIndex = 73;
            this.comboBox_Deseace_Name.Text = "Select Desease Name";
            // 
            // clearPatientDetailsBtn
            // 
            this.clearPatientDetailsBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPatientDetailsBtn.Location = new System.Drawing.Point(442, 277);
            this.clearPatientDetailsBtn.Name = "clearPatientDetailsBtn";
            this.clearPatientDetailsBtn.Size = new System.Drawing.Size(128, 31);
            this.clearPatientDetailsBtn.TabIndex = 72;
            this.clearPatientDetailsBtn.Text = "Clear";
            this.clearPatientDetailsBtn.UseVisualStyleBackColor = true;
            this.clearPatientDetailsBtn.Click += new System.EventHandler(this.clearPatientDetailsBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(278, 277);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 31);
            this.saveBtn.TabIndex = 71;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(288, 150);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(200, 20);
            this.textBox_Age.TabIndex = 70;
            this.textBox_Age.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_Age_PreviewKeyDown);
            // 
            // textBox_Patient_Name
            // 
            this.textBox_Patient_Name.Location = new System.Drawing.Point(288, 111);
            this.textBox_Patient_Name.Name = "textBox_Patient_Name";
            this.textBox_Patient_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Patient_Name.TabIndex = 69;
            this.textBox_Patient_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_Patient_Name_PreviewKeyDown);
            // 
            // textBox_PATIENT_id
            // 
            this.textBox_PATIENT_id.Location = new System.Drawing.Point(288, 72);
            this.textBox_PATIENT_id.Name = "textBox_PATIENT_id";
            this.textBox_PATIENT_id.Size = new System.Drawing.Size(200, 20);
            this.textBox_PATIENT_id.TabIndex = 68;
            this.textBox_PATIENT_id.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_PATIENT_id_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(135, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Desease Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(136, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(135, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Patient Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar);
            this.tabPage2.Controls.Add(this.imageId);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.value16);
            this.tabPage2.Controls.Add(this.value15);
            this.tabPage2.Controls.Add(this.value14);
            this.tabPage2.Controls.Add(this.value13);
            this.tabPage2.Controls.Add(this.value12);
            this.tabPage2.Controls.Add(this.value11);
            this.tabPage2.Controls.Add(this.value10);
            this.tabPage2.Controls.Add(this.value9);
            this.tabPage2.Controls.Add(this.value8);
            this.tabPage2.Controls.Add(this.value7);
            this.tabPage2.Controls.Add(this.value6);
            this.tabPage2.Controls.Add(this.value5);
            this.tabPage2.Controls.Add(this.value4);
            this.tabPage2.Controls.Add(this.value3);
            this.tabPage2.Controls.Add(this.value2);
            this.tabPage2.Controls.Add(this.value1);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.openImageBtn);
            this.tabPage2.Controls.Add(this.showPathText);
            this.tabPage2.Controls.Add(this.clearImageDetailsBtn);
            this.tabPage2.Controls.Add(this.processImageBtn);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.comboBox9);
            this.tabPage2.Controls.Add(this.comboBox10);
            this.tabPage2.Controls.Add(this.comboBox11);
            this.tabPage2.Controls.Add(this.comboBox12);
            this.tabPage2.Controls.Add(this.comboBox13);
            this.tabPage2.Controls.Add(this.comboBox14);
            this.tabPage2.Controls.Add(this.comboBox15);
            this.tabPage2.Controls.Add(this.comboBox16);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.comboBox8);
            this.tabPage2.Controls.Add(this.comboBox7);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assignment of Gel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(41, 322);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(275, 14);
            this.progressBar.TabIndex = 138;
            // 
            // imageId
            // 
            this.imageId.Location = new System.Drawing.Point(490, 22);
            this.imageId.Name = "imageId";
            this.imageId.Size = new System.Drawing.Size(121, 20);
            this.imageId.TabIndex = 137;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label26.Location = new System.Drawing.Point(414, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 19);
            this.label26.TabIndex = 136;
            this.label26.Text = "Image_ID";
            // 
            // value16
            // 
            this.value16.FormattingEnabled = true;
            this.value16.Location = new System.Drawing.Point(490, 280);
            this.value16.Name = "value16";
            this.value16.Size = new System.Drawing.Size(121, 21);
            this.value16.TabIndex = 135;
            // 
            // value15
            // 
            this.value15.FormattingEnabled = true;
            this.value15.Location = new System.Drawing.Point(490, 250);
            this.value15.Name = "value15";
            this.value15.Size = new System.Drawing.Size(121, 21);
            this.value15.TabIndex = 134;
            // 
            // value14
            // 
            this.value14.FormattingEnabled = true;
            this.value14.Location = new System.Drawing.Point(490, 222);
            this.value14.Name = "value14";
            this.value14.Size = new System.Drawing.Size(121, 21);
            this.value14.TabIndex = 133;
            // 
            // value13
            // 
            this.value13.FormattingEnabled = true;
            this.value13.Location = new System.Drawing.Point(490, 193);
            this.value13.Name = "value13";
            this.value13.Size = new System.Drawing.Size(121, 21);
            this.value13.TabIndex = 132;
            // 
            // value12
            // 
            this.value12.FormattingEnabled = true;
            this.value12.Location = new System.Drawing.Point(490, 164);
            this.value12.Name = "value12";
            this.value12.Size = new System.Drawing.Size(121, 21);
            this.value12.TabIndex = 131;
            // 
            // value11
            // 
            this.value11.FormattingEnabled = true;
            this.value11.Location = new System.Drawing.Point(490, 136);
            this.value11.Name = "value11";
            this.value11.Size = new System.Drawing.Size(121, 21);
            this.value11.TabIndex = 130;
            // 
            // value10
            // 
            this.value10.FormattingEnabled = true;
            this.value10.Location = new System.Drawing.Point(490, 107);
            this.value10.Name = "value10";
            this.value10.Size = new System.Drawing.Size(121, 21);
            this.value10.TabIndex = 129;
            // 
            // value9
            // 
            this.value9.FormattingEnabled = true;
            this.value9.Location = new System.Drawing.Point(490, 79);
            this.value9.Name = "value9";
            this.value9.Size = new System.Drawing.Size(121, 21);
            this.value9.TabIndex = 128;
            // 
            // value8
            // 
            this.value8.FormattingEnabled = true;
            this.value8.Location = new System.Drawing.Point(195, 283);
            this.value8.Name = "value8";
            this.value8.Size = new System.Drawing.Size(121, 21);
            this.value8.TabIndex = 127;
            // 
            // value7
            // 
            this.value7.FormattingEnabled = true;
            this.value7.Location = new System.Drawing.Point(195, 254);
            this.value7.Name = "value7";
            this.value7.Size = new System.Drawing.Size(121, 21);
            this.value7.TabIndex = 126;
            // 
            // value6
            // 
            this.value6.FormattingEnabled = true;
            this.value6.Location = new System.Drawing.Point(195, 226);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(121, 21);
            this.value6.TabIndex = 125;
            // 
            // value5
            // 
            this.value5.FormattingEnabled = true;
            this.value5.Location = new System.Drawing.Point(195, 197);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(121, 21);
            this.value5.TabIndex = 124;
            // 
            // value4
            // 
            this.value4.FormattingEnabled = true;
            this.value4.Location = new System.Drawing.Point(195, 168);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(121, 21);
            this.value4.TabIndex = 123;
            // 
            // value3
            // 
            this.value3.FormattingEnabled = true;
            this.value3.Location = new System.Drawing.Point(195, 138);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(121, 21);
            this.value3.TabIndex = 122;
            // 
            // value2
            // 
            this.value2.FormattingEnabled = true;
            this.value2.Location = new System.Drawing.Point(195, 109);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(121, 21);
            this.value2.TabIndex = 121;
            // 
            // value1
            // 
            this.value1.FormattingEnabled = true;
            this.value1.Location = new System.Drawing.Point(195, 81);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(121, 21);
            this.value1.TabIndex = 120;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.Location = new System.Drawing.Point(487, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 18);
            this.label27.TabIndex = 119;
            this.label27.Text = "Patient ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(338, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 18);
            this.label25.TabIndex = 118;
            this.label25.Text = "Type";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(192, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 18);
            this.label24.TabIndex = 115;
            this.label24.Text = "Patient ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(38, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 18);
            this.label23.TabIndex = 114;
            this.label23.Text = "Type";
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(335, 15);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(38, 27);
            this.openImageBtn.TabIndex = 113;
            this.openImageBtn.Text = "....";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click_1);
            // 
            // showPathText
            // 
            this.showPathText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPathText.Location = new System.Drawing.Point(138, 16);
            this.showPathText.Name = "showPathText";
            this.showPathText.Size = new System.Drawing.Size(191, 24);
            this.showPathText.TabIndex = 112;
            // 
            // clearImageDetailsBtn
            // 
            this.clearImageDetailsBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearImageDetailsBtn.Location = new System.Drawing.Point(506, 308);
            this.clearImageDetailsBtn.Name = "clearImageDetailsBtn";
            this.clearImageDetailsBtn.Size = new System.Drawing.Size(105, 31);
            this.clearImageDetailsBtn.TabIndex = 111;
            this.clearImageDetailsBtn.Text = "Clear\r\n";
            this.clearImageDetailsBtn.UseVisualStyleBackColor = true;
            this.clearImageDetailsBtn.Click += new System.EventHandler(this.clearImageDetailsBtn_Click);
            // 
            // processImageBtn
            // 
            this.processImageBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processImageBtn.Location = new System.Drawing.Point(376, 308);
            this.processImageBtn.Name = "processImageBtn";
            this.processImageBtn.Size = new System.Drawing.Size(106, 31);
            this.processImageBtn.TabIndex = 110;
            this.processImageBtn.Text = "Process";
            this.processImageBtn.UseVisualStyleBackColor = true;
            this.processImageBtn.Click += new System.EventHandler(this.processImageBtn_Click_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label22.Location = new System.Drawing.Point(37, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 19);
            this.label22.TabIndex = 109;
            this.label22.Text = "Upload Image";
            // 
            // comboBox9
            // 
            this.comboBox9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(341, 77);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(135, 25);
            this.comboBox9.TabIndex = 100;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(341, 105);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(135, 25);
            this.comboBox10.TabIndex = 99;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(341, 134);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(135, 25);
            this.comboBox11.TabIndex = 98;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // comboBox12
            // 
            this.comboBox12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(341, 163);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(135, 25);
            this.comboBox12.TabIndex = 97;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(341, 191);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(135, 25);
            this.comboBox13.TabIndex = 96;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(341, 221);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(135, 25);
            this.comboBox14.TabIndex = 95;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(341, 249);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(135, 25);
            this.comboBox15.TabIndex = 94;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "asdfghj",
            "asdfghjkl",
            "sdfghj"});
            this.comboBox16.Location = new System.Drawing.Point(341, 278);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(135, 25);
            this.comboBox16.TabIndex = 93;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "14";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "13";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(320, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "12";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(319, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 87;
            this.label19.Text = "11";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(318, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "10";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(322, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 85;
            this.label21.Text = "9";
            // 
            // comboBox8
            // 
            this.comboBox8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(41, 279);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(144, 25);
            this.comboBox8.TabIndex = 76;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(41, 250);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(144, 25);
            this.comboBox7.TabIndex = 75;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(41, 222);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(144, 25);
            this.comboBox6.TabIndex = 74;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(41, 193);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(144, 25);
            this.comboBox5.TabIndex = 73;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(41, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(144, 25);
            this.comboBox4.TabIndex = 72;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(41, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 25);
            this.comboBox3.TabIndex = 71;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(41, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 25);
            this.comboBox2.TabIndex = 70;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 25);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "1";
            // 
            // tabPageGenerateResult
            // 
            this.tabPageGenerateResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageGenerateResult.BackgroundImage")));
            this.tabPageGenerateResult.Controls.Add(this.genResLabel);
            this.tabPageGenerateResult.Controls.Add(this.genResBtn);
            this.tabPageGenerateResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenerateResult.Name = "tabPageGenerateResult";
            this.tabPageGenerateResult.Size = new System.Drawing.Size(632, 345);
            this.tabPageGenerateResult.TabIndex = 2;
            this.tabPageGenerateResult.Text = "Generate Results";
            this.tabPageGenerateResult.UseVisualStyleBackColor = true;
            // 
            // genResLabel
            // 
            this.genResLabel.AutoSize = true;
            this.genResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genResLabel.ForeColor = System.Drawing.Color.Black;
            this.genResLabel.Location = new System.Drawing.Point(45, 42);
            this.genResLabel.Name = "genResLabel";
            this.genResLabel.Size = new System.Drawing.Size(229, 20);
            this.genResLabel.TabIndex = 1;
            this.genResLabel.Text = "Click Here to Generate Results";
            // 
            // genResBtn
            // 
            this.genResBtn.BackColor = System.Drawing.Color.OldLace;
            this.genResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genResBtn.ForeColor = System.Drawing.Color.Black;
            this.genResBtn.Location = new System.Drawing.Point(260, 77);
            this.genResBtn.Name = "genResBtn";
            this.genResBtn.Size = new System.Drawing.Size(144, 35);
            this.genResBtn.TabIndex = 0;
            this.genResBtn.Text = "Generate Results";
            this.genResBtn.UseVisualStyleBackColor = false;
            this.genResBtn.Click += new System.EventHandler(this.genResBtn_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted_1);
            // 
            // Gel_Doc_UI_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 371);
            this.Controls.Add(this.tabControlPrediction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gel_Doc_UI_Main_Form";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gel_Doc_UI_Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Gel_Doc_UI_Main_Form_Load);
            this.tabControlPrediction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageGenerateResult.ResumeLayout(false);
            this.tabPageGenerateResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrediction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.ComboBox comboBox_Deseace_Name;
        private System.Windows.Forms.Button clearPatientDetailsBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Patient_Name;
        private System.Windows.Forms.TextBox textBox_PATIENT_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.TextBox showPathText;
        private System.Windows.Forms.Button clearImageDetailsBtn;
        private System.Windows.Forms.Button processImageBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox value16;
        private System.Windows.Forms.ComboBox value15;
        private System.Windows.Forms.ComboBox value14;
        private System.Windows.Forms.ComboBox value13;
        private System.Windows.Forms.ComboBox value12;
        private System.Windows.Forms.ComboBox value11;
        private System.Windows.Forms.ComboBox value10;
        private System.Windows.Forms.ComboBox value9;
        private System.Windows.Forms.ComboBox value8;
        private System.Windows.Forms.ComboBox value7;
        private System.Windows.Forms.ComboBox value6;
        private System.Windows.Forms.ComboBox value5;
        private System.Windows.Forms.ComboBox value4;
        private System.Windows.Forms.ComboBox value3;
        private System.Windows.Forms.ComboBox value2;
        private System.Windows.Forms.ComboBox value1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.TextBox imageId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label patientDetails;
        private System.Windows.Forms.TabPage tabPageGenerateResult;
        private System.Windows.Forms.Label genResLabel;
        private System.Windows.Forms.Button genResBtn;
    }
}