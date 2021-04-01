using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsList
{
    class FileContainer
    {
        private string path;

        public FileContainer(string path)
        {
            path = path.Substring(0, path.LastIndexOf('.'));
            this.path = path;
        }

        public void Save(ref StudentsContainer students, ref StudentsContainer deductedStudents)
        {
            save("txt", ref students, ref deductedStudents);
            save("bin", ref students, ref deductedStudents);
            save("dat", ref students, ref deductedStudents);
        }

        private void save(string ext, ref StudentsContainer students, ref StudentsContainer deductedStudents)
        {
            FileStream fstream = new FileStream($"{path}.{ext}", FileMode.Create);
            byte[] array;
            int offset = 0;
            int len = students.Count;
            int i = 0;
            foreach (Student student in students)
            {
                i++;
                string text = student.Name + ',' + student.Group + ',' + student.Subject + ',' + student.Mark + ',' + student.IsDeducted.ToString();
                if (i < len) { text += Environment.NewLine; }
                array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
                offset += array.Length;
            }
            if (deductedStudents.Count > 0)
            {
                if (students.Count > 0)
                {
                    array = System.Text.Encoding.Default.GetBytes(Environment.NewLine);
                    fstream.Write(array, 0, array.Length);
                }

                i = 0;
                foreach (Student student in deductedStudents)
                {
                    i++;
                    string text = student.Name + ',' + student.Group + ',' + student.Subject + ',' + student.Mark + ',' + student.IsDeducted.ToString();
                    if (i < deductedStudents.Count) { text += Environment.NewLine; }
                    array = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                    offset += array.Length;
                }
            }
            fstream.Close();
        }

        public void Load(ref StudentsContainer students, ref StudentsContainer deductedStudents)
        {
            // чтение из файла
            try
            {
                FileStream fstream = new FileStream($"{path}.txt", FileMode.Open);
                load(fstream, ref students, ref deductedStudents);
                fstream.Close();
                return;
            }
            catch { }

            try
            {
                FileStream fstream = new FileStream($"{path}.dat", FileMode.Open);
                load(fstream, ref students, ref deductedStudents);
                fstream.Close();
                return;
            }
            catch { }

            try
            {
                FileStream fstream = new FileStream($"{path}.bin", FileMode.Open);
                load(fstream, ref students, ref deductedStudents);
                fstream.Close();
                return;
            }
            catch {
                MessageBox.Show("Файл не существует");
            }
        }

        private void load(FileStream fstream, ref StudentsContainer students, ref StudentsContainer deductedStudents)
        {
            // преобразуем строку в байты
            byte[] array = new byte[fstream.Length];
            // считываем данные
            fstream.Read(array, 0, array.Length);
            // декодируем байты в строку
            string textFromFile = System.Text.Encoding.Default.GetString(array);

            foreach (var line in textFromFile.Split('\n')) {
                string s = line.Trim();
                var parts = s.Split(',');
                var student = new Student(parts[0], parts[1], parts[2], parts[3], Boolean.Parse(parts[4]));

                if (student.IsDeducted)
                {
                    deductedStudents.Add(student);
                } else
                {
                    students.Add(student);
                }
            }
        }
    }
}
