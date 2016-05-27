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
            this.btn_draw = new System.Windows.Forms.Button();
            this.btn_paint = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(80, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 331);
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
            this.btn_save.Location = new System.Drawing.Point(12, 333);
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
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(12, 306);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(62, 21);
            this.btn_draw.TabIndex = 8;
            this.btn_draw.Text = "描画";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Visible = false;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 366);
            this.Controls.Add(this.btn_paint);
            this.Controls.Add(this.btn_draw);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Button btn_paint;

        private System.Drawing.Imaging.ColorMap[] cmr = 
                {
                    new System.Drawing.Imaging.ColorMap(),
                    new System.Drawing.Imaging.ColorMap()
                };
    }
}

