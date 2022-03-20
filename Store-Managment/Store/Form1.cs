namespace Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            l2PasswordIncorrent.Visible = false;
            this.tbPassword.PasswordChar = '*';
            Console.WriteLine(tbPassword);
            btnlogin.Cursor = Cursors.Hand;
            this.BackgroundImage = Image.FromFile("C:\\Users\\Naveed Ahmed\\Downloads\\shop.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l2PasswordIncorrent.Visible = true;
            l2PasswordIncorrent.Text = "Incorrent Password";
            l2PasswordIncorrent.BorderStyle = BorderStyle.Fixed3D;
            l2PasswordIncorrent.BackColor = Color.Red;
            if ((tbUsername.Text=="Admin" || tbUsername.Text == "admin")&& tbPassword.Text=="1234") 
            {
                this.Hide();
                Loading loading = new Loading();
                loading.ShowDialog();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}