using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XLA
{
    public partial class mainForm : Form
    {
        Bitmap img;
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureboxin_Click(object sender, EventArgs e)
        {
            //Đọc ảnh vào Bitmap
            OpenFileDialog openpt = new OpenFileDialog();
            openpt.InitialDirectory = @"D:\Documents\Xu ly anh\XLA\XLA\Image\ImgInput\";
            if (openpt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img = new Bitmap(openpt.FileName);                
                pictureboxin.Image = img;
            }
        }

        unsafe
        private Bitmap AnhXam(Bitmap img)
        {
            Bitmap imgtmp = new Bitmap(img);
            imgtmp = img;
            //Nạp ảnh vào BitmapData
            //-Rectangle(0,0,img.Width,img.Height) khai báo một hình chữ nhật là kích thước của ảnh
            /*-Phương thức img.LockBits sẽ chuyển từ 1 ảnh, sang 1 vùng nhớ (imgData). Trên ảnh bm, ta chỉ có thể
               xem nó, chứ không thể chỉnh sử pixel. Muốn sửa, phải chuyển nó sang lớp BitmapData,
               trên đó có các thứ cần thiết để can thiệp vào từng điểm ảnh.
            */
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height),
                                                ImageLockMode.ReadWrite,
                                                imgtmp.PixelFormat);
            //Tính Offset
            //-imgdata.Stride : số byte thực sự mà máy tính lưu trữ mỗi hàng của ảnh
            int offset = imgdata.Stride - imgtmp.Width * 3;

            //Truy cập đến con trỏ đầu tiên
            //-imgdata.Scan0 : chỉ ra địa chỉ pixel đầu tiên của ảnh mà imgData quản lý
            byte* p = (byte*)imgdata.Scan0;

            //Duyệt theo con trỏ đầu tiên(Duyệt ảnh)
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    //Xử lý 3 byte của 1 pixel
                    int t = (p[0] + p[1] + p[2]) / 3;

                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;

                    //Chuyển con trỏ sang pixel kế tiếp 
                    p += 3; //Mõi pixel cách nhau 3 byte
                }
                //Chuyển con trỏ xuống hàng kế tiếp
                p += offset;
            }

            //Giải phóng biến BitmapData
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }
        private void btnanhxam_Click(object sender, EventArgs e)
        {
            
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!", "Image Null");
            }
            else
                pictureboxout.Image = AnhXam(img);
        }
        unsafe
        private Bitmap NhiPhan(Bitmap img, byte nguong)
        {
            Bitmap imgtmp = new Bitmap(img);
            imgtmp = img;

            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height),
                                                ImageLockMode.ReadWrite,
                                                imgtmp.PixelFormat);

            int offset = imgdata.Stride - imgtmp.Width * 3;

            byte* p = (byte*)imgdata.Scan0;

            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    //Xử lý 3 byte của 1 pixel
                    int t = (p[0] + p[1] + p[2]) / 3;
                    if ((byte)t < nguong)
                    {
                        t = 0;
                    }
                    else t = 255;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    p += 3;
                }
                p += offset;
            }
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }
        private void btnnhiphan_Click(object sender, EventArgs e)
        {
            
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!", "Image Null");
            }
            else
                pictureboxout.Image = NhiPhan(img, 128);
        }
        unsafe
        private Bitmap AmBan(Bitmap img)
        {
            Bitmap imgtmp = new Bitmap(img.Width, img.Height);
            imgtmp = img;
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite, imgtmp.PixelFormat);
            int offset = imgdata.Stride - 3 * imgtmp.Width;

            byte* p = (byte*)imgdata.Scan0;
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    int t = (p[0] + p[1] + p[2]) / 3;
                    t = 255 - t;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;

                    p += 3;
                }
                p += offset;
            }
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }
        private void btnamban_Click(object sender, EventArgs e)
        {
            
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!", "Image Null");
            }
            else
                pictureboxout.Image = AmBan(img);
        }        
        public static bool LocTrungVi(Bitmap img)
        {
            //Loc trung vi
            Bitmap imgtmp = (Bitmap)img.Clone();
            BitmapData imgdata = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format24bppRgb);
            BitmapData imgtmpdata = imgtmp.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format24bppRgb);
            int stride = imgdata.Stride;
            int stride2 = stride * 2;
            ArrayList list;
            unsafe
            {
                byte* p = (byte*)imgdata.Scan0;
                byte* p1 = (byte*)imgtmpdata.Scan0;
                int nOffset = stride - img.Width * 3;
                int nWidth = img.Width - 2;
                //trừ đi các rìa ảnh
                int nHeight = img.Height - 2;
                int nPixel;
                list = new ArrayList();
                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        for (int i = 0; i < 3; ++i)
                        {
                            list.Add(p1[0]);
                            list.Add(p1[3]);
                            list.Add(p1[6]);
                            list.Add(p1[0 + stride]);
                            list.Add(p1[3 + stride]);
                            list.Add(p1[6 + stride]);
                            list.Add(p1[0 + stride2]);
                            list.Add(p1[3 + stride2]);
                            list.Add(p1[6 + stride2]);
                            list.Sort();
                            nPixel = Convert.ToInt32(list[4]);
                            if (nPixel < 0) nPixel = 0;
                            if (nPixel > 255) nPixel = 255;
                            p[3 + stride] = (byte)nPixel;
                            ++p;
                            ++p1;
                            list.Clear();
                        }
                    }
                    p += nOffset;
                    p1 += nOffset;
                }
            }
            img.UnlockBits(imgdata);
            return true;
        }
        private void btnlocnhieu_Click(object sender, EventArgs e)
        {
            
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!", "Image Null");
            }
            else
            {
                if (LocTrungVi(img))
                {
                    pictureboxout.Image = img;
                }
            }

                
        }
        private void btndobien_Click_1(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!", "Image Null");
            }
            else
                MessageBox.Show("Chức năng đang hoàn thiện!", "Image Null");
        }
        unsafe
        private Bitmap BienDoiLog(Bitmap img)
        {
            Bitmap imgtmp = new Bitmap(img.Width, img.Height);
            imgtmp = img;
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite, imgtmp.PixelFormat);
            int offset = imgdata.Stride - 3 * imgtmp.Width;

            byte* p = (byte*)imgdata.Scan0;
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    int t = (p[0] + p[1] + p[2]) / 3;
                    t = (byte)Math.Log(1 + t);
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;

                    p += 3;
                }
                p += offset;
            }
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }
        //Hàm lưu ảnh
        private void btluuanh_Click(object sender, EventArgs e)
        {
            if (pictureboxout.Image == null)
            {
                MessageBox.Show("Ảnh chưa đựơc xử lý!", "Image Null");
            }
            else
            {
                SaveFileDialog saveimg = new SaveFileDialog();
                saveimg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveimg.Title = "Save an Image File";
                saveimg.InitialDirectory = @"D:\Documents\Xu ly anh\XLA\XLA\Image\ImgOutput\";

                if (saveimg.ShowDialog() == DialogResult.OK)
                {
                    pictureboxout.Image.Save(saveimg.FileName);
                    MessageBox.Show("Ảnh đã được lưu!", "Save Image");
                }
            }
        }

        
    }
}