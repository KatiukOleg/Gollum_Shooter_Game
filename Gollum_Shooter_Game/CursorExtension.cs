using System;
using System.Windows.Forms;
using System.Drawing;

namespace Gollum_Shooter_Game
{
    public static class CursorExtension
    {

        public static Cursor ArchedCursor(this Cursor cursor)
        {
            Bitmap bitmap = new Bitmap(@"Pictures\Weapon\archer_small.png");
            bitmap.MakeTransparent(bitmap.GetPixel(0, 0));
            IntPtr patern = bitmap.GetHicon();
            return new Cursor(patern);
        }

    }
}
