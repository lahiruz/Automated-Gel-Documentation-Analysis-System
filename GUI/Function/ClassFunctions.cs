using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using GelDocUI;
using GUI.Function;


namespace GUI
{

    static class ClassFunctions
    {

        public static void Separation(string imageData)
        {
            if (imageData != "")
            {

                string imageID = GlobalVariables.image_Id;
                //string all1 = "1:DMD C:692.000000,575.000000,531.000000,436.000000,381.000000,260.000000,234.000000:579.000000,439.000000,388.000000,267.000000,240.000000||3:DMD D:597.000000,515.000000,483.000000,461.000000,436.000000,391.000000,369.000000,308.000000,260.000000,224.000000,215.000000,192.000000:469.000000,446.000000,313.000000,226.000000||6:DMD A:536.000000,491.000000,432.000000,332.000000:519.000000,476.000000,418.000000,323.000000||8:DMD B:667.000000,415.000000,269.000000:632.000000,465.000000,408.000000,265.000000||10:DMD E:552.000000:557.000000||12:DMD F::291.000000||";

                string[] words = imageData.Split('|');
                if (words.Length > 0)
                {
                    foreach (string word in words)
                    {

                        string[] InsertString = word.Split(':');
                        string query1 = "Insert into db_final_value(Image_ID,Patient_ID,Desease_Name,BP_Value,Negative_Controller) values ('" + imageID + "','"
                            + InsertString[0] + "','" + InsertString[1] + "','" + InsertString[2] + "','" + InsertString[3] + "')";

                        ClassDB.update(query1);
                    }
                }
            }
            else {
                MessageBox.Show("Image is not Valid", "Image Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}