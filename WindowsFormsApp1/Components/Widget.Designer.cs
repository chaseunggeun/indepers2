namespace WindowsFormsApp1.Components
{
    partial class Widget
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblCost = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.imgImage);
            this.bunifuPanel1.Controls.Add(this.lblCost);
            this.bunifuPanel1.Controls.Add(this.lblTitle);
            this.bunifuPanel1.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(285, 156);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // imgImage
            // 
            this.imgImage.AllowFocused = false;
            this.imgImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgImage.AutoSizeHeight = false;
            this.imgImage.BorderRadius = 0;
            this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
            this.imgImage.IsCircle = false;
            this.imgImage.Location = new System.Drawing.Point(182, 15);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(100, 118);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgImage.TabIndex = 3;
            this.imgImage.TabStop = false;
            this.imgImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.imgImage.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AllowParentOverrides = false;
            this.lblCost.AutoEllipsis = false;
            this.lblCost.BackColor = System.Drawing.Color.White;
            this.lblCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblCost.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCost.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCost.Font = new System.Drawing.Font("Cooper Std Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblCost.Location = new System.Drawing.Point(24, 59);
            this.lblCost.Name = "lblCost";
            this.lblCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCost.Size = new System.Drawing.Size(100, 23);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "30,00krw";
            this.lblCost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(23, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(101, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "아이스 아메리카노";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(291, 174);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuLabel lblCost;
        public Bunifu.UI.WinForms.BunifuLabel lblTitle;
        public Bunifu.UI.WinForms.BunifuPictureBox imgImage;
    }
}
