namespace VI_mark
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_selectimg = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_selectcolor1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_selectcolor2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pic_select1 = new System.Windows.Forms.PictureBox();
            this.pic_select2 = new System.Windows.Forms.PictureBox();
            this.btn_paint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_fontset = new System.Windows.Forms.Button();
            this.btn_txtdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_selectimg
            // 
            this.btn_selectimg.Location = new System.Drawing.Point(12, 23);
            this.btn_selectimg.Name = "btn_selectimg";
            this.btn_selectimg.Size = new System.Drawing.Size(62, 21);
            this.btn_selectimg.TabIndex = 1;
            this.btn_selectimg.Text = "画像選択";
            this.btn_selectimg.UseVisualStyleBackColor = true;
            this.btn_selectimg.Click += new System.EventHandler(this.btn_selectimg_Click);
            // 
            // btn_selectcolor1
            // 
            this.btn_selectcolor1.Location = new System.Drawing.Point(12, 50);
            this.btn_selectcolor1.Name = "btn_selectcolor1";
            this.btn_selectcolor1.Size = new System.Drawing.Size(62, 21);
            this.btn_selectcolor1.TabIndex = 2;
            this.btn_selectcolor1.Text = "色１選択";
            this.btn_selectcolor1.UseVisualStyleBackColor = true;
            this.btn_selectcolor1.Click += new System.EventHandler(this.btn_selectcolor1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(89, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // btn_selectcolor2
            // 
            this.btn_selectcolor2.Location = new System.Drawing.Point(12, 109);
            this.btn_selectcolor2.Name = "btn_selectcolor2";
            this.btn_selectcolor2.Size = new System.Drawing.Size(62, 21);
            this.btn_selectcolor2.TabIndex = 4;
            this.btn_selectcolor2.Text = "色２選択";
            this.btn_selectcolor2.UseVisualStyleBackColor = true;
            this.btn_selectcolor2.Click += new System.EventHandler(this.btn_selectcolor2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(12, 353);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(62, 21);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pic_select1
            // 
            this.pic_select1.BackColor = System.Drawing.Color.White;
            this.pic_select1.Location = new System.Drawing.Point(12, 77);
            this.pic_select1.Name = "pic_select1";
            this.pic_select1.Size = new System.Drawing.Size(62, 23);
            this.pic_select1.TabIndex = 6;
            this.pic_select1.TabStop = false;
            // 
            // pic_select2
            // 
            this.pic_select2.BackColor = System.Drawing.Color.Blue;
            this.pic_select2.Location = new System.Drawing.Point(12, 136);
            this.pic_select2.Name = "pic_select2";
            this.pic_select2.Size = new System.Drawing.Size(62, 23);
            this.pic_select2.TabIndex = 7;
            this.pic_select2.TabStop = false;
            // 
            // btn_paint
            // 
            this.btn_paint.Location = new System.Drawing.Point(12, 165);
            this.btn_paint.Name = "btn_paint";
            this.btn_paint.Size = new System.Drawing.Size(62, 21);
            this.btn_paint.TabIndex = 9;
            this.btn_paint.Text = "塗る";
            this.btn_paint.UseVisualStyleBackColor = true;
            this.btn_paint.Click += new System.EventHandler(this.btn_paint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 271);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 19);
            this.textBox1.TabIndex = 14;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.White;
            this.fontDialog1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            // 
            // btn_fontset
            // 
            this.btn_fontset.Location = new System.Drawing.Point(12, 296);
            this.btn_fontset.Name = "btn_fontset";
            this.btn_fontset.Size = new System.Drawing.Size(62, 21);
            this.btn_fontset.TabIndex = 16;
            this.btn_fontset.Text = "文字表示";
            this.btn_fontset.UseVisualStyleBackColor = true;
            this.btn_fontset.Click += new System.EventHandler(this.btn_fontset_Click);
            // 
            // btn_txtdel
            // 
            this.btn_txtdel.Location = new System.Drawing.Point(12, 323);
            this.btn_txtdel.Name = "btn_txtdel";
            this.btn_txtdel.Size = new System.Drawing.Size(62, 21);
            this.btn_txtdel.TabIndex = 17;
            this.btn_txtdel.Text = "消す";
            this.btn_txtdel.UseVisualStyleBackColor = true;
            this.btn_txtdel.Click += new System.EventHandler(this.btn_txtdel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 386);
            this.Controls.Add(this.btn_txtdel);
            this.Controls.Add(this.btn_fontset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_paint);
            this.Controls.Add(this.pic_select2);
            this.Controls.Add(this.pic_select1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_selectcolor2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_selectcolor1);
            this.Controls.Add(this.btn_selectimg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "VI マーク作成モックアップ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectimg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_selectcolor1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_selectcolor2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pic_select1;
        private System.Windows.Forms.PictureBox pic_select2;
        private System.Windows.Forms.Button btn_paint;

        private System.Drawing.Imaging.ColorMap[] cmr = 
                {
                    new System.Drawing.Imaging.ColorMap(),
                    new System.Drawing.Imaging.ColorMap()
                };
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_fontset;

        private System.Drawing.Bitmap canvas_bk = null;
        private System.Windows.Forms.Button btn_txtdel;
    }
}

