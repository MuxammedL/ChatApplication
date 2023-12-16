using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayCircularImage();
        }
        string loginCon = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=ChatApplication;Integrated Security=True";
        private void DisplayCircularImage()
        {


            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            GraphicsPath path2 = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            path2.AddEllipse(0, 0,choosePhoto.Width,choosePhoto.Height);
            // Apply the circular region to the PictureBox
            pictureBox1.Region = new Region(path);
            choosePhoto.Region = new Region(path2);
            invalidText.Hide();
            // Set the image to the PictureBox and adjust its size mode
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // or other modes as needed
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel3.BackColor = Color.White; 
            panel4.BackColor = Color.Transparent;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.White;

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            loginBtn.PerformClick();

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                errorProvider1.SetError(choosePhoto, "Photo is required!");
                return;
            }
            else
            {
                
                if (string.IsNullOrEmpty(firstName.Text.Trim()))
                {
                    errorProvider1.SetError(firstName, "First Name is required!");
                    return;
                }
                else if (firstName.Text.Trim().Length < 3)
                {
                    errorProvider1.SetError(firstName, "First Name is short!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(firstName, string.Empty);
                }

                if (string.IsNullOrEmpty(lastName.Text.Trim()))
                {
                    errorProvider1.SetError(lastName, "Last Name is required!");
                    return;
                }
                else if (lastName.Text.Trim().Length < 3)
                {
                    errorProvider1.SetError(lastName, "Last Name is short!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(lastName, string.Empty);
                }

               

                // Regular expression pattern for email validation
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Check if the email matches the pattern
                bool isValidEmail = Regex.IsMatch(email.Text.Trim(), pattern);

                if (string.IsNullOrEmpty(email.Text.Trim()))
                {
                    errorProvider1.SetError(email, "Email is required!");
                    return;
                }
                else if (!isValidEmail)
                {
                    errorProvider1.SetError(email, "Email is invalid!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(email, string.Empty);
                }

                if (string.IsNullOrEmpty(password.Text.Trim()))
                {
                    errorProvider1.SetError(password, "Password is required!");
                    return;
                }
                else if (password.Text.Trim().Length < 8)
                {
                    errorProvider1.SetError(password, "Password is short!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(password, string.Empty);
                }

                if (string.IsNullOrEmpty(confirmPassword.Text.Trim()))
                {
                    errorProvider1.SetError(confirmPassword, "Password Confirmation is required!");
                    return;
                }
                else
                {
                    errorProvider1.SetError(confirmPassword, string.Empty);
                }

                if(confirmPassword.Text != password.Text) 
                {
                    MessageBox.Show("Password is not equal");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(loginCon);
                    string q = "insert into Login(firstName,lastName,email,password,confirmPassword,image)values(@firstName,@lastName,@email,@password,@confirmPassword,@image)";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    MemoryStream me = new MemoryStream();
                    pictureBox1.Image.Save(me, pictureBox1.Image.RawFormat);
                    cmd.Parameters.AddWithValue("firstName", firstName.Text);
                    cmd.Parameters.AddWithValue("lastName", lastName.Text);
                    cmd.Parameters.AddWithValue("email", email.Text);
                    cmd.Parameters.AddWithValue("password", password.Text);
                    cmd.Parameters.AddWithValue("confirmPassword", confirmPassword.Text);
                    cmd.Parameters.AddWithValue("image", me.ToArray());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registration succesfully.......");
                    firstName.Clear();
                    lastName.Clear();
                    email.Clear();
                    password.Clear();
                    confirmPassword.Clear();
                    pictureBox1.Image = null;
                }
            }
        }

        private void xMark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*Jpg; *.png; *Gif|*.Jpg; *.png; *Gif ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image= Image.FromFile(openFileDialog1.FileName);
                choosePhoto.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailLoginInput.Text.Trim()))
            {
                errorProvider1.SetError(emailLoginInput, "Email is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(emailLoginInput, string.Empty);
            }

            if (string.IsNullOrEmpty(passwordLoginInput.Text.Trim()))
            {
                errorProvider1.SetError(passwordLoginInput, "Password is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(passwordLoginInput, string.Empty);
            }
            SqlConnection con = new SqlConnection(loginCon);
            con.Open();
            string q = "select * from Login WHERE email = '"+ emailLoginInput.Text + "'AND password = '" + passwordLoginInput.Text + "'";
            SqlCommand cmd = new SqlCommand(q,con);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.emailname = emailLoginInput.Text;
                form2.Show();
            }else
            {
                invalidText.Show();
            }
            con.Close();


        }
    }
}
