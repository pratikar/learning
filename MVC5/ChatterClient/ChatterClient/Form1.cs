using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunAsync(textBox1.Text, "919824695985", "919924322977").Wait();
        }

        async Task RunAsync(string message, string sender, string receiver)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:6027/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



                var chat = new Chat() { ChatContent = message, SenderId = sender, ReceiverId = receiver };

           
                
                
                HttpResponseMessage response = await client.PostAsJsonAsync("api/chats", chat);
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    Uri mediaItemUrl = response.Headers.Location;
                }
            }
        }
    }
}
