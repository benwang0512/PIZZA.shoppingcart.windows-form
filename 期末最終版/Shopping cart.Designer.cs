namespace 期末最終版
{
    partial class Shopping_cart
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
            this.components = new System.ComponentModel.Container();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn移除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.listBox訂購單資訊 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text訂購人姓名 = new System.Windows.Forms.TextBox();
            this.text訂購人手機 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text外送地址 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio外送 = new System.Windows.Forms.RadioButton();
            this.radio自取 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp取餐日期 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox時間 = new System.Windows.Forms.ComboBox();
            this.btn訂單確認送出 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.ForeColor = System.Drawing.Color.Orange;
            this.lbl訂單總價.Location = new System.Drawing.Point(341, 435);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(232, 29);
            this.lbl訂單總價.TabIndex = 5;
            this.lbl訂單總價.Text = "訂單總價xxxx元";
            // 
            // btn移除所有品項
            // 
            this.btn移除所有品項.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btn移除所有品項.FlatAppearance.BorderSize = 3;
            this.btn移除所有品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所有品項.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所有品項.ForeColor = System.Drawing.Color.Orange;
            this.btn移除所有品項.Location = new System.Drawing.Point(414, 485);
            this.btn移除所有品項.Name = "btn移除所有品項";
            this.btn移除所有品項.Size = new System.Drawing.Size(159, 35);
            this.btn移除所有品項.TabIndex = 9;
            this.btn移除所有品項.Text = "移除所有品項";
            this.btn移除所有品項.UseVisualStyleBackColor = false;
            this.btn移除所有品項.Click += new System.EventHandler(this.btn移除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btn移除所選品項.FlatAppearance.BorderSize = 3;
            this.btn移除所選品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所選品項.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.ForeColor = System.Drawing.Color.Orange;
            this.btn移除所選品項.Location = new System.Drawing.Point(226, 485);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(159, 35);
            this.btn移除所選品項.TabIndex = 8;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // listBox訂購單資訊
            // 
            this.listBox訂購單資訊.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.listBox訂購單資訊.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購單資訊.ForeColor = System.Drawing.Color.Orange;
            this.listBox訂購單資訊.FormattingEnabled = true;
            this.listBox訂購單資訊.ItemHeight = 21;
            this.listBox訂購單資訊.Location = new System.Drawing.Point(25, 31);
            this.listBox訂購單資訊.Name = "listBox訂購單資訊";
            this.listBox訂購單資訊.Size = new System.Drawing.Size(548, 382);
            this.listBox訂購單資訊.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // text訂購人姓名
            // 
            this.text訂購人姓名.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text訂購人姓名.Location = new System.Drawing.Point(727, 97);
            this.text訂購人姓名.Name = "text訂購人姓名";
            this.text訂購人姓名.Size = new System.Drawing.Size(162, 29);
            this.text訂購人姓名.TabIndex = 29;
            // 
            // text訂購人手機
            // 
            this.text訂購人手機.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text訂購人手機.Location = new System.Drawing.Point(727, 148);
            this.text訂購人手機.MaxLength = 10;
            this.text訂購人手機.Name = "text訂購人手機";
            this.text訂購人手機.Size = new System.Drawing.Size(162, 29);
            this.text訂購人手機.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "訂購人姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "訂購人手機:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "外送地址:";
            // 
            // text外送地址
            // 
            this.text外送地址.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text外送地址.Location = new System.Drawing.Point(727, 199);
            this.text外送地址.Multiline = true;
            this.text外送地址.Name = "text外送地址";
            this.text外送地址.Size = new System.Drawing.Size(162, 129);
            this.text外送地址.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.radio外送);
            this.groupBox1.Controls.Add(this.radio自取);
            this.groupBox1.Location = new System.Drawing.Point(743, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 57);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // radio外送
            // 
            this.radio外送.AutoSize = true;
            this.radio外送.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio外送.Location = new System.Drawing.Point(9, 19);
            this.radio外送.Name = "radio外送";
            this.radio外送.Size = new System.Drawing.Size(64, 25);
            this.radio外送.TabIndex = 1;
            this.radio外送.TabStop = true;
            this.radio外送.Text = "外送";
            this.radio外送.UseVisualStyleBackColor = true;
            this.radio外送.CheckedChanged += new System.EventHandler(this.radio外送_CheckedChanged);
            // 
            // radio自取
            // 
            this.radio自取.AutoSize = true;
            this.radio自取.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio自取.Location = new System.Drawing.Point(82, 19);
            this.radio自取.Name = "radio自取";
            this.radio自取.Size = new System.Drawing.Size(64, 25);
            this.radio自取.TabIndex = 0;
            this.radio自取.Text = "自取";
            this.radio自取.UseVisualStyleBackColor = true;
            this.radio自取.CheckedChanged += new System.EventHandler(this.radio自取_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "外送 or 自取:";
            // 
            // dtp取餐日期
            // 
            this.dtp取餐日期.CalendarFont = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp取餐日期.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp取餐日期.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtp取餐日期.Enabled = false;
            this.dtp取餐日期.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp取餐日期.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp取餐日期.Location = new System.Drawing.Point(603, 370);
            this.dtp取餐日期.Name = "dtp取餐日期";
            this.dtp取餐日期.Size = new System.Drawing.Size(143, 33);
            this.dtp取餐日期.TabIndex = 37;
            this.dtp取餐日期.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "預計取餐時間:";
            // 
            // comboBox時間
            // 
            this.comboBox時間.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox時間.FormattingEnabled = true;
            this.comboBox時間.Location = new System.Drawing.Point(762, 377);
            this.comboBox時間.Name = "comboBox時間";
            this.comboBox時間.Size = new System.Drawing.Size(85, 27);
            this.comboBox時間.TabIndex = 39;
            // 
            // btn訂單確認送出
            // 
            this.btn訂單確認送出.AccessibleName = "btn訂單確認送出";
            this.btn訂單確認送出.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btn訂單確認送出.FlatAppearance.BorderSize = 3;
            this.btn訂單確認送出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn訂單確認送出.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單確認送出.ForeColor = System.Drawing.Color.Orange;
            this.btn訂單確認送出.Location = new System.Drawing.Point(685, 479);
            this.btn訂單確認送出.Name = "btn訂單確認送出";
            this.btn訂單確認送出.Size = new System.Drawing.Size(204, 41);
            this.btn訂單確認送出.TabIndex = 40;
            this.btn訂單確認送出.Text = "確認後送出訂單";
            this.btn訂單確認送出.UseVisualStyleBackColor = false;
            this.btn訂單確認送出.Click += new System.EventHandler(this.btn訂單確認送出_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(542, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "外送+39元 訂單總價滿1000元免運";
            // 
            // Shopping_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 539);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn訂單確認送出);
            this.Controls.Add(this.comboBox時間);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp取餐日期);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text外送地址);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text訂購人姓名);
            this.Controls.Add(this.text訂購人手機);
            this.Controls.Add(this.listBox訂購單資訊);
            this.Controls.Add(this.btn移除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shopping_cart";
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.Shopping_cart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn移除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.ListBox listBox訂購單資訊;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox text訂購人姓名;
        private System.Windows.Forms.TextBox text訂購人手機;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text外送地址;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio外送;
        private System.Windows.Forms.RadioButton radio自取;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp取餐日期;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox時間;
        private System.Windows.Forms.Button btn訂單確認送出;
        private System.Windows.Forms.Label label8;
    }
}