namespace TestLab4
{
    partial class CalculatorForm
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.BtSubstract = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(12, 12);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(160, 20);
            this.tbA.TabIndex = 0;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(12, 38);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(160, 20);
            this.tbB.TabIndex = 1;
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(12, 64);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(160, 23);
            this.btSum.TabIndex = 2;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.OnPlusClicked);
            // 
            // BtSubstract
            // 
            this.BtSubstract.Location = new System.Drawing.Point(12, 93);
            this.BtSubstract.Name = "BtSubstract";
            this.BtSubstract.Size = new System.Drawing.Size(160, 23);
            this.BtSubstract.TabIndex = 3;
            this.BtSubstract.Text = "-";
            this.BtSubstract.UseVisualStyleBackColor = true;
            this.BtSubstract.Click += new System.EventHandler(this.OnMinusClicked);
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(12, 122);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(160, 23);
            this.btMultiply.TabIndex = 4;
            this.btMultiply.Text = "*";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.OnMultiplyClicked);
            // 
            // btDevide
            // 
            this.btDevide.Location = new System.Drawing.Point(12, 151);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(160, 23);
            this.btDevide.TabIndex = 5;
            this.btDevide.Text = "/";
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.OnDivideClicked);
            // 
            // tbMessage
            // 
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(12, 180);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(160, 20);
            this.tbMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.BtSubstract);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button BtSubstract;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.TextBox tbMessage;
    }
}

