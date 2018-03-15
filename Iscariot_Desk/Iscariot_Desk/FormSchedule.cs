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
        //взял с прошлой формы
        public string user_group;
        public string user_tokken;

        //флаги
        private bool flag_refresh = false;
        private bool flag_saved = true;

        //массивы
        private string[] data_mass = new string[] { };
        private string[] days_mass = new string[] {"Monday_", "Tuesday_", "Wednesday_", "Thursday_", "Friday_", "Saturday_", "Sunday_" };
        private string[] days_server_mass = new string[] {"&monday_", "&tuesday_", "&wednesday_", "&thursday_", "&friday_", "&saturday_", "&sunday_" };

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
            btn_schload.Enabled = false;

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
                        colorized(1);
                    break;
                case "Tuesday":
                    for (int i = 0; i < 4; i++)
                        colorized(2);
                    break;
                case "Wednesday":
                        colorized(3);
                    break;
                case "Thursday":
                        colorized(4);
                    break;
                case "Friday":
                        colorized(5);
                    break;
                case "Saturday":
                        colorized(6);
                    break;
                case "Sunday":
                        colorized(7);
                    break;
            }            
        }

        //Покраска текущего дня
        private void colorized(int day_num)
        {
            for (int i = 0; i < 4; i++)
            {
                dgv_schedule_ch.Rows[i].Cells[day_num].Style.BackColor = ColorTranslator.FromHtml("#0078D7");
                dgv_schedule_z.Rows[i].Cells[day_num].Style.BackColor = ColorTranslator.FromHtml("#0078D7");

                dgv_schedule_ch.FirstDisplayedScrollingColumnIndex = day_num;
                dgv_schedule_z.FirstDisplayedScrollingColumnIndex = day_num;
            }
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
                //РЕФРЕШ
                //refresh_dgvs(1, 0, 0, 0);
            }

            check_bull_cb();
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
                //РЕФРЕШ
                //refresh_dgvs(0, 1, 0, 0);
            }

            check_bull_cb();
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
                //РЕФРЕШ
                //refresh_dgvs(0, 0, 1, 0);
            }

            check_bull_cb();
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
                //РЕФРЕШ
                //refresh_dgvs(0, 0, 0, 1);
            }

            check_bull_cb();
        }

        /*
        //Рефреш гридов в реальном времени
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

        */
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
                    save_to_server();
                    //Если да - произвести сохранение
                }
            }
        }

        // -------- Загрузка с сервера --------
        private async void get_from_server(string param)
        {
            string json_async_string = "http://iscariotserver1.azurewebsites.net/api/schedule?";
            string json = "";
            JArray jArray;
            JObject jObject;

            switch (param)
            {
                case "first": //Берет факультеты
                    {
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_fak.Items.Clear();
                        cb_fak.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "0": //Берет направление
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_spec.Items.Clear();
                        cb_spec.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "1": //Берет профиль
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_sec.Items.Clear();
                        cb_sec.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "2": //Берет курсы
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem +"&section=" + cb_sec.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jArray = JArray.Parse(json);

                        cb_term.Items.Clear();
                        cb_term.Items.AddRange((string[])jArray.ToObject(typeof(string[])));

                        break;
                    }
                case "load_dgvs": //Берет все данные с параметрами выше
                    {
                        json_async_string += "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem + "&section=" + cb_sec.SelectedItem + "&term=" + cb_term.SelectedItem;
                        json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();
                        jObject = JObject.Parse(json);

                        //сама загрузка
                        for (int i = 1; i <= 7; i++)
                        {
                            loader_for_dgvs((string)jObject["schedule"][days_mass[i - 1] + "Ch"], i, dgv_schedule_ch);
                            loader_for_dgvs((string)jObject["schedule"][days_mass[i - 1] + "Z"], i, dgv_schedule_z);
                        }

                        break;
                    }
            }
                   
        }

        //Загрузка данных в dgvs по дням и парам
        private void loader_for_dgvs(string data_str, int day_num, DataGridView dgv_for_loader)
        {
            data_mass = null;
            data_mass = data_str.Split('\t');
            
            for (int i = 0; i<=3; i++)
            {
                dgv_for_loader.Rows[i].Cells[day_num].Value = data_mass[i];
            }
        }

        // -------- Кнопки редактора и ф-ии для dgvs --------

        //Кнопка "Сохр."
        private void btn_save_Click(object sender, EventArgs e)
        {
            flag_saved = true;

            save_to_server();
        }

        // -------------------- Сами dgvs -------------------

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
            if (user_group == "Редактор")
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
                        save_to_server();                                              
                    }
                    else return;
                }
            }

            get_from_server("load_dgvs");
        }

        //Ф-я сохранения данных на сервер
        private async void save_to_server()
        {
            string[] days_to_server_ch = new string[7] { "", "", "", "", "", "", "" };

            string[] days_to_server_z = new string[7] { "", "", "", "", "", "", "" };

            //Обнуление
            for (int i = 1; i < 8; i++)
            {
                days_to_server_ch[i - 1] = "";
                days_to_server_z[i - 1] = "";
            }

            //Пробег dgvs и взятие того, что внутри
            for (int i = 1; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {  
                    days_to_server_ch[i-1] += dgv_schedule_ch.Rows[j].Cells[i].Value.ToString();
                    days_to_server_z[i-1] += dgv_schedule_z.Rows[j].Cells[i].Value.ToString();
                    if (j < 3)
                    {
                        days_to_server_ch[i-1] += "\t";
                        days_to_server_z[i - 1] += "\t";
                    } 
                }
            }

            //Собрать строчку поста
            string post_to_server = "http://iscariotserver1.azurewebsites.net/api/schedule?" +
                "faculty=" + cb_fak.SelectedItem + "&specialty=" + cb_spec.SelectedItem + "&section=" + cb_sec.SelectedItem + "&term=" + cb_term.SelectedItem;

            for (int i = 0; i < 7; i++)
            {
                post_to_server += days_server_mass[i] + "ch=" + days_to_server_ch[i] + days_server_mass[i] + "z=" + days_to_server_z[i];
            }

            post_to_server += "&token=" + user_tokken;

            //Отправка
            var res = await (await new HttpClient().PostAsync(post_to_server, new FormUrlEncodedContent(new KeyValuePair<string, string>[] { }))).Content.ReadAsStringAsync();

            MessageBox.Show("Сохранено.");
        }

        //-------------------------------------------

        //Активация кнопки загрузки
        private void check_bull_cb()
        {
            if ((string)cb_fak.SelectedItem != null & (string)cb_sec.SelectedItem != null & (string)cb_spec.SelectedItem != null & (string)cb_term.SelectedItem != null)
            {
                btn_schload.Enabled = true;
            }
        }
    }
}
