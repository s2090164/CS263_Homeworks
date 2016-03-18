namespace nAnB_002
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnReNew = new System.Windows.Forms.Button();
            this.lblWarrning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(22, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(536, 45);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "這是一個幾A幾B的遊戲，遊戲開始時，電腦會出一個隨機的數字，\r\n在下方的欄位中輸入您的答案後按確定，透過幾A幾B的結果來猜出電腦出的數字\r\n(A：數字有出現且位置" +
    "正確，B：數字有正確但位置不對) ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(116, 107);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(179, 25);
            this.txtAnswer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "您的答案：";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(314, 108);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "確定";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnReNew
            // 
            this.btnReNew.Location = new System.Drawing.Point(405, 108);
            this.btnReNew.Name = "btnReNew";
            this.btnReNew.Size = new System.Drawing.Size(144, 23);
            this.btnReNew.TabIndex = 4;
            this.btnReNew.Text = "重新出題";
            this.btnReNew.UseVisualStyleBackColor = true;
            this.btnReNew.Click += new System.EventHandler(this.btnReNew_Click);
            // 
            // lblWarrning
            // 
            this.lblWarrning.AutoSize = true;
            this.lblWarrning.ForeColor = System.Drawing.Color.Red;
            this.lblWarrning.Location = new System.Drawing.Point(25, 75);
            this.lblWarrning.Name = "lblWarrning";
            this.lblWarrning.Size = new System.Drawing.Size(41, 15);
            this.lblWarrning.TabIndex = 5;
            this.lblWarrning.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 148);
            this.Controls.Add(this.lblWarrning);
            this.Controls.Add(this.btnReNew);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnReNew;
        private System.Windows.Forms.Label lblWarrning;
    }
}

