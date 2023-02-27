namespace LabControls
{
    partial class kvColor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.radioBtnDec = new System.Windows.Forms.RadioButton();
            this.radioBtnHex = new System.Windows.Forms.RadioButton();
            this.numberBoxBlue = new LabControls.NumberBox(this.components);
            this.numberBoxGreen = new LabControls.NumberBox(this.components);
            this.numberBoxRed = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(12, 30);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(33, 16);
            this.Red.TabIndex = 3;
            this.Red.Text = "Red";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(12, 62);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(44, 16);
            this.Green.TabIndex = 4;
            this.Green.Text = "Green";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(12, 94);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(34, 16);
            this.Blue.TabIndex = 5;
            this.Blue.Text = "Blue";
            // 
            // radioBtnDec
            // 
            this.radioBtnDec.AutoSize = true;
            this.radioBtnDec.Checked = true;
            this.radioBtnDec.Location = new System.Drawing.Point(15, 135);
            this.radioBtnDec.Name = "radioBtnDec";
            this.radioBtnDec.Size = new System.Drawing.Size(53, 20);
            this.radioBtnDec.TabIndex = 6;
            this.radioBtnDec.TabStop = true;
            this.radioBtnDec.Text = "Dec";
            this.radioBtnDec.UseVisualStyleBackColor = true;
            this.radioBtnDec.CheckedChanged += new System.EventHandler(this.radioBtnDec_CheckedChanged);
            // 
            // radioBtnHex
            // 
            this.radioBtnHex.AutoSize = true;
            this.radioBtnHex.Location = new System.Drawing.Point(89, 135);
            this.radioBtnHex.Name = "radioBtnHex";
            this.radioBtnHex.Size = new System.Drawing.Size(52, 20);
            this.radioBtnHex.TabIndex = 7;
            this.radioBtnHex.Text = "Hex";
            this.radioBtnHex.UseVisualStyleBackColor = true;
            // 
            // numberBoxBlue
            // 
            this.numberBoxBlue.Hex = false;
            this.numberBoxBlue.Location = new System.Drawing.Point(65, 88);
            this.numberBoxBlue.Name = "numberBoxBlue";
            this.numberBoxBlue.Size = new System.Drawing.Size(100, 22);
            this.numberBoxBlue.TabIndex = 2;
            this.numberBoxBlue.Text = "0";
            this.numberBoxBlue.TextChanged += new System.EventHandler(this.numberBoxBlue_TextChanged);
            // 
            // numberBoxGreen
            // 
            this.numberBoxGreen.Hex = false;
            this.numberBoxGreen.Location = new System.Drawing.Point(65, 59);
            this.numberBoxGreen.Name = "numberBoxGreen";
            this.numberBoxGreen.Size = new System.Drawing.Size(100, 22);
            this.numberBoxGreen.TabIndex = 1;
            this.numberBoxGreen.Text = "0";
            this.numberBoxGreen.TextChanged += new System.EventHandler(this.numberBoxGreen_TextChanged);
            // 
            // numberBoxRed
            // 
            this.numberBoxRed.Hex = false;
            this.numberBoxRed.Location = new System.Drawing.Point(65, 30);
            this.numberBoxRed.Name = "numberBoxRed";
            this.numberBoxRed.Size = new System.Drawing.Size(100, 22);
            this.numberBoxRed.TabIndex = 0;
            this.numberBoxRed.Text = "0";
            this.numberBoxRed.TextChanged += new System.EventHandler(this.numberBoxRed_TextChanged_1);
            // 
            // kvColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnHex);
            this.Controls.Add(this.radioBtnDec);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.numberBoxBlue);
            this.Controls.Add(this.numberBoxGreen);
            this.Controls.Add(this.numberBoxRed);
            this.Name = "kvColor";
            this.Size = new System.Drawing.Size(391, 179);
            this.Load += new System.EventHandler(this.kvColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberBox numberBoxRed;
        private NumberBox numberBoxGreen;
        private NumberBox numberBoxBlue;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.RadioButton radioBtnDec;
        private System.Windows.Forms.RadioButton radioBtnHex;
    }
}
