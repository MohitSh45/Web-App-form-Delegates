using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301297059_Sharma__Lab_2
{
    public delegate void NotificationSender(string message);
    public partial class Form1 : Form
    {
        private List<string> subscribedEmails = new List<string>();
        private List<string> subscribedMobiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            PublishNotification.Enabled = false;
        }

        private void ManageSubsrcription_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PublishNotification_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
            string message = f3.Notification.Text;
            //// Implement notification sending logic using delegates
             
            NotificationSender emailSender = SendViaEmail;
            NotificationSender mobileSender = SendViaMobile;
            emailSender.Invoke(message);
            mobileSender.Invoke(message);
        }
        public void Subscribe(string email, string mobile)
        {
            // Implement subscription logic
            if (!string.IsNullOrEmpty(email) && IsValidEmail(email) && !subscribedEmails.Contains(email))
            {
                subscribedEmails.Add(email);
            }
            

            if (!string.IsNullOrEmpty(mobile) && IsValidMobile(mobile) && !subscribedMobiles.Contains(mobile))
            {
                subscribedMobiles.Add(mobile);
            }
            

            // Enable Publish Notification button if there are subscribers
            if(subscribedEmails.Count > 0 || subscribedMobiles.Count > 0)
            {
                PublishNotification.Enabled = true;
            }
            else
            {
                PublishNotification.Enabled = false;
            }

        }
        public void Unsubscribe(string email, string mobile)
        {
            // Implement unsubscription logic
            if (!string.IsNullOrEmpty(email) && subscribedEmails.Contains(email))
                subscribedEmails.Remove(email);

            if (!string.IsNullOrEmpty(mobile) && subscribedMobiles.Contains(mobile))
                subscribedMobiles.Remove(mobile);

            // Disable Publish Notification button if there are no subscribers
            PublishNotification.Enabled = subscribedEmails.Count > 0 || subscribedMobiles.Count > 0;

        }

        // Validation methods for email and mobile number formats
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        }

        private bool IsValidMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^\+\d{11}$");
        }
        public void SendViaEmail(string message)
        {
            // Implement email notification sending logic
            foreach (var email in subscribedEmails)
            {
                // Send email to each subscribed email address
                Console.WriteLine($"Sending email notification to {email}: {message}");
            }
        }
        public void SendViaMobile(string message)
        {
            // Implement SMS notification sending logic
            foreach (var mobile in subscribedMobiles)
            {
                // Send SMS to each subscribed mobile number
                Console.WriteLine($"Sending SMS notification to {mobile}: {message}");
            }
        }
    }
}
