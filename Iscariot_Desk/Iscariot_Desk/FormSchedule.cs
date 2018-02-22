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

        private bool flag_refresh = false;

        //Для ФМФ
        string[] fmf_specs = new string[] { "Строит.", "ПМИ", "ПИвЛ", "МиИ", "ФиИ" };

        string[] stroit_prof = new string[] { "Пром.", "Гражд." };
        string[] pmi_prof = new string[] { "Мат. и Инф. Мод." };
        string[] pivl_prof = new string[] { "Проф. 1" };
        string[] mii_prof = new string[] { "Проф. 1" };
        string[] fii_prof = new string[] { "Проф. 1" };

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

            cb_fak.SelectedIndex = 0;
            cb_spec.SelectedIndex = 0;
            cb_sec.SelectedIndex = 0;
            cb_term.SelectedIndex = 0;

            if (user_group == "Редактор")
            {
                gb_edit.Visible = true;

                dgv_schedule_ch.ReadOnly = false;
                dgv_schedule_z.ReadOnly = false;

                this.Height = 539;
            }
            else
            {
                gb_edit.Visible = false;

                dgv_schedule_ch.ReadOnly = true;
                dgv_schedule_z.ReadOnly = true;

                this.Height = 468;
            }

            //Добавление кол-ва пар
            dgv_schedule_ch.RowCount = 4;
            dgv_schedule_z.RowCount = 4;

            for (int i = 0; i < 4; i++)
            {
                dgv_schedule_ch.Rows[i].Cells[0].Value = i + 1;
                dgv_schedule_z.Rows[i].Cells[0].Value = i + 1;
            }

            //Подсветка текущего дня и закрепление кол-ва пар
            dgv_schedule_ch.Columns[0].Frozen = true;
            dgv_schedule_z.Columns[0].Frozen = true;
            
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 1;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 1;
                    }
                    break;
                case "Tuesday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 2;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 2;
                    }
                    break;
                case "Wednesday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 3;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 3;
                    }
                    break;
                case "Thursday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 4;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 4;
                    }
                    break;
                case "Friday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 5;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 5;
                    }
                    break;
                case "Saturday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[6].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[6].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 6;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 6;
                    }
                    break;
                case "Sunday":
                    for (int i = 0; i < 4; i++)
                    {
                        dgv_schedule_ch.Rows[i].Cells[7].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                        dgv_schedule_z.Rows[i].Cells[7].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                        dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = 7;
                        dgv_schedule_z.FirstDisplayedScrollingColumnIndex = 7;
                    }
                    break;
            }
        }

        //Закрытие формы
        private void FormSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;

            FormAuth form_auth = new FormAuth();
            form_auth.Visible = true;
        }

        // -------- Смена выбранных пунктов --------

        //Факультет выбран
        private void cb_fak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cb_fak.SelectedItem == "ФМФ")
            {
                cb_spec.Items.Clear();
                cb_spec.Items.AddRange(fmf_specs);
            }

            if (flag_refresh == false)
            {
                refresh_dgvs(1, 0, 0, 0);
            }
        }

        //Направление выбрано
        private void cb_spec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cb_fak.SelectedItem == "ФМФ")
            {
                cb_sec.Items.Clear();

                switch (cb_spec.SelectedIndex)
                {
                    case 0:
                        cb_sec.Items.AddRange(stroit_prof);
                        break;
                    case 1:
                        cb_sec.Items.AddRange(pmi_prof);
                        break;
                    case 2:
                        cb_sec.Items.AddRange(pivl_prof);
                        break;
                    case 3:
                        cb_sec.Items.AddRange(mii_prof);
                        break;
                    case 4:
                        cb_sec.Items.AddRange(fii_prof);
                        break;
                }

                cb_term.Items.Clear();

                if (cb_spec.SelectedIndex == 0 | cb_spec.SelectedIndex == 1 | cb_spec.SelectedIndex == 2)
                {
                    cb_term.Items.AddRange(new string[] { "1", "2", "3", "4" });
                }
                else
                {
                    cb_term.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
                }
            }

            if (flag_refresh == false)
            {
                refresh_dgvs(0, 1, 0, 0);
            }
        }

        //Профиль выбран
        private void cb_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_refresh == false)
            {
                refresh_dgvs(0, 0, 1, 0);
            }
        }

        //Курс выбран
        private void cb_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_refresh == false)
            {
                refresh_dgvs(0, 0, 0, 1);
            }
        }

        //Рефреш гридов
        private void refresh_dgvs(int a, int b, int c, int d)
        {
            flag_refresh = true;

            if (a == 1)
            {
                cb_spec.SelectedIndex = 0;
                cb_sec.SelectedIndex = 0;
                cb_term.SelectedIndex = 0;

                flag_refresh = false;
            }
            if (b == 1)
            {
                cb_sec.SelectedIndex = 0;
                cb_term.SelectedIndex = 0;

                flag_refresh = false;
            }
            if (c == 1)
            {
                cb_term.SelectedIndex = 0;

                flag_refresh = false;
            }
            if (d == 1)
            {
                flag_refresh = false;
            }
        }
        //------------------------------------------
    }
}
