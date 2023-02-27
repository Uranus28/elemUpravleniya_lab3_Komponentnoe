namespace TestControlsApplication
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
            this.kvColor1 = new LabControls.kvColor();
            this.kvColor2 = new LabControls.kvColor();
            this.SuspendLayout();
            // 
            // kvColor1
            // 
            this.kvColor1.CurColor = System.Drawing.Color.Black;
            this.kvColor1.Location = new System.Drawing.Point(12, 12);
            this.kvColor1.Name = "kvColor1";
            this.kvColor1.Size = new System.Drawing.Size(391, 204);
            this.kvColor1.TabIndex = 2;
            // 
            // kvColor2
            // 
            this.kvColor2.CurColor = System.Drawing.Color.Black;
            this.kvColor2.Location = new System.Drawing.Point(12, 222);
            this.kvColor2.Name = "kvColor2";
            this.kvColor2.Size = new System.Drawing.Size(391, 179);
            this.kvColor2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 432);
            this.Controls.Add(this.kvColor2);
            this.Controls.Add(this.kvColor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private LabControls.kvColor kvColor1;
        private LabControls.kvColor kvColor2;
    }
}

