namespace UdemyTranscation.UI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_kontrolEtAktar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_aliciHesap = new System.Windows.Forms.TextBox();
            this.txt_gondericiHesap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1544, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_kontrolEtAktar
            // 
            this.btn_kontrolEtAktar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_kontrolEtAktar.Location = new System.Drawing.Point(1198, 439);
            this.btn_kontrolEtAktar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_kontrolEtAktar.Name = "btn_kontrolEtAktar";
            this.btn_kontrolEtAktar.Size = new System.Drawing.Size(289, 70);
            this.btn_kontrolEtAktar.TabIndex = 1;
            this.btn_kontrolEtAktar.Text = "KONTROL ET AKTAR TRANS";
            this.btn_kontrolEtAktar.UseVisualStyleBackColor = false;
            this.btn_kontrolEtAktar.Click += new System.EventHandler(this.btn_kontrolEtAktar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Location = new System.Drawing.Point(827, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "KONTROL ET AKTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "GÖNDERİCİ HESAP NUMARASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALICI HESAP NUMARASI";
            // 
            // txt_aliciHesap
            // 
            this.txt_aliciHesap.Location = new System.Drawing.Point(424, 415);
            this.txt_aliciHesap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_aliciHesap.Name = "txt_aliciHesap";
            this.txt_aliciHesap.Size = new System.Drawing.Size(308, 30);
            this.txt_aliciHesap.TabIndex = 5;
            // 
            // txt_gondericiHesap
            // 
            this.txt_gondericiHesap.Location = new System.Drawing.Point(424, 347);
            this.txt_gondericiHesap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_gondericiHesap.Name = "txt_gondericiHesap";
            this.txt_gondericiHesap.Size = new System.Drawing.Size(308, 30);
            this.txt_gondericiHesap.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "TUTAR $";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(424, 479);
            this.txt_tutar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(308, 30);
            this.txt_tutar.TabIndex = 8;
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_yenile.Location = new System.Drawing.Point(839, 329);
            this.btn_yenile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(636, 74);
            this.btn_yenile.TabIndex = 10;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1539, 621);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gondericiHesap);
            this.Controls.Add(this.txt_aliciHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_kontrolEtAktar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "HESAP GORUNUMU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_kontrolEtAktar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aliciHesap;
        private System.Windows.Forms.TextBox txt_gondericiHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Button btn_yenile;
    }
}

