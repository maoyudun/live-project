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
            this.TestEnd = new System.Windows.Forms.Button();
            this.TestStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.TestNum = new System.Windows.Forms.Label();
            this.TestNumberInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // TestEnd
            // 
            this.TestEnd.Location = new System.Drawing.Point(106, 20);
            this.TestEnd.Name = "TestEnd";
            this.TestEnd.Size = new System.Drawing.Size(75, 23);
            this.TestEnd.TabIndex = 0;
            this.TestEnd.Text = "结束测试";
            this.TestEnd.UseVisualStyleBackColor = true;
            // 
            // TestStart
            // 
            this.TestStart.Location = new System.Drawing.Point(13, 20);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(75, 23);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "开始测试";
            this.TestStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestNumberInput);
            this.groupBox1.Controls.Add(this.TestNum);
            this.groupBox1.Controls.Add(this.TestStart);
            this.groupBox1.Controls.Add(this.TestEnd);
            this.groupBox1.Location = new System.Drawing.Point(49, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试部分";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(129, 90);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(120, 21);
            this.nameInput.TabIndex = 3;
            // 
            // realName
            // 
            this.realName.AutoSize = true;
            this.realName.Location = new System.Drawing.Point(58, 93);
            this.realName.Name = "realName";
            this.realName.Size = new System.Drawing.Size(65, 12);
            this.realName.TabIndex = 4;
            this.realName.Text = "真实姓名：";
            // 
            // IDnumber
            // 
            this.IDnumber.AutoSize = true;
            this.IDnumber.Location = new System.Drawing.Point(58, 128);
            this.IDnumber.Name = "IDnumber";
            this.IDnumber.Size = new System.Drawing.Size(65, 12);
            this.IDnumber.TabIndex = 5;
            this.IDnumber.Text = "身份证号：";
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(129, 125);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(120, 21);
            this.IdInput.TabIndex = 6;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(60, 165);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(65, 12);
            this.Tel.TabIndex = 7;
            this.Tel.Text = "电话号码：";
            // 
            // TelInput
            // 
            this.TelInput.Location = new System.Drawing.Point(129, 162);
            this.TelInput.Name = "TelInput";
            this.TelInput.Size = new System.Drawing.Size(120, 21);
            this.TelInput.TabIndex = 8;
            // 
            // NumberOfOrder
            // 
            this.NumberOfOrder.AutoSize = true;
            this.NumberOfOrder.Location = new System.Drawing.Point(58, 205);
            this.NumberOfOrder.Name = "NumberOfOrder";
            this.NumberOfOrder.Size = new System.Drawing.Size(65, 12);
            this.NumberOfOrder.TabIndex = 9;
            this.NumberOfOrder.Text = "预约数量：";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 20F);
            this.title.Location = new System.Drawing.Point(104, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 27);
            this.title.TabIndex = 10;
            this.title.Text = "口罩预约";
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(129, 203);
            this.OrderNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(120, 21);
            this.OrderNumber.TabIndex = 11;
            this.OrderNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(118, 258);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "预约提交";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // TestNum
            // 
            this.TestNum.AutoSize = true;
            this.TestNum.Location = new System.Drawing.Point(11, 67);
            this.TestNum.Name = "TestNum";
            this.TestNum.Size = new System.Drawing.Size(89, 12);
            this.TestNum.TabIndex = 2;
            this.TestNum.Text = "设置测试总量：";
            // 
            // TestNumberInput
            // 
            this.TestNumberInput.Location = new System.Drawing.Point(106, 65);
            this.TestNumberInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TestNumberInput.Name = "TestNumberInput";
            this.TestNumberInput.Size = new System.Drawing.Size(88, 21);
            this.TestNumberInput.TabIndex = 3;
            this.TestNumberInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 459);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestNumberInput)).EndInit();
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
    }
}

