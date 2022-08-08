using System.Diagnostics;

namespace PipelineForUnity
{
    public partial class Form1 : Form
    {
        public static List<String> ProjectNameList = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
            foreach (string line in System.IO.File.ReadLines("ProjectNames.txt"))
            {
                ProjectNameList.Add(line);
            }
        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            String name = ProjectNameTextBox.Text;

            foreach (string line in ProjectNameList)
            {
                if (name == line)
                {
                    OutputTextBox.Text = "This Name Exists";
                    return;
                }
            }
             
            ProjectNameList.Add(name);

            OutputTextBox.Text = "SUCCESS";


            string ARGS = @" -createProject " + @"./" + name;
            string EXE = @"C:\Program Files\Unity\Hub\Editor\2021.2.17f1\Editor\Unity.exe";
            System.Diagnostics.Process.Start(EXE, ARGS); 

            File.WriteAllLines("ProjectNames.txt", ProjectNameList);      

        }

        private void ToManagerButton_Click(object sender, EventArgs e)
        { 
            this.Hide(); 
            (new Form2()).Show(); 
        }
    }
}