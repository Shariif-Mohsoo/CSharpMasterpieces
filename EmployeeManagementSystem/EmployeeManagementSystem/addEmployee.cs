using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Provides classes for creating Windows-based applications with UI components like forms, buttons, labels, etc.
//using System.Data; // Contains classes for accessing and managing data from different sources (e.g., DataTable, DataSet).
using System.Data.SqlClient; // Provides classes for SQL Server database operations, such as connections, commands, and queries.
using System.IO; // Enables file input/output operations, like reading, writing, and managing files and directories.



namespace EmployeeManagementSystem
{
    public partial class addEmployee : UserControl
    {
        SqlConnection connect = new
    SqlConnection("Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;");

        public addEmployee()
        {
            InitializeComponent();
            //to display the data from database to your data grid view.
            this.displayEmployeeData();
        }

        public void RefreshData()
        {
            // Check: Are we running on the wrong thread? (Not the UI/main thread)
            if (InvokeRequired)
            {
                // If yes, call this method again but on the correct UI thread
                Invoke((MethodInvoker)RefreshData);
                return; // Stop this call
            }

            // Now we are on the correct UI thread
            // So it's safe to update the screen (UI)
            this.displayEmployeeData(); // Call a method to show employee data on the screen
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }
        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_fullName.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phoneNumber.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null
                //new one adding for salary
                || addEmployee_salary.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // add employee to the db
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmp = "select count(*) from employees where employee_id = @emID and delete_date is null";
                        using (SqlCommand cmd = new SqlCommand(checkEmp, connect))
                        {

                            cmd.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());
                            int count = (int)cmd.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken"
                                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "insert into employees " +
                                    "(employee_id, full_name,gender,contact_number," +
                                    "position,salary,image,insert_date,status)" +
                                    "values(@employeeID,@fullName,@gender,@contactNum" +
                                    ",@position,@salary,@image,@insertDate,@status);"+
                                    " insert into Bonus(employee_id,basic_salary,bonus)" +
                                     " values(@employeeID,@salary,@bonus);"
                                    ;
                                // Construct the full file path where the employee image will be saved
                                // Combines the base directory path with the employee ID (as the filename) and ".jpg" extension
                                // Example output: E:\C#\EmployeeManagementSystem\EmployeeManagementSystem\Directory\EMP123.jpg
                                string path = Path.Combine(@"E:\C#\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                    + addEmployee_id.Text.Trim() + ".jpg");


                                // Extract the directory path from the full image path
                                // This ensures we have just the folder location where the image should be saved
                                string directoryPath = Path.GetDirectoryName(path);

                                // Check if the directory does not exist
                                if (!Directory.Exists(directoryPath))
                                {
                                    // If it doesn't exist, create the directory to ensure the image can be saved there
                                    Directory.CreateDirectory(directoryPath);
                                }

                                if (!string.IsNullOrEmpty(addEmployee_picture.ImageLocation))
                                {
                                    // Copy the selected image from its original location to the specified path
                                    // The third parameter 'true' allows overwriting the file if it already exists at the destination
                                    File.Copy(addEmployee_picture.ImageLocation, path, true);
                                }
                                else
                                {
                                    // Handle missing image location (show message or skip copying)
                                    MessageBox.Show("Please select an image before saving.");
                                    // Stop the method here so that further commands do NOT run
                                    return;  // <-- This is very important!
                                }

                                //File.Copy(addEmployee_picture.ImageLocation, path, true);



                                using (SqlCommand cmdd = new SqlCommand(insertData, connect))
                                {
                                    cmdd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmdd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmdd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmdd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNumber.Text.Trim());
                                    cmdd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    //updating the salary from zero to user's (admin) choice.
                                    cmdd.Parameters.AddWithValue("@salary", Convert.ToInt32(addEmployee_salary.Text.Trim()));
                                    cmdd.Parameters.AddWithValue("@image", path);
                                    cmdd.Parameters.AddWithValue("@insertDate", today);
                                    cmdd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    //for bonus table
                                    cmdd.Parameters.AddWithValue("@bonus", 0);
                                    cmdd.ExecuteNonQuery();

                                    this.displayEmployeeData();

                                    MessageBox.Show("Added Successfully", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.clearFields();

                                  
                                }
                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of OpenFileDialog to allow the user to browse files
                OpenFileDialog dialog = new OpenFileDialog();

                // Set the filter to only allow image files with extensions .jpg, .jpeg, or .png
                //The Filter property sets what kind of files can be selected in the Open File Dialog.
                //"Description|FilterPattern"
                //"Image Files(*.jpg;*.jpeg;*.png)" // Shown to the user in the dialog
                // *.jpg;*.jpeg;*.png"              // Only these file types can be selected
                dialog.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                // Initialize an empty string to store the selected image path
                string imagePath = "";

                // Show the dialog box, and if the user selects a file and clicks OK...
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected file's path in the imagePath variable
                    imagePath = dialog.FileName;

                    // Set the image location of the PictureBox named 'addEmployee_picture'
                    // This displays the selected image in the PictureBox
                    addEmployee_picture.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }


        }

        // Event handler for cell click in DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is a valid data row (not a header or out of range)
            if (e.RowIndex != -1)
            {
                // Get the full row object from the clicked index
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //// Populate each input field with the corresponding cell value from the selected row
                //addEmployee_id.Text = row.Cells[1].Value.ToString();           // Set Employee ID
                //addEmployee_fullName.Text = row.Cells[2].Value.ToString();     // Set Full Name
                //addEmployee_gender.Text = row.Cells[3].Value.ToString();       // Set Gender
                //addEmployee_phoneNumber.Text = row.Cells[4].Value.ToString();  // Set Phone Number
                //addEmployee_position.Text = row.Cells[5].Value.ToString();     // Set Position

                //// Get the image file path from the 7th column (index 6) of the selected row
                //string imagePath = row.Cells[6].Value.ToString();

                //**** REPLACE WITH THIS **///

                // Populate each input field with the corresponding cell value from the selected row
                addEmployee_id.Text = row.Cells[0].Value.ToString();           // Set Employee ID
                addEmployee_fullName.Text = row.Cells[1].Value.ToString();     // Set Full Name
                addEmployee_gender.Text = row.Cells[2].Value.ToString();       // Set Gender
                addEmployee_phoneNumber.Text = row.Cells[3].Value.ToString();  // Set Phone Number
                addEmployee_position.Text = row.Cells[4].Value.ToString();     // Set Position
                addEmployee_salary.Text = row.Cells[6].Value.ToString();       // Set salary

                // Get the image file path from the 7th column (index 6) of the selected row
                string imagePath = row.Cells[5].Value.ToString();

                // Check if the image path is not null (a valid path is present)
                if (imagePath != null)
                {
                    // Load and display the image in the PictureBox using the file path
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }

                //addEmployee_status.Text = row.Cells[8].Value.ToString();       // Set Status
                //** replace with **//
                addEmployee_status.Text = row.Cells[7].Value.ToString();       // Set Status
            }
        }

        public void clearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phoneNumber.Text = "";
            addEmployee_salary.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_fullName.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phoneNumber.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null
                //new one for the salary
                || addEmployee_salary.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " + "Employee ID: "
                    + addEmployee_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    );
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string updateData = "update employees set full_name = @fullName" +
                            ", gender=@gender,contact_number=@contactNum,salary=@salary" +
                            ", position=@position,update_date=@updateDate,status=@status " +
                            "where employee_id = @employeeID; "+
                            "update Bonus set basic_salary=@salary where employee_id=@employeeID";

                        DateTime today = DateTime.Today;
                        using (SqlCommand cmdd = new SqlCommand(updateData, connect))
                        {
                            cmdd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmdd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                            cmdd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                            cmdd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNumber.Text.Trim());
                            //updating the salary from zero to user's (admin) choice.
                            cmdd.Parameters.AddWithValue("@salary", Convert.ToInt32(addEmployee_salary.Text.Trim()));
                            cmdd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                            cmdd.Parameters.AddWithValue("@updateDate", today);
                            cmdd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                            cmdd.ExecuteNonQuery();

                            this.displayEmployeeData();
                            MessageBox.Show("Updated Successfully", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.clearFields();
                            
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled"
                           , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning
                           );
                }

            }
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to DELETE " + "Employee ID: "
                    + addEmployee_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    );
            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    string updateData = "update employees set delete_date = @deleteDate" +
                        " where employee_id = @employeeID";

                    DateTime today = DateTime.Today;
                    using (SqlCommand cmdd = new SqlCommand(updateData, connect))
                    {
                        cmdd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                        cmdd.Parameters.AddWithValue("@deleteDate", today);
                        

                        cmdd.ExecuteNonQuery();

                        this.displayEmployeeData();
                        MessageBox.Show("Deleted Successfully", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.clearFields();

                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
