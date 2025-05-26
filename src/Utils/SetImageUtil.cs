using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BTL_C_.src.Utils
{
  internal class SetImageUtil
  {
    public static void SetImageFromUrl(Control control, string imageUrl)
    {
      using (WebClient wc = new WebClient())
      using (var stream = wc.OpenRead(imageUrl))
      {
        if (stream != null)
        {
          Image img = Image.FromStream(stream);

          // Gắn ảnh dựa trên loại control
          if (control is Button btn)
          {
            btn.Image = img;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
          }
          else if (control is Label lbl)
          {
            lbl.Image = img;
            lbl.ImageAlign = ContentAlignment.MiddleCenter;
          }
          else if (control is PictureBox pb)
          {
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
          }
        }
      }
    }
  }
}
