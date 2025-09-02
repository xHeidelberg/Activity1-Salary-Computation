using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fernandez_RobynKristoffer_2F1
{
    public partial class mainForm : Form
    {
        public object MessageBoxImage { get; private set; }

        public mainForm()
        {
            InitializeComponent();
            calculateBtn.Enabled = false;
            requiredName.Visible = false;
            requiredPosition.Visible = false;
            requiredAbsent.Visible = false;
        }

        public void calculateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Name Filter 
                if (string.IsNullOrWhiteSpace(nameTxt.Text))
                {
                    requiredName.Text = "Field is required.";
                    requiredName.Visible = true;
                    return;
                }
                // Minimum of 5 | catch at 4
                else if (nameTxt.Text.Length < 5)
                {
                    requiredName.Text = "Minimum length of 5 characters.";
                    requiredName.Visible = true;
                    return;
                }
                // catch if consist of number 
                else if (!Regex.IsMatch(nameTxt.Text, @"^[a-z A-Z]+$"))
                {
                    requiredName.Text = "Special characters or numbers not allowed.";
                    requiredName.Visible = true;
                    return;
                }

                // if not selected 
                if (employeeType.SelectedIndex < 0)
                {
                    requiredPosition.Text = "This field is required.";
                    requiredPosition.Visible = true;
                    return;
                }
            }
            catch (Exception messageEx)
            {
                MessageBox.Show($"{messageEx}", "Error");
                return;
            }


            // Check Absent
            try
            {
                if (string.IsNullOrEmpty(nameTxt.Text))
                {
                    requiredAbsent.Text = "This field is Required.";
                    requiredAbsent.Visible = true;
                    return;
                }

                if (int.TryParse(numberTxt.Text, out int absent))
                {
                    if (absent > 10)
                    {
                        MessageBox.Show("Maximum value of Absent Reach", "Error!", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        // empty
                    }
                }
                else
                {
                    requiredAbsent.Text = "This field only accept number";
                    requiredAbsent.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }

            // Calculation ex
            Calculate();

        }




        public void Calculate()
        {
            string month = "August";
            int absentDays = int.Parse(numberTxt.Text);
            int totalDays = 25; 
            int holidays = 2;
            int workingDays = totalDays - holidays;

// --- Calculations for Job Order Employee ---
            decimal jobOrderRate = 9000m;
            decimal jobOrderDailyRate = jobOrderRate / totalDays; 
            decimal absentDeductionJO = absentDays * jobOrderDailyRate;
            decimal grossSalaryJO = jobOrderRate - absentDeductionJO;

// --- Calculations for Contract of Service Employee ---
            decimal contractOfServiceRate = 18000m;
            decimal dailyRateCOS = contractOfServiceRate / totalDays; 
            decimal absentDeductionCOS = absentDays * dailyRateCOS;
            decimal grossSalaryCOS = contractOfServiceRate - absentDeductionCOS;
            decimal philHealthCOS = 1458.25m;
            decimal sssCOS = 760m;
            decimal netSalaryCOS = grossSalaryCOS - (philHealthCOS + sssCOS);

// --- Calculations for Permanent Employee ---
            decimal permanentRate = 32000m;
            decimal dailyRatePermanent = permanentRate / totalDays;
            decimal absentDeductionPermanent = absentDays * dailyRatePermanent;
            decimal permanentGrossSalary = permanentRate - absentDeductionPermanent;
            decimal gsisPermanent = (permanentGrossSalary * 0.09M);
            decimal philHealthPermanent = (permanentGrossSalary * 0.05M) / 2;
            decimal pagIbigPermanent = 100m;
            decimal taxPermanent = 1500m;
            decimal permanentNetSalary = permanentGrossSalary - (gsisPermanent + philHealthPermanent + pagIbigPermanent + taxPermanent);

// --- Displaying Results in MessageBox based on selected employee type ---
if (employeeType.SelectedIndex == 0)
{
    // Display the calculated gross and net salary for Job Order
    MessageBox.Show($"Month:\t{month}\nGross Salary: {grossSalaryJO:F2}\nNet Salary: {grossSalaryJO:F2}");
}
else if (employeeType.SelectedIndex == 1)
{
    // Display the calculated gross and net salary for Contract of Service
    MessageBox.Show($"Month:\t{month}\nGross Salary: {grossSalaryCOS:F2}\nNet Salary: {netSalaryCOS:F2}");
}
else if (employeeType.SelectedIndex == 2)
{
    // Display the calculated gross and net salary for Permanent
    MessageBox.Show($"Month:\t{month}\nGross Salary: {permanentGrossSalary:F2}\nNet Salary: {permanentNetSalary:F2}");
}
        }


        // Onclick Textbox event
        public void nameTxt_Click(object sender, EventArgs e)
        {
            requiredName.Text = "";
            requiredName.Visible = false;
        }

        private void employeeType_Click(object sender, EventArgs e)
        {
            requiredPosition.Text = "";
            requiredPosition.Visible = false;
        }

        private void numberTxt_Click(object sender, EventArgs e)
        {
            requiredAbsent.Text = "";
            requiredAbsent.Visible = false; 
        }

        private void isTandC_Click(object sender, EventArgs e)
        {
            if (!isTandC.Checked) 
            { 
                calculateBtn.Enabled = false;
            } else
            {
                calculateBtn.Enabled = true;
            }
        }

   
    }
}
