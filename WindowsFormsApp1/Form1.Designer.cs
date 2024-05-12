namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSon = new System.Windows.Forms.Button();
            this.btnSa = new System.Windows.Forms.Button();
            this.btn_DBtest = new System.Windows.Forms.Button();
            this.btn_SonUITest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(60, 65);
            this.btnSon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(166, 159);
            this.btnSon.TabIndex = 0;
            this.btnSon.Text = "손님용";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnSa
            // 
            this.btnSa.Location = new System.Drawing.Point(327, 65);
            this.btnSa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(166, 159);
            this.btnSa.TabIndex = 1;
            this.btnSa.Text = "사장용";
            this.btnSa.UseVisualStyleBackColor = true;
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click);
            // 
            // btn_DBtest
            // 
            this.btn_DBtest.Location = new System.Drawing.Point(35, 252);
            this.btn_DBtest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DBtest.Name = "btn_DBtest";
            this.btn_DBtest.Size = new System.Drawing.Size(85, 33);
            this.btn_DBtest.TabIndex = 2;
            this.btn_DBtest.Text = "DBtest";
            this.btn_DBtest.UseVisualStyleBackColor = true;
            this.btn_DBtest.Click += new System.EventHandler(this.btn_DBtest_Click);
            // 
            // btn_SonUITest
            // 
            this.btn_SonUITest.Location = new System.Drawing.Point(425, 252);
            this.btn_SonUITest.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SonUITest.Name = "btn_SonUITest";
            this.btn_SonUITest.Size = new System.Drawing.Size(85, 33);
            this.btn_SonUITest.TabIndex = 3;
            this.btn_SonUITest.Text = "SonUITest";
            this.btn_SonUITest.UseVisualStyleBackColor = true;
            this.btn_SonUITest.Click += new System.EventHandler(this.btn_SonUITest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.btn_SonUITest);
            this.Controls.Add(this.btn_DBtest);
            this.Controls.Add(this.btnSa);
            this.Controls.Add(this.btnSon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnSa;
        private System.Windows.Forms.Button btn_DBtest;
        private System.Windows.Forms.Button btn_SonUITest;
    }
}

