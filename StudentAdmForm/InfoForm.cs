using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentAdmForm
{
    public partial class InfoForm : Form
    {
        private StudentDbContext context; // Replace StudentDbContext with your actual DbContext class

        public InfoForm()
        {
            InitializeComponent();
            context = new StudentDbContext(); // Initialize your DbContext

            // Automatically fetch and display information when the form loads
            Load += InfoForm_Load;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // Call btnShowInfo_Click to fetch and display information
            btnShowInfo_Click(sender, e);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all students from the database
                var students = context.Students.ToList();

                // Clear existing rows in DataGridView
                dataGridView1.Rows.Clear();

                // Populate DataGridView with student data
                foreach (var student in students)
                {
                    dataGridView1.Rows.Add(
                        student.Name,
                        student.Age,
                        student.Gender,
                        student.DateOfBirth.ToShortDateString(),
                        student.PhoneNumber,
                        student.EmailAddress,
                        student.Address
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
    }
}
