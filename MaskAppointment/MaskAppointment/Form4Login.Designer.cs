namespace MaskAppointment
{
    partial class Form4Login
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
            this.textBox4Pass = new System.Windows.Forms.TextBox();
            this.button4Pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请在下方输入管理员密码";
            // 
            // textBox4Pass
            // 
            this.textBox4Pass.Location = new System.Drawing.Point(119, 126);
            this.textBox4Pass.Name = "textBox4Pass";
            this.textBox4Pass.Size = new System.Drawing.Size(238, 25);
            this.textBox4Pass.TabIndex = 1;
            // 
            // button4Pass
            // 
            this.button4Pass.Location = new System.Drawing.Point(188, 183);
            this.button4Pass.Name = "button4Pass";
            this.button4Pass.Size = new System.Drawing.Size(75, 23);
            this.button4Pass.TabIndex = 2;
            this.button4Pass.Text = "确认";
            this.button4Pass.UseVisualStyleBackColor = true;
            this.button4Pass.Click += new System.EventHandler(this.button4Pass_Click);
            // 
            // Form4Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 279);
            this.Controls.Add(this.button4Pass);
            this.Controls.Add(this.textBox4Pass);
            this.Controls.Add(this.label1);
            this.Name = "Form4Login";
            this.Text = "管理员登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4Pass;
        private System.Windows.Forms.Button button4Pass;
    }
}