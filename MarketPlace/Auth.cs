using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;


namespace MarketPlace
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        async private void loginBtn_Click(object sender, EventArgs e)
        {
            string content = "{\"email\": \"" + emailtextBox.Text + "\",\"password\":\"" + passwordtextBox.Text + "\"}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "http://localhost:3000/api/users/auth", 
                    new StringContent(content, Encoding.UTF8, "application/json"));
                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);

            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
