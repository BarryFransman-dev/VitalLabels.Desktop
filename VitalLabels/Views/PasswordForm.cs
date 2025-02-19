using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalLabels.Desktop.Views
{
    public class PasswordInputForm : Form
    {
        public TextBox passwordTextBox;
        private Button submitButton;

        public PasswordInputForm()
        {
            // Initialize the form and controls
            this.Text = "Password Input";
            this.Size = new System.Drawing.Size(300, 150);

            // Create and configure the password text box
            passwordTextBox = new TextBox();
            passwordTextBox.UseSystemPasswordChar = true; // Mask the characters
            passwordTextBox.Location = new System.Drawing.Point(50, 30);
            passwordTextBox.Width = 200;

            // Create and configure the submit button
            submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new System.Drawing.Point(100, 70);
            submitButton.Click += SubmitButton_Click;

            // Add the controls to the form
            this.Controls.Add(passwordTextBox);
            this.Controls.Add(submitButton);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            this.Close();
            //MessageBox.Show("Password entered: " + password);
        }
    }
}