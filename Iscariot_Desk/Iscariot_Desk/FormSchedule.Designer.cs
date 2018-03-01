namespace Iscariot_Desk
{
    partial class FormSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_View = new System.Windows.Forms.GroupBox();
            this.cb_term = new System.Windows.Forms.ComboBox();
            this.lbl_term = new System.Windows.Forms.Label();
            this.cb_sec = new System.Windows.Forms.ComboBox();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.cb_spec = new System.Windows.Forms.ComboBox();
            this.lbl_spec = new System.Windows.Forms.Label();
            this.cb_fak = new System.Windows.Forms.ComboBox();
            this.lbl_fak = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.lbl_ch = new System.Windows.Forms.Label();
            this.dgv_schedule_z = new System.Windows.Forms.DataGridView();
            this.col_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tue_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wed_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fri_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sun_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_schedule_ch = new System.Windows.Forms.DataGridView();
            this.col_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tue_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wed_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fri_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sun_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_edit = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_schload = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gb_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule_ch)).BeginInit();
            this.gb_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользToolStripMenuItem
            // 
            this.пользToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.пользToolStripMenuItem.Name = "пользToolStripMenuItem";
            this.пользToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.пользToolStripMenuItem.Text = "Польз.";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // gb_View
            // 
            this.gb_View.Controls.Add(this.btn_schload);
            this.gb_View.Controls.Add(this.cb_term);
            this.gb_View.Controls.Add(this.lbl_term);
            this.gb_View.Controls.Add(this.cb_sec);
            this.gb_View.Controls.Add(this.lbl_sec);
            this.gb_View.Controls.Add(this.cb_spec);
            this.gb_View.Controls.Add(this.lbl_spec);
            this.gb_View.Controls.Add(this.cb_fak);
            this.gb_View.Controls.Add(this.lbl_fak);
            this.gb_View.Controls.Add(this.lbl_z);
            this.gb_View.Controls.Add(this.lbl_ch);
            this.gb_View.Controls.Add(this.dgv_schedule_z);
            this.gb_View.Controls.Add(this.dgv_schedule_ch);
            this.gb_View.Location = new System.Drawing.Point(12, 27);
            this.gb_View.Name = "gb_View";
            this.gb_View.Size = new System.Drawing.Size(706, 397);
            this.gb_View.TabIndex = 1;
            this.gb_View.TabStop = false;
            this.gb_View.Text = "Рассписание:";
            // 
            // cb_term
            // 
            this.cb_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_term.Location = new System.Drawing.Point(510, 34);
            this.cb_term.Name = "cb_term";
            this.cb_term.Size = new System.Drawing.Size(101, 21);
            this.cb_term.TabIndex = 11;
            this.cb_term.TabStop = false;
            this.cb_term.SelectedIndexChanged += new System.EventHandler(this.cb_term_SelectedIndexChanged);
            // 
            // lbl_term
            // 
            this.lbl_term.AutoSize = true;
            this.lbl_term.Location = new System.Drawing.Point(465, 37);
            this.lbl_term.Name = "lbl_term";
            this.lbl_term.Size = new System.Drawing.Size(37, 13);
            this.lbl_term.TabIndex = 10;
            this.lbl_term.Text = "Курс :";
            // 
            // cb_sec
            // 
            this.cb_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sec.Location = new System.Drawing.Point(357, 34);
            this.cb_sec.Name = "cb_sec";
            this.cb_sec.Size = new System.Drawing.Size(101, 21);
            this.cb_sec.TabIndex = 9;
            this.cb_sec.TabStop = false;
            this.cb_sec.SelectedIndexChanged += new System.EventHandler(this.cb_sec_SelectedIndexChanged);
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Location = new System.Drawing.Point(307, 37);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(44, 13);
            this.lbl_sec.TabIndex = 8;
            this.lbl_sec.Text = "Проф. :";
            // 
            // cb_spec
            // 
            this.cb_spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_spec.Location = new System.Drawing.Point(203, 34);
            this.cb_spec.Name = "cb_spec";
            this.cb_spec.Size = new System.Drawing.Size(101, 21);
            this.cb_spec.TabIndex = 7;
            this.cb_spec.TabStop = false;
            this.cb_spec.SelectedIndexChanged += new System.EventHandler(this.cb_spec_SelectedIndexChanged);
            // 
            // lbl_spec
            // 
            this.lbl_spec.AutoSize = true;
            this.lbl_spec.Location = new System.Drawing.Point(155, 37);
            this.lbl_spec.Name = "lbl_spec";
            this.lbl_spec.Size = new System.Drawing.Size(42, 13);
            this.lbl_spec.TabIndex = 6;
            this.lbl_spec.Text = "Напр. :";
            // 
            // cb_fak
            // 
            this.cb_fak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fak.Location = new System.Drawing.Point(51, 34);
            this.cb_fak.Name = "cb_fak";
            this.cb_fak.Size = new System.Drawing.Size(101, 21);
            this.cb_fak.TabIndex = 5;
            this.cb_fak.TabStop = false;
            this.cb_fak.SelectedIndexChanged += new System.EventHandler(this.cb_fak_SelectedIndexChanged);
            // 
            // lbl_fak
            // 
            this.lbl_fak.AutoSize = true;
            this.lbl_fak.Location = new System.Drawing.Point(6, 37);
            this.lbl_fak.Name = "lbl_fak";
            this.lbl_fak.Size = new System.Drawing.Size(39, 13);
            this.lbl_fak.TabIndex = 4;
            this.lbl_fak.Text = "Фак. :";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.Location = new System.Drawing.Point(3, 242);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(78, 13);
            this.lbl_z.TabIndex = 3;
            this.lbl_z.Text = "Знаменатель:";
            // 
            // lbl_ch
            // 
            this.lbl_ch.AutoSize = true;
            this.lbl_ch.Location = new System.Drawing.Point(6, 77);
            this.lbl_ch.Name = "lbl_ch";
            this.lbl_ch.Size = new System.Drawing.Size(65, 13);
            this.lbl_ch.TabIndex = 2;
            this.lbl_ch.Text = "Числитель:";
            // 
            // dgv_schedule_z
            // 
            this.dgv_schedule_z.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_schedule_z.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_z,
            this.mon_z,
            this.tue_z,
            this.wed_z,
            this.thu_z,
            this.fri_z,
            this.sat_z,
            this.sun_z});
            this.dgv_schedule_z.Location = new System.Drawing.Point(6, 258);
            this.dgv_schedule_z.Name = "dgv_schedule_z";
            this.dgv_schedule_z.Size = new System.Drawing.Size(694, 133);
            this.dgv_schedule_z.TabIndex = 1;
            this.dgv_schedule_z.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_schedule_z_CellEndEdit);
            // 
            // col_z
            // 
            this.col_z.HeaderText = "П\\Д";
            this.col_z.Name = "col_z";
            this.col_z.Width = 45;
            // 
            // mon_z
            // 
            this.mon_z.HeaderText = "ПН";
            this.mon_z.Name = "mon_z";
            // 
            // tue_z
            // 
            this.tue_z.HeaderText = "ВТ";
            this.tue_z.Name = "tue_z";
            // 
            // wed_z
            // 
            this.wed_z.HeaderText = "СР";
            this.wed_z.Name = "wed_z";
            // 
            // thu_z
            // 
            this.thu_z.HeaderText = "ЧТ";
            this.thu_z.Name = "thu_z";
            // 
            // fri_z
            // 
            this.fri_z.HeaderText = "ПТ";
            this.fri_z.Name = "fri_z";
            // 
            // sat_z
            // 
            this.sat_z.HeaderText = "СБ";
            this.sat_z.Name = "sat_z";
            // 
            // sun_z
            // 
            this.sun_z.HeaderText = "ВС";
            this.sun_z.Name = "sun_z";
            // 
            // dgv_schedule_ch
            // 
            this.dgv_schedule_ch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_schedule_ch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ch,
            this.mon_ch,
            this.tue_ch,
            this.wed_ch,
            this.thu_ch,
            this.fri_ch,
            this.sat_ch,
            this.sun_ch});
            this.dgv_schedule_ch.Location = new System.Drawing.Point(6, 93);
            this.dgv_schedule_ch.Name = "dgv_schedule_ch";
            this.dgv_schedule_ch.Size = new System.Drawing.Size(694, 133);
            this.dgv_schedule_ch.TabIndex = 0;
            this.dgv_schedule_ch.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_schedule_ch_CellEndEdit);
            // 
            // col_ch
            // 
            this.col_ch.HeaderText = "П\\Д";
            this.col_ch.Name = "col_ch";
            this.col_ch.Width = 45;
            // 
            // mon_ch
            // 
            this.mon_ch.HeaderText = "ПН";
            this.mon_ch.Name = "mon_ch";
            // 
            // tue_ch
            // 
            this.tue_ch.HeaderText = "ВТ";
            this.tue_ch.Name = "tue_ch";
            // 
            // wed_ch
            // 
            this.wed_ch.HeaderText = "СР";
            this.wed_ch.Name = "wed_ch";
            // 
            // thu_ch
            // 
            this.thu_ch.HeaderText = "ЧТ";
            this.thu_ch.Name = "thu_ch";
            // 
            // fri_ch
            // 
            this.fri_ch.HeaderText = "ПТ";
            this.fri_ch.Name = "fri_ch";
            // 
            // sat_ch
            // 
            this.sat_ch.HeaderText = "СБ";
            this.sat_ch.Name = "sat_ch";
            // 
            // sun_ch
            // 
            this.sun_ch.HeaderText = "ВС";
            this.sun_ch.Name = "sun_ch";
            // 
            // gb_edit
            // 
            this.gb_edit.Controls.Add(this.btn_save);
            this.gb_edit.Location = new System.Drawing.Point(12, 430);
            this.gb_edit.Name = "gb_edit";
            this.gb_edit.Size = new System.Drawing.Size(706, 51);
            this.gb_edit.TabIndex = 2;
            this.gb_edit.TabStop = false;
            this.gb_edit.Text = "Окно редактирования:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(9, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Сохр.";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_schload
            // 
            this.btn_schload.Location = new System.Drawing.Point(625, 33);
            this.btn_schload.Name = "btn_schload";
            this.btn_schload.Size = new System.Drawing.Size(75, 21);
            this.btn_schload.TabIndex = 12;
            this.btn_schload.Text = "Загрузить";
            this.btn_schload.UseVisualStyleBackColor = true;
            this.btn_schload.Click += new System.EventHandler(this.btn_schload_Click);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(730, 493);
            this.Controls.Add(this.gb_edit);
            this.Controls.Add(this.gb_View);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSchedule";
            this.Text = "Рассписание СмолГУ |";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSchedule_FormClosed);
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_View.ResumeLayout(false);
            this.gb_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule_ch)).EndInit();
            this.gb_edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_View;
        private System.Windows.Forms.Label lbl_z;
        private System.Windows.Forms.Label lbl_ch;
        private System.Windows.Forms.DataGridView dgv_schedule_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn tue_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn wed_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn fri_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn sun_z;
        private System.Windows.Forms.DataGridView dgv_schedule_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn tue_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn wed_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn fri_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn sun_ch;
        private System.Windows.Forms.GroupBox gb_edit;
        private System.Windows.Forms.Label lbl_fak;
        private System.Windows.Forms.ComboBox cb_fak;
        private System.Windows.Forms.ComboBox cb_term;
        private System.Windows.Forms.Label lbl_term;
        private System.Windows.Forms.ComboBox cb_sec;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.ComboBox cb_spec;
        private System.Windows.Forms.Label lbl_spec;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_schload;
    }
}