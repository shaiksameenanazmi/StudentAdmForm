using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentAdmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                string name = textBox1.Text;
                int age = Convert.ToInt32(textBox2.Text);
                DateTime dateOfBirth = dateTimePicker1.Value;
                long phoneNumber = Convert.ToInt64(textBox3.Text);
                string emailAddress = textBox4.Text;
                string address = textBox5.Text;

                // Create a new Student object
                Student newStudent = new Student
                {
                    Name = name,
                    Age = age,
                    DateOfBirth = dateOfBirth,
                    PhoneNumber = phoneNumber,
                    EmailAddress = emailAddress,
                    Address = address
                };

                // Instantiate your StudentDbContext
                using (var context = new StudentDbContext())
                {
                    // Add the new student to the DbSet
                    context.Students.Add(newStudent);

                    // Save changes to the database
                    context.SaveChanges();
                }

                MessageBox.Show("Student information saved successfully.");

                // Logging user action
                Logger.Log(LogLevel.Info, "User submitted form.");
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in button1_Click: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();

                // Logging user action
                Logger.Log(LogLevel.Info, "User cleared form fields.");
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in button2_Click: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

                // Logging user action
                Logger.Log(LogLevel.Info, "User closed the application.");
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in button3_Click: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set filter options for image files
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.FilterIndex = 1;

                // Set title
                openFileDialog.Title = "Select an Image File";

                // Show the dialog and get result
                DialogResult result = openFileDialog.ShowDialog();

                // If the user selected a file
                if (result == DialogResult.OK)
                {
                    // Get the file name
                    string fileName = openFileDialog.FileName;

                    // Logging user action
                    Logger.Log(LogLevel.Info, $"User selected image: {fileName}");

                    // You can now use the file path (fileName) for further processing
                    MessageBox.Show($"Image selected: {fileName}", "Image Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // For example, you can display the image or perform other actions with the file
                    // pictureBox1.Image = new Bitmap(fileName);
                }
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in button4_Click: {ex.Message}");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateAge();
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !IsValidName(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Please enter a valid age between 0 and 100.");
                return false;
            }


            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || !IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text) || !IsValidEmail(textBox4.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter a valid address.");
                return false;
            }

            return true;
        }

        private void ValidateName()
        {
            string namePattern = @"^[A-Z][a-zA-Z\s'-]*$";
            try
            {
                if (Regex.IsMatch(textBox1.Text, namePattern))
                {
                    textBox1.BackColor = Color.LightGreen;
                    textBox1.ForeColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.LightCoral;
                    textBox1.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in textBox1_TextChanged: {ex.Message}");
            }
        }
       

        private bool IsValidName(string name)
        {
            string namePattern = @"^[A-Z][a-zA-Z\s'-]*$";
            return Regex.IsMatch(name, namePattern);
        }

        private void ValidatePhoneNumber()
        {
            string phonePattern = @"^\+91\d{10}$"; // Example: E.164 format, allows optional + at the start

            try
            {
                if (Regex.IsMatch(textBox3.Text, phonePattern))
                {
                    // Valid phone number
                    textBox3.BackColor = Color.LightGreen;
                    textBox3.ForeColor = Color.Green;
                }
                else
                {
                    // Invalid phone number
                    textBox3.BackColor = Color.LightCoral;
                    textBox3.ForeColor = Color.Red;
                }

                // Logging user action
                Logger.Log(LogLevel.Info, "User entered phone number.");
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in textBox3_TextChanged: {ex.Message}");
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^\+91\d{10}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private void ValidateEmail()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            try
            {
                if (Regex.IsMatch(textBox4.Text, emailPattern))
                {
                    // Valid email
                    textBox4.BackColor = Color.LightGreen;
                }
                else
                {
                    // Invalid email
                    textBox4.BackColor = Color.LightCoral;
                }

                // Logging user action
                Logger.Log(LogLevel.Info, "User entered email address.");
            }
            catch (Exception ex)
            {
                // Log exception as error
                Logger.Log(LogLevel.Error, $"Exception in textBox4_TextChanged: {ex.Message}");
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void ValidateAge()
        {
            string ageRegex = @"^(?:[1-9][0-9]?|1[01][0-9]|120)$";
            try
            {
                if (Regex.IsMatch(textBox2.Text, ageRegex))
                {
                    textBox2.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox2.BackColor = Color.LightCoral;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Exception in textBox2_TextChanged: {ex.Message}");
            }
        }
    }
}
