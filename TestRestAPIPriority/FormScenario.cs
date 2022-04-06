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
    public partial class FormScenario : Form
    {
        HttpRequest http = null;
        Size size;
        public FormScenario()
        {
            InitializeComponent();
            http = new HttpRequest(Config.Instance.User, Config.Instance.Pwd, Config.Instance.URL);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "";
        }

        private void FormScenario_ResizeBegin(object sender, EventArgs e)
        {
            if (!size.IsEmpty) this.Size = size;
        }

        private void FormScenario_SizeChanged(object sender, EventArgs e)
        {
            if (!size.IsEmpty) this.Size = size;
        }

        private void FormScenario_Shown(object sender, EventArgs e)
        {
            size = this.Size;
        }
        private void btnRunSc1_Click(object sender, EventArgs e)
        {
            ///task/0522385127
            string resp=http.GetRequest("/task/" + txtPhone.Text);
            PriorityTaskResponseModel respobj = JsonConvert.DeserializeObject<PriorityTaskResponseModel>(resp);
            txtResponse.Text = JsonConvert.SerializeObject(respobj, Formatting.Indented);
        }
        private void btnRunSc2_Click(object sender, EventArgs e)
        {
            ///ticket/0522385127/0019
            string resp=http.GetRequest("/ticket/" + txtPhone.Text + "/" + txt4Digits.Text);
            PriorityTaskResponseModel respobj = JsonConvert.DeserializeObject<PriorityTaskResponseModel>(resp);
            txtResponse.Text = JsonConvert.SerializeObject(respobj, Formatting.Indented);
        }
    }
}
