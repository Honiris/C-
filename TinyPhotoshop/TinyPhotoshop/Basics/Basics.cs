using System;
using System.Drawing;

namespace TinyPhotoshop
{
    public static class Basics
    {
        public static Color Grey(Color color)
        {
	        Color gray = Color.FromArgb((int) Math.Floor(color.R * 0.2126),
		                                (int) Math.Floor(color.G * 0.7152),
		                                (int) Math.Floor(color.B * 0.0722));
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

	        Color bc = Color.FromArgb(r, g, b);

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
			//FIXME
			throw new NotImplementedException();
		}

        public static Image Apply(Bitmap img, Func<Color, Color> func)
        {
			//FIXME
			throw new NotImplementedException();
		}
    }
}