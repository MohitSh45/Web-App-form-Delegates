namespace _301297059_Sharma__Lab_2
{
    partial class Form1
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
            this.ManageSubsrcription = new System.Windows.Forms.Button();
            this.PublishNotification = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageSubsrcription
            // 
            this.ManageSubsrcription.Location = new System.Drawing.Point(90, 113);
            this.ManageSubsrcription.Name = "ManageSubsrcription";
            this.ManageSubsrcription.Size = new System.Drawing.Size(141, 46);
            this.ManageSubsrcription.TabIndex = 0;
            this.ManageSubsrcription.Text = "Manage Subscription";
            this.ManageSubsrcription.UseVisualStyleBackColor = true;
            this.ManageSubsrcription.Click += new System.EventHandler(this.ManageSubsrcription_Click);
            // 
            // PublishNotification
            // 
            this.PublishNotification.Enabled = false;
            this.PublishNotification.Location = new System.Drawing.Point(316, 113);
            this.PublishNotification.Name = "PublishNotification";
            this.PublishNotification.Size = new System.Drawing.Size(133, 46);
            this.PublishNotification.TabIndex = 1;
            this.PublishNotification.Text = "Publish Notification";
            this.PublishNotification.UseVisualStyleBackColor = true;
            this.PublishNotification.Click += new System.EventHandler(this.PublishNotification_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(569, 113);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 46);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PublishNotification);
            this.Controls.Add(this.ManageSubsrcription);
            this.Name = "Form1";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageSubsrcription;
        private System.Windows.Forms.Button PublishNotification;
        private System.Windows.Forms.Button Exit;
    }
}

