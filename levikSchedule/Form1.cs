using levikSchedule.Models;
using System.ComponentModel;
using System.Text.Json;

namespace levikSchedule
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        string path = "./students.json";
        public Form1()
        {
            InitializeComponent();
            studentList.DataSource = new BindingSource(students, null);
            studentList.DisplayMember = "FullName";
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (studentName.Text != String.Empty)
            {
                Student student = new Student()
                {
                    FullName = studentName.Text,
                    Marks = new Marks(),
                };
                students.Add(student);
                studentName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Введите имя студента");
            }
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            var student = (Student)studentList.SelectedItem;
            students.Remove(student);
        }

        private void studentList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (studentList.SelectedItem != null)
            {
                var student = (Student)studentList.SelectedItem;
                marks.DataSource = new BindingSource(student.Marks, null);
            }
        }

        private void marks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cell = marks.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var color = default(Color);
            switch ((int)cell.Value)
            {
                case 2:
                    color = Color.Red; break;
                case 3:
                    color = Color.Yellow; break;
                case 4:
                    color = Color.Green; break;
                case 5:
                    color = Color.LightGreen; break;
                default:
                    
                    cell.Value = 2; break;
            }
            cell.Style.BackColor = color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите сохранить данные в файл?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var json = JsonSerializer.Serialize(students);
                File.WriteAllText(path, json);
            }
        }
    }
}