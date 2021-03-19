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

        public void Save(ref StudentsContainer students)
        {
            saveTxt(ref students);
            //saveBin(students);
            //saveDat(students);
        }

        private void saveTxt(ref StudentsContainer students)
        {
            FileStream fstream = new FileStream($"{path}.txt", FileMode.Create);
            int offset = 0;
            int len = students.Count;
            int i = 0;
            foreach (Student student in students)
            {
                i++;
                string text = student.Name + ',' + student.Group + ',' + student.Subject + ',' + student.Mark;
                if (i < len) { text += Environment.NewLine; }
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
                offset += array.Length;
            }
            fstream.Close();
        }

        public void Load(ref StudentsContainer students)
        {
            // чтение из файла
            try
            {
                FileStream fstream = new FileStream($"{path}.txt", FileMode.Open);
                loadTxt(fstream, ref students);
                fstream.Close();
                return;
            }
            catch { }

            try
            {
                FileStream fstream = new FileStream($"{path}.dat", FileMode.Open);
                loadDat(fstream);
                fstream.Close();
                return;
            }
            catch { }

            try
            {
                FileStream fstream = new FileStream($"{path}.bin", FileMode.Open);
                loadBin(fstream);
                fstream.Close();
                return;
            }
            catch {
                MessageBox.Show("Файл не существует");
            }
        }

        private void loadTxt(FileStream fstream, ref StudentsContainer students)
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
                students.Add(new Student(parts[0], parts[1], parts[2], parts[3]));
            }
        }

        private void loadDat(FileStream fstream)
        {

        }

        private void loadBin(FileStream fstream)
        {

        }
    }
}
