namespace _301297059_Sharma__Lab_2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.TextBox();
            this.Publish = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // Notification
            // 
            this.Notification.Location = new System.Drawing.Point(285, 102);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(189, 20);
            this.Notification.TabIndex = 1;
            // 
            // Publish
            // 
            this.Publish.Location = new System.Drawing.Point(68, 205);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(103, 27);
            this.Publish.TabIndex = 2;
            this.Publish.Text = "Publish";
            this.Publish.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(296, 205);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(146, 27);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Publish);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.TextBox Notification;
    }
}