﻿namespace Modeling
{
    partial class MainForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.Modeling = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(199, 17);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(90, 20);
            this.textBox.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(41, 20);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(152, 13);
            this.text1.TabIndex = 2;
            this.text1.Text = "Введите количество сессий:";
            // 
            // Modeling
            // 
            this.Modeling.Location = new System.Drawing.Point(93, 43);
            this.Modeling.Name = "Modeling";
            this.Modeling.Size = new System.Drawing.Size(149, 31);
            this.Modeling.TabIndex = 3;
            this.Modeling.Text = "Получить сессии";
            this.Modeling.UseVisualStyleBackColor = true;
            this.Modeling.Click += new System.EventHandler(this.Modeling_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(41, 86);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(131, 13);
            this.text2.TabIndex = 4;
            this.text2.Text = "Пользователи системы:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(44, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(245, 121);
            this.listBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 243);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.Modeling);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.textBox);
            this.Name = "MainForm";
            this.Text = "Моделирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button Modeling;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ListBox listBox;
    }
}

