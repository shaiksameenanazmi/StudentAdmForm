namespace StudentAdmForm
{
    partial class InfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'Name'
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'Age'
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'Gender'
            this.DateOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'DOB'
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'PhNumber'
            this.EmailAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'EAdress'
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Renamed from 'Adress'
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.AgeColumn,
            this.GenderColumn,
            this.DateOfBirthColumn,
            this.PhoneNumberColumn,
            this.EmailAddressColumn,
            this.AddressColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "Age";
            this.AgeColumn.Name = "AgeColumn";
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            // 
            // DateOfBirthColumn
            // 
            this.DateOfBirthColumn.HeaderText = "Date of Birth";
            this.DateOfBirthColumn.Name = "DateOfBirthColumn";
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "Phone Number";
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            // 
            // EmailAddressColumn
            // 
            this.EmailAddressColumn.HeaderText = "Email Address";
            this.EmailAddressColumn.Name = "EmailAddressColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName; // Renamed from 'Name'
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn; // Renamed from 'Age'
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn; // Renamed from 'Gender'
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirthColumn; // Renamed from 'DOB'
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn; // Renamed from 'PhNumber'
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressColumn; // Renamed from 'EAdress'
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn; // Renamed from 'Adress'
    }
}
