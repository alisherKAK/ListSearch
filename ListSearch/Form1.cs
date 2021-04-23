using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSearch
{
    public partial class Form1 : Form
    {
        List<Card> cards;
        string search = "";
        public Form1()
        {
            InitializeComponent();
            Validate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            MessageBox.Show(cards[index].Text);
        }

        private void Validate()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString($"https://api.hearthstonejson.com/v1/25770/enUS/cards.json");
                cards = JsonConvert.DeserializeObject<List<Card>>(json).Take(100).ToList();
                foreach(var card in cards)
                {
                    listBox1.Items.Add(card);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBox1.Text.ToLower();
            listBox1.Items.Clear();
            foreach (var card in cards.Where(c => c.Name.ToLower().StartsWith(search)).ToList())
            {
                listBox1.Items.Add(card);
            }
        }
    }
}
