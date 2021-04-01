using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsList
{
    public partial class Form2 : Form
    {
        private StudentsContainer students, deductedStudents;
        public Form2(StudentsContainer students, StudentsContainer deductedStudents)
        {
            InitializeComponent();
            this.students = students;
            this.deductedStudents = deductedStudents;
            LoadStudentsInGrid();
        }

        public void LoadStudentsInGrid()
        {
            dgwDeductedStudents.Rows.Clear();

            foreach (Student student in deductedStudents)
            {
                dgwDeductedStudents.Rows.Add(new string[] { student.Name, student.Group, student.Subject, student.Mark, "" });
            }
        }

        private void btDeduct_Click(object sender, EventArgs e)
        {
            ((Form1) Owner).TotalDeductStudent(dgwDeductedStudents.CurrentRow.Index);
            LoadStudentsInGrid();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            ((Form1) Owner).ReturnStudent(dgwDeductedStudents.CurrentRow.Index);
            LoadStudentsInGrid();
        }
    }
}
