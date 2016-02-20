using GelDocUI;
using GUI.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Gel_Doc_UI_Main_Form : Form
    {
        public Gel_Doc_UI_Main_Form()
        {
            InitializeComponent();            
        }

        private void Gel_Doc_UI_Main_Form_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            SelectType();            
            this.ActiveControl = textBox_PATIENT_id;           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBox_PATIENT_id.TextLength > 0 && textBox_Patient_Name.TextLength > 0 && textBox_Age.TextLength > 0 && comboBox_Sex.Text != "Select Sex" && comboBox_Deseace_Name.Text != "Select Desease Name")
            {
                Save_patient_Detail();
            }
            else
            {
                MessageBox.Show("Invalid Column Name");
                //ClearTextBoxes(this);
                comboBox_Sex.Text = "Select Sex";
                comboBox_Deseace_Name.Text = "Select Desease Name";

            }
        }

        private void Save_patient_Detail()
        {
            string patient_id = textBox_PATIENT_id.Text;
            GlobalVariables.patient_Id = patient_id;
            string patient_name = textBox_Patient_Name.Text;
            string age = textBox_Age.Text;
            string sex = comboBox_Sex.Text;
            string Desease_Name = comboBox_Deseace_Name.Text;

            string query1 = "insert into Patient_Detail(Patient_ID,Patient_Name,Age,Sex,Desease_Name) values ('"
                                + patient_id + "','" + patient_name + "','" + age + "','" + sex + "','" + Desease_Name + "')";
            ClassDB.update(query1);
            ClearTextBoxes(this);
            comboBox_Sex.Text = "Select Sex";
            comboBox_Deseace_Name.Text = "Select Desease Name";
            
            MessageBox.Show("Successfully Updated");
        }       

        private void openImageBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string FilePath = opd.FileName;
                showPathText.Text = FilePath;

            }
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if (!(c.Parent is NumericUpDown))
                    {
                        ((TextBox)c).Clear();
                    }
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void SelectType()
        {
            string query_Type = "SELECT Name FROM Deseace_Type";
            DataTable dt_Advance_Type = ClassDB.selectRecords(query_Type);

            var a = new[]
            {
                 comboBox1, comboBox2, comboBox3, comboBox4, comboBox5,
                 comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                 comboBox11,comboBox12,comboBox13,comboBox14,comboBox15,
                 comboBox16
            };

            foreach (var comboBox in a)
            {

                comboBox.DataSource = dt_Advance_Type;
                comboBox.DisplayMember = "Name";
                comboBox.BindingContext = new BindingContext();
            }

        }

        private void PatientId()
        {
            string patientId = "SELECT Patient_ID FROM patient_detail";
            DataTable dt_Advance_Type = ClassDB.selectRecords(patientId);

            var patient_Id = new[]
            {
                 value1, value2, value3, value4, value5,
                 value6, value7, value8, value9, value10,
                 value11,value12,value13,value14,value15,
                 value16
            };

            foreach (var value in patient_Id)
            {
                value.DataSource = dt_Advance_Type;
                value.DisplayMember = "Patient_ID";
                value.BindingContext = new BindingContext();
            }

        }

        private void clearPatientDetailsBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);

            SelectType();
            comboBox_Sex.Text = "Select Sex";
            comboBox_Deseace_Name.Text = "Select Desease Name";
        }

        private void processImageBtn_Click_1(object sender, EventArgs e)
        {
            if (showPathText.TextLength > 0 && imageId.TextLength > 0)
            {
                GlobalVariables.image_Id = imageId.Text;
                string comboBox_val1 = comboBox1.Text;
                string comboBox_val2 = comboBox2.Text;
                string comboBox_val3 = comboBox3.Text;
                string comboBox_val4 = comboBox4.Text;
                string comboBox_val5 = comboBox5.Text;
                string comboBox_val6 = comboBox6.Text;
                string comboBox_val7 = comboBox7.Text;
                string comboBox_val8 = comboBox8.Text;
                string comboBox_val9 = comboBox9.Text;
                string comboBox_val10 = comboBox10.Text;
                string comboBox_val11 = comboBox11.Text;
                string comboBox_val12 = comboBox12.Text;
                string comboBox_val13 = comboBox13.Text;
                string comboBox_val14 = comboBox14.Text;
                string comboBox_val15 = comboBox15.Text;
                string comboBox_val16 = comboBox16.Text;
                string textBox_Val1 = value1.Text;
                string textBox_Val2 = value2.Text;
                string textBox_Val3 = value3.Text;
                string textBox_Val4 = value4.Text;
                string textBox_Val5 = value5.Text;
                string textBox_Val6 = value6.Text;
                string textBox_Val7 = value7.Text;
                string textBox_Val8 = value8.Text;
                string textBox_Val9 = value9.Text;
                string textBox_Val10 = value10.Text;
                string textBox_Val11 = value11.Text;
                string textBox_Val12 = value12.Text;
                string textBox_Val13 = value13.Text;
                string textBox_Val14 = value14.Text;
                string textBox_Val15 = value15.Text;
                string textBox_Val16 = value16.Text;

                string Image_path = showPathText.Text;
                string All_Detail = comboBox_val1 + ":" + textBox_Val1 + "," + comboBox_val2 + ":" + textBox_Val2 + ","
                    + comboBox_val3 + ":" + textBox_Val3 + "," + comboBox_val4 + ":" + textBox_Val4 + ","
                    + comboBox_val5 + ":" + textBox_Val5 + "," + comboBox_val6 + ":" + textBox_Val6 + ","
                    + comboBox_val7 + ":" + textBox_Val7 + "," + comboBox_val8 + ":" + textBox_Val8 + ","
                    + comboBox_val9 + ":" + textBox_Val9 + "," + comboBox_val10 + ":" + textBox_Val10 + ","
                    + comboBox_val11 + ":" + textBox_Val11 + "," + comboBox_val12 + ":" + textBox_Val12 + ","
                    + comboBox_val13 + ":" + textBox_Val13 + "," + comboBox_val14 + ":" + textBox_Val14 + ","
                    + comboBox_val15 + ":" + textBox_Val15 + "," + comboBox_val16 + ":" + textBox_Val16;

                if (All_Detail.Contains("NO DNA") && All_Detail.Contains("LADDER"))
                {
                    if (!bgWorker.IsBusy)
                    {
                        progressBar.Visible = true;
                        progressBar.Style = ProgressBarStyle.Marquee;
                        bgWorker.RunWorkerAsync(Image_path + "|" + All_Detail);                    
                    }   
                }
                else
                {
                    MessageBox.Show("Please Assign NO DNA and LADDER Column", "Image Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           }
            else
            {
                MessageBox.Show("Please Provide a Valid Image Path and Image ID");
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string path = (string)e.Argument;
                string[] imageData = path.Split('|');
                GelWrapper.GelDocWrapper wrapper = new GelWrapper.GelDocWrapper();
                //e.Result = wrapper.wrapExecute(imageData[0], imageData[1]);
            }
            catch(Exception e1) {
                MessageBox.Show("error"+e1);
            }
        }

        private void bgWorker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message); 
            }
            else if (e.Cancelled)
            {

            }
            else {

                progressBar.Value = 0;
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Visible = false;
                ClassFunctions.Separation((string)e.Result);
                Generate_Report generateReport = new Generate_Report();
                generateReport.Show();
            }
        }

        
        private void textBox_PATIENT_id_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_PATIENT_id.Text == "")
                {
                    MessageBox.Show("Enter Patient ID");

                }

                else
                {
                    textBox_Patient_Name.Focus();                    
                }

            }
        }

        private void textBox_Patient_Name_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Patient_Name.Text == "")
                {
                    MessageBox.Show("Enter Patient Name");

                }

                else
                {
                    textBox_Age.Focus();
                    //this.ActiveControl = textBox_Age;
                }

            }
        }

        private void textBox_Age_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Age.Text == "")
                {
                    MessageBox.Show("Enter Patient ID");

                }

                else
                {
                    this.ActiveControl = comboBox_Sex;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("CONTROLLER") || comboBox1.Text.Contains("LADDER") || comboBox1.Text == "NO DNA" || comboBox1.Text == "NO BAND")
            {
                value1.Text = "";
                value1.Hide();
            }
            else value1.Show();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.Contains("CONTROLLER") || comboBox2.Text.Contains("LADDER") || comboBox2.Text == "NO DNA" || comboBox2.Text == "NO BAND")
            {
                value2.Text = "";
                value2.Hide();
            }
            else value2.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text.Contains("CONTROLLER") || comboBox3.Text.Contains("LADDER") || comboBox3.Text == "NO DNA" || comboBox3.Text == "NO BAND")
            {
                value3.Text = "";
                value3.Hide();
            }
            else value3.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text.Contains("CONTROLLER") || comboBox4.Text.Contains("LADDER") || comboBox4.Text == "NO DNA" || comboBox4.Text == "NO BAND")
            {
                value4.Text = "";
                value4.Hide();
            }
            else value4.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text.Contains("CONTROLLER") || comboBox5.Text.Contains("LADDER") || comboBox5.Text == "NO DNA" || comboBox5.Text == "NO BAND")
            {
                value5.Text = "";
                value5.Hide();
            }
            else value5.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text.Contains("CONTROLLER") || comboBox6.Text.Contains("LADDER") || comboBox6.Text == "NO DNA" || comboBox6.Text == "NO BAND")
            {
                value6.Text = "";
                value6.Hide();
            }
            else value6.Show();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text.Contains("CONTROLLER") || comboBox7.Text.Contains("LADDER") || comboBox7.Text == "NO DNA" || comboBox7.Text == "NO BAND")
            {
                value7.Text = "";
                value7.Hide();
            }
            else value7.Show();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.Text.Contains("CONTROLLER") || comboBox8.Text.Contains("LADDER") || comboBox8.Text == "NO DNA" || comboBox8.Text == "NO BAND")
            {
                value8.Text = "";
                value8.Hide();
            }
            else value8.Show();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.Text.Contains("CONTROLLER") || comboBox9.Text.Contains("LADDER") || comboBox9.Text == "NO DNA" || comboBox9.Text == "NO BAND")
            {
                value9.Text = "";
                value9.Hide();
            }
            else value9.Show();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text.Contains("CONTROLLER") || comboBox10.Text.Contains("LADDER") || comboBox10.Text == "NO DNA" || comboBox10.Text == "NO BAND")
            {
                value10.Text = "";
                value10.Hide();
            }
            else value10.Show();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.Text.Contains("CONTROLLER") || comboBox11.Text.Contains("LADDER") || comboBox11.Text == "NO DNA" || comboBox11.Text == "NO BAND")
            {
                value11.Text = "";
                value11.Hide();
            }
            else value11.Show();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.Text.Contains("CONTROLLER") || comboBox12.Text.Contains("LADDER") || comboBox12.Text == "NO DNA" || comboBox12.Text == "NO BAND")
            {
                value12.Text = "";
                value12.Hide();
            }
            else value12.Show();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.Text.Contains("CONTROLLER") || comboBox13.Text.Contains("LADDER") || comboBox13.Text == "NO DNA" || comboBox13.Text == "NO BAND")
            {
                value13.Text = "";
                value13.Hide();
            }
            else value13.Show();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.Text.Contains("CONTROLLER") || comboBox14.Text.Contains("LADDER") || comboBox14.Text == "NO DNA" || comboBox14.Text == "NO BAND")
            {
                value14.Text = "";
                value14.Hide();
            }
            else value14.Show();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.Text.Contains("CONTROLLER") || comboBox15.Text.Contains("LADDER") || comboBox15.Text == "NO DNA" || comboBox15.Text == "NO BAND")
            {
                value15.Text = "";
                value15.Hide();
            }
            else value15.Show();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox16.Text.Contains("CONTROLLER") || comboBox16.Text.Contains("LADDER") || comboBox16.Text == "NO DNA" || comboBox16.Text == "NO BAND")
            {
                value16.Text = "";
                value16.Hide();
            }
            else value16.Show();
        }

        private void clearImageDetailsBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            SelectType();
            comboBox_Sex.Text = "Select Sex";
            comboBox_Deseace_Name.Text = "Select Desease Name";
        }       

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            PatientId();
        }

        private void Gel_Doc_UI_Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Gel_Doc_UI_Login_Form gelUI = new Gel_Doc_UI_Login_Form();
            gelUI.Show();

        }

        private void tabControlPrediction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genResBtn_Click(object sender, EventArgs e)
        {
            Generate_Report genReport = new Generate_Report();
            genReport.Show();
        }                     
    }
}
