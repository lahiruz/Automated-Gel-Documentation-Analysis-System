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
    public partial class HD_SEVERITY : Form
    {
        public HD_SEVERITY()
        {
            InitializeComponent();
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

        private void HD_SEVERITY_Load(object sender, EventArgs e)
        {
            patientId.Text = GlobalVariables.patient_Id;
            ageOnSet.Focus();
        }

        private void SaveFunction_Click(object sender, EventArgs e)
        {

            if (patientId.Text != "" && ageOnSet.Text != "" && totalScore.Text != "" && functionalScore.Text != "")
            {
                Save_patient_Detail();
                this.Visible = false;
                GlobalVariables.severity = true;
                Generate_Report generateReport = new Generate_Report();
                generateReport.Show();
            }
            else
                MessageBox.Show("Enter Correct Details...");
           
        }

        private void Save_patient_Detail()
        {            
            string query1 = "insert into hd_severity(Patient_ID,Age_On_Set,UHDRS_Total_Score,UHDRS_Functional_Score) values ('"
                                + patientId.Text + "','" + ageOnSet.Text + "','" + totalScore.Text + "','" + functionalScore.Text + "')";
            ClassDB.update(query1);
            ClearTextBoxes(this);            
            MessageBox.Show("Successfully Updated");
        }

        private void Cancelfunction_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void patientId_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (patientId.Text == "")
                {
                    MessageBox.Show("Enter Patient ID ");

                }

                else
                {
                    this.ActiveControl = ageOnSet;
                }

            }
        }

        private void totalScore_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (totalScore.Text == "")
                {
                    MessageBox.Show("Enter Total Score ");

                }

                else
                {
                    this.ActiveControl = functionalScore;
                }

            }
        }

        private void ageOnSet_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ageOnSet.Text == "")
                {
                    MessageBox.Show("Enter Age On Set ");

                }

                else
                {
                    this.ActiveControl = totalScore;
                }

            }
        }

        private void functionalScore_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (functionalScore.Text == "")
                {
                    MessageBox.Show("Enter Functional Score ");

                }

                else
                {
                    this.ActiveControl = SaveFunction;
                }

            }
        }

        private void HD_SEVERITY_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
