using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipelineForUnity
{
    public partial class Form2 : Form
    {
        public static List<String> ProjectNameList = new List<string>();
        public Form2()
        {
             InitializeComponent(); 
            foreach (string line in System.IO.File.ReadLines("ProjectNames.txt"))
            {
                ProjectNameList.Add(line);
                ProjectNamesBox.Items.Add(line);
            } 
        }

        private void ToCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();  
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {



            string name = ProjectNamesBox.Text;    

            string ARGS = @" -projectPath " + @"./" + name;  
            string EXE = @"C:\Program Files\Unity\Hub\Editor\2021.2.17f1\Editor\Unity.exe";
            System.Diagnostics.Process.Start(EXE, ARGS);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            foreach (string line in System.IO.File.ReadLines("ProjectNames.txt"))
            {
                ProjectNameList.Add(line);
                ProjectNamesBox.Items.Add(line);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {


            string name = ProjectNamesBox.Text;

            OutputTextBox.Text = name;

            System.IO.DirectoryInfo di = new DirectoryInfo(name); 

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            di.Delete();

            ProjectNamesBox.Text = ""; 

            ProjectNameList.Remove(name);

            ProjectNamesBox.Items.Remove(name); 

            File.WriteAllLines("ProjectNames.txt", ProjectNameList);

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowInExplorerButton_Click(object sender, EventArgs e)
        {
            string name = ProjectNamesBox.Text; 

            string folderPath = Directory.GetCurrentDirectory() + @"\" + name;

            OutputTextBox.Text = "Opened: "+ folderPath;  
            System.Diagnostics.Process.Start("explorer.exe", folderPath);     

             
        }
    }
}
