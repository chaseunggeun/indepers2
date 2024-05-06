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
            this.SuspendLayout();
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(85, 98);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(237, 238);
            this.btnSon.TabIndex = 0;
            this.btnSon.Text = "손님용";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnSa
            // 
            this.btnSa.Location = new System.Drawing.Point(467, 98);
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(237, 238);
            this.btnSa.TabIndex = 1;
            this.btnSa.Text = "사장용";
            this.btnSa.UseVisualStyleBackColor = true;
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSa);
            this.Controls.Add(this.btnSon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnSa;
    }
}

