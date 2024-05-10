namespace WindowsFormsApp1
{
    partial class FormSon
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
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lvw_shoppingcart = new System.Windows.Forms.ListView();
            this.txt_bvgname = new System.Windows.Forms.TextBox();
            this.txt_bvgprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_damgi = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(89, 77);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(483, 28);
            this.txt_ip.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(626, 61);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(124, 63);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "접속";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lvw_shoppingcart
            // 
            this.lvw_shoppingcart.HideSelection = false;
            this.lvw_shoppingcart.Location = new System.Drawing.Point(89, 215);
            this.lvw_shoppingcart.Name = "lvw_shoppingcart";
            this.lvw_shoppingcart.Size = new System.Drawing.Size(665, 274);
            this.lvw_shoppingcart.TabIndex = 6;
            this.lvw_shoppingcart.UseCompatibleStateImageBehavior = false;
            this.lvw_shoppingcart.View = System.Windows.Forms.View.Details;
            // 
            // txt_bvgname
            // 
            this.txt_bvgname.Location = new System.Drawing.Point(89, 181);
            this.txt_bvgname.Name = "txt_bvgname";
            this.txt_bvgname.Size = new System.Drawing.Size(184, 28);
            this.txt_bvgname.TabIndex = 7;
            // 
            // txt_bvgprice
            // 
            this.txt_bvgprice.Location = new System.Drawing.Point(316, 181);
            this.txt_bvgprice.Name = "txt_bvgprice";
            this.txt_bvgprice.Size = new System.Drawing.Size(202, 28);
            this.txt_bvgprice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "가격";
            // 
            // btn_damgi
            // 
            this.btn_damgi.Location = new System.Drawing.Point(534, 168);
            this.btn_damgi.Name = "btn_damgi";
            this.btn_damgi.Size = new System.Drawing.Size(95, 40);
            this.btn_damgi.TabIndex = 11;
            this.btn_damgi.Text = "담기";
            this.btn_damgi.UseVisualStyleBackColor = true;
            this.btn_damgi.Click += new System.EventHandler(this.btn_damgi_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(635, 168);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(115, 40);
            this.btn_order.TabIndex = 12;
            this.btn_order.Text = "주문";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // FormSon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_damgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bvgprice);
            this.Controls.Add(this.txt_bvgname);
            this.Controls.Add(this.lvw_shoppingcart);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_ip);
            this.Name = "FormSon";
            this.Text = "FormSon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSon_FormClosed);
            this.Load += new System.EventHandler(this.FormSon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListView lvw_shoppingcart;
        private System.Windows.Forms.TextBox txt_bvgname;
        private System.Windows.Forms.TextBox txt_bvgprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_damgi;
        private System.Windows.Forms.Button btn_order;
    }
}