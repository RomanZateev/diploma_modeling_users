namespace Modeling
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
            this.modeling = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(44, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(149, 20);
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
            // modeling
            // 
            this.modeling.Location = new System.Drawing.Point(44, 91);
            this.modeling.Name = "modeling";
            this.modeling.Size = new System.Drawing.Size(149, 31);
            this.modeling.TabIndex = 3;
            this.modeling.Text = "Получить сессии";
            this.modeling.UseVisualStyleBackColor = true;
            this.modeling.Click += new System.EventHandler(this.modeling_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(44, 138);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(131, 13);
            this.text2.TabIndex = 4;
            this.text2.Text = "Пользователи системы:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(44, 163);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(149, 121);
            this.listBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 306);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.modeling);
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
        private System.Windows.Forms.Button modeling;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ListBox listBox;
    }
}

