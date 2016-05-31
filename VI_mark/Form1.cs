using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VI_mark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画像選択ダイアログ表示
        /// </summary>
        private void btn_selectimg_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            ofd.FileName = null;
            //はじめに表示されるフォルダを指定する
            ofd.InitialDirectory = @".";
            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter = "画像ファイル(*.png)|*.png";
            //[ファイルの種類]ではじめに「画像ファイル」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = "画像ファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // OKボタンがクリックされたとき
                // 画像パスを格納する
                //表示する画像を設定する
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.ImageLocation = ofd.FileName;
                    
                // 色情報初期化
                // default Color1:SkyBlue(135,206,235)
                // default Color2:PowderBlue(176,224,230)
                cmr[0].OldColor = global::VI_mark.Properties.Settings.Default.Color1;
                cmr[1].OldColor = global::VI_mark.Properties.Settings.Default.Color2;

                // ボタンを有効化
                btn_paint.Enabled = true;
                textBox1.Enabled = true;
                btn_save.Enabled = true;
                btn_reset.Enabled = true;
                comboBox1.Enabled = true;
                
            }

            //コントロールを再描画する。
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// 色１
        /// </summary>
        private void btn_selectcolor1_Click(object sender, EventArgs e)
        {
            colorSet(btn_selectcolor1);
        }

        /// <summary>
        /// 色２
        /// </summary>
        private void btn_selectcolor2_Click(object sender, EventArgs e)
        {
            colorSet(btn_selectcolor2);
        }

        /// <summary>
        /// 色選択
        /// </summary>
        /// <param name="btn">Buttonオブジェクト</param>
        private void colorSet(Button btn)
        {
            //はじめに選択されている色を設定
            colorDialog1.Color = btn.BackColor;
            //色の作成部分を表示可能にする
            //デフォルトがTrueのため必要はない
            colorDialog1.AllowFullOpen = true;
            //純色だけに制限しない
            //デフォルトがFalseのため必要はない
            colorDialog1.SolidColorOnly = false;
            //[作成した色]に指定した色（RGB値）を表示する
            colorDialog1.CustomColors = new int[] {
                0x33, 0x66, 0x99, 0xCC, 0x3300, 0x3333,
                0x3366, 0x3399, 0x33CC, 0x6600, 0x6633,
                0x6666, 0x6699, 0x66CC, 0x9900, 0x9933
            };

            //ダイアログを表示する
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //選択された色の取得
                btn.BackColor = colorDialog1.Color;
                btn.ForeColor = GetBlackorWhite(btn.BackColor);
            }
        }

        /// <summary>
        /// PictureBoxリサイズイベント
        /// </summary>
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            // 再描画処理
            ((Control)sender).Invalidate();
        }

        /// <summary>
        /// 画像を保存
        /// </summary>
        private void btn_save_Click(object sender, EventArgs e)
        {
            // フィルターの設定
            saveFileDialog1.Filter = "PNG|*.png";

            // ファイル保存ダイアログを表示
            saveFileDialog1.ShowDialog();
        }

        /// <summary>
        ///  [保存]ボタンクリック時の処理
        /// </summary>
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);

            try
            {
                switch (extension.ToUpper())
                {
                    case ".GIF":
                        // PictureBoxのイメージをGIF形式で保存する
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case ".JPG":
                        // PictureBoxのイメージをJPEG形式で保存する
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".PNG":
                        // PictureBoxのイメージをGIF形式で保存する
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                MessageBox.Show("保存しました","保存");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }


        }



        /// <summary>
        /// 指定された色を塗る
        /// </summary>
        private void btn_paint_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_selectcolor1.BackColor == btn_selectcolor2.BackColor)
                {
                    DialogResult result = MessageBox.Show(
                        "１色で塗り潰されます。" + Environment.NewLine +
                        "２色で塗り分ける場合は、画像選択からテンプレートを選び直してください。",
                        "お知らせ",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Cancel) { return; }
                }

                //描画先とするImageオブジェクトを作成する
                Bitmap canvas = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                //Bitmap canvas = new Bitmap(global::VI_mark.Properties.Settings.Default.Width, 
                //    global::VI_mark.Properties.Settings.Default.Height);
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //ColorMapオブジェクトの配列（カラーリマップテーブル）を作成
                System.Drawing.Imaging.ColorMap[] cms =
                    new System.Drawing.Imaging.ColorMap[] 
                {
                    new System.Drawing.Imaging.ColorMap(),
                    new System.Drawing.Imaging.ColorMap()
                };

                //SkyBlueを色１に変換する
                cms[0].OldColor = cmr[0].OldColor;
                cms[0].NewColor = btn_selectcolor1.BackColor;
                //PowderBlueを色２に変換する
                cms[1].OldColor = cmr[1].OldColor;
                cms[1].NewColor = btn_selectcolor2.BackColor;
                //色情報を保存
                cmr[0].OldColor = btn_selectcolor1.BackColor;
                cmr[1].OldColor = btn_selectcolor2.BackColor;

                //ImageAttributesオブジェクトの作成
                System.Drawing.Imaging.ImageAttributes ia =
                    new System.Drawing.Imaging.ImageAttributes();
                //ColorMapを設定
                ia.SetRemapTable(cms);

                //色を変換して画像を描画
                g.DrawImage(pictureBox1.Image,
                    new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height),
                    0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height,
                    GraphicsUnit.Pixel,
                    ia);

                //Graphicsオブジェクトのリソースを解放する
                g.Dispose();

                // pictureBox1に表示する
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = canvas;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
            finally
            {
                string s =@"　　 （　・∀・）　　　|　|　ｶﾞｯ
　　と　　　　）　 　 |　|
　　　 Ｙ　/ノ　　　 人
　　　　 /　）　 　 < 　>__Λ∩
　　 ＿/し'　／／. Ｖ｀Д´）/ 
　　（＿フ彡　　　　　 　　/";

                MessageBox.Show(s,"ぬるぽ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初期値
            this.Text += " ver " + this.ProductVersion;
            btn_selectcolor1.ForeColor = GetBlackorWhite(btn_selectcolor1.BackColor);
            btn_selectcolor2.ForeColor = GetBlackorWhite(btn_selectcolor2.BackColor);
            comboBox1.SelectedIndex = 0;

            string str_c1 =
                "色1 " +
                global::VI_mark.Properties.Settings.Default.Color1.Name.ToString() + "(" +
                global::VI_mark.Properties.Settings.Default.Color1.R.ToString() + "," +
                global::VI_mark.Properties.Settings.Default.Color1.G.ToString() + "," +
                global::VI_mark.Properties.Settings.Default.Color1.B.ToString() + ") ";

            string str_c2 =
                "色2 " +
                global::VI_mark.Properties.Settings.Default.Color2.Name.ToString() + "(" +
                global::VI_mark.Properties.Settings.Default.Color2.R.ToString() + "," +
                global::VI_mark.Properties.Settings.Default.Color2.G.ToString() + "," +
                global::VI_mark.Properties.Settings.Default.Color2.B.ToString() + ") ";

            lbl_defcolor.Text += str_c1 + str_c2;

        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //フォントオブジェクトの作成
            //Font fnt = new Font(cbb_font.SelectedItem.ToString(), float.Parse(cbb_fontsize.SelectedItem.ToString()));
            //文字列を位置(0,0)、青色で表示
            //g.DrawString(textBox1.Text, fnt, Brushes.White, 0, 0);

            //リソースを解放する
            //fnt.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        /// <summary>
        /// フォントダイアログ表示
        /// </summary>
        private void btn_fontset_Click(object sender, EventArgs e)
        {
            //FontDialogクラスのインスタンスを作成
            FontDialog fd = new FontDialog();

            //初期のフォントを設定
            fd.Font = textBox1.Font;
            //初期の色を設定
            fd.Color = textBox1.ForeColor;
            //ユーザーが選択できるポイントサイズの最大値を設定する
            fd.MaxSize = 500;
            fd.MinSize = 18;
            //存在しないフォントやスタイルをユーザーが選択すると
            //エラーメッセージを表示する
            fd.FontMustExist = true;
            //横書きフォントだけを表示する
            fd.AllowVerticalFonts = false;
            //色を選択できるようにする
            fd.ShowColor = true;
            //取り消し線、下線、テキストの色などのオプションを指定不可にする
            fd.ShowEffects = true;
            //固定ピッチフォント以外も表示する
            //デフォルトがFalseのため必要はない
            fd.FixedPitchOnly = false;
            //ベクタ フォントを選択できるようにする
            //デフォルトがTrueのため必要はない
            fd.AllowVectorFonts = true;

            //ダイアログを表示する
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                // テキスト描画する
                DrawingText(comboBox1.SelectedIndex,fd.Font,fd.Color);
                
            }
        }


        /// <summary>
        /// 文字を描画する
        /// </summary>
        /// <param name="mode">書込みモード 0:中央 1:下部</param>
        /// <param name="fd">フォント</param>
        /// <param name="color">色</param>
        private void DrawingText(int mode, Font fd, Color color)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("まだ作ってないよ (ゝω・)ﾃﾍﾍﾟﾛ", "Comming Soon!!");
                return;
            }
            try
            {
                //描画元のImageオブジェクトバックアップ
                canvas_bk = new Bitmap(pictureBox1.Image);
                //描画先とするImageオブジェクトを作成する
                Bitmap canvas = new Bitmap(pictureBox1.Image);
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //StringFormatオブジェクトの作成
                StringFormat sf = new StringFormat();

                //フォントオブジェクトの作成
                Font fnt = new Font(fd.Name, fd.Size);

                //(高品質で低速なレンダリング)を指定する
                g.SmoothingMode = SmoothingMode.HighQuality;

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

                //幅の最大値をpitureBoxの幅(pixel)、文字列を描画するときの大きさを計測する
                //SizeF stringSize = g.MeasureString(textBox1.Text, fnt, pictureBox1.Width, sf);
                Size stringSize = TextRenderer.MeasureText(g, textBox1.Text, fnt,
                     new Size(1000, 1000), TextFormatFlags.NoPadding);
                //取得した文字列の大きさを使って四角を描画する
                //g.DrawRectangle(Pens.Red, 
                //    (pictureBox1.Image.Width / 2) - (stringSize.Width / 2), 
                //    (pictureBox1.Image.Height / 2) - (stringSize.Height / 2), 
                //    stringSize.Width, stringSize.Height);

                //文字列を中心座標、選択した色で表示
                TextRenderer.DrawText(
                    g, textBox1.Text, fnt,
                    new Point((pictureBox1.Image.Width / 2) - (stringSize.Width / 2),
                        (pictureBox1.Image.Height / 2) - (stringSize.Height / 2)),
                    color, TextFormatFlags.NoPadding);
                //g.DrawString(textBox1.Text, fnt, Brushes.Red, 0, 0);

                //リソースを解放する
                fnt.Dispose();
                g.Dispose();

                //pictureBox1に表示する
                pictureBox1.Image = canvas;

                // 消すボタン有効化
                btn_txtdel.Enabled = true;

                // 表示ボタン無効化
                btn_fontset.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }

        }

        /// <summary>
        /// 文字を消す
        /// </summary>
        private void btn_txtdel_Click(object sender, EventArgs e)
        {
            try
            {
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas_bk);

                //PictureBox1に表示する
                pictureBox1.Image = canvas_bk;

                //リソースを解放する
                g.Dispose();
                canvas_bk= null;

                //消すボタン無効化
                btn_txtdel.Enabled = false;

                // 表示ボタン有効化
                btn_fontset.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        private void pic_select1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 補色を取得する
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>補色のColorオブジェクト</returns>
        private Color GetComplementaryColor(Color color)
        {
            byte r = (byte)~color.R;
            byte g = (byte)~color.G;
            byte b = (byte)~color.B;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// 白か黒を返す
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>白か黒のColorオブジェクト</returns>
        private Color GetBlackorWhite(Color color)
        {
            byte r = (byte)color.R;
            byte g = (byte)color.G;
            byte b = (byte)color.B;

            if (r > 127 && g > 127 && b > 127)
            {
                return Color.Black;
            }
            else if (r > 127 || g > 127 || b > 127)
            {
                return Color.White;
            }
            else if (r < 127 && g < 127 && b < 127)
            {
                return Color.White;
            }

            else
            {
                return Color.Black;
            }

            //return Color.FromArgb(r, g, b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                btn_fontset.Enabled = true;
            }
            else
            {
                btn_fontset.Enabled = false;
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                //リソースを解放する
                pictureBox1.Image = null;
                canvas_bk = null;
                textBox1.Text = null;

                //コントロール無効化
                comboBox1.Enabled = false;
                textBox1.Enabled = false;
                btn_paint.Enabled = false;
                btn_txtdel.Enabled = false;
                btn_reset.Enabled = false;
                btn_save.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

    }
}
