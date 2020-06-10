namespace Modeling
{
    partial class ShowSessions
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sessions = new System.Windows.Forms.ListBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Смоделированные сесии";
            // 
            // Sessions
            // 
            this.Sessions.FormattingEnabled = true;
            this.Sessions.HorizontalScrollbar = true;
            this.Sessions.Location = new System.Drawing.Point(12, 46);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(384, 485);
            this.Sessions.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(99, 541);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(90, 26);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(234, 541);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 26);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ShowSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 580);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Sessions);
            this.Controls.Add(this.label1);
            this.Name = "ShowSessions";
            this.Text = "Результат моделирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Sessions;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}