namespace Task_Await_Jeremy
{
    partial class Form1
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
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.btnLoadEmployee = new System.Windows.Forms.Button();
            this.btnLoadWithLamda = new System.Windows.Forms.Button();
            this.btnLoadWithAwait = new System.Windows.Forms.Button();
            this.btnWithAwaitOnly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.Location = new System.Drawing.Point(12, 103);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(216, 264);
            this.lstEmployee.TabIndex = 0;
            // 
            // btnLoadEmployee
            // 
            this.btnLoadEmployee.Location = new System.Drawing.Point(12, 9);
            this.btnLoadEmployee.Name = "btnLoadEmployee";
            this.btnLoadEmployee.Size = new System.Drawing.Size(106, 35);
            this.btnLoadEmployee.TabIndex = 1;
            this.btnLoadEmployee.Text = "Load Employee";
            this.btnLoadEmployee.UseVisualStyleBackColor = true;
            this.btnLoadEmployee.Click += new System.EventHandler(this.btnLoadEmployee_Click);
            // 
            // btnLoadWithLamda
            // 
            this.btnLoadWithLamda.Location = new System.Drawing.Point(124, 9);
            this.btnLoadWithLamda.Name = "btnLoadWithLamda";
            this.btnLoadWithLamda.Size = new System.Drawing.Size(104, 35);
            this.btnLoadWithLamda.TabIndex = 2;
            this.btnLoadWithLamda.Text = "Loan Employee Lamda";
            this.btnLoadWithLamda.UseVisualStyleBackColor = true;
            this.btnLoadWithLamda.Click += new System.EventHandler(this.btnLoadWithLamda_Click);
            // 
            // btnLoadWithAwait
            // 
            this.btnLoadWithAwait.Location = new System.Drawing.Point(12, 50);
            this.btnLoadWithAwait.Name = "btnLoadWithAwait";
            this.btnLoadWithAwait.Size = new System.Drawing.Size(106, 35);
            this.btnLoadWithAwait.TabIndex = 3;
            this.btnLoadWithAwait.Text = "Load with await";
            this.btnLoadWithAwait.UseVisualStyleBackColor = true;
            this.btnLoadWithAwait.Click += new System.EventHandler(this.btnLoadWithAwait_Click);
            // 
            // btnWithAwaitOnly
            // 
            this.btnWithAwaitOnly.Location = new System.Drawing.Point(124, 50);
            this.btnWithAwaitOnly.Name = "btnWithAwaitOnly";
            this.btnWithAwaitOnly.Size = new System.Drawing.Size(106, 35);
            this.btnWithAwaitOnly.TabIndex = 3;
            this.btnWithAwaitOnly.Text = "Load with await";
            this.btnWithAwaitOnly.UseVisualStyleBackColor = true;
            this.btnWithAwaitOnly.Click += new System.EventHandler(this.btnWithAwaitOnly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 377);
            this.Controls.Add(this.btnWithAwaitOnly);
            this.Controls.Add(this.btnLoadWithAwait);
            this.Controls.Add(this.btnLoadWithLamda);
            this.Controls.Add(this.btnLoadEmployee);
            this.Controls.Add(this.lstEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.Button btnLoadEmployee;
        private System.Windows.Forms.Button btnLoadWithLamda;
        private System.Windows.Forms.Button btnLoadWithAwait;
        private System.Windows.Forms.Button btnWithAwaitOnly;
    }
}

