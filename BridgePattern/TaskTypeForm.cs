using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public partial class TaskTypeForm : Form
    {
        public TaskTypeForm()
        {
            InitializeComponent();
        }
        public string filename;
        public string folderNname;
        private void CreateImageBtn_Click(object sender, EventArgs e)
        {
            TaskManager ts = new ExtraTask(new PictureTask());
            filename = textBox1.Text;
            ts.task = new PictureTask();
            ts.createTask(folderNname + "\\" + filename + ".jpg");

            this.Close();

        }

        private void CreateTextBtn_Click(object sender, EventArgs e)
        {
            TaskManager ts = new ExtraTask(new TextTask());
            filename = textBox1.Text;

            ts.task = new TextTask();
            ts.createTask(folderNname + "\\" + filename + ".txt");

            this.Close();

        }

        private void CreateAudioBtn_Click(object sender, EventArgs e)
        {
            TaskManager ts = new ExtraTask(new AudioTask());
            filename = textBox1.Text;

            ts.task = new AudioTask();
            ts.createTask(folderNname + "\\" + filename + ".mp3");

            this.Close();
        }
    }
}
