using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThreadingPresentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            //Creating User Depending on Input
            User newUser = new User(fnameInput.Text, lnameInput.Text, emailInput.Text);

            try
            {
                newUser.ValidateName();
                newUser.ValidateLName();
                newUser.ValidateEmail();
                logScreen.Text += $"{fnameInput.Text} Started Registration....\n";
                Task regTask = new Task(newUser.Register);
                regTask.Start();
                await regTask;
                logScreen.Text += $"{fnameInput.Text} Registration Finished, Download Ready....";
                downloadButton.Enabled = true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void userFileButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                logScreen.Text += $"user{i} Started Registration....\n";
                User myUser = new User($"user{i}", $"last{i}", $"user{i}@gmail.com");

                myUser.Register();
                /*
                try
                {
                    new Thread(myUser.Register).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                */
                
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Content uploadedContent = new Content(10);
            Thread[] threads = new Thread[15];

            

            for (int i = 0; i < 15; i++)
            {

                try
                {
                    Thread t = new Thread(new ThreadStart(uploadedContent.Downloader));
                    t.Name = i.ToString();
                    threads[i] = t;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }

            for (int i = 0; i < 15; i++)
            {
                logScreen.Text += $"\nThread {threads[i].Name} Active : {threads[i].IsAlive}";
                threads[i].Start();
                logScreen.Text += $"\nThread {threads[i].Name} Active : {threads[i].IsAlive}";
            }

            logScreen.Text += $"\nCurrent Piority : {Thread.CurrentThread.Priority}";
            logScreen.Text += $"\nThread {Thread.CurrentThread.Name} Ending";

        }
    }
}
