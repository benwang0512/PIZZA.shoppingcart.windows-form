namespace 期末最終版
{
    partial class member
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
            this.checkBox顯示密碼 = new System.Windows.Forms.CheckBox();
            this.btn登入按鈕 = new System.Windows.Forms.Button();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.text密碼登入 = new System.Windows.Forms.TextBox();
            this.text手機號碼登入 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel會員 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkBox顯示密碼
            // 
            this.checkBox顯示密碼.AutoSize = true;
            this.checkBox顯示密碼.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox顯示密碼.Location = new System.Drawing.Point(535, 192);
            this.checkBox顯示密碼.Name = "checkBox顯示密碼";
            this.checkBox顯示密碼.Size = new System.Drawing.Size(108, 23);
            this.checkBox顯示密碼.TabIndex = 31;
            this.checkBox顯示密碼.Text = "顯示密碼";
            this.checkBox顯示密碼.UseVisualStyleBackColor = true;
            this.checkBox顯示密碼.CheckedChanged += new System.EventHandler(this.checkBox顯示密碼_CheckedChanged);
            // 
            // btn登入按鈕
            // 
            this.btn登入按鈕.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入按鈕.Location = new System.Drawing.Point(363, 268);
            this.btn登入按鈕.Name = "btn登入按鈕";
            this.btn登入按鈕.Size = new System.Drawing.Size(120, 30);
            this.btn登入按鈕.TabIndex = 30;
            this.btn登入按鈕.Text = "登入";
            this.btn登入按鈕.UseVisualStyleBackColor = true;
            this.btn登入按鈕.Click += new System.EventHandler(this.btn登入按鈕_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(607, 374);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(130, 43);
            this.btn註冊.TabIndex = 29;
            this.btn註冊.Text = "先去註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // text密碼登入
            // 
            this.text密碼登入.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text密碼登入.Location = new System.Drawing.Point(348, 188);
            this.text密碼登入.Name = "text密碼登入";
            this.text密碼登入.PasswordChar = '★';
            this.text密碼登入.Size = new System.Drawing.Size(162, 27);
            this.text密碼登入.TabIndex = 27;
            // 
            // text手機號碼登入
            // 
            this.text手機號碼登入.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text手機號碼登入.Location = new System.Drawing.Point(347, 141);
            this.text手機號碼登入.MaxLength = 10;
            this.text手機號碼登入.Name = "text手機號碼登入";
            this.text手機號碼登入.Size = new System.Drawing.Size(162, 27);
            this.text手機號碼登入.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(239, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "密碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(239, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "手機號碼";
            // 
            // panel會員
            // 
            this.panel會員.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel會員.Location = new System.Drawing.Point(0, 0);
            this.panel會員.Name = "panel會員";
            this.panel會員.Size = new System.Drawing.Size(916, 500);
            this.panel會員.TabIndex = 32;
            this.panel會員.Paint += new System.Windows.Forms.PaintEventHandler(this.panel會員_Paint);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(916, 500);
            this.Controls.Add(this.checkBox顯示密碼);
            this.Controls.Add(this.btn登入按鈕);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.text密碼登入);
            this.Controls.Add(this.text手機號碼登入);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel會員);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "member";
            this.Text = "member";
            this.Load += new System.EventHandler(this.member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox顯示密碼;
        private System.Windows.Forms.Button btn登入按鈕;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.TextBox text密碼登入;
        private System.Windows.Forms.TextBox text手機號碼登入;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel會員;
    }
}