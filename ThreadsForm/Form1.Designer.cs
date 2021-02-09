
namespace ThreadsForm
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.CheckMax = new System.Windows.Forms.CheckBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.txtFirstThread = new System.Windows.Forms.TextBox();
            this.grpBoxSecondThread = new System.Windows.Forms.GroupBox();
            this.CheckAvg = new System.Windows.Forms.CheckBox();
            this.pBar2 = new System.Windows.Forms.ProgressBar();
            this.txtSecondThread = new System.Windows.Forms.TextBox();
            this.grpBoxThirfThread = new System.Windows.Forms.GroupBox();
            this.CheckMin = new System.Windows.Forms.CheckBox();
            this.pBar3 = new System.Windows.Forms.ProgressBar();
            this.txtThirdThread = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.grpBoxSecondThread.SuspendLayout();
            this.grpBoxThirfThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.pBar1);
            this.grpBox1.Controls.Add(this.txtFirstThread);
            this.grpBox1.Location = new System.Drawing.Point(51, 24);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(732, 100);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "First thread (Max)";
            this.grpBox1.Enter += new System.EventHandler(this.grpBox1_Enter);
            // 
            // CheckMax
            // 
            this.CheckMax.AutoSize = true;
            this.CheckMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckMax.Location = new System.Drawing.Point(849, 104);
            this.CheckMax.Name = "CheckMax";
            this.CheckMax.Size = new System.Drawing.Size(52, 20);
            this.CheckMax.TabIndex = 6;
            this.CheckMax.Text = "Max";
            this.CheckMax.UseVisualStyleBackColor = true;
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(276, 45);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(333, 37);
            this.pBar1.TabIndex = 1;
            // 
            // txtFirstThread
            // 
            this.txtFirstThread.Location = new System.Drawing.Point(30, 45);
            this.txtFirstThread.Multiline = true;
            this.txtFirstThread.Name = "txtFirstThread";
            this.txtFirstThread.ReadOnly = true;
            this.txtFirstThread.Size = new System.Drawing.Size(219, 38);
            this.txtFirstThread.TabIndex = 0;
            // 
            // grpBoxSecondThread
            // 
            this.grpBoxSecondThread.Controls.Add(this.pBar2);
            this.grpBoxSecondThread.Controls.Add(this.txtSecondThread);
            this.grpBoxSecondThread.Location = new System.Drawing.Point(51, 139);
            this.grpBoxSecondThread.Name = "grpBoxSecondThread";
            this.grpBoxSecondThread.Size = new System.Drawing.Size(732, 107);
            this.grpBoxSecondThread.TabIndex = 2;
            this.grpBoxSecondThread.TabStop = false;
            this.grpBoxSecondThread.Text = "Second thread (Avg)";
            // 
            // CheckAvg
            // 
            this.CheckAvg.AutoSize = true;
            this.CheckAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckAvg.Location = new System.Drawing.Point(849, 130);
            this.CheckAvg.Name = "CheckAvg";
            this.CheckAvg.Size = new System.Drawing.Size(55, 20);
            this.CheckAvg.TabIndex = 7;
            this.CheckAvg.Text = "AVG";
            this.CheckAvg.UseVisualStyleBackColor = true;
            // 
            // pBar2
            // 
            this.pBar2.Location = new System.Drawing.Point(276, 45);
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(333, 37);
            this.pBar2.TabIndex = 1;
            // 
            // txtSecondThread
            // 
            this.txtSecondThread.Location = new System.Drawing.Point(30, 45);
            this.txtSecondThread.Multiline = true;
            this.txtSecondThread.Name = "txtSecondThread";
            this.txtSecondThread.ReadOnly = true;
            this.txtSecondThread.Size = new System.Drawing.Size(219, 38);
            this.txtSecondThread.TabIndex = 0;
            // 
            // grpBoxThirfThread
            // 
            this.grpBoxThirfThread.Controls.Add(this.pBar3);
            this.grpBoxThirfThread.Controls.Add(this.txtThirdThread);
            this.grpBoxThirfThread.Location = new System.Drawing.Point(51, 262);
            this.grpBoxThirfThread.Name = "grpBoxThirfThread";
            this.grpBoxThirfThread.Size = new System.Drawing.Size(732, 110);
            this.grpBoxThirfThread.TabIndex = 3;
            this.grpBoxThirfThread.TabStop = false;
            this.grpBoxThirfThread.Text = "Third thread (Min)";
            // 
            // CheckMin
            // 
            this.CheckMin.AutoSize = true;
            this.CheckMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckMin.Location = new System.Drawing.Point(849, 156);
            this.CheckMin.Name = "CheckMin";
            this.CheckMin.Size = new System.Drawing.Size(48, 20);
            this.CheckMin.TabIndex = 8;
            this.CheckMin.Text = "Min";
            this.CheckMin.UseVisualStyleBackColor = true;
            // 
            // pBar3
            // 
            this.pBar3.Location = new System.Drawing.Point(276, 45);
            this.pBar3.Name = "pBar3";
            this.pBar3.Size = new System.Drawing.Size(333, 37);
            this.pBar3.TabIndex = 1;
            // 
            // txtThirdThread
            // 
            this.txtThirdThread.Location = new System.Drawing.Point(30, 44);
            this.txtThirdThread.Multiline = true;
            this.txtThirdThread.Name = "txtThirdThread";
            this.txtThirdThread.ReadOnly = true;
            this.txtThirdThread.Size = new System.Drawing.Size(219, 38);
            this.txtThirdThread.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(810, 45);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(124, 44);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(810, 328);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(124, 44);
            this.btnExitProgram.TabIndex = 9;
            this.btnExitProgram.Text = "Exit";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 395);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.CheckMin);
            this.Controls.Add(this.CheckAvg);
            this.Controls.Add(this.CheckMax);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpBoxThirfThread);
            this.Controls.Add(this.grpBoxSecondThread);
            this.Controls.Add(this.grpBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBoxSecondThread.ResumeLayout(false);
            this.grpBoxSecondThread.PerformLayout();
            this.grpBoxThirfThread.ResumeLayout(false);
            this.grpBoxThirfThread.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.TextBox txtFirstThread;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.GroupBox grpBoxSecondThread;
        private System.Windows.Forms.ProgressBar pBar2;
        private System.Windows.Forms.TextBox txtSecondThread;
        private System.Windows.Forms.GroupBox grpBoxThirfThread;
        private System.Windows.Forms.ProgressBar pBar3;
        private System.Windows.Forms.TextBox txtThirdThread;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox CheckMax;
        private System.Windows.Forms.CheckBox CheckAvg;
        private System.Windows.Forms.CheckBox CheckMin;
        private System.Windows.Forms.Button btnExitProgram;
    }
}

