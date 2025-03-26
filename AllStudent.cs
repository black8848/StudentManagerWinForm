using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using StudentManagerNamespace;
using StudentNamespace;

namespace StudentManagerWinform
{
    public partial class AllStudent : Form
    {
        private StudentManager studentManager = new StudentManager();
        private string jsonFilePath = "students.json";
        private List<Student> students = new List<Student>();
        public AllStudent()
        {
            InitializeComponent();
            LoadStudents();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Dock = DockStyle.Fill;

        }

        private void LoadStudents()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath); // 读取 JSON 文件
                students = JsonConvert.DeserializeObject<List<Student>>(json); // 解析 JSON
                dataGridView1.DataSource = students; // 绑定到 DataGridView
            }
            else
            {
                MessageBox.Show("学生信息文件不存在！");
            }
        }

        private void SaveStudents()
        {
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            MessageBox.Show("学生信息已保存！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();

            try
            {
                Student student = new Student
                {
                    ID = addStudent.GetStudentID(),
                    Name = addStudent.GetStudentName(),
                    Age = addStudent.GetStudentAge(),
                    Grade = addStudent.GetStudentGrade(),
                };

                // 直接修改 `students` 列表
                students.Add(student);
                SaveStudents();  // 立即保存数据

                // 直接刷新 DataGridView，避免重新加载旧数据
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = students;
                dataGridView1.DataSource = bindingSource;
                bindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加失败: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                students.RemoveAt(selectedIndex);
                SaveStudents();  // 立即保存数据

                // 直接刷新 DataGridView，避免重新加载
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = students;
                dataGridView1.DataSource = bindingSource;
                bindingSource.ResetBindings(false);
            }
        }
    }
}
