using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace BridgePattern
{
    public abstract class ImpTask
    {
        public abstract void OpenFile(string taskName);
        public abstract void CreateFile(String taskName);
        public abstract void EditFile(String taskName);
    }
    
    
    class PictureTask : ImpTask
    {
        public override void OpenFile(string taskName)
        {
            File.SetAttributes(taskName, FileAttributes.ReadOnly);
            Process.Start(taskName);
        }
        public override void CreateFile(String taskName)
        {
            Form1 forma = new Form1();
            MessageBox.Show("После работы укажите путь");

            Process.Start("ms-paint:", forma.taskType);
        }

        public override void EditFile(string taskName)
        {
            string paint3DPath = @"C:\Program Files\Adobe\Adobe Photoshop 2020\Photoshop.exe";
            File.SetAttributes(taskName, File.GetAttributes(taskName) & ~FileAttributes.ReadOnly);

            Process.Start(paint3DPath, $"\"{taskName}\"");

        }

    }
    class ExtraTask : TaskManager
    {
        public ExtraTask(ImpTask tsk)
        : base(tsk)
        {
            
        }

    }
    class DelayTask : TaskManager
    {
        public DelayTask(ImpTask tsk)
        : base(tsk)
        {
            
        }
    }
    class TextTask : ImpTask
    {
        public override void OpenFile(string taskName)
        {
            File.SetAttributes(taskName, FileAttributes.ReadOnly);
            Process.Start(taskName);
        }
        public override void CreateFile(String taskName)
        {
            Form1 forma = new Form1();


            using (StreamWriter writer = new StreamWriter(taskName))
            {
                writer.Write("");
            }

            MessageBox.Show("Файл успешно создан!");
        }
        public override void EditFile(String taskName)
        {
            File.SetAttributes(taskName, File.GetAttributes(taskName) & ~FileAttributes.ReadOnly);
            Process.Start(taskName);
        }
    }
    class AudioTask : ImpTask
    {
        public override void OpenFile(string taskName)
        {
            File.SetAttributes(taskName, FileAttributes.ReadOnly);
            Process.Start(taskName);
        }
        public override void CreateFile(String taskName)
        {
            Process.Start(@"C:\Program Files (x86)\Windows Media Player\wmplayer.exe");

            MessageBox.Show("Представим что файл успешно создан!))");
        }
        public override void EditFile(String taskName)
        {
            File.SetAttributes(taskName, File.GetAttributes(taskName) & ~FileAttributes.ReadOnly);

        }
    }

    public abstract class TaskManager
    {
        
        public ImpTask task;
        public ImpTask tsk
        {
            set { tsk = value; }
        }
        public TaskManager(ImpTask tsk)
        {
            task = tsk;
        }

        public virtual void createTask(string taskName)
        {
            task.CreateFile(taskName);
           // task.OpenFile(taskName);
        }
        public virtual void DeleteTask(string tsk)
        {
            Form1 forma = new Form1();

            string selectedFile = tsk;
            File.SetAttributes(selectedFile, File.GetAttributes(selectedFile) & ~FileAttributes.ReadOnly);

            File.Delete(selectedFile);
            
        }
        public virtual void EditTask(String taskName)
        {
            task.EditFile(taskName);
        }
        public virtual void OpenTask(String taskName)
        {
            task.OpenFile(taskName);
        }

    }
}
