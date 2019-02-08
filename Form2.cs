using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//webForm
namespace subway
{
    public partial class Form2 : Form
    {
        String webUrl = "";
        public Form2()
        {
            InitializeComponent();
        }


        public Form2(String webUrl)
        {
            InitializeComponent();
            this.webUrl = webUrl;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(this.webUrl);
        }
    }
}
