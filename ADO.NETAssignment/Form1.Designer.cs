namespace ADO.NETAssignment
{
    partial class Studprofile
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lblrno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbdoj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphno = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtbrno = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.cbdoj = new System.Windows.Forms.ComboBox();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.txtbaddress = new System.Windows.Forms.TextBox();
            this.txtboxphone = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblheading.Location = new System.Drawing.Point(477, 37);
            this.lblheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(150, 17);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "STUDENT PROFILE";
            this.lblheading.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrno
            // 
            this.lblrno.AutoSize = true;
            this.lblrno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrno.Location = new System.Drawing.Point(114, 68);
            this.lblrno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrno.Name = "lblrno";
            this.lblrno.Size = new System.Drawing.Size(53, 19);
            this.lblrno.TabIndex = 1;
            this.lblrno.Text = "Rollno";
            this.lblrno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Location = new System.Drawing.Point(117, 103);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 19);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lbdoj
            // 
            this.lbdoj.AutoSize = true;
            this.lbdoj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbdoj.Location = new System.Drawing.Point(124, 144);
            this.lbdoj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdoj.Name = "lbdoj";
            this.lbdoj.Size = new System.Drawing.Size(41, 19);
            this.lbdoj.TabIndex = 3;
            this.lbdoj.Text = "DOJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldept.Location = new System.Drawing.Point(114, 256);
            this.lbldept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(88, 19);
            this.lbldept.TabIndex = 5;
            this.lbldept.Text = "Department";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcourse.Location = new System.Drawing.Point(114, 303);
            this.lblcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(58, 19);
            this.lblcourse.TabIndex = 6;
            this.lblcourse.Text = "Course";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsem.Location = new System.Drawing.Point(114, 354);
            this.lblsem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(72, 19);
            this.lblsem.TabIndex = 7;
            this.lblsem.Text = "Semester";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladdress.Location = new System.Drawing.Point(114, 409);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(65, 19);
            this.lbladdress.TabIndex = 8;
            this.lbladdress.Text = "Address";
            // 
            // lblphno
            // 
            this.lblphno.AutoSize = true;
            this.lblphno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblphno.Location = new System.Drawing.Point(114, 471);
            this.lblphno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphno.Name = "lblphno";
            this.lblphno.Size = new System.Drawing.Size(74, 19);
            this.lblphno.TabIndex = 9;
            this.lblphno.Text = "Phone No";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgender.Location = new System.Drawing.Point(114, 214);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(59, 19);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(98, 541);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(132, 44);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add New";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(312, 541);
            this.btnselect.Margin = new System.Windows.Forms.Padding(4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(144, 44);
            this.btnselect.TabIndex = 12;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(570, 541);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 44);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(790, 541);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(140, 44);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtbrno
            // 
            this.txtbrno.Location = new System.Drawing.Point(312, 60);
            this.txtbrno.Margin = new System.Windows.Forms.Padding(4);
            this.txtbrno.Name = "txtbrno";
            this.txtbrno.Size = new System.Drawing.Size(148, 25);
            this.txtbrno.TabIndex = 15;
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(312, 103);
            this.txtbname.Margin = new System.Windows.Forms.Padding(4);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(148, 25);
            this.txtbname.TabIndex = 16;
            // 
            // cbdoj
            // 
            this.cbdoj.FormattingEnabled = true;
            this.cbdoj.Items.AddRange(new object[] {
            "16/07/2018",
            "17/07/2018",
            "18/07/2018"});
            this.cbdoj.Location = new System.Drawing.Point(312, 144);
            this.cbdoj.Margin = new System.Windows.Forms.Padding(4);
            this.cbdoj.Name = "cbdoj";
            this.cbdoj.Size = new System.Drawing.Size(180, 25);
            this.cbdoj.TabIndex = 17;
            this.cbdoj.SelectedIndexChanged += new System.EventHandler(this.cbdoj_SelectedIndexChanged);
            // 
            // cbdepartment
            // 
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Items.AddRange(new object[] {
            "computer science",
            "civil",
            "mechanical",
            "inforamtion technology",
            "IS                                                                               " +
                "                                                            "});
            this.cbdepartment.Location = new System.Drawing.Point(312, 256);
            this.cbdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(180, 25);
            this.cbdepartment.TabIndex = 19;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(312, 214);
            this.rbmale.Margin = new System.Windows.Forms.Padding(4);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(60, 21);
            this.rbmale.TabIndex = 20;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(495, 214);
            this.rbfemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(74, 21);
            this.rbfemale.TabIndex = 21;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "Engineering",
            "Bsc",
            "Bca"});
            this.cbcourse.Location = new System.Drawing.Point(312, 303);
            this.cbcourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(180, 25);
            this.cbcourse.TabIndex = 22;
            // 
            // cbsemester
            // 
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.cbsemester.Location = new System.Drawing.Point(312, 354);
            this.cbsemester.Margin = new System.Windows.Forms.Padding(4);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(180, 25);
            this.cbsemester.TabIndex = 23;
            // 
            // txtbaddress
            // 
            this.txtbaddress.Location = new System.Drawing.Point(312, 409);
            this.txtbaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtbaddress.Name = "txtbaddress";
            this.txtbaddress.Size = new System.Drawing.Size(148, 25);
            this.txtbaddress.TabIndex = 24;
            // 
            // txtboxphone
            // 
            this.txtboxphone.Location = new System.Drawing.Point(312, 471);
            this.txtboxphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxphone.Name = "txtboxphone";
            this.txtboxphone.Size = new System.Drawing.Size(148, 25);
            this.txtboxphone.TabIndex = 25;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(520, 68);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(112, 30);
            this.btnfind.TabIndex = 26;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 17;
            this.lbselect.Location = new System.Drawing.Point(635, 194);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(336, 310);
            this.lbselect.TabIndex = 27;
            // 
            // Studprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1470, 602);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtboxphone);
            this.Controls.Add(this.txtbaddress);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.cbdepartment);
            this.Controls.Add(this.cbdoj);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.txtbrno);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblphno);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblsem);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbdoj);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblrno);
            this.Controls.Add(this.lblheading);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Studprofile";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblrno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbdoj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphno;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtbrno;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.ComboBox cbdoj;
        private System.Windows.Forms.ComboBox cbdepartment;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.TextBox txtbaddress;
        private System.Windows.Forms.TextBox txtboxphone;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.ListBox lbselect;
    }
}

