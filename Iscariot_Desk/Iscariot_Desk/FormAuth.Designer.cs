namespace Iscariot_Desk
{
    partial class FormAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.lbl_auth = new System.Windows.Forms.Label();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.gb_log_pass = new System.Windows.Forms.GroupBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.gr_user = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_log_pass.SuspendLayout();
            this.gr_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_auth
            // 
            this.btn_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_auth.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_auth.Location = new System.Drawing.Point(52, 202);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(100, 23);
            this.btn_auth.TabIndex = 1;
            this.btn_auth.Text = "Войти";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // lbl_auth
            // 
            this.lbl_auth.AutoSize = true;
            this.lbl_auth.Location = new System.Drawing.Point(70, 156);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(65, 13);
            this.lbl_auth.TabIndex = 2;
            this.lbl_auth.Text = "Тип польз.:";
            // 
            // cb_user
            // 
            this.cb_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_user.Items.AddRange(new object[] {
            "Студент",
            "Гость",
            "Редактор"});
            this.cb_user.Location = new System.Drawing.Point(30, 172);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(147, 21);
            this.cb_user.TabIndex = 3;
            this.cb_user.TabStop = false;
            this.cb_user.SelectedIndexChanged += new System.EventHandler(this.cb_user_SelectedIndexChanged);
            // 
            // gb_log_pass
            // 
            this.gb_log_pass.Controls.Add(this.lbl_pass);
            this.gb_log_pass.Controls.Add(this.lbl_log);
            this.gb_log_pass.Controls.Add(this.tb_pass);
            this.gb_log_pass.Controls.Add(this.tb_log);
            this.gb_log_pass.Location = new System.Drawing.Point(12, 280);
            this.gb_log_pass.Name = "gb_log_pass";
            this.gb_log_pass.Size = new System.Drawing.Size(200, 124);
            this.gb_log_pass.TabIndex = 4;
            this.gb_log_pass.TabStop = false;
            this.gb_log_pass.Text = "Вход:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(27, 73);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(48, 13);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Пароль:";
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Location = new System.Drawing.Point(27, 21);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(41, 13);
            this.lbl_log.TabIndex = 2;
            this.lbl_log.Text = "Логин:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(30, 89);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(147, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            this.tb_pass.Enter += new System.EventHandler(this.tb_pass_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(30, 37);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(147, 20);
            this.tb_log.TabIndex = 0;
            this.tb_log.TextChanged += new System.EventHandler(this.tb_log_TextChanged);
            this.tb_log.Enter += new System.EventHandler(this.tb_log_Enter);
            this.tb_log.Leave += new System.EventHandler(this.tb_log_Leave);
            // 
            // gr_user
            // 
            this.gr_user.Controls.Add(this.pictureBox1);
            this.gr_user.Controls.Add(this.btn_auth);
            this.gr_user.Controls.Add(this.cb_user);
            this.gr_user.Controls.Add(this.lbl_auth);
            this.gr_user.Location = new System.Drawing.Point(12, 12);
            this.gr_user.Name = "gr_user";
            this.gr_user.Size = new System.Drawing.Size(200, 262);
            this.gr_user.TabIndex = 5;
            this.gr_user.TabStop = false;
            this.gr_user.Text = "Авторизация:";
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(229, 281);
            this.Controls.Add(this.gr_user);
            this.Controls.Add(this.gb_log_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuth";
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuth_FormClosed);
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_log_pass.ResumeLayout(false);
            this.gb_log_pass.PerformLayout();
            this.gr_user.ResumeLayout(false);
            this.gr_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Label lbl_auth;
        private System.Windows.Forms.GroupBox gb_log_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.GroupBox gr_user;
        private System.Windows.Forms.ComboBox cb_user;
    }
}

