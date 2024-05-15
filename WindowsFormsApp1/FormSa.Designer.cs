namespace WindowsFormsApp1
{
    partial class FormSa
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_server_state
            // 
            this.txt_server_state.Location = new System.Drawing.Point(0, 0);
            this.txt_server_state.Multiline = true;
            this.txt_server_state.Name = "txt_server_state";
            this.txt_server_state.Size = new System.Drawing.Size(800, 367);
            this.txt_server_state.TabIndex = 0;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(32, 408);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(310, 28);
            this.txt_message.TabIndex = 1;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(370, 413);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMessage.TabIndex = 2;
            this.btn_SendMessage.Text = "button1";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            // 
            // FormSa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_server_state);
            this.Name = "FormSa";
            this.Text = "FormSa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSa_FormClosed);
            this.Load += new System.EventHandler(this.FormSa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server_state;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_SendMessage;
    }
}