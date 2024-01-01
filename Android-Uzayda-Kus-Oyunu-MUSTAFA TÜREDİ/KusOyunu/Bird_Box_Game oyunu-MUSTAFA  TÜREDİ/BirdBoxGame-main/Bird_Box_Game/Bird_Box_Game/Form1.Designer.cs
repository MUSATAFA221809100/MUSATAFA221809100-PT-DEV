
namespace Bird_Box_Game
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.geri_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.basla_btn = new System.Windows.Forms.Button();
            this.game_pnl = new System.Windows.Forms.Panel();
            this.mermi_lbl_2 = new System.Windows.Forms.Label();
            this.mermi_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.false_bird_2 = new System.Windows.Forms.PictureBox();
            this.false_bird = new System.Windows.Forms.PictureBox();
            this.bird_4 = new System.Windows.Forms.PictureBox();
            this.bird_3 = new System.Windows.Forms.PictureBox();
            this.bird_2 = new System.Windows.Forms.PictureBox();
            this.bird_1 = new System.Windows.Forms.PictureBox();
            this.return_pnl = new System.Windows.Forms.Panel();
            this.return_btn = new System.Windows.Forms.Button();
            this.score_lbl_2 = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.help_pnl.SuspendLayout();
            this.game_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.false_bird_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.false_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_1)).BeginInit();
            this.return_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bird_Box_Game.Properties.Resources.Bird_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(498, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // help_pnl
            // 
            this.help_pnl.BackColor = System.Drawing.Color.Transparent;
            this.help_pnl.Controls.Add(this.label1);
            this.help_pnl.Controls.Add(this.geri_btn);
            this.help_pnl.Location = new System.Drawing.Point(54, 663);
            this.help_pnl.Name = "help_pnl";
            this.help_pnl.Size = new System.Drawing.Size(1009, 44);
            this.help_pnl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(379, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 230);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.Wheat;
            this.geri_btn.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_btn.Location = new System.Drawing.Point(477, 417);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(222, 115);
            this.geri_btn.TabIndex = 0;
            this.geri_btn.Text = "Menüye Dön";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Wheat;
            this.help_btn.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.help_btn.Location = new System.Drawing.Point(489, 491);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(189, 88);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "NASIL OYNANIR";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // basla_btn
            // 
            this.basla_btn.BackColor = System.Drawing.Color.Wheat;
            this.basla_btn.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basla_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.basla_btn.Location = new System.Drawing.Point(489, 351);
            this.basla_btn.Name = "basla_btn";
            this.basla_btn.Size = new System.Drawing.Size(189, 88);
            this.basla_btn.TabIndex = 4;
            this.basla_btn.Text = "OYNA";
            this.basla_btn.UseVisualStyleBackColor = false;
            this.basla_btn.Click += new System.EventHandler(this.basla_btn_Click_1);
            // 
            // game_pnl
            // 
            this.game_pnl.BackColor = System.Drawing.Color.Transparent;
            this.game_pnl.Controls.Add(this.mermi_lbl_2);
            this.game_pnl.Controls.Add(this.mermi_lbl);
            this.game_pnl.Controls.Add(this.button1);
            this.game_pnl.Controls.Add(this.false_bird_2);
            this.game_pnl.Controls.Add(this.false_bird);
            this.game_pnl.Controls.Add(this.bird_4);
            this.game_pnl.Controls.Add(this.bird_3);
            this.game_pnl.Controls.Add(this.bird_2);
            this.game_pnl.Controls.Add(this.bird_1);
            this.game_pnl.Location = new System.Drawing.Point(12, 12);
            this.game_pnl.Name = "game_pnl";
            this.game_pnl.Size = new System.Drawing.Size(1171, 286);
            this.game_pnl.TabIndex = 5;
            // 
            // mermi_lbl_2
            // 
            this.mermi_lbl_2.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mermi_lbl_2.Location = new System.Drawing.Point(631, 0);
            this.mermi_lbl_2.Name = "mermi_lbl_2";
            this.mermi_lbl_2.Size = new System.Drawing.Size(48, 31);
            this.mermi_lbl_2.TabIndex = 8;
            this.mermi_lbl_2.Text = "20";
            // 
            // mermi_lbl
            // 
            this.mermi_lbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mermi_lbl.Location = new System.Drawing.Point(551, 0);
            this.mermi_lbl.Name = "mermi_lbl";
            this.mermi_lbl.Size = new System.Drawing.Size(85, 31);
            this.mermi_lbl.TabIndex = 7;
            this.mermi_lbl.Text = "Mermi:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(1041, 727);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "OYUNU BİTİR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // false_bird_2
            // 
            this.false_bird_2.BackColor = System.Drawing.Color.Transparent;
            this.false_bird_2.Image = global::Bird_Box_Game.Properties.Resources.superman_2;
            this.false_bird_2.Location = new System.Drawing.Point(1097, 56);
            this.false_bird_2.Name = "false_bird_2";
            this.false_bird_2.Size = new System.Drawing.Size(71, 50);
            this.false_bird_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.false_bird_2.TabIndex = 5;
            this.false_bird_2.TabStop = false;
            this.false_bird_2.Click += new System.EventHandler(this.false_bird_2_Click);
            // 
            // false_bird
            // 
            this.false_bird.BackColor = System.Drawing.Color.Transparent;
            this.false_bird.Image = ((System.Drawing.Image)(resources.GetObject("false_bird.Image")));
            this.false_bird.Location = new System.Drawing.Point(0, 57);
            this.false_bird.Name = "false_bird";
            this.false_bird.Size = new System.Drawing.Size(71, 50);
            this.false_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.false_bird.TabIndex = 4;
            this.false_bird.TabStop = false;
            this.false_bird.Click += new System.EventHandler(this.false_bird_Click);
            // 
            // bird_4
            // 
            this.bird_4.Image = global::Bird_Box_Game.Properties.Resources.BİRDD2;
            this.bird_4.Location = new System.Drawing.Point(1092, 112);
            this.bird_4.Name = "bird_4";
            this.bird_4.Size = new System.Drawing.Size(79, 50);
            this.bird_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_4.TabIndex = 3;
            this.bird_4.TabStop = false;
            this.bird_4.Click += new System.EventHandler(this.bird_4_Click);
            // 
            // bird_3
            // 
            this.bird_3.Image = global::Bird_Box_Game.Properties.Resources.BİRDDDD;
            this.bird_3.Location = new System.Drawing.Point(3, 112);
            this.bird_3.Name = "bird_3";
            this.bird_3.Size = new System.Drawing.Size(71, 48);
            this.bird_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_3.TabIndex = 2;
            this.bird_3.TabStop = false;
            this.bird_3.Click += new System.EventHandler(this.bird_3_Click);
            // 
            // bird_2
            // 
            this.bird_2.Image = global::Bird_Box_Game.Properties.Resources.BİRDD2;
            this.bird_2.Location = new System.Drawing.Point(1092, 0);
            this.bird_2.Name = "bird_2";
            this.bird_2.Size = new System.Drawing.Size(79, 50);
            this.bird_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_2.TabIndex = 1;
            this.bird_2.TabStop = false;
            this.bird_2.Click += new System.EventHandler(this.bird_2_Click);
            // 
            // bird_1
            // 
            this.bird_1.Image = global::Bird_Box_Game.Properties.Resources.BİRDDDD;
            this.bird_1.Location = new System.Drawing.Point(3, 3);
            this.bird_1.Name = "bird_1";
            this.bird_1.Size = new System.Drawing.Size(71, 48);
            this.bird_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_1.TabIndex = 0;
            this.bird_1.TabStop = false;
            this.bird_1.Click += new System.EventHandler(this.bird_1_Click_1);
            // 
            // return_pnl
            // 
            this.return_pnl.BackColor = System.Drawing.Color.Transparent;
            this.return_pnl.Controls.Add(this.return_btn);
            this.return_pnl.Controls.Add(this.score_lbl_2);
            this.return_pnl.Controls.Add(this.score_lbl);
            this.return_pnl.Location = new System.Drawing.Point(31, 728);
            this.return_pnl.Name = "return_pnl";
            this.return_pnl.Size = new System.Drawing.Size(1083, 21);
            this.return_pnl.TabIndex = 6;
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Wheat;
            this.return_btn.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.Color.Maroon;
            this.return_btn.Location = new System.Drawing.Point(478, 479);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(223, 91);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "Yeniden Oyna";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // score_lbl_2
            // 
            this.score_lbl_2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl_2.ForeColor = System.Drawing.Color.Snow;
            this.score_lbl_2.Location = new System.Drawing.Point(627, 365);
            this.score_lbl_2.Name = "score_lbl_2";
            this.score_lbl_2.Size = new System.Drawing.Size(105, 39);
            this.score_lbl_2.TabIndex = 1;
            this.score_lbl_2.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.Color.Snow;
            this.score_lbl.Location = new System.Drawing.Point(493, 365);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(105, 39);
            this.score_lbl.TabIndex = 0;
            this.score_lbl.Text = "SKOR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = global::Bird_Box_Game.Properties.Resources.Bird_Box_BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.game_pnl);
            this.Controls.Add(this.return_pnl);
            this.Controls.Add(this.help_pnl);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.basla_btn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.help_pnl.ResumeLayout(false);
            this.game_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.false_bird_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.false_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_1)).EndInit();
            this.return_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel help_pnl;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button basla_btn;
        private System.Windows.Forms.Panel game_pnl;
        private System.Windows.Forms.PictureBox bird_2;
        private System.Windows.Forms.PictureBox bird_1;
        private System.Windows.Forms.PictureBox bird_4;
        private System.Windows.Forms.PictureBox bird_3;
        private System.Windows.Forms.PictureBox false_bird;
        private System.Windows.Forms.PictureBox false_bird_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel return_pnl;
        private System.Windows.Forms.Label score_lbl_2;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label mermi_lbl_2;
        private System.Windows.Forms.Label mermi_lbl;
    }
}

