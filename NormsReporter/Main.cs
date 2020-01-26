using IronPdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormsReporter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            TabADAS.Enabled = false;
            TabAttention.Enabled = false;
            TabMemory.Enabled = false;
            TabVisuospatial.Enabled = false;
            TabLanguage.Enabled = false;
            TabMotor.Enabled = false;
            TabAdaptiveFunction.Enabled = false;
        }

        private void premoridNext_Click(object sender, EventArgs e)
        {
            premoridNext.TabIndex = 1;
            premoridNext.TabStop = true;

            if ((TextMoCA.Text  == "") || (TextAMNART.Text == "") || (TextOrientPerson.Text == "") || 
                (TextOrientPerson.Text == "") || (TxtFirstName.Text == "") || (TxtLastName.Text == "") || 
                (ComboSex.Text == "") || (TextEducation.Text == "") || (Handedness.Text == "") || (DateDOB.Text == "") 
                || (DateOfTesting.Text == "") || (ComboEthnicity.Text == "") || (ComboNeuropsychologist.Text == "") 
                || (ComboReferredBY.Text == ""))
            {
                MessageBox.Show("Please fill in all the values.");
            }
            else 
            {
                TabADAS.Enabled = true;
                PremorbidTab.SelectTab(TabADAS);
            }

        }

        private void TextMoCA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextMoCA.Text, "  ^ [0-9]"))
            {
                TextMoCA.Text = "";
            }
        }
        private void TextMoCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextAMNART_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextOrientPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboReferredBY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboNeuropsychologist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboEthnicity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static double CalculateVisuospatialzScore(int age, double beery)
        {
            double vmiss = 0.0;
            //Below is the Beery array for calculating the Standard Score
            double[] numArray = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            double[] numArray166 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 50, 57, 66, 72, 77, 83, 87, 92, 98, 103, 107 };
            double[] numArray167 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 50, 58, 65, 72, 77, 84, 87, 92, 97, 103, 108, 113 };
            double[] numArray168 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 49, 55, 63, 69, 75, 80, 85, 90, 95, 100, 105, 110, 116 };
            double[] numArray169 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 51, 61, 69, 74, 79, 84, 89, 94, 99, 104, 108, 113, 119 };
            double[] numArray170 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 49, 56, 64, 72, 77, 82, 86, 91, 96, 101, 106, 111, 115, 120 };
            double[] numArray171 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 53, 61, 67, 74, 79, 84, 88, 94, 98, 104, 108, 113, 117, 121 };
            double[] numArray172 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 54, 64, 69, 75, 80, 85, 89, 95, 99, 105, 109, 114, 119, 124 };
            double[] numArray173 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 50, 58, 66, 71, 76, 81, 86, 91, 96, 100, 106, 111, 116, 121, 126 };
            double[] numArray174 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 53, 61, 69, 74, 79, 84, 89, 94, 99, 101, 108, 114, 119, 124, 129 };
            double[] numArray175 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 48, 56, 64, 71, 76, 81, 86, 91, 96, 101, 105, 111, 116, 122, 127, 132 };
            double[] numArray176 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 53, 61, 69, 74, 79, 84, 89, 94, 99, 105, 109, 114, 119, 125, 130, 135 };
            double[] numArray177 = numArray;
            numArray = new double[] { 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 51, 59, 67, 74, 78, 83, 88, 93, 98, 103, 108, 113, 117, 121, 127, 134, 138 };
            double[] numArray178 = numArray;
            if (beery < 995)
            //Visuospatial Tab
            //Pulls the Beery Standard Score from the above coded array based upon the patient's age
            //The Beery raw scores are 0 - 30.
            {
                double num19 = age;
                if (num19 < 19 || num19 > 39)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray167[num2];
                }
                else if (num19 < 40 || num19 > 49 )
                {
                    int num2 = 0;
                    if (beery <= numArray166[num2])
                    {
                        while (beery != numArray166[num2])
                        {
                            num2 = checked(num2 + 1);
                        }
                    }
                    vmiss = numArray168[num2];
                }
                else if (num19 < 50 || num19 > 54)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray169[num2];
                }
                else if (num19 < 55 || num19 > 59)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray170[num2];
                }
                else if (num19 < 60 || num19 > 64)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray171[num2];
                }
                else if (num19 < 65 || num19 > 69 )
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray172[num2];
                }
                else if (num19 < 70 || num19 > 74)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray173[num2];
                }
                else if (num19 < 75 || num19 > 79)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray174[num2];
                }
                else if (num19 < 80 || num19 > 84)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray175[num2];
                }
                else if (num19 < 85 || num19 > 89)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray176[num2];
                }
                else if (num19 < 90 || num19 > 94)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray177[num2];
                }
                else if (num19 >= 95)
                {
                    int num2 = 0;
                    while (beery != numArray166[num2])
                    {
                        num2 = checked(num2 + 1);
                    }
                    vmiss = numArray178[num2];
                }
            }
            else
            {
                vmiss = 997;
            }

            return vmiss;
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        private static string CalculateMOCAInterpretation(int moca)
        {
            var mocaIntpretation = string.Empty;
            if (moca > 25 && moca < 31)
            {
                mocaIntpretation = "Within Normal Limits";
            }
            else if(moca> 18 && moca< 26)
            {
                mocaIntpretation = "Mild Impairment";
            }
            else if (moca > 10 && moca < 18)
            {
                mocaIntpretation = "Mild Dementia";
            }
            else if (moca > 5 && moca < 11)
            {
                mocaIntpretation = "Moderate Dementia";
            }
            else if (moca > 0 && moca < 6)
            {
                mocaIntpretation = "Severe Dementia";
            }
            return mocaIntpretation;
        }
        public HVLzScore HVLTZScore(int age, double hvltrtp, double hvltrfp, double hvltr1, double hvltr2, double hvltr3, 
            double hvltr4, double hvltr1to3, double hvltrd)
        {
            HVLzScore z = new HVLzScore();
            //next this calculates the "Discrimination". Subtracting False Positives from True //Positives
            double Discrimination = hvltrtp - hvltrfp;

            //HVLT section, Z-Score for HVLT is calculated here
            //Based on patient age, the Z-Score is calculated with the following formulas (for //Trials 1, Trial 2, Trial 3, Trial 4, 
            if ((age < 31 == true|| age > 54 == true))
            {
                z.hvltr1z = (hvltr1 - 7.8) / 1.7;
                z.hvltr2z = (hvltr2 - 9.9) / 1.5;
                z.hvltr3z = (hvltr3 - 10.9) / 1.2;
                z.hvltr4z = (hvltr4 - 10.3) / 1.7;
                z.hvltr1to3z = (hvltr1to3 - 28.8) / 3.8;
                z.hvltrhz = (hvltrtp - 11.8) / 0.4;
                z.hvltrfpz = (hvltrfp - 0.7) / 0.9;
                z.hvltrdz = (hvltrd - 11.2) / 1.1;
            }
            else if ((age < 55 == true || age > 69 == true))
            {
                z.hvltr1z = (hvltr1 - 7.4) / 1.9;
                z.hvltr2z = (hvltr2 - 9.7) / 1.7;
                z.hvltr3z = (hvltr3 - 10.6) / 1.4;
                z.hvltr4z = (hvltr4 - 9.8) / 1.8;
                z.hvltr1to3z = (hvltr1to3 - 27.5) / 1.3;
                z.hvltrhz = (hvltrtp - 11.5) / 0.9;
                z.hvltrfpz = (hvltrfp - 0.7) / 0.9;
                z.hvltrdz = (hvltrd - 10.8) / 1.4;
            }
            else if (age >= 70)
            {
                z.hvltr1z = (hvltr1 - 6.7) / 2;
                z.hvltr2z = (hvltr2 - 8.8) / 2.1;
                z.hvltr3z = (hvltr3 - 9.7) / 2;
                z.hvltr4z = (hvltr4 - 8.7) / 2.8;
                z.hvltr1to3z = (hvltr1to3 - 25.2) / 5.5;
                z.hvltrhz = (hvltrtp - 11.3) / 0.9;
                z.hvltrfpz = (hvltrfp - 0.7) / 0.9;
                z.hvltrdz = (hvltrd - 10.6) / 1.5;
            }
            Main m = new Main();
            z.hvltr1z = m.quarantine(hvltr1, z.hvltr1z);
            z.hvltr2z = m.quarantine(hvltr2, z.hvltr2z);
            z.hvltr3z = this.quarantine(hvltr3, z.hvltr3z);
            z.hvltr1to3z = this.quarantine(hvltr1to3, z.hvltr1to3z);
            z.hvltr4z = this.quarantine(hvltr4, z.hvltr4z);
            z.hvltrhz = this.quarantine(hvltrtp, z.hvltrhz);
            z.hvltrfpz = this.quarantine(hvltrfp, z.hvltrfpz);
            z.hvltrdz = this.quarantine(hvltrd, z.hvltrdz);
            return z;
        }
        public double quarantine(double rawscore, double normedscore)
        {
            if (rawscore >= 995)
            {
                normedscore = rawscore;
            }
            return normedscore;
        }
        private static int CalculateNamingScore(int namingFingers, int namingObjects)
        {
            int namingScrore = namingFingers + namingObjects;
            double num3 = namingScrore;
            if ((num3 < 0 || num3 > 2 ? false : true))
            {
                //if true, assigns a value o adasnaming, else moves on to next condition
                namingScrore = 0;
            }
            else if ((num3 < 3 || num3 > 5 ? false : true))
            {
                namingScrore = 1;
            }
            else if ((num3 < 6 || num3 > 8 ? false : true))
            {
                namingScrore = 2;
            }
            else if ((num3 < 9 || num3 > 11 ? false : true))
            {
                namingScrore = 3;
            }
            else if ((num3 < 12 || num3 > 14 ? false : true))
            {
                namingScrore = 4;
            }
            else if ((num3 < 15 || num3 > 17 ? false : true))
            {
                namingScrore  = 5;
            }
            
            return namingScrore;
        }
        private static zScore CalculateVSATTimezScore(int Education, string gender, double ftdom, double ftndom, 
                                             int VSATTime, int VSATErrors, int age)
        {
            zScore z = new zScore();

            if ((age < 20 || age > 49 ? false : true))
            {
                if (gender== "Male")
                {
                    z.ftapdomzScore = (ftdom - 53.57) / 6.22;
                    z.ftapndomzScore = (ftndom - 48.77) / 6.34;
                }
                if (gender=="Female")
                {
                    z.ftapdomzScore = (ftdom - 49.52) / 5.49;
                    z.ftapndomzScore = (ftndom - 45.18) / 5.48;
                }
                if (Education <= 12)
                {
                    z.VSatTimezScore = (VSATTime - 85.3) / 24.7;
                    z.VASTErrorszScore = (VSATErrors - 1) / 2.1;
                }
                if (Education >= 13)
                {
                    z.VSatTimezScore = (VSATTime - 76.1) / 18.2;
                    z.VASTErrorszScore = (VSATErrors - 0.8) / 1.3;
                }
            }
            else if ((age < 50 || age > 69 ? false : true))
            {
                if (gender== "Male")
                {
                    z.ftapdomzScore  = (ftdom - 52.12) / 6.32;
                    z.ftapndomzScore = (ftndom - 48.03) / 7.16;
                }
                if (gender == "Female")
                {
                    z.ftapdomzScore = (ftdom - 45.74) / 5.7;
                    z.ftapndomzScore = (ftndom - 42.78) / 5.9;
                }
                if (Education <= 12)
                {
                    z.VSatTimezScore = (VSATTime - 97.9) / 25.2;
                    z.VASTErrorszScore = (VSATErrors - 2.1) / 2.1;
                }
                if (Education >= 13)
                {
                    z.VSatTimezScore = (VSATTime - 84.3) / 28.6;
                    z.VASTErrorszScore = (VSATErrors - 1.7) / 2.1;
                }
            }
            else if (age >= 70)
            {
                if (gender== "Male")
                {
                    z.ftapdomzScore = (ftdom - 48.47) / 7.9;
                    z.ftapndomzScore = (ftndom - 44.04) / 5.65;
                }
                if (gender== "Female")
                {
                    z.ftapdomzScore = (ftdom - 39.84) / 5.03;
                    z.ftapndomzScore = (ftndom - 37.78) / 5.67;
                }
                if (Education <= 12)
                {
                    z.VSatTimezScore = (VSATTime - 113.7) / 37;
                    z.VASTErrorszScore = (VSATErrors - 2.9) / 2.7;
                }
                if (Education >= 13)
                {
                    z.VSatTimezScore = (VSATTime - 88) / 22.3;
                    z.VASTErrorszScore = (VSATErrors - 1.8) / 2.6;
                }
            }

            z.VSatTimezScore *= -1;
            z.VASTErrorszScore *= -1;
            Main m = new Main();
            z.ftapdomzScore = m.quarantine(ftdom, z.ftapdomzScore);
            z.ftapndomzScore = m.quarantine(ftndom, z.ftapndomzScore);
            z.VSatTimezScore = m.quarantine(VSATTime, z.VSatTimezScore);
            z.VASTErrorszScore = m.quarantine(VSATErrors, z.VASTErrorszScore);
            return z;
        }
        private static TrailszScore CalculateTrailszScore(int age, double bnt, double trailsA, double trailsB, int education)
        {
            TrailszScore z = new TrailszScore();
            if ((age < 35 || age > 44 ? false : true))
            {
                z.BNTzScore = (bnt - 56.1) / 3.6;
                z.TrailsAzScore = (trailsA - 28.54) / 10.09;
                z.TrailsBzScore = (trailsB - 58.46) / 16.41;
            }
            else if ((age < 45 || age > 54 ? false : true))
            {
                z.BNTzScore = (bnt - 55.4) / 3.6;
                z.TrailsAzScore = (trailsA - 31.78) / 9.93;
                z.TrailsBzScore = (trailsB - 63.76) / 14.42;
            }
            else if ((age < 55 || age > 59 ? false : true))
            {
                z.BNTzScore = (bnt - 56) / 3.1;
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 35.1) / 10.94; z.TrailsBzScore = (trailsB - 78.84) / 19.09;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 31.72) / 10.14;
                    z.TrailsBzScore = (trailsB - 68.74) / 21.02;
                }
            }
            else if ((age < 60 || age > 64 ? false : true))
            {
                z.BNTzScore = (bnt - 56.6) / 2.9;
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 33.22) / 9.1;
                    z.TrailsBzScore = (trailsB - 74.55) / 19.55;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 31.32) / 6.96;
                    z.TrailsBzScore = (trailsB - 64.58) / 18.59;
                }
            }
            else if ((age < 65 || age > 69 ? false : true))
            {
                z.BNTzScore = (bnt - 55.8) / 3.5;
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 39.14) / 11.84;
                    z.TrailsBzScore = (trailsB - 91.32) / 28.89;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 33.84) / 6.69;
                    z.TrailsBzScore = (trailsB - 67.12) / 9.31;
                }
            }
            else if ((age < 70 || age > 74 ? false : true))
            {
                z.BNTzScore = (bnt - 54.3) / 4.4;
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 42.47) / 15.15;
                    z.TrailsBzScore = (trailsB - 109.95) / 35.15;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 40.13) / 14.48;
                    z.TrailsBzScore = (trailsB - 86.27) / 24.07;
                }
            }
            else if ((age < 75 || age > 79 ? false : true))
            {
                z.BNTzScore = (bnt - 53.4) / 4.6;
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 50.81) / 17.44;
                    z.TrailsBzScore = (trailsB - 130.61) / 45.74;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 41.74) / 15.32;
                    z.TrailsBzScore = (trailsB - 100.68) / 44.16;
                }
            }
            else if ((age < 80 || age > 84 ? false : true))
            {
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 58.19) / 23.31;
                    z.TrailsBzScore = (trailsB - 152.74) / 65.68;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 55.32) / 21.28;
                    z.TrailsBzScore = (trailsB - 132.15) / 42.95;
                }
            }
            else if (age >= 85)
            {
                if (education <= 12)
                {
                    z.TrailsAzScore = (trailsA - 57.56) / 21.54;
                    z.TrailsBzScore = (trailsB - 167.69) / 78.5;
                }
                if (education > 12)
                {
                    z.TrailsAzScore = (trailsA - 63.46) / 29.22;
                    z.TrailsBzScore = (trailsB - 140.54) / 75.38;
                }
            }
            z.TrailsAzScore *= -1;
            z.TrailsBzScore *= -1;

            Main m = new Main();

            z.BNTzScore = m.quarantine(bnt, z.BNTzScore);
            z.TrailsAzScore = m.quarantine(trailsA, z.TrailsAzScore);
            z.TrailsBzScore = m.quarantine(trailsB, z.TrailsBzScore);

            return z;

        }
        private static StroopzScore CalculateStroopzScore(int age, double word, double color, double wordColor)
        {
            StroopzScore z = new StroopzScore();
            
            bool flag;
            Main m = new Main();
            word = m.quarantine(word, z.wordt);
            z.colort = m.quarantine(color, z.colort);
            z.colorwordt = m.quarantine(wordColor, z.colorwordt);
            if ((age < 45 || age > 64 ? false : true))
            {
                if (word < 995)
                {
                    word += 8;
                }
                if (color < 995)
                {
                    color += 4;
                }
                if (wordColor < 995)
                {
                    wordColor += 5;
                }
            }
            else if (age >= 65)
            {
                if (word < 995)
                {
                    word += 14;
                }
                if (color < 995)
                {
                    color += 11;
                }
                if (wordColor < 995)
                {
                    wordColor += 15;
                }
            }
            if (word >= 995 && color >= 995)
            {
                if (wordColor < 995)
                {
                    flag = true;
                }
                flag = false;
                if (!flag)
                {
                    z.interference = 997;
                }
                else
                {
                    z.predictedcolorword = (double)(checked((int)Math.Round(color * word / (color + word))));
                    z.interference = wordColor - z.predictedcolorword;
                }
                z.interferencet = m.quarantine(z.interference, z.interferencet);
                if (word < 995)
                {
                    z.wordt = (double)(checked((int)Math.Round(word * 0.5 - 4)));
                }
                if (color < 995)
                {
                    z.colort = (double)(checked((int)Math.Round(color * 0.667 - 3.33)));
                }
                if (wordColor < 995)
                {
                    z.colorwordt = wordColor + 5;
                }
                if (z.interference < 995)
                {
                    z.interferencet = z.interference + 50;
                }

            }
            
            return z;
        }
        private static LanguagezScore CalculateLanguagezScore(int age, double f, double a, double s, int education, double animals)
        {
            LanguagezScore z = new LanguagezScore();
             z.fas = f + a + s;

            if (age <= 59)
            {
                if (education <= 8)
                {
                    z.fasz = (z.fas - 38.5) / 12;
                    z.animalsz = (animals - 19.8) / 4.2;
                }
                if (education >= 9 & education <= 12)
                {
                    z.fasz = (z.fas - 40.5) / 10.7;
                    z.animalsz = (animals - 19.8) / 4.2;
                }
                if (education > 12)
                {
                    z.fasz = (z.fas - 44.7) / 11.2;
                    z.animalsz = (animals - 21.9) / 5.4;
                }
            }
            else if ((age < 60 || age > 79 ? false : true))
            {
                if (education <= 8)
                {
                    z.fasz = (z.fas - 25.3) / 11.1;
                    z.animalsz = (animals - 14.4) / 3.4;
                }
                if (education >= 9 & education <= 12)
                {
                    z.fasz = (z.fas - 35.6) / 12.5;
                    z.animalsz = (animals - 16.4) / 4.3;
                }
                if (education > 12)
                {
                    z.fasz = (z.fas - 42) / 12.1;
                    z.animalsz = (animals - 18.2) / 4.2;
                }
            }
            else if (age > 79)
            {
                if (education <= 8)
                {
                    z.fasz = (z.fas - 22.4) / 8.2;
                    z.animalsz = (animals - 13.1) / 3.8;
                }
                if (education <= 9 & education <= 12)
                {
                    z.fasz = (z.fas - 29.8) / 11.4;
                    z.animalsz = (animals - 13.9) / 3.4;
                }
                if (education > 12)
                {
                    z.fasz = (z.fas - 37) / 11.2;
                    z.animalsz = (animals - 16.3) / 4.3;
                }
            }
            Main m = new Main();
            z.fasz = m.quarantine(z.fas, z.fasz);
            z.animalsz = m.quarantine(animals, z.animalsz);
            return z;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dob = Convert.ToDateTime(DateDOB.Text);
                int age = CalculateAge(dob);
                int VASTABCTime = Convert.ToInt32(TextVSATABCTime.Text);
                int VSAT20_19Time = Convert.ToInt32(TextVSAT20_19Time.Text);
                int VSAT100_97Time = Convert.ToInt32(TextVSAT100_97Time.Text);
                int VSATMon_TueTime = Convert.ToInt32(TextVSATMon_TuesTime.Text);
                int VSATSun_SATTime = Convert.ToInt32(TextVSATSun_SatTime.Text);
                int VSatJan_FebTime = Convert.ToInt32(TextVSATJan_FebTime.Text);
                int VSATDec_NovTime = Convert.ToInt32(TextVSATDec_NovTime.Text);
                int VSAT1A_2BTime = Convert.ToInt32(TextVSAT1A_2BTime.Text);
                double ftdom = Convert.ToDouble(TextFingerTapDom.Text);
                double ftndom = Convert.ToDouble(TextFingerTapNonDom.Text);
                int education = Convert.ToInt32(TextEducation.Text);
                double trail_A = Convert.ToDouble(TextTrailsATime.Text);
                double trail_B = Convert.ToDouble(TextTrailsBTime.Text);
                double FNumberDigit = Convert.ToDouble(TextDigitsForw.Text);
                double ReservsedNumberDigit = Convert.ToDouble(TextDigitsRev.Text);
                double digitsforwardz = (FNumberDigit - 6.57) / 1.38;
                double digitsbackwardz = (ReservsedNumberDigit - 4.79) / 1.42;
                double HVLTrial1 = Convert.ToDouble(TextHVLTRT1.Text);
                double HVLTrial2 = Convert.ToDouble(TextHVLTRT2.Text);
                double HvlTrial3 = Convert.ToDouble(TextHVLTRT3.Text);
                double HvlTrial4 = Convert.ToDouble(TextHVLTRT4.Text);
                double HvlTrial1to3 = HVLTrial1 + HVLTrial2 + HvlTrial3;
                double HVLTotal = HVLTrial1 + HVLTrial2 + HvlTrial3 + HvlTrial4;
                double word = Convert.ToDouble(TextStroopWord.Text);
                double Color = Convert.ToDouble(TextStroopColor.Text);
                double ColorWord = Convert.ToDouble(TextStroopColorWord.Text);
                double FalsePossitive = Convert.ToDouble(TextHVLTRFalsePos.Text);
                double TruePossitive = Convert.ToDouble(texttruepossitive.Text);
                double HVLTrD = TruePossitive - FalsePossitive;
                double CloxTrial1 = Convert.ToDouble(TextCloxTr1.Text);
                double CloxTrial2 = Convert.ToDouble(TextCloxTr2.Text);
                double BeeryVMI = Convert.ToDouble(TextVMI.Text);
                double F = Convert.ToDouble(TextF.Text);
                double A = Convert.ToDouble(TextA.Text);
                double S = Convert.ToDouble(TextS.Text);
                double animals = Convert.ToDouble(TextAnimal.Text);

                int VASTTime = VASTABCTime + VSAT20_19Time + VSAT100_97Time + VSATMon_TueTime
                   + VSATSun_SATTime + VSatJan_FebTime + VSATDec_NovTime + VSAT1A_2BTime;
                int VSATErrors = Convert.ToInt32(TextVSATABCErr.Text) + Convert.ToInt32(TextVSAT20_19Err.Text) + Convert.ToInt32(TextVSAT100_97Err.Text) + Convert.ToInt32(TextVSATMon_TuesErr.Text) + Convert.ToInt32(TextVSATSun_SatErr.Text) + Convert.ToInt32(TextVSATJan_FebErr.Text) + Convert.ToInt32(TextVSATDec_NovErr.Text) + Convert.ToInt32(TextVSAT1A_2BErr.Text) + Convert.ToInt32(LabelVSATVigil.Text);
                double vBeetScore = CalculateVisuospatialzScore(age, BeeryVMI);




                string mocaIntepretation = CalculateMOCAInterpretation(Convert.ToInt32(TextMoCA.Text));
                double IQ = 118.2 - 0.89 * Convert.ToInt32(TextAMNART.Text) + 0.64 * Convert.ToInt32(TextEducation.Text);
                int WordRecallAverageError = (Convert.ToInt32(TextADASWRETr1.Text) + Convert.ToInt32(TextADASWRETr2.Text) + Convert.ToInt32(TextADASWRETr3.Text)) / 3;
                int Misses = (Convert.ToInt32(TextADASWordRecMissTr1.Text) + Convert.ToInt32(TextADASWordRecMissTr2.Text) + Convert.ToInt32(TextADASWordRecMissTr3.Text)) / 3;
                int FalseAvge = (Convert.ToInt32(TextADASFalsePosTr1.Text) + Convert.ToInt32(TextADASFalsePosTr2.Text) + Convert.ToInt32(TextADASFalsePosTr3.Text)) / 3;
                int namingScore = CalculateNamingScore(Convert.ToInt32(TextADASFingerErr.Text), Convert.ToInt32(TextADASObjErr.Text));
                int Trial1Errors = Convert.ToInt32(TextADASWordRecMissTr1.Text) + Convert.ToInt32(TextADASFalsePosTr1.Text);
                int Trial2Errors = Convert.ToInt32(TextADASWordRecMissTr2.Text) + Convert.ToInt32(TextADASFalsePosTr2.Text);
                int Trial3Errors = Convert.ToInt32(TextADASWordRecMissTr3.Text) + Convert.ToInt32(TextADASFalsePosTr3.Text);
                int wordRecogavg = (Trial1Errors + Trial2Errors + Trial3Errors) / 3;
                int discrimination = (1 - (FalseAvge + Misses) / 24) * 100;
                int num = (FalseAvge != 0 ? FalseAvge : 1);
                int num1 = (Misses != 0 ? Misses : 1);
                int responseBias = (num - num1) / (num + num1);
                if ((FalseAvge >= 995 || Misses >= 995 ? true : false))
                {
                    discrimination = 997;
                    responseBias = 997;
                }

                int adastotal = WordRecallAverageError + Convert.ToInt32(TextADASCommandErr.Text) + namingScore + Convert.ToInt32(TextADASConstr.Text) + Convert.ToInt32(TextADASPraxis.Text) + Convert.ToInt32(TextADASOrientErr.Text) + wordRecogavg + Convert.ToInt32(TextADASSpeech.Text) + Convert.ToInt32(TextADASAuralComp.Text) + Convert.ToInt32(TextADASTestIntr.Text) + Convert.ToInt32(TextADASWordFind.Text);

                if (WordRecallAverageError >= 995 || Convert.ToInt32(TextADASCommandErr.Text) >= 995 || namingScore >= 995 || Convert.ToInt32(TextADASConstr.Text) >= 995 || Convert.ToInt32(TextADASPraxis.Text) >= 995 || Convert.ToInt32(TextADASOrientErr.Text) >= 995 || wordRecogavg >= 995 || Convert.ToInt32(TextADASSpeech.Text) >= 995 || Convert.ToInt32(TextADASAuralComp.Text) >= 995 || Convert.ToInt32(TextADASTestIntr.Text) >= 995 || Convert.ToInt32(TextADASWordFind.Text) >= 995)
                {
                    adastotal = 997;
                }

                zScore zSco = CalculateVSATTimezScore(education, ComboSex.Text, ftdom, ftndom, VASTTime, VSATErrors, age);
                TrailszScore zTSco = CalculateTrailszScore(age, Convert.ToDouble(TextBNTnoCue.Text), trail_A, trail_B, education);
                StroopzScore zsSco = CalculateStroopzScore(age, word, Color, ColorWord);
                HVLzScore HVLzSco = HVLTZScore(age, TruePossitive, FalsePossitive, HVLTrial1, HVLTrial2, HvlTrial3, HvlTrial4, HvlTrial1to3, HVLTrD);
                LanguagezScore lzSco = CalculateLanguagezScore(age, F, A, S, education, animals);
                var Renderer3 = new IronPdf.HtmlToPdf();
                var htmlTemplate = @"PdfTemplate.html";
                var fullPath = Path.GetFullPath(htmlTemplate);
                fullPath = fullPath.Replace("\\bin\\Debug", "");
                StreamReader sr = new StreamReader(fullPath);

                //Read the first line of text
                var line = sr.ReadLine();
                var PdfBody = string.Empty;

                //Continue to read until you reach end of file
                while (line != null)
                {
                    line = line.Replace("valuefromnametextbox", TxtFirstName.Text + " " + TxtLastName.Text);
                    line = line.Replace("valueforsex", ComboSex.Text);
                    var Agee = age.ToString();

                    line = line.Replace("valueforAge", Agee);
                    line = line.Replace("valueforEthnicity", ComboEthnicity.Text);
                    line = line.Replace("valueforEducation", TextEducation.Text);
                    line = line.Replace("valueforDOB", DateDOB.Text);
                    line = line.Replace("valueforhandpref", Handedness.Text);
                    line = line.Replace("valuefordateoftesting", DateOfTesting.Text);
                    line = line.Replace("valueforPlaceofTesting", ComboNeuropsychologist.Text);
                    line = line.Replace("valueforreferredby", ComboReferredBY.Text);
                    line = line.Replace("valueforLblMoCA", TextMoCA.Text);
                    line = line.Replace("valueforMoCAInterpretation", mocaIntepretation);
                    line = line.Replace("valueforAMNART", TextAMNART.Text);
                    line = line.Replace("valueforOrientedtoPerson", TextOrientPerson.Text);
                    line = line.Replace("valueforOrientedtoPlace", TextOrientPlace.Text);
                    line = line.Replace("valueforOrientedtoTime", TextOrientTime.Text);
                    line = line.Replace("valueforIQCalculated", IQ.ToString());
                    line = line.Replace("valueforWordRecallTrial1Errors", TextADASWRETr1.Text);
                    line = line.Replace("valueforWordRecallErrorsTrial2", TextADASWRETr2.Text);
                    line = line.Replace("valueforWordRecallErrorsTrial2", TextADASWRETr2.Text);
                    line = line.Replace("valuefor3WordRecallErrorsTrial3", TextADASWRETr3.Text);
                    line = line.Replace("valueforIntrusions", TextADASIntrusion.Text);
                    line = line.Replace("valueforDelayedRecallErrors", TextADASDelayRecErr.Text);
                    line = line.Replace("valuefor1WordRecognitionTrial1Errors", TextADASWordRecMissTr1.Text);
                    line = line.Replace("valueforWordRecognitionTrial2Errors", TextADASWordRecMissTr2.Text);
                    line = line.Replace("valuefor3WordRecognitionTrial3Errors", TextADASWordRecMissTr3.Text);
                    line = line.Replace("valuefor1FalsePositivesTrial1", TextADASFalsePosTr1.Text);
                    line = line.Replace("valuefor2FalsePositivesTrial2", TextADASFalsePosTr2.Text);
                    line = line.Replace("valuefor3FalsePositivesTrial3", TextADASFalsePosTr3.Text);
                    line = line.Replace("valueforOrientation", TextADASOrientErr.Text);
                    line = line.Replace("valueforCommands", TextADASCommandErr.Text);
                    line = line.Replace("valueforNamingFingers", TextADASFingerErr.Text);
                    line = line.Replace("valueforNamingObjects", TextADASObjErr.Text);
                    line = line.Replace("valueforConstruction", TextADASConstr.Text);
                    line = line.Replace("valueforIdeationalPraxis", TextADASPraxis.Text);
                    line = line.Replace("valueforSpeechContent", TextADASSpeech.Text);
                    line = line.Replace("valueforAuralComprehension", TextADASAuralComp.Text);
                    line = line.Replace("valueforRecallTestIntrusions", TextADASTestIntr.Text);
                    line = line.Replace("valueforWordFinding", TextADASWordFind.Text);
                    line = line.Replace("valueforWordRecallAverageError", WordRecallAverageError.ToString());
                    line = line.Replace("valueforADASNaming", namingScore.ToString());
                    line = line.Replace("valueforMisses", Misses.ToString());
                    line = line.Replace("valueforFalseAvrage", FalseAvge.ToString());
                    line = line.Replace("valueforDiscrimination", discrimination.ToString());
                    line = line.Replace("valueforADASTOTAL", adastotal.ToString());
                    line = line.Replace("valueforResponseBias", responseBias.ToString());
                    line = line.Replace("valueforWordrecogavg", wordRecogavg.ToString());
                    line = line.Replace("valueforVSATtime", VASTTime.ToString());
                    line = line.Replace("valueforVSATErrors", VSATErrors.ToString());
                    line = line.Replace("valueforzScoreVSATtime", zSco.VSatTimezScore.ToString());
                    line = line.Replace("valueforzScoreVSATErrors", zSco.VASTErrorszScore.ToString());
                    line = line.Replace("valueforTrailsATime", trail_A.ToString());
                    line = line.Replace("valueforTrailsBTime", trail_B.ToString());
                    line = line.Replace("valueforTrailsAZ_Score", zTSco.TrailsAzScore.ToString());
                    line = line.Replace("valueforTrailsBZ_Score", zTSco.TrailsBzScore.ToString());
                    line = line.Replace("valueforStroopWord", zsSco.Word.ToString());
                    line = line.Replace("valueforStroopColor", zsSco.Color.ToString());
                    line = line.Replace("valueforStroopColorWord", zsSco.WordColor.ToString());
                    line = line.Replace("valueforStroopInterference", zsSco.interference.ToString());
                    line = line.Replace("valueforTScoreWord", zsSco.wordt.ToString());
                    line = line.Replace("valueforTScoreColor", zsSco.colort.ToString());
                    line = line.Replace("valueforTScoreColorWord", zsSco.colorwordt.ToString());
                    line = line.Replace("valueforTScoreInterference", zsSco.interferencet.ToString());
                    line = line.Replace("valueforForwardNumberDigit", FNumberDigit.ToString());
                    line = line.Replace("valueforForwardZScore", digitsforwardz.ToString());
                    line = line.Replace("valueforBackWardNumberDigit", ReservsedNumberDigit.ToString());
                    line = line.Replace("valueforBackWardZScore", digitsbackwardz.ToString());
                    line = line.Replace("valueforABCtime", VASTABCTime.ToString());
                    line = line.Replace("valueforABCErrors", TextVSATABCErr.Text);
                    line = line.Replace("valuefor2019time", VSAT20_19Time.ToString());
                    line = line.Replace("valuefor2019Errors", TextVSAT20_19Err.Text);
                    line = line.Replace("valuefor10097Time", TextVSAT100_97Time.Text);
                    line = line.Replace("valuefor10097Errors", TextVSAT100_97Err.Text);
                    line = line.Replace("valueforMonTueTime", TextVSATMon_TuesTime.Text);
                    line = line.Replace("valueforMonTueErrors", TextVSATMon_TuesErr.Text);
                    line = line.Replace("valueforSatSunTime", TextVSATSun_SatTime.Text);
                    line = line.Replace("valueforSatSunErrors", TextVSATSun_SatErr.Text);
                    line = line.Replace("valueforJanFebTime", TextVSATJan_FebTime.Text);
                    line = line.Replace("valueforJanFebErrors", TextVSATJan_FebErr.Text);
                    line = line.Replace("valueforDecNovTime", TextVSATDec_NovTime.Text);
                    line = line.Replace("valueforDecNovErrors", TextVSATDec_NovErr.Text);
                    line = line.Replace("valuefor1a2bTime", TextVSAT1A_2BTime.Text);
                    line = line.Replace("valuefor1a2bErrors", TextVSAT1A_2BErr.Text);
                    line = line.Replace("valueforVigilanceErrors", LabelVSATVigil.Text);
                    line = line.Replace("valueforTrail1", TextHVLTRT1.Text);
                    line = line.Replace("valueforTrail2", TextHVLTRT2.Text);
                    line = line.Replace("valueforTrail3", TextHVLTRT3.Text);
                    line = line.Replace("valueforTrail4", TextHVLTRT4.Text);
                    line = line.Replace("valuefort1ZScore", HVLzSco.hvltr1z.ToString());
                    line = line.Replace("valuefort2ZScore", HVLzSco.hvltr2z.ToString());
                    line = line.Replace("valuefort3ZScore", HVLzSco.hvltr3z.ToString());
                    line = line.Replace("valuefor4ZScore", HVLzSco.hvltr4z.ToString());
                    line = line.Replace("valuefort_1to3ZScore", HVLzSco.hvltr1to3z.ToString());
                    line = line.Replace("valueforf_pZScore", HVLzSco.hvltrfpz.ToString());
                    line = line.Replace("valuefort_pZScore", HVLzSco.hvltrhz.ToString());
                    line = line.Replace("valueforHVLTotal", HVLzSco.hvltrdz.ToString());
                    line = line.Replace("valueforDelay", TextHVLTRDelay.Text);
                    line = line.Replace("valueforZScoreDelay", HVLzSco.ToString());
                    line = line.Replace("valueforFalsePositives", TextHVLTRFalsePos.Text);
                    line = line.Replace("valueforTruePositives", texttruepossitive.Text);
                    line = line.Replace("valueforMisses", TextHVLTRMiss.Text);
                    line = line.Replace("valueforDiscriminationPercentage", discrimination.ToString());
                    line = line.Replace("valueforlogicalmemory1", TextLM1.Text);
                    line = line.Replace("valueforlogicalmemory2", TextLM2.Text);
                    line = line.Replace("valueforlogicalmemoryRecog", TextLMR.Text);
                    line = line.Replace("valueforVisualReproduction1", TextVR1.Text);
                    line = line.Replace("valueforVisualReproduction2", TextVR2.Text);
                    line = line.Replace("valueforVisualReproductionCue", TextVRCue.Text);
                    line = line.Replace("valueforCloxTrail1", CloxTrial1.ToString());
                    line = line.Replace("valueforCloxTrail2", CloxTrial2.ToString());
                    line = line.Replace("valueforTrueVMIBeery", BeeryVMI.ToString());
                    line = line.Replace("valueforBeeryVMIStandardScore", vBeetScore.ToString());
                    line = line.Replace("valueforRawBNTUncued", TextBNTnoCue.Text);
                    line = line.Replace("valueforBNTRawCued", TextBNTCue.Text);
                    line = line.Replace("valueforZ-ScoreBNTUncued", zTSco.BNTzScore.ToString());
                    line = line.Replace("valueforFVal", F.ToString());
                    line = line.Replace("valueforAVal", A.ToString());
                    line = line.Replace("valueforSVal", S.ToString());
                    line = line.Replace("valueforFASTotal", lzSco.fas.ToString());
                    line = line.Replace("valuefor_FASZ_Score", lzSco.fasz.ToString());
                    line = line.Replace("valuefor_Animals_Raw", animals.ToString());
                    line = line.Replace("valuefotwoAnimals_Z_Score", lzSco.animalsz.ToString());
                    line = line.Replace("valueforWABYN", TextWABYN.Text);
                    line = line.Replace("valuefor_WABSeq", TextWABSeq.Text);
                    line = line.Replace("valueforDominant", TextFingerTapDom.Text);
                    line = line.Replace("valueforNondominant", TextFingerTapNonDom.Text);
                    line = line.Replace("valueforMotorInhibitionErrors", TextFingerTapInhibErr.Text);
                    line = line.Replace("valueforbimanualErrors", TextBiManProgErr.Text);
                    line = line.Replace("valueforBICompletedSequences", TextBiManCompSeq.Text);
                    line = line.Replace("valueforBuccofacial", TextBAECommBucc.Text);
                    line = line.Replace("valueforIntransitive", TextBAECommIntransR.Text);
                    line = line.Replace("valueforTransitive", TextBAECommTransR.Text);
                    line = line.Replace("valueforleftIntransitive", TextBAECommIntransL.Text);
                    line = line.Replace("valueforleftTransitive", TextBAECommTransL.Text);
                    line = line.Replace("valueforBostonBuccofacial", TextBAECommBucc.Text);
                    line = line.Replace("valueforBostonrightIntransitive", TextBAECommIntransR.Text);
                    line = line.Replace("valueforBostonleftIntransitive", TextBAECommIntransL.Text);
                    line = line.Replace("valueforBostonTransitive", TextBAECommTransR.Text);
                    line = line.Replace("valueforBostonleftTransitive", TextBAECommTransL.Text);
                    line = line.Replace("valueforImitationBuccofacial", TextBAEImitBucc.Text);
                    line = line.Replace("valueforImitationIntransitive", TextBAEImitIntransR.Text);
                    line = line.Replace("valueforImitationleftIntransitive", TextBAEImitIntransL.Text);
                    line = line.Replace("valueforImitationTransitive", TextBAEImitTransR.Text);
                    line = line.Replace("valueforImitationleftTransitive", TextBAEImitTransL.Text);
                    line = line.Replace("valueforWithITransitive", TextTransWInstrR.Text);
                    line = line.Replace("valueforWithILeftTransitive", TextTransWInstrL.Text);
                    line = line.Replace("valueforWithIGroovedPegBoard", TextPegBrdR.Text);
                    line = line.Replace("valueforwithILeftGroovedPegBoard", TextPegBrdL.Text);

                    line = line.Replace("DatetimeCopyRights", DateTime.Now.ToString());

                    PdfBody = PdfBody + line;
                    line = sr.ReadLine();
                }

                var PDF4 = Renderer3.RenderHtmlAsPdf(PdfBody);
                var OutputPath4 = "Invoice21.pdf";
                PDF4.SaveAs("OutPut1.pdf");
                //var Names = new[] { "John", "James", "Jenny" };
                //foreach (var name in Names)
                //{
                //    var HtmlInstance = HtmlTemplate.Replace("[[NAME]]", name);
                //    var Pdf = Renderer.RenderHtmlAsPdf(HtmlInstance);
                //    Pdf.SaveAs(name + ".pdf");
                //}

                //var PDF6 = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
                //PdfDocument.Merge(new PdfDocument("CoverPage.pdf"), PDF).SaveAs("Combined.Pdf");

            }
            catch (Exception ex)
            {
                errorMessagelbl.Text = ex.Message;
            }
        }

        private void ADASNext_Click(object sender, EventArgs e)
        {
            ADASNext.TabIndex = 1;
            ADASNext.TabStop = true;

            if ((TextADASWRETr1.Text == "") || (TextADASWRETr2.Text == "") || (TextADASWRETr3.Text == "") ||
                (TextADASIntrusion.Text == "") || (TextADASDelayRecErr.Text == "") || (TextADASWordRecMissTr1.Text == "") ||
                (TextADASWordRecMissTr2.Text == "") || (TextADASWordRecMissTr3.Text == "") || (TextADASFalsePosTr1.Text == "") || (TextADASFalsePosTr2.Text == "")
                || (TextADASFalsePosTr3.Text == "") || (TextADASOrientErr.Text == "") || (TextADASCommandErr.Text == "")
                || (TextADASFingerErr.Text == "") || (TextADASObjErr.Text == "") || (TextADASConstr.Text == "")
                || (TextADASPraxis.Text == "") || (TextADASSpeech.Text == "") || (TextADASAuralComp.Text == "")
                || (TextADASTestIntr.Text == "") || (TextADASWordFind.Text == ""))
            {
                MessageBox.Show("Please fill in all the values.");
            }
            else
            {
                TabAttention.Enabled = true;
                PremorbidTab.SelectTab(TabAttention);
            }
        }

        private void AttentionNext_Click(object sender, EventArgs e)
        {
            TabMemory.Enabled = true;
            PremorbidTab.SelectTab(TabMemory);
        }

        private void memoryNext_Click(object sender, EventArgs e)
        {
            TabVisuospatial.Enabled = true;
            PremorbidTab.SelectTab(TabVisuospatial);
        }

        private void visuoNext_Click(object sender, EventArgs e)
        {
            TabLanguage.Enabled = true;
            PremorbidTab.SelectTab(TabLanguage);
        }

        private void languageNext_Click(object sender, EventArgs e)
        {
            TabMotor.Enabled = true;
            PremorbidTab.SelectTab(TabMotor);
        }

        private void MotorNext_Click(object sender, EventArgs e)
        {
            TabAdaptiveFunction.Enabled = true;
            PremorbidTab.SelectTab(TabAdaptiveFunction);
        }

      
       
    }
}
