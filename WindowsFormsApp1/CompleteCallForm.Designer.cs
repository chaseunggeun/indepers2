﻿namespace WindowsFormsApp1
{
    partial class CompleteCallForm
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
            this.txt_server_state = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_server_state
            // 
            this.txt_server_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_server_state.Location = new System.Drawing.Point(0, 0);
            this.txt_server_state.Multiline = true;
            this.txt_server_state.Name = "txt_server_state";
            this.txt_server_state.Size = new System.Drawing.Size(800, 450);
            this.txt_server_state.TabIndex = 1;
            // 
            // CompleteCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_server_state);
            this.Name = "CompleteCall";
            this.Text = "CompleteCall";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompleteCall_FormClosed);
            this.Load += new System.EventHandler(this.CompleteCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server_state;
    }
}