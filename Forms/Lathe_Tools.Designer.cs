namespace GCodeNpp.Forms
{
    partial class Lathe_Tools
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SFM_Result = new System.Windows.Forms.TextBox();
            this.SFM_D = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SFM_RPM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RPM_Result = new System.Windows.Forms.TextBox();
            this.RPM_D = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RPM_SFM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IPR_Result = new System.Windows.Forms.TextBox();
            this.IPR_RPM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.IPR_IPM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.IPM_Result = new System.Windows.Forms.TextBox();
            this.IPM_RPM = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.IPM_IPR = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MRR_Result = new System.Windows.Forms.TextBox();
            this.MRR_IPR = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MRR_SFM = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.MRR_DOC = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter RPM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SFM_Result);
            this.groupBox1.Controls.Add(this.SFM_D);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SFM_RPM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surface Feet Per Minute (SFM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(211, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "* π/12 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "*";
            // 
            // SFM_Result
            // 
            this.SFM_Result.Location = new System.Drawing.Point(326, 36);
            this.SFM_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SFM_Result.Name = "SFM_Result";
            this.SFM_Result.ReadOnly = true;
            this.SFM_Result.Size = new System.Drawing.Size(89, 23);
            this.SFM_Result.TabIndex = 4;
            // 
            // SFM_D
            // 
            this.SFM_D.Location = new System.Drawing.Point(116, 36);
            this.SFM_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SFM_D.Name = "SFM_D";
            this.SFM_D.Size = new System.Drawing.Size(89, 23);
            this.SFM_D.TabIndex = 4;
            this.SFM_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SFM_D_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "SFM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Ø";
            // 
            // SFM_RPM
            // 
            this.SFM_RPM.Location = new System.Drawing.Point(9, 36);
            this.SFM_RPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SFM_RPM.MaxLength = 6;
            this.SFM_RPM.Name = "SFM_RPM";
            this.SFM_RPM.Size = new System.Drawing.Size(89, 23);
            this.SFM_RPM.TabIndex = 2;
            this.SFM_RPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SFM_RPM_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RPM_Result);
            this.groupBox2.Controls.Add(this.RPM_D);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.RPM_SFM);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox2.Location = new System.Drawing.Point(11, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(456, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revolutions Per Minute (RPM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(103, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "* (12/π) /";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "=";
            // 
            // RPM_Result
            // 
            this.RPM_Result.Location = new System.Drawing.Point(325, 35);
            this.RPM_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RPM_Result.Name = "RPM_Result";
            this.RPM_Result.ReadOnly = true;
            this.RPM_Result.Size = new System.Drawing.Size(89, 23);
            this.RPM_Result.TabIndex = 4;
            // 
            // RPM_D
            // 
            this.RPM_D.Location = new System.Drawing.Point(168, 35);
            this.RPM_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RPM_D.Name = "RPM_D";
            this.RPM_D.Size = new System.Drawing.Size(89, 23);
            this.RPM_D.TabIndex = 4;
            this.RPM_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RPM_D_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "RPM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Enter Ø";
            // 
            // RPM_SFM
            // 
            this.RPM_SFM.Location = new System.Drawing.Point(9, 35);
            this.RPM_SFM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RPM_SFM.Name = "RPM_SFM";
            this.RPM_SFM.Size = new System.Drawing.Size(89, 23);
            this.RPM_SFM.TabIndex = 2;
            this.RPM_SFM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RPM_SFM_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enter SFM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.IPR_Result);
            this.groupBox3.Controls.Add(this.IPR_RPM);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.IPR_IPM);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox3.Location = new System.Drawing.Point(9, 150);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(456, 66);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inches Per Revolution (IPR)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.Location = new System.Drawing.Point(211, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "/";
            // 
            // IPR_Result
            // 
            this.IPR_Result.Location = new System.Drawing.Point(326, 36);
            this.IPR_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPR_Result.Name = "IPR_Result";
            this.IPR_Result.ReadOnly = true;
            this.IPR_Result.Size = new System.Drawing.Size(89, 23);
            this.IPR_Result.TabIndex = 4;
            // 
            // IPR_RPM
            // 
            this.IPR_RPM.Location = new System.Drawing.Point(116, 36);
            this.IPR_RPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPR_RPM.Name = "IPR_RPM";
            this.IPR_RPM.Size = new System.Drawing.Size(89, 23);
            this.IPR_RPM.TabIndex = 4;
            this.IPR_RPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPR_RPM_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "IPR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Enter RPM";
            // 
            // IPR_IPM
            // 
            this.IPR_IPM.Location = new System.Drawing.Point(9, 36);
            this.IPR_IPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPR_IPM.MaxLength = 6;
            this.IPR_IPM.Name = "IPR_IPM";
            this.IPR_IPM.Size = new System.Drawing.Size(89, 23);
            this.IPR_IPM.TabIndex = 2;
            this.IPR_IPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPR_IPM_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Enter IPM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.IPM_Result);
            this.groupBox4.Controls.Add(this.IPM_RPM);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.IPM_IPR);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox4.Location = new System.Drawing.Point(9, 220);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(456, 66);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inches Per Minute (IPM)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F);
            this.label16.Location = new System.Drawing.Point(211, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "*";
            // 
            // IPM_Result
            // 
            this.IPM_Result.Location = new System.Drawing.Point(326, 36);
            this.IPM_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPM_Result.Name = "IPM_Result";
            this.IPM_Result.ReadOnly = true;
            this.IPM_Result.Size = new System.Drawing.Size(89, 23);
            this.IPM_Result.TabIndex = 4;
            // 
            // IPM_RPM
            // 
            this.IPM_RPM.Location = new System.Drawing.Point(116, 36);
            this.IPM_RPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPM_RPM.Name = "IPM_RPM";
            this.IPM_RPM.Size = new System.Drawing.Size(89, 23);
            this.IPM_RPM.TabIndex = 4;
            this.IPM_RPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPM_RPM_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "IPM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(113, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Enter RPM";
            // 
            // IPM_IPR
            // 
            this.IPM_IPR.Location = new System.Drawing.Point(9, 36);
            this.IPM_IPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPM_IPR.MaxLength = 6;
            this.IPM_IPR.Name = "IPM_IPR";
            this.IPM_IPR.Size = new System.Drawing.Size(89, 23);
            this.IPM_IPR.TabIndex = 2;
            this.IPM_IPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPM_IPR_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Enter IPR";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.MRR_DOC);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.MRR_Result);
            this.groupBox5.Controls.Add(this.MRR_IPR);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.MRR_SFM);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox5.Location = new System.Drawing.Point(9, 290);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(456, 66);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cubic Inches Minute Removal Rate (in³/min)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10F);
            this.label21.Location = new System.Drawing.Point(190, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(77, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "* 12 *";
            // 
            // MRR_Result
            // 
            this.MRR_Result.Location = new System.Drawing.Point(326, 36);
            this.MRR_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MRR_Result.Name = "MRR_Result";
            this.MRR_Result.ReadOnly = true;
            this.MRR_Result.Size = new System.Drawing.Size(89, 23);
            this.MRR_Result.TabIndex = 4;
            // 
            // MRR_IPR
            // 
            this.MRR_IPR.Location = new System.Drawing.Point(121, 36);
            this.MRR_IPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MRR_IPR.Name = "MRR_IPR";
            this.MRR_IPR.Size = new System.Drawing.Size(64, 23);
            this.MRR_IPR.TabIndex = 4;
            this.MRR_IPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MRR_IPR_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(323, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "in³/min";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(118, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 16);
            this.label24.TabIndex = 3;
            this.label24.Text = "Enter IPR";
            // 
            // MRR_SFM
            // 
            this.MRR_SFM.Location = new System.Drawing.Point(9, 36);
            this.MRR_SFM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MRR_SFM.MaxLength = 6;
            this.MRR_SFM.Name = "MRR_SFM";
            this.MRR_SFM.Size = new System.Drawing.Size(64, 23);
            this.MRR_SFM.TabIndex = 2;
            this.MRR_SFM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MRR_SFM_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Enter SFM";
            // 
            // MRR_DOC
            // 
            this.MRR_DOC.Location = new System.Drawing.Point(209, 36);
            this.MRR_DOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MRR_DOC.Name = "MRR_DOC";
            this.MRR_DOC.Size = new System.Drawing.Size(64, 23);
            this.MRR_DOC.TabIndex = 7;
            this.MRR_DOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MRR_DOC_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10F);
            this.label26.Location = new System.Drawing.Point(279, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 16);
            this.label26.TabIndex = 7;
            this.label26.Text = "=";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(205, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 16);
            this.label27.TabIndex = 8;
            this.label27.Text = "Enter DOC";
            // 
            // Lathe_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 363);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lathe_Tools";
            this.ShowIcon = false;
            this.Text = "Lathe_Tools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SFM_Result;
        private System.Windows.Forms.TextBox SFM_D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SFM_RPM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RPM_Result;
        private System.Windows.Forms.TextBox RPM_D;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RPM_SFM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IPR_Result;
        private System.Windows.Forms.TextBox IPR_RPM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox IPR_IPM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox IPM_Result;
        private System.Windows.Forms.TextBox IPM_RPM;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox IPM_IPR;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox MRR_DOC;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox MRR_Result;
        private System.Windows.Forms.TextBox MRR_IPR;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox MRR_SFM;
        private System.Windows.Forms.Label label25;
    }
}