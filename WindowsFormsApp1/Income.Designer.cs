namespace WindowsFormsApp1
{
    partial class Income
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
            this.lvwIncomeList = new System.Windows.Forms.ListView();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIcomeSum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwIncomeList
            // 
            this.lvwIncomeList.HideSelection = false;
            this.lvwIncomeList.Location = new System.Drawing.Point(28, 13);
            this.lvwIncomeList.Name = "lvwIncomeList";
            this.lvwIncomeList.Size = new System.Drawing.Size(693, 834);
            this.lvwIncomeList.TabIndex = 0;
            this.lvwIncomeList.UseCompatibleStateImageBehavior = false;
            this.lvwIncomeList.View = System.Windows.Forms.View.Details;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(748, 86);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 82;
            this.dgvIncome.RowTemplate.Height = 37;
            this.dgvIncome.Size = new System.Drawing.Size(812, 427);
            this.dgvIncome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "금액 목록";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(748, 667);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "~원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "금액 목록:";
            // 
            // btnIcomeSum
            // 
            this.btnIcomeSum.Location = new System.Drawing.Point(1454, 531);
            this.btnIcomeSum.Name = "btnIcomeSum";
            this.btnIcomeSum.Size = new System.Drawing.Size(106, 65);
            this.btnIcomeSum.TabIndex = 4;
            this.btnIcomeSum.Text = "합계";
            this.btnIcomeSum.UseVisualStyleBackColor = true;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 875);
            this.Controls.Add(this.btnIcomeSum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.lvwIncomeList);
            this.Name = "Income";
            this.Text = "Income";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwIncomeList;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIcomeSum;
    }
}