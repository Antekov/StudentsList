using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentsList
{
    public partial class Form1 : Form
    {
        private StudentsContainer students, deductedStudents;
        private FileContainer inFileContainer, outFileContainer;
        private int CurrentRowIndex = -1;
        private IniFile settingsFile = new IniFile("settings.ini");

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (settingsFile.KeyExists("RestoreState"))
            {
                tbInFileName.Text = settingsFile.Read("InputFile");
                tbOutFileName.Text = settingsFile.Read("OutputFile");

                if (tbInFileName.Text != "") {
                    LoadInputFile(tbInFileName.Text);
                    // CurrentRowIndex = dgwStudents.CurrentRow.Index;
                }

                if (tbOutFileName.Text != "")
                {
                    outFileContainer = new FileContainer(tbOutFileName.Text);
                }

                cbRestoreState.Checked = true;

                cbCyclicScrolling.Checked = settingsFile.Read("CyclicScrolling") == "True";
                cbEnableDuplicateName.Checked = settingsFile.Read("EnableDuplicateName") == "True";
                cbShowDeducted.Checked = settingsFile.Read("ShowDeducted") == "True";
            }
        }

        private void SaveSettings()
        {
            settingsFile.Write("InputFile", tbInFileName.Text);
            settingsFile.Write("OutputFile", tbOutFileName.Text);

            if (cbRestoreState.Checked)
            {
                settingsFile.Write("RestoreState", "1");
            } else if (settingsFile.KeyExists("RestoreState"))
            {
                settingsFile.DeleteKey("RestoreState");
            }

            settingsFile.Write("CyclicScrolling", cbCyclicScrolling.Checked.ToString());
            settingsFile.Write("EnableDuplicateName", cbEnableDuplicateName.Checked.ToString());
            settingsFile.Write("ShowDeducted", cbShowDeducted.Checked.ToString());
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDeletedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btInFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialogIn.DefaultExt = "*.txt";
            openFileDialogIn.FileName = "";
            openFileDialogIn.Filter = "Текстовые файлы (*.txt)|*.txt|Батовые файлы (*.dat)|*.dat|Бинарные файлы (*.bin)|*.bin";
            openFileDialogIn.ShowDialog();
        }

        private void btOutFileSelect_Click(object sender, EventArgs e)
        {
            saveFileDialogOut.DefaultExt = "*.txt";
            saveFileDialogOut.FileName = "";
            saveFileDialogOut.Filter = "Текстовые файлы (*.txt)|*.txt|Батовые файлы (*.dat)|*.dat|Бинарные файлы (*.bin)|*.bin";
            saveFileDialogOut.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialogIn_FileOk(object sender, CancelEventArgs e)
        {
            tbInFileName.Text = openFileDialogIn.FileName;
            LoadInputFile(tbInFileName.Text);
            CurrentRowIndex = dgwStudents.CurrentRow.Index;
        }

        private void LoadInputFile(string filename)
        {
            students = new StudentsContainer();
            deductedStudents = new StudentsContainer();
            inFileContainer = new FileContainer(filename);
            inFileContainer.Load(ref students, ref deductedStudents);

            foreach (Student student in students)
            {
                dgwStudents.Rows.Add(new string[] { student.Name, student.Group, student.Subject, student.Mark });
            }
           
        }


        private bool IsEmptyRow(DataGridViewRow Row)
        {
            return (Row.Cells[0].Value == null || Row.Cells[0].Value.ToString().Equals("")) 
                && (Row.Cells[1].Value == null || Row.Cells[1].Value.ToString().Equals(""))
                && (Row.Cells[2].Value == null || Row.Cells[2].Value.ToString().Equals(""))
                && (Row.Cells[3].Value == null || Row.Cells[3].Value.ToString().Equals(""));
        }

        private void dgwStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(students is null))
            {
                Student student = (Student)students[dgwStudents.CurrentRow.Index];
                
                student.Name = dgwStudents.CurrentRow.Cells[0].Value?.ToString();
                student.Group = dgwStudents.CurrentRow.Cells[1].Value?.ToString();
                student.Subject = dgwStudents.CurrentRow.Cells[2].Value?.ToString();
                student.Mark = dgwStudents.CurrentRow.Cells[3].Value?.ToString();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgwStudents.CurrentRow.Cells[0].Value = "";
            dgwStudents.CurrentRow.Cells[1].Value = "";
            dgwStudents.CurrentRow.Cells[2].Value = "";
            dgwStudents.CurrentRow.Cells[3].Value = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void btFirstRecord_Click(object sender, EventArgs e)
        {
            dgwStudents.CurrentCell = dgwStudents.Rows[0].Cells[0];
        }

        private void btLastRecord_Click(object sender, EventArgs e)
        {
            dgwStudents.CurrentCell = dgwStudents.Rows[dgwStudents.Rows.Count - 1].Cells[0];
        }

        private void btPrevRecord_Click(object sender, EventArgs e)
        {
            if (dgwStudents.CurrentRow.Index > 0)
            {
                dgwStudents.CurrentCell = dgwStudents.Rows[dgwStudents.CurrentRow.Index - 1].Cells[0];
            } else if (cbCyclicScrolling.Checked)
            {
                dgwStudents.CurrentCell = dgwStudents.Rows[dgwStudents.Rows.Count - 1].Cells[0];
            }
        }

        private void btNextRecord_Click(object sender, EventArgs e)
        {
            if (dgwStudents.CurrentRow.Index < dgwStudents.Rows.Count - 1)
            {
                dgwStudents.CurrentCell = dgwStudents.Rows[dgwStudents.CurrentRow.Index + 1].Cells[0];
            }
            else if (cbCyclicScrolling.Checked)
            {
                dgwStudents.CurrentCell = dgwStudents.Rows[0].Cells[0];
            }
        }

        private void btCreateRecord_Click(object sender, EventArgs e)
        {
            dgwStudents.Rows.Add();
            CurrentRowIndex = dgwStudents.Rows.Count - 1;
            students.Add(new Student());
        }

        private void btDeduct_Click(object sender, EventArgs e)
        {
            ((Student) students[CurrentRowIndex]).IsDeducted = true;
            deductedStudents.Add(students[CurrentRowIndex]);
            students.RemoveAt(CurrentRowIndex);
            dgwStudents.Rows.Remove(dgwStudents.Rows[CurrentRowIndex]);
            outFileContainer.Save(ref students, ref deductedStudents);
        }

        private void dgwStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (!(outFileContainer is null) && CurrentRowIndex != -1 && CurrentRowIndex < dgwStudents.Rows.Count && dgwStudents.CurrentRow.Index != CurrentRowIndex)
            {
                if (IsEmptyRow(dgwStudents.Rows[CurrentRowIndex]))
                {
                    students.RemoveAt(CurrentRowIndex);
                    dgwStudents.Rows.Remove(dgwStudents.Rows[CurrentRowIndex]);
                }

                outFileContainer.Save(ref students, ref deductedStudents);
            }
            CurrentRowIndex = dgwStudents.CurrentRow.Index;
        }

        private void saveFileDialogOut_FileOk(object sender, CancelEventArgs e)
        {
            tbOutFileName.Text = saveFileDialogOut.FileName;
            outFileContainer = new FileContainer(saveFileDialogOut.FileName);
        }
    }
}
