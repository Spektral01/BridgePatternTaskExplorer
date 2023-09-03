
namespace BridgePattern
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.ExtraTaskBtn = new System.Windows.Forms.Button();
            this.DelayTaskBtn = new System.Windows.Forms.Button();
            this.OpenTaskBtn = new System.Windows.Forms.Button();
            this.DelTaskBtn = new System.Windows.Forms.Button();
            this.CreateTaskBtn = new System.Windows.Forms.Button();
            this.EditTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.ItemHeight = 16;
            this.TaskListBox.Location = new System.Drawing.Point(24, 79);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(952, 596);
            this.TaskListBox.TabIndex = 0;
            // 
            // ExtraTaskBtn
            // 
            this.ExtraTaskBtn.Location = new System.Drawing.Point(78, 22);
            this.ExtraTaskBtn.Name = "ExtraTaskBtn";
            this.ExtraTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.ExtraTaskBtn.TabIndex = 1;
            this.ExtraTaskBtn.Text = "Экстренные задачи";
            this.ExtraTaskBtn.UseVisualStyleBackColor = true;
            this.ExtraTaskBtn.Click += new System.EventHandler(this.ExtraTaskBtn_Click);
            // 
            // DelayTaskBtn
            // 
            this.DelayTaskBtn.Location = new System.Drawing.Point(284, 22);
            this.DelayTaskBtn.Name = "DelayTaskBtn";
            this.DelayTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.DelayTaskBtn.TabIndex = 2;
            this.DelayTaskBtn.Text = "Долгосрочные задачи";
            this.DelayTaskBtn.UseVisualStyleBackColor = true;
            this.DelayTaskBtn.Click += new System.EventHandler(this.DelayTaskBtn_Click);
            // 
            // OpenTaskBtn
            // 
            this.OpenTaskBtn.Location = new System.Drawing.Point(982, 136);
            this.OpenTaskBtn.Name = "OpenTaskBtn";
            this.OpenTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.OpenTaskBtn.TabIndex = 3;
            this.OpenTaskBtn.Text = "Открыть задачу";
            this.OpenTaskBtn.UseVisualStyleBackColor = true;
            this.OpenTaskBtn.Click += new System.EventHandler(this.OpenTaskBtn_Click);
            // 
            // DelTaskBtn
            // 
            this.DelTaskBtn.Location = new System.Drawing.Point(982, 250);
            this.DelTaskBtn.Name = "DelTaskBtn";
            this.DelTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.DelTaskBtn.TabIndex = 4;
            this.DelTaskBtn.Text = "Удалить задачу";
            this.DelTaskBtn.UseVisualStyleBackColor = true;
            this.DelTaskBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // CreateTaskBtn
            // 
            this.CreateTaskBtn.Location = new System.Drawing.Point(982, 79);
            this.CreateTaskBtn.Name = "CreateTaskBtn";
            this.CreateTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.CreateTaskBtn.TabIndex = 5;
            this.CreateTaskBtn.Text = "Создать задачу";
            this.CreateTaskBtn.UseVisualStyleBackColor = true;
            this.CreateTaskBtn.Click += new System.EventHandler(this.CreateTaskBtn_Click);
            // 
            // EditTaskBtn
            // 
            this.EditTaskBtn.Location = new System.Drawing.Point(982, 193);
            this.EditTaskBtn.Name = "EditTaskBtn";
            this.EditTaskBtn.Size = new System.Drawing.Size(169, 51);
            this.EditTaskBtn.TabIndex = 6;
            this.EditTaskBtn.Text = "Редактировать задачу";
            this.EditTaskBtn.UseVisualStyleBackColor = true;
            this.EditTaskBtn.Click += new System.EventHandler(this.EditTaskBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 712);
            this.Controls.Add(this.EditTaskBtn);
            this.Controls.Add(this.CreateTaskBtn);
            this.Controls.Add(this.DelTaskBtn);
            this.Controls.Add(this.OpenTaskBtn);
            this.Controls.Add(this.DelayTaskBtn);
            this.Controls.Add(this.ExtraTaskBtn);
            this.Controls.Add(this.TaskListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.Button ExtraTaskBtn;
        private System.Windows.Forms.Button DelayTaskBtn;
        private System.Windows.Forms.Button OpenTaskBtn;
        private System.Windows.Forms.Button DelTaskBtn;
        private System.Windows.Forms.Button CreateTaskBtn;
        private System.Windows.Forms.Button EditTaskBtn;
    }
}

