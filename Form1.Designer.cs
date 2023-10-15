namespace Start_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.White;
            this.bStart.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(120, 115);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(143, 51);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "START";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            this.bStart.MouseLeave += new System.EventHandler(this.bStart_MouseLeave);
            this.bStart.MouseHover += new System.EventHandler(this.bStart_MouseHover);
            // 
            // bOptions
            // 
            this.bOptions.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptions.Location = new System.Drawing.Point(120, 188);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(143, 51);
            this.bOptions.TabIndex = 2;
            this.bOptions.Text = "OPTIONS";
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            this.bOptions.MouseLeave += new System.EventHandler(this.bOptions_MouseLeave);
            this.bOptions.MouseHover += new System.EventHandler(this.bOptions_MouseHover);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(120, 262);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(143, 51);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            this.bExit.MouseLeave += new System.EventHandler(this.bExit_MouseLeave);
            this.bExit.MouseHover += new System.EventHandler(this.bExit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bStart;
    }
}

