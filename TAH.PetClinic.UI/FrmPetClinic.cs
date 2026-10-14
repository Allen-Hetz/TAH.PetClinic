namespace TAH.PetClinic.UI
{
    public partial class FrmPetClinic : Form
    {
        public FrmPetClinic()
        {
            InitializeComponent();
        }
        float total = 0;
        private void chkEmergency_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the Emergency fee based on if the checkbox is checked or not
            if (chkEmergency.Checked)
                total += 500;
            else if (!chkEmergency.Checked)
                total -= 500;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkExam_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the Exam fee based on if the checkbox is checked or not
            if (chkExam.Checked)
                total += 50;
            else if (!chkExam.Checked)
                total -= 50;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkGrooming_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the Grooming fee based on if the checkbox is checked or not
            if (chkGrooming.Checked)
                total += 25;
            else if (!chkGrooming.Checked)
                total -= 25;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkSpayOrNeuter_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the Spay/Neuter fee based on if the checkbox is checked or not
            if (chkSpayOrNeuter.Checked)
                total += 100;
            else if (!chkSpayOrNeuter.Checked)
                total -= 100;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkVaccination_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the Vaccination fee based on if the checkbox is checked or not 
            if (chkVaccination.Checked)
                total += 10;
            else if (!chkVaccination.Checked)
                total -= 10;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkOneHour_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the One Hour Boarding fee based on if the checkbox is checked or not
            if (chkOneHour.Checked)
                total += 15;
            else if (!chkOneHour.Checked)
                total -= 15;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkOneDay_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the One Day Boarding fee based on if the checkbox is checked or not
            if (chkOneDay.Checked)
                total += 80;
            else if (!chkOneDay.Checked)
                total -= 80;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void chkOneWeek_CheckedChanged(object sender, EventArgs e)
        {
            // Adds or subtracts the One Week Boarding fee based on if the checkbox is checked or not
            if (chkOneWeek.Checked)
                total += 350;
            else if (!chkOneWeek.Checked)
                total -= 350;
            // Updates the total label with the new total
            lblTotal.Text = total.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all the checkboxes and resets the total to 0
            chkEmergency.Checked = false;
            chkExam.Checked = false;
            chkGrooming.Checked = false;
            chkSpayOrNeuter.Checked = false;
            chkVaccination.Checked = false;
            chkOneHour.Checked = false;
            chkOneDay.Checked = false;
            chkOneWeek.Checked = false;
            total = 0;
            lblTotal.Text = total.ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }
    }
}
