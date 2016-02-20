using GelDocUI;
using GUI.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Generate_Report : Form
    {
        public Generate_Report()
        {
            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {

            if (GlobalVariables.severity == true)
            {
                SelectImageId();
                //SelectDeceaseType();
                checkseverity.Enabled = true;
                ReportImageId.Text = "Image ID....";
                patientId.Text = "Patient Id....";
                deseaseType.Text = "Desease Type....";
            }
            else
            {
                SelectImageId();
                //SelectDeceaseType();
                checkseverity.Enabled = false;
                ReportImageId.Text = "Image ID....";
                patientId.Text = "Patient Id....";
                deseaseType.Text = "Desease Type....";
            }
        }

        private void SelectImageId()
        {
            string query_Type = "SELECT DISTINCT Image_ID FROM db_final_value";
            DataTable dt_Advance_Type = ClassDB.selectRecords(query_Type);           

            ReportImageId.DataSource = dt_Advance_Type;
            ReportImageId.DisplayMember = "Image_ID";
            ReportImageId.BindingContext = new BindingContext();
         

        }

        private void SelectPatientId()
        {
            string filter = ReportImageId.Text;
            string query_Type = "SELECT DISTINCT Patient_ID FROM db_final_value WHERE Image_ID = '" + filter + "'";
            DataTable dt_Advance_Type = ClassDB.selectRecords(query_Type);

            patientId.DataSource = dt_Advance_Type;
            patientId.DisplayMember = "Patient_ID";
            patientId.BindingContext = new BindingContext();


        }

        private void SelectDeceaseType()
        {

            string query_Type = "SELECT Desease_Name FROM db_final_value ";
            DataTable dt_Advance_Type = ClassDB.selectRecords(query_Type);

            deseaseType.DataSource = dt_Advance_Type;
            deseaseType.DisplayMember = "Desease_Name";
            deseaseType.BindingContext = new BindingContext();


        }

           

        private void imageId_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectPatientId();
        }

        private void deseaseType_SelectedValueChanged(object sender, EventArgs e)
        {
            GlobalVariables.patient_Id = patientId.Text;
            if (deseaseType.Text == "HD")
            {
                if (ReportImageId.Text != "Image ID..." && patientId.Text != "Patient Id...")
                {
                    HD_SEVERITY hdSeverity = new HD_SEVERITY();
                    hdSeverity.Show();
                    //checkseverity.Enabled = true;
                    this.Hide();
                }
                else
                    MessageBox.Show("Enter Correct Details...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gel_Doc_UI_Main_Form mainForm = new Gel_Doc_UI_Main_Form();
            mainForm.Hide();

            string genaratReportResult;
            //GlobalVariables.image_Id = ReportImageId.Text;
            //GlobalVariables.patient_Id = patientId.Text;
            //GlobalVariables.desease_Type = deseaseType.Text;
            //GlobalVariables.severity;

            if (deseaseType.Text == "DMD")
            {
                //severity = false;
                genaratReportResult = GlobalVariables.patient_Id + "|" + GlobalVariables.desease_Type + "|" + GlobalVariables.severity;
            }

            else if (deseaseType.Text == "STROKE")
            {
                //severity = false;
                genaratReportResult = GlobalVariables.image_Id + "|" + GlobalVariables.desease_Type + "|" + GlobalVariables.severity;

            }

            else if (deseaseType.Text == "HD")
            {
                //GlobalVariables.severity = true;
                genaratReportResult = GlobalVariables.patient_Id + "|" + GlobalVariables.desease_Type + "|" + GlobalVariables.severity;
            }

            this.Hide();

            System.Diagnostics.Process clientProcess = new Process();
            string id = "";
            if (GlobalVariables.desease_Type.Equals("STROKE"))
            {
                id = GlobalVariables.image_Id;
            }
            else
            {
                id = GlobalVariables.patient_Id;
            }
            clientProcess.StartInfo.FileName = @"C:\Program Files\Java\jdk1.8.0_66\bin\java.exe";
            clientProcess.StartInfo.Arguments = @"-jar F:\GelDocNeededSources\GelProjectJarFile\GelProject.jar" + " " + GlobalVariables.desease_Type + " " + id + " " + GlobalVariables.severity;
            clientProcess.Start();            
            clientProcess.WaitForExit();
            Application.Exit();

        }

        private void checkseverity_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = @"C:\Program Files\Java\jdk1.8.0_66\bin\java.exe";
            clientProcess.StartInfo.Arguments = @"-jar F:\GelDocNeededSources\GelProjectJarFile\GelProject.jar" + " " + GlobalVariables.desease_Type + " " + GlobalVariables.patient_Id + " " + GlobalVariables.severity;
            clientProcess.Start();
            //clientProcess.StartInfo.RedirectStandardOutput = true;
            //clientProcess.StartInfo.UseShellExecute = false;
            //string a = clientProcess.StandardOutput.ReadToEnd();
           
            clientProcess.WaitForExit();        
        }

        private void Generate_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            //Generate_Report generateReport = new Generate_Report();
            //generateReport.Show();
        }

        private void deseaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariables.image_Id = ReportImageId.Text;
            GlobalVariables.patient_Id = patientId.Text;
            GlobalVariables.desease_Type = deseaseType.Text;
        }
    }
}
