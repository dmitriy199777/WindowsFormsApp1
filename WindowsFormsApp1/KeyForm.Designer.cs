namespace WindowsFormsApp1
{
    partial class KeyForm
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
            this.btnKey = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(24, 111);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(127, 23);
            this.btnKey.TabIndex = 0;
            this.btnKey.Text = "Сменить пароль";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(21, 26);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(130, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Введите ключ к паролю:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(24, 65);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(127, 20);
            this.txtKey.TabIndex = 2;
            // 
            // KeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 180);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnKey);
            this.Name = "KeyForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
    }
}