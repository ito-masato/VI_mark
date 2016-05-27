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
                
            }

            //コントロールを再描画する。
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// 色選択1
        /// </summary>
        private void btn_selectcolor1_Click(object sender, EventArgs e)
        {
            //はじめに選択されている色を設定
            colorDialog1.Color = pic_select1.BackColor;
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
                pic_select1.BackColor = colorDialog1.Color;

            }
        }

        /// <summary>
        /// 色選択2
        /// </summary>
        private void btn_selectcolor2_Click(object sender, EventArgs e)
        {
            //はじめに選択されている色を設定
            colorDialog1.Color = pic_select2.BackColor;
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
                pic_select2.BackColor = colorDialog1.Color;

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

        private void btn_draw_Click(object sender, EventArgs e)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            Region rgn;
            Rectangle rect1, rect2;

            //Regionで使用する2つの領域
            rect1 = new Rectangle(20, 20, 200, 200);
            rect2 = new Rectangle(220, 20, 200, 200);

            //rect1を青で塗る
            g.FillRectangle(Brushes.SkyBlue, rect1);
            //rect2を緑で塗る
            g.FillRectangle(Brushes.PowderBlue, rect2);
            //rect1でRegionを作成
            rgn = new Region(rect1);
            //Union(和集合)によりrect2を追加
            rgn.Union(rect2);
            //出来上がったRegionを黒で描画
            //g.FillRegion(Brushes.Black, rgn);


            //リソースを解放する
            g.Dispose();

            //pictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        /// <summary>
        /// 指定された色を塗る
        /// </summary>
        private void btn_paint_Click(object sender, EventArgs e)
        {
            try
            {
                if(pic_select1.BackColor == pic_select2.BackColor){
                    DialogResult result = MessageBox.Show(
                        "１色で塗り潰されます。" + Environment.NewLine + 
                        "２色で塗り分ける場合は、画像選択からテンプレートを選び直してください。",
                        "お知らせ",
                        MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation );

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
                cms[0].NewColor = pic_select1.BackColor;
                //PowderBlueを色２に変換する
                cms[1].OldColor = cmr[1].OldColor;
                cms[1].NewColor = pic_select2.BackColor;
                //色情報を保存
                cmr[0].OldColor = pic_select1.BackColor;
                cmr[1].OldColor = pic_select2.BackColor;

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
                MessageBox.Show(ex.Message,"エラー");
            }
        }





    }
}
