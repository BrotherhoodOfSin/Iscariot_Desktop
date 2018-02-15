using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iscariot_Desk
{
    public partial class FormSchedule : Form
    {
        public string user_group;

        public FormSchedule()
        {
            InitializeComponent();            
        }

        //Меню "Польз." -> "Выйти"
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FormAuth form_auth = new FormAuth();
            form_auth.Visible = true;
        }

        //Загрузка формы
        private void FormSchedule_Load(object sender, EventArgs e)
        {
            this.Text = "Рассписание СмолГУ | " + user_group;
        }
    }
}
