namespace WindowsFormsApp1
{
    partial class LogForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.txtPas = new System.Windows.Forms.TextBox();
            this.lblPas = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPas
            // 
            resources.ApplyResources(this.txtPas, "txtPas");
            this.txtPas.Name = "txtPas";
            // 
            // lblPas
            // 
            resources.ApplyResources(this.lblPas, "lblPas");
            this.lblPas.Name = "lblPas";
            // 
            // btnLog
            // 
            resources.ApplyResources(this.btnLog, "btnLog");
            this.btnLog.Name = "btnLog";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // LogForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.txtPas);
            this.Name = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.Button btnLog;
    }
}

