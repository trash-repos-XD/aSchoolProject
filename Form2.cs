﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        DelegateNumber DelStudentNo, DelAge, DelContact;

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DelegateText DelProgram, DelLastName, DelFirstName, DelAddress, DelMiddleName;

        public Form2()
        {
            InitializeComponent();

            DelStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContact = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            StudentNo.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();
            Program.Text = DelProgram(StudentInfoClass.Program).ToString();
            LastName.Text = DelLastName(StudentInfoClass.LastName).ToString();
            FirstName.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            MiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            Age.Text = DelAge(StudentInfoClass.StudentNo).ToString();
            ContactNo.Text = DelContact(StudentInfoClass.ContactNo).ToString();
            Address.Text = DelAddress(StudentInfoClass.Address).ToString();

        }
    }
}
