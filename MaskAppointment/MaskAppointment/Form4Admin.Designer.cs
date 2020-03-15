namespace MaskAppointment
{
    partial class Form4Admin
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
            this.label4Begin = new System.Windows.Forms.Label();
            this.label4End = new System.Windows.Forms.Label();
            this.dateTimePicker4Begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4Find = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown4TotalNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4PerNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button4Find = new System.Windows.Forms.Button();
            this.button4Set = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4TotalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4PerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label4Begin
            // 
            this.label4Begin.AutoSize = true;
            this.label4Begin.Font = new System.Drawing.Font("宋体", 11F);
            this.label4Begin.Location = new System.Drawing.Point(28, 61);
            this.label4Begin.Name = "label4Begin";
            this.label4Begin.Size = new System.Drawing.Size(180, 19);
            this.label4Begin.TabIndex = 0;
            this.label4Begin.Text = "请设置预约开始时间";
            // 
            // label4End
            // 
            this.label4End.AutoSize = true;
            this.label4End.Font = new System.Drawing.Font("宋体", 11F);
            this.label4End.Location = new System.Drawing.Point(409, 61);
            this.label4End.Name = "label4End";
            this.label4End.Size = new System.Drawing.Size(180, 19);
            this.label4End.TabIndex = 1;
            this.label4End.Text = "请设置预约截至时间";
            // 
            // dateTimePicker4Begin
            // 
            this.dateTimePicker4Begin.Location = new System.Drawing.Point(214, 56);
            this.dateTimePicker4Begin.Name = "dateTimePicker4Begin";
            this.dateTimePicker4Begin.Size = new System.Drawing.Size(154, 25);
            this.dateTimePicker4Begin.TabIndex = 2;
            // 
            // dateTimePicker4End
            // 
            this.dateTimePicker4End.Location = new System.Drawing.Point(595, 56);
            this.dateTimePicker4End.Name = "dateTimePicker4End";
            this.dateTimePicker4End.Size = new System.Drawing.Size(156, 25);
            this.dateTimePicker4End.TabIndex = 3;
            // 
            // dateTimePicker4Find
            // 
            this.dateTimePicker4Find.Location = new System.Drawing.Point(322, 266);
            this.dateTimePicker4Find.Name = "dateTimePicker4Find";
            this.dateTimePicker4Find.Size = new System.Drawing.Size(156, 25);
            this.dateTimePicker4Find.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "发放口罩数量";
            // 
            // numericUpDown4TotalNum
            // 
            this.numericUpDown4TotalNum.Location = new System.Drawing.Point(177, 106);
            this.numericUpDown4TotalNum.Name = "numericUpDown4TotalNum";
            this.numericUpDown4TotalNum.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown4TotalNum.TabIndex = 6;
            // 
            // numericUpDown4PerNum
            // 
            this.numericUpDown4PerNum.Location = new System.Drawing.Point(575, 106);
            this.numericUpDown4PerNum.Name = "numericUpDown4PerNum";
            this.numericUpDown4PerNum.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown4PerNum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(427, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "个人最多预约数";
            // 
            // button4Find
            // 
            this.button4Find.Font = new System.Drawing.Font("宋体", 11F);
            this.button4Find.Location = new System.Drawing.Point(313, 321);
            this.button4Find.Name = "button4Find";
            this.button4Find.Size = new System.Drawing.Size(137, 35);
            this.button4Find.TabIndex = 9;
            this.button4Find.Text = "查看中签名单";
            this.button4Find.UseVisualStyleBackColor = true;
            // 
            // button4Set
            // 
            this.button4Set.Font = new System.Drawing.Font("宋体", 11F);
            this.button4Set.Location = new System.Drawing.Point(331, 180);
            this.button4Set.Name = "button4Set";
            this.button4Set.Size = new System.Drawing.Size(105, 34);
            this.button4Set.TabIndex = 10;
            this.button4Set.Text = "确认设置";
            this.button4Set.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(155, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "选择查看中签日期";
            // 
            // Form4Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4Set);
            this.Controls.Add(this.button4Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown4PerNum);
            this.Controls.Add(this.numericUpDown4TotalNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker4Find);
            this.Controls.Add(this.dateTimePicker4End);
            this.Controls.Add(this.dateTimePicker4Begin);
            this.Controls.Add(this.label4End);
            this.Controls.Add(this.label4Begin);
            this.Name = "Form4Admin";
            this.Text = "管理员界面";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4TotalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4PerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4Begin;
        private System.Windows.Forms.Label label4End;
        private System.Windows.Forms.DateTimePicker dateTimePicker4Begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker4End;
        private System.Windows.Forms.DateTimePicker dateTimePicker4Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown4TotalNum;
        private System.Windows.Forms.NumericUpDown numericUpDown4PerNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4Find;
        private System.Windows.Forms.Button button4Set;
        private System.Windows.Forms.Label label3;
    }
}