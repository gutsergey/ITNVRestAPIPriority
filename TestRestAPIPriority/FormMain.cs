using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ITNVRestAPIPriority.Models;

namespace TestRestAPIPriority
{
    public partial class FormMain : Form
    {
        HttpRequest http = null;
        Size size;
        FormScenario frmscenario;
        public FormMain()
        {
            Config.Initialize();
            InitializeComponent();
            http = new HttpRequest(Config.Instance.User, Config.Instance.Pwd, Config.Instance.URL);
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string resp = "";
            if (txtPhone.Text.Trim().Length<=0)
            {
                resp=http.GetRequest("");
                List<PhoneItemFull> respobj0 = JsonConvert.DeserializeObject<List<PhoneItemFull>>(resp);
                txtResponse.Text = JsonConvert.SerializeObject(respobj0, Formatting.Indented);
            }
            else
            {
                resp=http.GetRequest("/PHONEBOOK/" + txtPhone.Text);
                PhoneItemFull respobj = JsonConvert.DeserializeObject<PhoneItemFull>(resp);
                txtResponse.Text = JsonConvert.SerializeObject(respobj, Formatting.Indented);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "";
        }


        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (!size.IsEmpty) this.Size = size;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (!size.IsEmpty) this.Size =size;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            size = this.Size;
        }

        private void btnScenario_Click(object sender, EventArgs e)
        {
            frmscenario = new FormScenario();
            frmscenario.Show();
        }
    }
}
