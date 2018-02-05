using System;
using System.Drawing;

namespace TinyPhotoshop
{
    public static class Basics
    {
        public static Color Grey(Color color)
        {
	        double r = (double)color.R;
	        double g = (double)color.G;
	        double b = (double)color.B;
	        int moy = (int)Math.Floor((r + g + b) / 3);
	        Color gray = Color.FromArgb(moy, moy, moy);
	        return gray;
        }

        public static Color Binarize(Color color)
        {
			double moy = ((double)color.R + (double)color.G + (double)color.B) / 3;
	        return (moy >= 127.5) ? Color.White : Color.Black;
        }
        
        public static Color BinarizeColor(Color color)
        {
	        double r = (double)color.R;
	        double g = (double)color.G;
	        double b = (double)color.B;
	        
	        r = (r >= 127.5) ? 255 : 0;
	        g = (g >= 127.5) ? 255 : 0;
	        b = (b >= 127.5) ? 255 : 0;

	        Color bc = Color.FromArgb((int)r, (int)g, (int)b);

	        return bc;
        }
        
        public static Color Negative(Color color)
        {
	        int r = color.R;
	        int g = color.G;
	        int b = color.B;

	        r = 255 - r;
	        g = 255 - g;
	        b = 255 - b;
			
	        Color bc = Color.FromArgb(r, g, b);

	        return bc;
		}
        
        public static Color Tinter(Color color, Color tint, int factor)
        {
	        int r = color.R;
	        int g = color.G;
	        int b = color.B;
	        double rr = tint.R;
	        double gg = tint.G;
	        double bb = tint.B;
	        int rrr = r * factor / 100 + (int)Math.Floor(rr * (1 - (double)factor / 100));
	        int ggg = g * factor / 100 + (int)Math.Floor(gg * (1 - (double)factor / 100));
	        int bbb = b * factor / 100 + (int)Math.Floor(bb * (1 - (double)factor / 100));
	        
	        Color bc = Color.FromArgb(rrr, ggg, bbb);

	        return bc;
        }

        public static Image Apply(Bitmap img, Func<Color, Color> func)
        {
	        int x = img.Width;
	        int y = img.Height;
	        
	        for (int i = 0; i < x; i++)
	        {
		        for (int j = 0; j < y; j++)
		        {
			        img.SetPixel(i, j, func(img.GetPixel(i, j)));
		        }
	        }

	        return img;
        }
    }
}
