namespace MaskAppointment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TestEnd = new System.Windows.Forms.Button();
            this.TestStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestNumberInput = new System.Windows.Forms.NumericUpDown();
            this.TestNum = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.realName = new System.Windows.Forms.Label();
            this.IDnumber = new System.Windows.Forms.Label();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.TelInput = new System.Windows.Forms.TextBox();
            this.NumberOfOrder = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.NumericUpDown();
            this.Submit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AboveTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // TestEnd
            // 
            this.TestEnd.Location = new System.Drawing.Point(141, 25);
            this.TestEnd.Margin = new System.Windows.Forms.Padding(4);
            this.TestEnd.Name = "TestEnd";
            this.TestEnd.Size = new System.Drawing.Size(100, 29);
            this.TestEnd.TabIndex = 0;
            this.TestEnd.Text = "结束测试";
            this.TestEnd.UseVisualStyleBackColor = true;
            this.TestEnd.Click += new System.EventHandler(this.TestEnd_Click);
            // 
            // TestStart
            // 
            this.TestStart.Location = new System.Drawing.Point(17, 25);
            this.TestStart.Margin = new System.Windows.Forms.Padding(4);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(100, 29);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "开始测试";
            this.TestStart.UseVisualStyleBackColor = true;
            this.TestStart.Click += new System.EventHandler(this.TestStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestNumberInput);
            this.groupBox1.Controls.Add(this.TestNum);
            this.groupBox1.Controls.Add(this.TestStart);
            this.groupBox1.Controls.Add(this.TestEnd);
            this.groupBox1.Location = new System.Drawing.Point(65, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试部分";
            // 
            // TestNumberInput
            // 
            this.TestNumberInput.Location = new System.Drawing.Point(141, 81);
            this.TestNumberInput.Margin = new System.Windows.Forms.Padding(4);
            this.TestNumberInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TestNumberInput.Name = "TestNumberInput";
            this.TestNumberInput.Size = new System.Drawing.Size(117, 25);
            this.TestNumberInput.TabIndex = 3;
            this.TestNumberInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TestNum
            // 
            this.TestNum.AutoSize = true;
            this.TestNum.Location = new System.Drawing.Point(15, 84);
            this.TestNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestNum.Name = "TestNum";
            this.TestNum.Size = new System.Drawing.Size(112, 15);
            this.TestNum.TabIndex = 2;
            this.TestNum.Text = "设置测试总量：";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(172, 112);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(159, 25);
            this.nameInput.TabIndex = 3;
            // 
            // realName
            // 
            this.realName.AutoSize = true;
            this.realName.Location = new System.Drawing.Point(77, 116);
            this.realName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realName.Name = "realName";
            this.realName.Size = new System.Drawing.Size(82, 15);
            this.realName.TabIndex = 4;
            this.realName.Text = "真实姓名：";
            // 
            // IDnumber
            // 
            this.IDnumber.AutoSize = true;
            this.IDnumber.Location = new System.Drawing.Point(77, 160);
            this.IDnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDnumber.Name = "IDnumber";
            this.IDnumber.Size = new System.Drawing.Size(82, 15);
            this.IDnumber.TabIndex = 5;
            this.IDnumber.Text = "身份证号：";
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(172, 156);
            this.IdInput.Margin = new System.Windows.Forms.Padding(4);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(159, 25);
            this.IdInput.TabIndex = 6;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(80, 206);
            this.Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(82, 15);
            this.Tel.TabIndex = 7;
            this.Tel.Text = "电话号码：";
            // 
            // TelInput
            // 
            this.TelInput.Location = new System.Drawing.Point(172, 202);
            this.TelInput.Margin = new System.Windows.Forms.Padding(4);
            this.TelInput.Name = "TelInput";
            this.TelInput.Size = new System.Drawing.Size(159, 25);
            this.TelInput.TabIndex = 8;
            // 
            // NumberOfOrder
            // 
            this.NumberOfOrder.AutoSize = true;
            this.NumberOfOrder.Location = new System.Drawing.Point(77, 256);
            this.NumberOfOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfOrder.Name = "NumberOfOrder";
            this.NumberOfOrder.Size = new System.Drawing.Size(82, 15);
            this.NumberOfOrder.TabIndex = 9;
            this.NumberOfOrder.Text = "预约数量：";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 20F);
            this.title.Location = new System.Drawing.Point(139, 45);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(151, 34);
            this.title.TabIndex = 10;
            this.title.Text = "口罩预约";
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(172, 254);
            this.OrderNumber.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(160, 25);
            this.OrderNumber.TabIndex = 11;
            this.OrderNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(157, 322);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 29);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "预约提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // AboveTitle
            // 
            this.AboveTitle.AutoSize = true;
            this.AboveTitle.Location = new System.Drawing.Point(11, 10);
            this.AboveTitle.Name = "AboveTitle";
            this.AboveTitle.Size = new System.Drawing.Size(142, 15);
            this.AboveTitle.TabIndex = 13;
            this.AboveTitle.Text = "当前不在预约时间内";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 471);
            this.Controls.Add(this.AboveTitle);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.title);
            this.Controls.Add(this.NumberOfOrder);
            this.Controls.Add(this.TelInput);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.IdInput);
            this.Controls.Add(this.IDnumber);
            this.Controls.Add(this.realName);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestEnd;
        private System.Windows.Forms.Button TestStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label realName;
        private System.Windows.Forms.Label IDnumber;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox TelInput;
        private System.Windows.Forms.Label NumberOfOrder;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown OrderNumber;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown TestNumberInput;
        private System.Windows.Forms.Label TestNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AboveTitle;
    }
}

