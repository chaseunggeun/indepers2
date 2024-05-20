namespace WindowsFormsApp1
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.Radio_hot = new System.Windows.Forms.RadioButton();
            this.Radio_ice = new System.Windows.Forms.RadioButton();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.Radio_decaffein = new System.Windows.Forms.RadioButton();
            this.Radio_caffein = new System.Windows.Forms.RadioButton();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.Radio_IceMore = new System.Windows.Forms.RadioButton();
            this.Radio_iceLess = new System.Windows.Forms.RadioButton();
            this.Radio_iceNormal = new System.Windows.Forms.RadioButton();
            this.btn_addShoppingCart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_selectedBeverage = new Bunifu.UI.WinForms.BunifuLabel();
            this.Radio_notInStore = new System.Windows.Forms.RadioButton();
            this.Radio_inStore = new System.Windows.Forms.RadioButton();
            this.bunifuGroupBox4 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuGroupBox1.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            this.bunifuGroupBox3.SuspendLayout();
            this.bunifuGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.Radio_hot);
            this.bunifuGroupBox1.Controls.Add(this.Radio_ice);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(116, 79);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(570, 145);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // Radio_hot
            // 
            this.Radio_hot.AutoSize = true;
            this.Radio_hot.Location = new System.Drawing.Point(399, 58);
            this.Radio_hot.Name = "Radio_hot";
            this.Radio_hot.Size = new System.Drawing.Size(72, 29);
            this.Radio_hot.TabIndex = 3;
            this.Radio_hot.TabStop = true;
            this.Radio_hot.Text = "HOT";
            this.Radio_hot.UseVisualStyleBackColor = true;
            // 
            // Radio_ice
            // 
            this.Radio_ice.AutoSize = true;
            this.Radio_ice.Checked = true;
            this.Radio_ice.Location = new System.Drawing.Point(100, 58);
            this.Radio_ice.Name = "Radio_ice";
            this.Radio_ice.Size = new System.Drawing.Size(62, 29);
            this.Radio_ice.TabIndex = 2;
            this.Radio_ice.TabStop = true;
            this.Radio_ice.Text = "ICE";
            this.Radio_ice.UseVisualStyleBackColor = true;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.Radio_decaffein);
            this.bunifuGroupBox2.Controls.Add(this.Radio_caffein);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(116, 242);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(570, 145);
            this.bunifuGroupBox2.TabIndex = 1;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "카페인";
            // 
            // Radio_decaffein
            // 
            this.Radio_decaffein.AutoSize = true;
            this.Radio_decaffein.Location = new System.Drawing.Point(380, 58);
            this.Radio_decaffein.Name = "Radio_decaffein";
            this.Radio_decaffein.Size = new System.Drawing.Size(109, 29);
            this.Radio_decaffein.TabIndex = 5;
            this.Radio_decaffein.TabStop = true;
            this.Radio_decaffein.Text = "디카페인";
            this.Radio_decaffein.UseVisualStyleBackColor = true;
            // 
            // Radio_caffein
            // 
            this.Radio_caffein.AutoSize = true;
            this.Radio_caffein.Checked = true;
            this.Radio_caffein.Location = new System.Drawing.Point(81, 58);
            this.Radio_caffein.Name = "Radio_caffein";
            this.Radio_caffein.Size = new System.Drawing.Size(91, 29);
            this.Radio_caffein.TabIndex = 4;
            this.Radio_caffein.TabStop = true;
            this.Radio_caffein.Text = "카페인";
            this.Radio_caffein.UseVisualStyleBackColor = true;
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox3.BorderRadius = 1;
            this.bunifuGroupBox3.BorderThickness = 1;
            this.bunifuGroupBox3.Controls.Add(this.Radio_IceMore);
            this.bunifuGroupBox3.Controls.Add(this.Radio_iceLess);
            this.bunifuGroupBox3.Controls.Add(this.Radio_iceNormal);
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(116, 411);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(570, 145);
            this.bunifuGroupBox3.TabIndex = 1;
            this.bunifuGroupBox3.TabStop = false;
            this.bunifuGroupBox3.Text = "얼음 양";
            // 
            // Radio_IceMore
            // 
            this.Radio_IceMore.AutoSize = true;
            this.Radio_IceMore.Location = new System.Drawing.Point(380, 58);
            this.Radio_IceMore.Name = "Radio_IceMore";
            this.Radio_IceMore.Size = new System.Drawing.Size(109, 29);
            this.Radio_IceMore.TabIndex = 9;
            this.Radio_IceMore.TabStop = true;
            this.Radio_IceMore.Text = "얼음많이";
            this.Radio_IceMore.UseVisualStyleBackColor = true;
            // 
            // Radio_iceLess
            // 
            this.Radio_iceLess.AutoSize = true;
            this.Radio_iceLess.Location = new System.Drawing.Point(81, 58);
            this.Radio_iceLess.Name = "Radio_iceLess";
            this.Radio_iceLess.Size = new System.Drawing.Size(109, 29);
            this.Radio_iceLess.TabIndex = 7;
            this.Radio_iceLess.TabStop = true;
            this.Radio_iceLess.Text = "얼음적게";
            this.Radio_iceLess.UseVisualStyleBackColor = true;
            // 
            // Radio_iceNormal
            // 
            this.Radio_iceNormal.AutoSize = true;
            this.Radio_iceNormal.Checked = true;
            this.Radio_iceNormal.Location = new System.Drawing.Point(228, 58);
            this.Radio_iceNormal.Name = "Radio_iceNormal";
            this.Radio_iceNormal.Size = new System.Drawing.Size(109, 29);
            this.Radio_iceNormal.TabIndex = 8;
            this.Radio_iceNormal.TabStop = true;
            this.Radio_iceNormal.Text = "얼음보통";
            this.Radio_iceNormal.UseVisualStyleBackColor = true;
            // 
            // btn_addShoppingCart
            // 
            this.btn_addShoppingCart.AllowAnimations = true;
            this.btn_addShoppingCart.AllowMouseEffects = true;
            this.btn_addShoppingCart.AllowToggling = false;
            this.btn_addShoppingCart.AnimationSpeed = 200;
            this.btn_addShoppingCart.AutoGenerateColors = false;
            this.btn_addShoppingCart.AutoRoundBorders = false;
            this.btn_addShoppingCart.AutoSizeLeftIcon = true;
            this.btn_addShoppingCart.AutoSizeRightIcon = true;
            this.btn_addShoppingCart.BackColor = System.Drawing.Color.Transparent;
            this.btn_addShoppingCart.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_addShoppingCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addShoppingCart.BackgroundImage")));
            this.btn_addShoppingCart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addShoppingCart.ButtonText = "담기";
            this.btn_addShoppingCart.ButtonTextMarginLeft = 0;
            this.btn_addShoppingCart.ColorContrastOnClick = 45;
            this.btn_addShoppingCart.ColorContrastOnHover = 45;
            this.btn_addShoppingCart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_addShoppingCart.CustomizableEdges = borderEdges3;
            this.btn_addShoppingCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addShoppingCart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addShoppingCart.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addShoppingCart.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addShoppingCart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_addShoppingCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addShoppingCart.ForeColor = System.Drawing.Color.White;
            this.btn_addShoppingCart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addShoppingCart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addShoppingCart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_addShoppingCart.IconMarginLeft = 11;
            this.btn_addShoppingCart.IconPadding = 10;
            this.btn_addShoppingCart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addShoppingCart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addShoppingCart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_addShoppingCart.IconSize = 25;
            this.btn_addShoppingCart.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_addShoppingCart.IdleBorderRadius = 1;
            this.btn_addShoppingCart.IdleBorderThickness = 1;
            this.btn_addShoppingCart.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_addShoppingCart.IdleIconLeftImage = null;
            this.btn_addShoppingCart.IdleIconRightImage = null;
            this.btn_addShoppingCart.IndicateFocus = false;
            this.btn_addShoppingCart.Location = new System.Drawing.Point(288, 758);
            this.btn_addShoppingCart.Name = "btn_addShoppingCart";
            this.btn_addShoppingCart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addShoppingCart.OnDisabledState.BorderRadius = 1;
            this.btn_addShoppingCart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addShoppingCart.OnDisabledState.BorderThickness = 1;
            this.btn_addShoppingCart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addShoppingCart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addShoppingCart.OnDisabledState.IconLeftImage = null;
            this.btn_addShoppingCart.OnDisabledState.IconRightImage = null;
            this.btn_addShoppingCart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addShoppingCart.onHoverState.BorderRadius = 1;
            this.btn_addShoppingCart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addShoppingCart.onHoverState.BorderThickness = 1;
            this.btn_addShoppingCart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addShoppingCart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addShoppingCart.onHoverState.IconLeftImage = null;
            this.btn_addShoppingCart.onHoverState.IconRightImage = null;
            this.btn_addShoppingCart.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_addShoppingCart.OnIdleState.BorderRadius = 1;
            this.btn_addShoppingCart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addShoppingCart.OnIdleState.BorderThickness = 1;
            this.btn_addShoppingCart.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_addShoppingCart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_addShoppingCart.OnIdleState.IconLeftImage = null;
            this.btn_addShoppingCart.OnIdleState.IconRightImage = null;
            this.btn_addShoppingCart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_addShoppingCart.OnPressedState.BorderRadius = 1;
            this.btn_addShoppingCart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addShoppingCart.OnPressedState.BorderThickness = 1;
            this.btn_addShoppingCart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_addShoppingCart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_addShoppingCart.OnPressedState.IconLeftImage = null;
            this.btn_addShoppingCart.OnPressedState.IconRightImage = null;
            this.btn_addShoppingCart.Size = new System.Drawing.Size(209, 59);
            this.btn_addShoppingCart.TabIndex = 2;
            this.btn_addShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addShoppingCart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addShoppingCart.TextMarginLeft = 0;
            this.btn_addShoppingCart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_addShoppingCart.UseDefaultRadiusAndThickness = true;
            this.btn_addShoppingCart.Click += new System.EventHandler(this.btn_addShoppingCart_Click);
            // 
            // lbl_selectedBeverage
            // 
            this.lbl_selectedBeverage.AllowParentOverrides = false;
            this.lbl_selectedBeverage.AutoEllipsis = false;
            this.lbl_selectedBeverage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_selectedBeverage.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_selectedBeverage.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_selectedBeverage.Location = new System.Drawing.Point(305, 25);
            this.lbl_selectedBeverage.Name = "lbl_selectedBeverage";
            this.lbl_selectedBeverage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_selectedBeverage.Size = new System.Drawing.Size(204, 48);
            this.lbl_selectedBeverage.TabIndex = 3;
            this.lbl_selectedBeverage.Text = "bunifuLabel1";
            this.lbl_selectedBeverage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_selectedBeverage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Radio_notInStore
            // 
            this.Radio_notInStore.AutoSize = true;
            this.Radio_notInStore.Location = new System.Drawing.Point(380, 58);
            this.Radio_notInStore.Name = "Radio_notInStore";
            this.Radio_notInStore.Size = new System.Drawing.Size(73, 29);
            this.Radio_notInStore.TabIndex = 5;
            this.Radio_notInStore.TabStop = true;
            this.Radio_notInStore.Text = "포장";
            this.Radio_notInStore.UseVisualStyleBackColor = true;
            // 
            // Radio_inStore
            // 
            this.Radio_inStore.AutoSize = true;
            this.Radio_inStore.Checked = true;
            this.Radio_inStore.Location = new System.Drawing.Point(81, 58);
            this.Radio_inStore.Name = "Radio_inStore";
            this.Radio_inStore.Size = new System.Drawing.Size(73, 29);
            this.Radio_inStore.TabIndex = 4;
            this.Radio_inStore.TabStop = true;
            this.Radio_inStore.Text = "매장";
            this.Radio_inStore.UseVisualStyleBackColor = true;
            // 
            // bunifuGroupBox4
            // 
            this.bunifuGroupBox4.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox4.BorderRadius = 1;
            this.bunifuGroupBox4.BorderThickness = 1;
            this.bunifuGroupBox4.Controls.Add(this.Radio_notInStore);
            this.bunifuGroupBox4.Controls.Add(this.Radio_inStore);
            this.bunifuGroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox4.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox4.LabelIndent = 10;
            this.bunifuGroupBox4.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox4.Location = new System.Drawing.Point(116, 587);
            this.bunifuGroupBox4.Name = "bunifuGroupBox4";
            this.bunifuGroupBox4.Size = new System.Drawing.Size(570, 145);
            this.bunifuGroupBox4.TabIndex = 6;
            this.bunifuGroupBox4.TabStop = false;
            this.bunifuGroupBox4.Text = "매장 포장 여부";
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 866);
            this.Controls.Add(this.bunifuGroupBox4);
            this.Controls.Add(this.lbl_selectedBeverage);
            this.Controls.Add(this.btn_addShoppingCart);
            this.Controls.Add(this.bunifuGroupBox3);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.bunifuGroupBox3.ResumeLayout(false);
            this.bunifuGroupBox3.PerformLayout();
            this.bunifuGroupBox4.ResumeLayout(false);
            this.bunifuGroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_addShoppingCart;
        private System.Windows.Forms.RadioButton Radio_hot;
        private System.Windows.Forms.RadioButton Radio_ice;
        private System.Windows.Forms.RadioButton Radio_decaffein;
        private System.Windows.Forms.RadioButton Radio_caffein;
        private System.Windows.Forms.RadioButton Radio_IceMore;
        private System.Windows.Forms.RadioButton Radio_iceLess;
        private System.Windows.Forms.RadioButton Radio_iceNormal;
        private Bunifu.UI.WinForms.BunifuLabel lbl_selectedBeverage;
        private System.Windows.Forms.RadioButton Radio_notInStore;
        private System.Windows.Forms.RadioButton Radio_inStore;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox4;
    }
}