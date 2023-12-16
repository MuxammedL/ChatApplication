using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form2 : Form
    {
        public string emailname {  get; set; }
        string loginCon = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=ChatApplication;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            DisplayCircularImage();
        }
        private void DisplayCircularImage()
        {


            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);

            // Apply the circular region to the PictureBox
            pictureBox1.Region = new Region(path);
            // Set the image to the PictureBox and adjust its size mode
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // or other modes as needed
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            byte[] getImage = new byte[0];
            SqlConnection conn = new SqlConnection(loginCon);
            conn.Open();
            string q = "select * from Login WHERE email = '" + emailname + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            if(dataReader.HasRows)
            {
                label2.Text = dataReader[0].ToString();
                byte[] images = (byte[])dataReader["image"];
                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream stream = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            conn.Close();
        }
    }
}
