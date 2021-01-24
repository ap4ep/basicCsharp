
namespace lesson7._2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblInpuTip = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTryCount = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtTryCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(90, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 63);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Играть";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(246, 93);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblInpuTip
            // 
            this.lblInpuTip.AutoSize = true;
            this.lblInpuTip.Location = new System.Drawing.Point(6, 98);
            this.lblInpuTip.Name = "lblInpuTip";
            this.lblInpuTip.Size = new System.Drawing.Size(81, 13);
            this.lblInpuTip.TabIndex = 2;
            this.lblInpuTip.Text = "Вводите числа";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(90, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 20);
            this.txtInput.TabIndex = 3;
            // 
            // lblTryCount
            // 
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Location = new System.Drawing.Point(111, 143);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(85, 13);
            this.lblTryCount.TabIndex = 4;
            this.lblTryCount.Text = "Число попыток";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(106, 118);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(120, 13);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "Тут будут подсказки :)";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTryCount
            // 
            this.txtTryCount.Enabled = false;
            this.txtTryCount.Location = new System.Drawing.Point(202, 140);
            this.txtTryCount.Name = "txtTryCount";
            this.txtTryCount.Size = new System.Drawing.Size(24, 20);
            this.txtTryCount.TabIndex = 6;
            this.txtTryCount.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 183);
            this.Controls.Add(this.txtTryCount);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblTryCount);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInpuTip);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblInpuTip;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTryCount;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtTryCount;
    }
}

