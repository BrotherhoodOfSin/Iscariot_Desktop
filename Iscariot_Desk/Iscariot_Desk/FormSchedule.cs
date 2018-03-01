using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Iscariot_Desk
{
    public partial class FormSchedule : Form
    {
        public string user_group;
        public string user_tokken;

        private bool flag_refresh = false;
        private bool flag_saved = true;

        public FormSchedule()
        {
            InitializeComponent();
        }

        //Меню "Польз." -> "Выйти"
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }            

            this.Visible = false;

            FormAuth form_auth = new FormAuth();
            form_auth.Visible = true;
        }

        //Загрузка формы
        private void FormSchedule_Load(object sender, EventArgs e)
        {
            this.Text = "Рассписание СмолГУ | " + user_group;

            flag_saved = true;

            get_from_server("first");

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

            flag_saved = false;            
        }

        //Закрытие формы
        private void FormSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }

            this.Visible = false;

            FormAuth form_auth = new FormAuth();
            form_auth.Visible = true;
        }

        // -------- Смена выбранных пунктов --------

        //Факультет выбран
        private void cb_fak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }

            get_from_server("0");

            if (flag_refresh == false)
            {
                //refresh_dgvs(1, 0, 0, 0);
            }
        }

        //Направление выбрано
        private void cb_spec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }

            get_from_server("1");

            if (flag_refresh == false)
            {
                //refresh_dgvs(0, 1, 0, 0);
            }
        }

        //Профиль выбран
        private void cb_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }

            get_from_server("2");

            if (flag_refresh == false)
            {
                //refresh_dgvs(0, 0, 1, 0);
            }
        }

        //Курс выбран
        private void cb_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_group == "Редактор")
            {
                save_changes();
                flag_saved = true;
            }

            if (flag_refresh == false)
            {
                //refresh_dgvs(0, 0, 0, 1);
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

        //Сохранение изменений
        private void save_changes()
        {
            if (flag_saved == false)
            {
                //Вывод сообщения с вопросом сохранения
                string message = "Сохранить изменения?";
                string caption = "Рассписание";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Если да - произвести сохранение
                    MessageBox.Show("Сохранено.");
                }
            }
        }

        // -------- Загрузка с сервера --------
        private async void get_from_server(string param)
        {
            string json_async_string = "http://iscariotserver.azurewebsites.net/api/schedule?";
            string json = "";
            JArray jArray;
            JObject jObject;

            switch (param)
            {
                case "first":
                    {
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_fak.Items.Clear();
                        cb_fak.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "0":
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_spec.Items.Clear();
                        cb_spec.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "1":
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_sec.Items.Clear();
                        cb_sec.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "2":
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem +"&section=" + cb_sec.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_term.Items.Clear();
                        cb_term.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "load_dgvs":
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem + "&section=" + cb_sec.SelectedItem + "&term=" + cb_term.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jObject = JObject.Parse(json);

                        

                        break;
                    }
            }
                   
        }

        // -------- Кнопки редактора и ф-ии для dgv --------

        //Кнопка "Сохр."
        private void btn_save_Click(object sender, EventArgs e)
        {
            flag_saved = true;
        }

        //Если изменено что-то в dgv_ch
        private void dgv_schedule_ch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            flag_saved = false;
        }

        //Если изменено что-то в z
        private void dgv_schedule_z_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            flag_saved = false;
        }

        //Загрузка dgvs
        private void btn_schload_Click(object sender, EventArgs e)
        {
            get_from_server("load_dgvs");
        }
    }
}
