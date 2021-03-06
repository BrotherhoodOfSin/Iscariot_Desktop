﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Iscariot_Desk
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        //Смена пользователя в поле
        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cb_user.SelectedItem == "Редактор")
            {
                btn_auth.Enabled = false;

                gb_log_pass.Visible = true;

                this.Height = 463;
            }
            else
            {
                btn_auth.Enabled = true;

                gb_log_pass.Visible = false;

                this.Height = 320;
            }
        }

        //Загрузка формы
        private void FormAuth_Load(object sender, EventArgs e)
        {
            tb_log.Text = "Логин";
            tb_pass.Text = "Пароль";

            tb_log.ForeColor = Color.Gray;
            tb_pass.ForeColor = Color.Gray;

            gb_log_pass.Visible = false;

            btn_auth.Enabled = true;

            cb_user.SelectedIndex = 0;

            this.Height = 320;
        }

        //Смена текста Логина
        private void tb_log_TextChanged(object sender, EventArgs e)
        {
            if (tb_log.Text == "" | tb_log.Text == "Логин")
            {
                tb_log.ForeColor = Color.Gray;
            }
            else
            {
                tb_log.ForeColor = Color.Black;
            }
            auth_enabled();
        }

        //Смена текста Пароля
        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            if (tb_pass.Text == "" | tb_pass.Text == "Пароль")
            {
                tb_pass.ForeColor = Color.Gray;
            }
            else
            {
                tb_pass.ForeColor = Color.Black;
            }
            auth_enabled();
        }

        //Вход в поле Логин
        private void tb_log_Enter(object sender, EventArgs e)
        {
            if (tb_log.Text == "Логин")
            {
                tb_log.Text = null;
            }
            tb_log.ForeColor = Color.Black;
        }

        //Вход в поле Пароль
        private void tb_pass_Enter(object sender, EventArgs e)
        {
            if (tb_pass.Text == "Пароль")
            {
                tb_pass.Text = null;
            }
            tb_pass.ForeColor = Color.Black;
        }

        //Проверка заполнения Логина и Пароля
        private void auth_enabled()
        {
            if (tb_log.Text != "" && tb_pass.Text != "" & tb_log.Text != "Логин" && tb_pass.Text != "Пароль")
            {
                btn_auth.Enabled = true;
            }
            else
            {
                btn_auth.Enabled = false;
            }
        }

        //Выход из Логина
        private void tb_log_Leave(object sender, EventArgs e)
        {
            if (tb_log.Text == "" | tb_log.Text == "Логин")
            {
                tb_log.Text = "Логин";
                tb_log.ForeColor = Color.Gray;
            }
        }

        //Выход из Пароля
        private void tb_pass_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text == "" | tb_pass.Text == "Пароль")
            {
                tb_pass.Text = "Пароль";
                tb_pass.ForeColor = Color.Gray;
            }
        }

        //Триггер кнопки перехода к Рассписанию
        private async void btn_auth_Click(object sender, EventArgs e)
        {
            btn_auth.Enabled = false;

            FormSchedule form_shed = new FormSchedule();

            if ((string)cb_user.SelectedItem == "Редактор")
            {
                string json_log = tb_log.Text;
                string json_pass = tb_pass.Text;

                string json_async_string = "http://iscariotserver1.azurewebsites.net/api/logpass?login=" + json_log + "&password=" + json_pass;
                string json = "";
                try
                {
                    json = await (await new HttpClient().GetAsync(json_async_string)).Content.ReadAsStringAsync();

                }
                catch 
                {
                    MessageBox.Show("Отсутствует подключение.", "Ошибка подключения");
                    btn_auth.Enabled = true;
                    return;
                }

                JObject jObject = JObject.Parse(json);

                //Проверка на статус
                if (jObject["status"] == null || jObject["status"].ToString() != "ok")
                {
                    MessageBox.Show("Пользователь с таким логином/паролем не найден.", "Ошибка входа");
                    btn_auth.Enabled = true;
                    return;
                }

                form_shed.user_tokken = jObject["token"].ToString();
            }

            btn_auth.Enabled = true;

            this.Visible = false;

            form_shed.user_group = (string)cb_user.SelectedItem;

            form_shed.Visible = true;            
        }

        //Выход из приложения по нажатию "Х"
        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
