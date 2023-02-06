namespace 期末最終版
{
    partial class Form產品
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form產品));
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl登入狀態 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(23, 10);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(510, 521);
            this.listView商品展示.TabIndex = 2;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn圖片模式.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.Image = ((System.Drawing.Image)(resources.GetObject("btn圖片模式.Image")));
            this.btn圖片模式.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn圖片模式.Location = new System.Drawing.Point(566, 360);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(185, 49);
            this.btn圖片模式.TabIndex = 3;
            this.btn圖片模式.Tag = "";
            this.btn圖片模式.Text = "  圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = false;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn列表模式.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.Image = ((System.Drawing.Image)(resources.GetObject("btn列表模式.Image")));
            this.btn列表模式.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn列表模式.Location = new System.Drawing.Point(566, 415);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(185, 49);
            this.btn列表模式.TabIndex = 4;
            this.btn列表模式.Tag = "";
            this.btn列表模式.Text = "  列表模式";
            this.btn列表模式.UseVisualStyleBackColor = false;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn加入購物車.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Image = ((System.Drawing.Image)(resources.GetObject("btn加入購物車.Image")));
            this.btn加入購物車.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn加入購物車.Location = new System.Drawing.Point(566, 470);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(185, 49);
            this.btn加入購物車.TabIndex = 5;
            this.btn加入購物車.Tag = "";
            this.btn加入購物車.Text = "   加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // lbl單價
            // 
            this.lbl單價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl單價.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(649, 316);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(85, 26);
            this.lbl單價.TabIndex = 9;
            this.lbl單價.Text = "xxxx元";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(562, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "單價:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl登入狀態
            // 
            this.lbl登入狀態.AutoSize = true;
            this.lbl登入狀態.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl登入狀態.Location = new System.Drawing.Point(539, 9);
            this.lbl登入狀態.Name = "lbl登入狀態";
            this.lbl登入狀態.Size = new System.Drawing.Size(143, 25);
            this.lbl登入狀態.TabIndex = 11;
            this.lbl登入狀態.Text = "登入狀態:訪客";
            // 
            // Form產品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 545);
            this.Controls.Add(this.lbl登入狀態);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form產品";
            this.Text = "Form產品";
            this.Load += new System.EventHandler(this.Form產品_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl登入狀態;
    }
}