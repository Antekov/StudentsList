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
        private Form2 form2;

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
            cbShowDeducted.Checked = !cbShowDeducted.Checked;
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
            LoadStudentsInGrid();
        }

        private void LoadInputFile(string filename)
        {
            students = new StudentsContainer();
            deductedStudents = new StudentsContainer();
            inFileContainer = new FileContainer(filename);
            inFileContainer.Load(ref students, ref deductedStudents);
            LoadStudentsInGrid();
        }

        private void LoadStudentsInGrid()
        {
            dgwStudents.Rows.Clear();

            foreach (Student student in students)
            {
                dgwStudents.Rows.Add(new string[] { student.Name, student.Group, student.Subject, student.Mark, ""});
            }

            if (CurrentRowIndex == -1 && students.Count > 0)
            {
                CurrentRowIndex = 0;
            }

            if (cbShowDeducted.Checked)
            {
                foreach (Student student in deductedStudents)
                {
                    dgwStudents.Rows.Add(new string[] { student.Name, student.Group, student.Subject, student.Mark, "Отчислен" });
                }

                if (CurrentRowIndex == -1 && deductedStudents.Count + students.Count > 0)
                {
                    CurrentRowIndex = 0;
                }
            }

        }

        private bool IsEmptyRow(DataGridViewRow Row)
        {
            return (Row.Cells[0].Value == null || Row.Cells[0].Value.ToString().Equals("")) 
                && (Row.Cells[1].Value == null || Row.Cells[1].Value.ToString().Equals(""))
                && (Row.Cells[2].Value == null || Row.Cells[2].Value.ToString().Equals(""))
                && (Row.Cells[3].Value == null || Row.Cells[3].Value.ToString().Equals(""));
        }

        private Student getCurrentStudent()
        {
            Student student;
            if (dgwStudents.CurrentRow.Index < students.Count)
            {
                student = (Student)students[dgwStudents.CurrentRow.Index];
            }
            else
            {
                student = (Student)deductedStudents[dgwStudents.CurrentRow.Index - students.Count];
            }

            return student;
        }

        private bool isUniqueName(string name) {
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    return false;
                }
            }

            foreach (Student student in deductedStudents)
            {
                if (student.Name == name)
                {
                    return false;
                }
            }

            return true;
        }

        private void dgwStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(students is null))
            {
                Student student = getCurrentStudent();

                if (isUniqueName(dgwStudents.CurrentRow.Cells[0].Value?.ToString()) || cbEnableDuplicateName.Checked)
                {
                    student.Name = dgwStudents.CurrentRow.Cells[0].Value?.ToString();
                } else
                {
                    // MessageBox.Show("Студент с таким ФИО уже существует");
                    dgwStudents.CurrentRow.Cells[0].Value = student.Name;
                }

                student.Group = dgwStudents.CurrentRow.Cells[1].Value?.ToString();
                student.Subject = dgwStudents.CurrentRow.Cells[2].Value?.ToString();

                student.Mark = dgwStudents.CurrentRow.Cells[3].Value?.ToString();

                if (student.Mark != "")
                {
                    int mark;

                    try
                    {
                        if (int.TryParse(student.Mark, out mark))
                        {
                            if (mark > 5 || mark < 2)
                            {
                                throw new MarkValueException();
                            }
                        }
                        else
                        {
                            throw new MarkValueException();
                        }
                    }
                    catch (MarkValueException)
                    {
                        MessageBox.Show("Оценка может быть в пределах от 2 до 5");
                        student.Mark = "";
                        dgwStudents.CurrentRow.Cells[3].Value = "";
                    }
                }
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
            students.Add(new Student());
            LoadStudentsInGrid();
            dgwStudents.CurrentCell = dgwStudents.Rows[students.Count-1].Cells[0];
        }

        private void btDeduct_Click(object sender, EventArgs e)
        {
            Student student = getCurrentStudent();

            if (student.IsDeducted == false) {
                student.IsDeducted = true;
                deductedStudents.Add(student);
                students.RemoveAt(CurrentRowIndex);
                outFileContainer.Save(ref students, ref deductedStudents);
                LoadStudentsInGrid();
            }
            if (form2 != null && form2.Visible)
            {
                form2.LoadStudentsInGrid();
            }
        }

        public void ReturnStudent(int index)
        {
            Student student = (Student) deductedStudents[index];
            student.IsDeducted = false;
            students.Add(student);
            deductedStudents.RemoveAt(index);
            outFileContainer.Save(ref students, ref deductedStudents);
            LoadStudentsInGrid();
        }

        public void TotalDeductStudent(int index)
        {
            deductedStudents.RemoveAt(index);
            outFileContainer.Save(ref students, ref deductedStudents);
            LoadStudentsInGrid();
        }

        private void cbShowDeducted_CheckedChanged(object sender, EventArgs e)
        {
            LoadStudentsInGrid();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outFileContainer.Save(ref students, ref deductedStudents);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btInFileSelect_Click(sender, e);
        }

        private void miAddRecord_Click(object sender, EventArgs e)
        {
            btCreateRecord_Click(sender, e);
        }

        private void miDeduct_Click(object sender, EventArgs e)
        {
            btDeduct_Click(sender, e);
        }

        private void miClear_Click(object sender, EventArgs e)
        {
            btClear_Click(sender, e);
        }

        private void btShowDeducted_Click(object sender, EventArgs e)
        {
            form2 = new Form2(students, deductedStudents);
            form2.Owner = this;
            form2.Show();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для управления списками студентов.\n" + 
                "Студенты могут находится в списке на отчисление, из которго их можно либо отчислить " +
                "окончательно, либо восстановить.");
        }

        private void dgwStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (!(outFileContainer is null) && CurrentRowIndex != -1 && CurrentRowIndex < dgwStudents.Rows.Count && dgwStudents.CurrentRow.Index != CurrentRowIndex)
            {
                if (IsEmptyRow(dgwStudents.Rows[CurrentRowIndex]))
                {
                    if (CurrentRowIndex < students.Count)
                    {
                        students.RemoveAt(CurrentRowIndex); 
                    }
                    else
                    {
                        deductedStudents.RemoveAt(CurrentRowIndex - students.Count);
                    }
                    CurrentRowIndex -= 1;
                    outFileContainer.Save(ref students, ref deductedStudents);
                    LoadStudentsInGrid();
                    if (CurrentRowIndex != -1)
                    {
                        dgwStudents.CurrentCell = dgwStudents.Rows[CurrentRowIndex].Cells[0];
                    }

                }
                else
                {
                    outFileContainer.Save(ref students, ref deductedStudents);
                }
                
            }
            CurrentRowIndex = dgwStudents.CurrentRow != null ? dgwStudents.CurrentRow.Index : -1;


        }

        private void saveFileDialogOut_FileOk(object sender, CancelEventArgs e)
        {
            tbOutFileName.Text = saveFileDialogOut.FileName;
            outFileContainer = new FileContainer(saveFileDialogOut.FileName);
        }
    }

    public class MarkValueException : Exception { };
}
