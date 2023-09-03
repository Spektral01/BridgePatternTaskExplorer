using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string taskType;
        private void ExtraTaskBtn_Click(object sender, EventArgs e)
        {
            taskType = "ExtraTask";
            ShowTaskList();
        }
        public string getTaskType()
        {
            return taskType;
        }
        public void ShowTaskList()
        {
            string folderPath = taskType;
            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");
            string[] jpgFiles = Directory.GetFiles(folderPath, "*.jpg");
            string[] audioFiles = Directory.GetFiles(folderPath, "*.mp3");
            string[] pngFiles = Directory.GetFiles(folderPath, "*.png");


            TaskListBox.Items.Clear();

            foreach (string txtFile in txtFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(txtFile));
            }
            foreach (string jpgFile in jpgFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(jpgFile));
            }
            foreach (string audioFile in audioFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(audioFile));
            }
            foreach (string pngFile in pngFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(pngFile));
            }
        }
        /*public void DelayList()
        {
            string folderPath = @"DelayTask";
            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");
            string[] jpgFiles = Directory.GetFiles(folderPath, "*.jpg");
            string[] audioFiles = Directory.GetFiles(folderPath, "*.mp3");
            string[] pngFiles = Directory.GetFiles(folderPath, "*.png");



            TaskListBox.Items.Clear();

            foreach (string txtFile in txtFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(txtFile));
            }
            foreach (string jpgFile in jpgFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(jpgFile));
            }
            foreach (string audioFile in audioFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(audioFile));
            }
            foreach (string pngFile in pngFiles)
            {
                TaskListBox.Items.Add(Path.GetFileName(pngFile));
            }
        }*/

        private void DelayTaskBtn_Click(object sender, EventArgs e)
        {
            taskType = "DelayTask";
            ShowTaskList();
            
        }

        
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (taskType != null && TaskListBox.SelectedIndex != -1)
            {
                TaskManager ts = new DelayTask(new TextTask());
            string selectedFile = taskType + "\\" + TaskListBox.SelectedItem.ToString();


            ts.DeleteTask(selectedFile);
            TaskListBox.Items.Remove(TaskListBox.SelectedItem.ToString());
            ShowTaskList();
            }
            else
            {
                MessageBox.Show("Выберите задачу!");
            }

        }

        private void CreateTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskType != null)
            {
                TaskTypeForm form = new TaskTypeForm();
                form.folderNname = taskType;
                form.Show();
            }
            else
            {
                MessageBox.Show("Выберите тип задачи!");
            }
            ShowTaskList();

        }
        public TaskManager ts;
        private void OpenTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskType != null && TaskListBox.SelectedIndex!=-1)
            {
                string taskName = TaskListBox.SelectedItem.ToString();
                TaskManager ts = new ExtraTask(setTaskType(taskName));

                taskName = Path.Combine(taskType, taskName);
                ts.task = new TextTask();
                ts.OpenTask(taskName);
                ShowTaskList();
            }
            else
            {
                MessageBox.Show("Выберите задачу!");
            }

        }

        private void EditTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskType != null && TaskListBox.SelectedIndex != -1)
            {
                string taskName = TaskListBox.SelectedItem.ToString();

            TaskManager ts = new ExtraTask(setTaskType(taskName));

            taskName = Path.Combine(taskType, taskName);
            ts.task = new TextTask();
            ts.EditTask(taskName);
            ShowTaskList();
            }
            else
            {
                MessageBox.Show("Выберите задачу!");
            }

        }

        public ImpTask setTaskType(string taskName)
        {
            //string taskName = TaskListBox.SelectedItem.ToString();
            if(taskName.EndsWith(".jpg") == true)
            {
                return new PictureTask();
            }
            if (taskName.EndsWith(".png") == true)
            {
                return new PictureTask();
            }
            if (taskName.EndsWith(".txt") == true)
            {
                return new TextTask();
            }
            if (taskName.EndsWith(".mp3") == true)
            {
                return new AudioTask();
            }
            return new TextTask();
        }
    }
    
   
}
