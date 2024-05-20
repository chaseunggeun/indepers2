namespace WindowsFormsApp1
{
    partial class SaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.lvwOrderCom = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "INDEPERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAFE";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Menu;
            this.btnInventory.Location = new System.Drawing.Point(32, 202);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(173, 72);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "재고 관리";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.SystemColors.Menu;
            this.btnIncome.Location = new System.Drawing.Point(32, 318);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(173, 72);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "매출";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // lvwOrder
            // 
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(216, 76);
            this.lvwOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(598, 685);
            this.lvwOrder.TabIndex = 4;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            // 
            // lvwOrderCom
            // 
            this.lvwOrderCom.HideSelection = false;
            this.lvwOrderCom.Location = new System.Drawing.Point(838, 76);
            this.lvwOrderCom.Margin = new System.Windows.Forms.Padding(2);
            this.lvwOrderCom.Name = "lvwOrderCom";
            this.lvwOrderCom.Size = new System.Drawing.Size(598, 685);
            this.lvwOrderCom.TabIndex = 5;
            this.lvwOrderCom.UseCompatibleStateImageBehavior = false;
            this.lvwOrderCom.View = System.Windows.Forms.View.Details;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.Location = new System.Drawing.Point(216, 788);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 74);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "주문 취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnComplete.Location = new System.Drawing.Point(629, 788);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(184, 74);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "주문 완료";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 914);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 914);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvwOrderCom);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaUI";
            this.Text = "SaUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaUI_FormClosed);
            this.Load += new System.EventHandler(this.SaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.ListView lvwOrder;
        private System.Windows.Forms.ListView lvwOrderCom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}