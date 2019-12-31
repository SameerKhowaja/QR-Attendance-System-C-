using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing.Imaging;

namespace Attendance_System_Manager
{
    public partial class qrCodeGenerator : UserControl
    {
        Bitmap bmp;
        public qrCodeGenerator()
        {
            InitializeComponent();
        }

        int a, b;
        Padding p;

        private void btnEncode_Click(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 12;
            bmp = encoder.Encode(txtEncode.Text);
            pictureBox.Image = bmp;
            pictureBox.BackgroundImageLayout = ImageLayout.Center;

            a = pictureBox.Width - pictureBox.Image.Width;
            b = pictureBox.Height - pictureBox.Image.Height;
            p = new System.Windows.Forms.Padding();
            p.Left = a / 2;
            p.Top = b / 2;
            pictureBox.Padding = p;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                        MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                        txtDecode.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox.Image as Bitmap));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                pictureBox.Image = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            txtEncode.Text = null;
            txtDecode.Text = "...";
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want to Save QRcode?", "Save or Not", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                            bmp.Save(sfd.FileName, ImageFormat.Jpeg);

                            pictureBox.Image = null;
                            txtEncode.Text = null;
                            txtDecode.Text = "...";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Currently No QRCode in Picture...!");
            }
        }
    }
}
