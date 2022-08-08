using System.Diagnostics;

namespace PipelineForUnity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            String name = ProjectNameTextBox.Text;

            string command = @" -createProject " + @"./" + name; 
            ////string command = "write";   

            //Process.Start("cmd.exe", command);   
            System.Diagnostics.Process.Start(@"C:\Program Files\Unity\Hub\Editor\2021.2.17f1\Editor\Unity.exe", @" -createProject " + @"./" + name);       
            //Process.Start(command); 
        } 

    }
}