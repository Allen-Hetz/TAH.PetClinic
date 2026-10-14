namespace TAH.PetClinic.UI
{
    partial class FrmPetClinic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMain = new Label();
            chkEmergency = new CheckBox();
            chkExam = new CheckBox();
            chkGrooming = new CheckBox();
            chkSpayOrNeuter = new CheckBox();
            chkVaccination = new CheckBox();
            chkOneHour = new CheckBox();
            chkOneDay = new CheckBox();
            chkOneWeek = new CheckBox();
            btnClear = new Button();
            btnExit = new Button();
            lblTotalLable = new Label();
            lblTotal = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(94, 9);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(207, 32);
            lblMain.TabIndex = 0;
            lblMain.Text = "Available Services";
            // 
            // chkEmergency
            // 
            chkEmergency.AutoSize = true;
            chkEmergency.Font = new Font("Segoe UI", 11F);
            chkEmergency.Location = new Point(47, 54);
            chkEmergency.Name = "chkEmergency";
            chkEmergency.Size = new Size(101, 24);
            chkEmergency.TabIndex = 1;
            chkEmergency.Text = "Emergency";
            chkEmergency.UseVisualStyleBackColor = true;
            chkEmergency.CheckedChanged += chkEmergency_CheckedChanged;
            // 
            // chkExam
            // 
            chkExam.AutoSize = true;
            chkExam.Font = new Font("Segoe UI", 11F);
            chkExam.Location = new Point(47, 94);
            chkExam.Name = "chkExam";
            chkExam.Size = new Size(64, 24);
            chkExam.TabIndex = 2;
            chkExam.Text = "Exam";
            chkExam.UseVisualStyleBackColor = true;
            chkExam.CheckedChanged += chkExam_CheckedChanged;
            // 
            // chkGrooming
            // 
            chkGrooming.AutoSize = true;
            chkGrooming.Font = new Font("Segoe UI", 11F);
            chkGrooming.Location = new Point(47, 134);
            chkGrooming.Name = "chkGrooming";
            chkGrooming.Size = new Size(95, 24);
            chkGrooming.TabIndex = 3;
            chkGrooming.Text = "Grooming";
            chkGrooming.UseVisualStyleBackColor = true;
            chkGrooming.CheckedChanged += chkGrooming_CheckedChanged;
            // 
            // chkSpayOrNeuter
            // 
            chkSpayOrNeuter.AutoSize = true;
            chkSpayOrNeuter.Font = new Font("Segoe UI", 11F);
            chkSpayOrNeuter.Location = new Point(47, 174);
            chkSpayOrNeuter.Name = "chkSpayOrNeuter";
            chkSpayOrNeuter.Size = new Size(111, 24);
            chkSpayOrNeuter.TabIndex = 4;
            chkSpayOrNeuter.Text = "Spay/Neuter";
            chkSpayOrNeuter.UseVisualStyleBackColor = true;
            chkSpayOrNeuter.CheckedChanged += chkSpayOrNeuter_CheckedChanged;
            // 
            // chkVaccination
            // 
            chkVaccination.AutoSize = true;
            chkVaccination.Font = new Font("Segoe UI", 11F);
            chkVaccination.Location = new Point(47, 214);
            chkVaccination.Name = "chkVaccination";
            chkVaccination.Size = new Size(104, 24);
            chkVaccination.TabIndex = 5;
            chkVaccination.Text = "Vaccination";
            chkVaccination.UseVisualStyleBackColor = true;
            chkVaccination.CheckedChanged += chkVaccination_CheckedChanged;
            // 
            // chkOneHour
            // 
            chkOneHour.AutoSize = true;
            chkOneHour.Font = new Font("Segoe UI", 11F);
            chkOneHour.Location = new Point(47, 254);
            chkOneHour.Name = "chkOneHour";
            chkOneHour.Size = new Size(157, 24);
            chkOneHour.TabIndex = 6;
            chkOneHour.Text = "One Hour Boarding";
            chkOneHour.UseVisualStyleBackColor = true;
            chkOneHour.CheckedChanged += chkOneHour_CheckedChanged;
            // 
            // chkOneDay
            // 
            chkOneDay.AutoSize = true;
            chkOneDay.Font = new Font("Segoe UI", 11F);
            chkOneDay.Location = new Point(47, 294);
            chkOneDay.Name = "chkOneDay";
            chkOneDay.Size = new Size(150, 24);
            chkOneDay.TabIndex = 7;
            chkOneDay.Text = "One Day Boarding";
            chkOneDay.UseMnemonic = false;
            chkOneDay.UseVisualStyleBackColor = true;
            chkOneDay.CheckedChanged += chkOneDay_CheckedChanged;
            // 
            // chkOneWeek
            // 
            chkOneWeek.AutoSize = true;
            chkOneWeek.Font = new Font("Segoe UI", 11F);
            chkOneWeek.Location = new Point(47, 334);
            chkOneWeek.Name = "chkOneWeek";
            chkOneWeek.Size = new Size(160, 24);
            chkOneWeek.TabIndex = 8;
            chkOneWeek.Text = "One Week Boarding";
            chkOneWeek.UseMnemonic = false;
            chkOneWeek.UseVisualStyleBackColor = true;
            chkOneWeek.CheckedChanged += chkOneWeek_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.Location = new Point(71, 430);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 37);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.Location = new Point(225, 430);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 37);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTotalLable
            // 
            lblTotalLable.AutoSize = true;
            lblTotalLable.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLable.Location = new Point(47, 382);
            lblTotalLable.Name = "lblTotalLable";
            lblTotalLable.RightToLeft = RightToLeft.No;
            lblTotalLable.Size = new Size(105, 20);
            lblTotalLable.TabIndex = 11;
            lblTotalLable.Text = "Total Charges:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(203, 377);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(142, 30);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "$0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(240, 53);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(105, 306);
            label2.TabIndex = 13;
            label2.Text = "$500.00\r\n\r\n$50.00\r\n\r\n$25.00\r\n\r\n$100.00\r\n\r\n$10.00\r\n\r\n$15.00\r\n\r\n$80.00\r\n\r\n$350.00";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmPetClinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 492);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalLable);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(chkOneWeek);
            Controls.Add(chkOneDay);
            Controls.Add(chkOneHour);
            Controls.Add(chkVaccination);
            Controls.Add(chkSpayOrNeuter);
            Controls.Add(chkGrooming);
            Controls.Add(chkExam);
            Controls.Add(chkEmergency);
            Controls.Add(lblMain);
            Name = "FrmPetClinic";
            Text = "Lions, Tigers, and Bears Pet Clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMain;
        private CheckBox chkEmergency;
        private CheckBox chkExam;
        private CheckBox chkGrooming;
        private CheckBox chkSpayOrNeuter;
        private CheckBox chkVaccination;
        private CheckBox chkOneHour;
        private CheckBox chkOneDay;
        private CheckBox chkOneWeek;
        private Button btnClear;
        private Button btnExit;
        private Label lblTotalLable;
        private Label lblTotal;
        private Label label2;
    }
}
