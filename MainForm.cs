using System.Xml.Linq;
using StudentManagerNamespace;
using StudentNamespace;

namespace StudentManagerWinform
{
    public partial class MainForm : Form
    {

        private StudentManager studentManager = new StudentManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //���ѧ��
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

                studentManager.AddStudent(student);
                MessageBox.Show($"ѧ�� {student.Name} ��ӳɹ���");
                //LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���ʧ��: {ex.Message}");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllStudent allStudent = new AllStudent();
            allStudent.ShowDialog();
        }
    }
}
