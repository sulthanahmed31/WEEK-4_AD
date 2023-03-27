namespace WEEK_4_AD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.nama_tim = new System.Windows.Forms.TextBox();
            this.nama_kota = new System.Windows.Forms.TextBox();
            this.nama_tempat = new System.Windows.Forms.TextBox();
            this.nomor_pemain = new System.Windows.Forms.TextBox();
            this.nama_pemain = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_team = new System.Windows.Forms.Button();
            this.button_Player = new System.Windows.Forms.Button();
            this.posisi_pemain = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Tim List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Player Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Player Position:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Player Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adding Team";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Choose Team:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(835, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Adding Player";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(186, 111);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(182, 33);
            this.cb_country.TabIndex = 11;
            this.cb_country.SelectedIndexChanged += new System.EventHandler(this.cb_country_SelectedIndexChanged);
            this.cb_country.SelectionChangeCommitted += new System.EventHandler(this.cb_country_SelectionChangeCommitted);
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(186, 193);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(182, 33);
            this.cb_team.TabIndex = 12;
            this.cb_team.SelectionChangeCommitted += new System.EventHandler(this.cb_team_SelectionChangeCommitted);
            // 
            // nama_tim
            // 
            this.nama_tim.Location = new System.Drawing.Point(536, 119);
            this.nama_tim.Name = "nama_tim";
            this.nama_tim.Size = new System.Drawing.Size(150, 31);
            this.nama_tim.TabIndex = 13;
            // 
            // nama_kota
            // 
            this.nama_kota.Location = new System.Drawing.Point(536, 263);
            this.nama_kota.Name = "nama_kota";
            this.nama_kota.Size = new System.Drawing.Size(150, 31);
            this.nama_kota.TabIndex = 14;
            // 
            // nama_tempat
            // 
            this.nama_tempat.Location = new System.Drawing.Point(536, 190);
            this.nama_tempat.Name = "nama_tempat";
            this.nama_tempat.Size = new System.Drawing.Size(150, 31);
            this.nama_tempat.TabIndex = 15;
            // 
            // nomor_pemain
            // 
            this.nomor_pemain.Location = new System.Drawing.Point(878, 190);
            this.nomor_pemain.Name = "nomor_pemain";
            this.nomor_pemain.Size = new System.Drawing.Size(150, 31);
            this.nomor_pemain.TabIndex = 17;
            // 
            // nama_pemain
            // 
            this.nama_pemain.Location = new System.Drawing.Point(878, 119);
            this.nama_pemain.Name = "nama_pemain";
            this.nama_pemain.Size = new System.Drawing.Size(150, 31);
            this.nama_pemain.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(31, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 179);
            this.listBox1.TabIndex = 19;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(468, 483);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(112, 34);
            this.button_remove.TabIndex = 20;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_team
            // 
            this.button_team.Location = new System.Drawing.Point(536, 316);
            this.button_team.Name = "button_team";
            this.button_team.Size = new System.Drawing.Size(150, 34);
            this.button_team.TabIndex = 21;
            this.button_team.Text = "Add";
            this.button_team.UseVisualStyleBackColor = true;
            this.button_team.Click += new System.EventHandler(this.button_team_Click);
            // 
            // button_Player
            // 
            this.button_Player.Location = new System.Drawing.Point(878, 316);
            this.button_Player.Name = "button_Player";
            this.button_Player.Size = new System.Drawing.Size(150, 34);
            this.button_Player.TabIndex = 22;
            this.button_Player.Text = "Add";
            this.button_Player.UseVisualStyleBackColor = true;
            this.button_Player.Click += new System.EventHandler(this.button_Player_Click);
            // 
            // posisi_pemain
            // 
            this.posisi_pemain.FormattingEnabled = true;
            this.posisi_pemain.Location = new System.Drawing.Point(878, 255);
            this.posisi_pemain.Name = "posisi_pemain";
            this.posisi_pemain.Size = new System.Drawing.Size(150, 33);
            this.posisi_pemain.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 556);
            this.Controls.Add(this.posisi_pemain);
            this.Controls.Add(this.button_Player);
            this.Controls.Add(this.button_team);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nama_pemain);
            this.Controls.Add(this.nomor_pemain);
            this.Controls.Add(this.nama_tempat);
            this.Controls.Add(this.nama_kota);
            this.Controls.Add(this.nama_tim);
            this.Controls.Add(this.cb_team);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cb_country;
        private ComboBox cb_team;
        private TextBox nama_tim;
        private TextBox nama_kota;
        private TextBox nama_tempat;
        private TextBox nomor_pemain;
        private TextBox nama_pemain;
        private ListBox listBox1;
        private Button button_remove;
        private Button button_team;
        private Button button_Player;
        private ComboBox posisi_pemain;
    }
}