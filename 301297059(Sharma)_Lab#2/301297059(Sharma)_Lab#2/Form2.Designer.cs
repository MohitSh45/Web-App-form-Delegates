namespace _301297059_Sharma__Lab_2
{
    partial class Form2
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
            this.email = new System.Windows.Forms.CheckBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.SMS = new System.Windows.Forms.CheckBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Subscribe = new System.Windows.Forms.Button();
            this.Unsubscribe = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(84, 98);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(150, 17);
            this.email.TabIndex = 0;
            this.email.Text = "Notification Sent By E-mail";
            this.email.UseVisualStyleBackColor = true;
            this.email.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(330, 95);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(230, 20);
            this.Mail.TabIndex = 1;
            // 
            // SMS
            // 
            this.SMS.AutoSize = true;
            this.SMS.Location = new System.Drawing.Point(84, 158);
            this.SMS.Name = "SMS";
            this.SMS.Size = new System.Drawing.Size(145, 17);
            this.SMS.TabIndex = 2;
            this.SMS.Text = "Notification Sent By SMS";
            this.SMS.UseVisualStyleBackColor = true;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(330, 155);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(230, 20);
            this.Phone.TabIndex = 3;
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(98, 285);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(98, 36);
            this.Subscribe.TabIndex = 4;
            this.Subscribe.Text = "Subscribe";
            this.Subscribe.UseVisualStyleBackColor = true;
            this.Subscribe.Click += new System.EventHandler(this.Subscribe_Click);
            // 
            // Unsubscribe
            // 
            this.Unsubscribe.Location = new System.Drawing.Point(291, 285);
            this.Unsubscribe.Name = "Unsubscribe";
            this.Unsubscribe.Size = new System.Drawing.Size(109, 36);
            this.Unsubscribe.TabIndex = 5;
            this.Unsubscribe.Text = "Unsubscribe";
            this.Unsubscribe.UseVisualStyleBackColor = true;
            this.Unsubscribe.Click += new System.EventHandler(this.Unsubscribe_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(485, 285);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 36);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Unsubscribe);
            this.Controls.Add(this.Subscribe);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.SMS);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.email);
            this.Name = "Form2";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox email;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.CheckBox SMS;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button Subscribe;
        private System.Windows.Forms.Button Unsubscribe;
        private System.Windows.Forms.Button Cancel;
    }
}