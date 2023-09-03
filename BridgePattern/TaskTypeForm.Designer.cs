
namespace BridgePattern
{
    partial class TaskTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateImageBtn = new System.Windows.Forms.Button();
            this.CreateTextBtn = new System.Windows.Forms.Button();
            this.CreateAudioBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateImageBtn
            // 
            this.CreateImageBtn.Location = new System.Drawing.Point(91, 59);
            this.CreateImageBtn.Name = "CreateImageBtn";
            this.CreateImageBtn.Size = new System.Drawing.Size(148, 66);
            this.CreateImageBtn.TabIndex = 0;
            this.CreateImageBtn.Text = "Создать изображение";
            this.CreateImageBtn.UseVisualStyleBackColor = true;
            this.CreateImageBtn.Click += new System.EventHandler(this.CreateImageBtn_Click);
            // 
            // CreateTextBtn
            // 
            this.CreateTextBtn.Location = new System.Drawing.Point(316, 59);
            this.CreateTextBtn.Name = "CreateTextBtn";
            this.CreateTextBtn.Size = new System.Drawing.Size(148, 66);
            this.CreateTextBtn.TabIndex = 1;
            this.CreateTextBtn.Text = "Создать текст";
            this.CreateTextBtn.UseVisualStyleBackColor = true;
            this.CreateTextBtn.Click += new System.EventHandler(this.CreateTextBtn_Click);
            // 
            // CreateAudioBtn
            // 
            this.CreateAudioBtn.Location = new System.Drawing.Point(519, 59);
            this.CreateAudioBtn.Name = "CreateAudioBtn";
            this.CreateAudioBtn.Size = new System.Drawing.Size(148, 66);
            this.CreateAudioBtn.TabIndex = 2;
            this.CreateAudioBtn.Text = "Создать аудио";
            this.CreateAudioBtn.UseVisualStyleBackColor = true;
            this.CreateAudioBtn.Click += new System.EventHandler(this.CreateAudioBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя файла:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 22);
            this.textBox1.TabIndex = 4;
            // 
            // TaskTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 244);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAudioBtn);
            this.Controls.Add(this.CreateTextBtn);
            this.Controls.Add(this.CreateImageBtn);
            this.Name = "TaskTypeForm";
            this.Text = "TaskTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateImageBtn;
        private System.Windows.Forms.Button CreateTextBtn;
        private System.Windows.Forms.Button CreateAudioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}