namespace MaskAppointment
{
    partial class QueryMask
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
            this.luckyNum = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyNum
            // 
            this.luckyNum.AutoSize = true;
            this.luckyNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.luckyNum.Location = new System.Drawing.Point(33, 143);
            this.luckyNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.luckyNum.Name = "luckyNum";
            this.luckyNum.Size = new System.Drawing.Size(119, 15);
            this.luckyNum.TabIndex = 5;
            this.luckyNum.Text = "查询中签编号：";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(153, 140);
            this.numInput.Margin = new System.Windows.Forms.Padding(4);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(201, 25);
            this.numInput.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(153, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "确认查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.luckyNum);
            this.Name = "Form2";
            this.Text = "中签查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNum;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button button1;
    }
}