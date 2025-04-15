using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinKalkulatorMihkelPloompuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(currencyselector.SelectedItem.ToString() != "USD" || currencyselector.SelectedItem.ToString() !=
                "GBP" || currencyselector.SelectedItem.ToString() != "EUR" || currencyselector.SelectedItem.ToString()
                != "EEK" || currencyselector.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Error");
                //MessageBox errorbox = new MessageBox("Palun vali valuuta.", "erroe", MessageBoxButtons.OK);
                //errorbox.Show();
            }
            else if (currencyselector.SelectedItem.ToString() == "USD")
            {
                resultlable.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(BitcoinAmountinput.Text)*(float)newbitcoinrate.Data.BTCUSD.VALUE;
                resultlable.Text = $"{result} Bitcoin dollareiss";
            }
        }

        public static BitcoinRates GetRates()
        {
            string url = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR,BTC-GBP&apply_mapping=true&groups=VALUE&api-key=3a76442ea5735f8851dded497370467eeed5f9b296e05e409ddf7a8148d8ec9e";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responsReader = new StreamReader(webStream))
            {
                var data = responsReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
