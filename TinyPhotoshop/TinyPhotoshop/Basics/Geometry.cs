using System;
using System.Drawing;
using System.Net.Mime;
using System.Security.Policy;


namespace TinyPhotoshop
{
    public static class Geometry
    {      
        public static Image Resize(Bitmap img, int x, int y)
        {
	        int xx = img.Width;
	        int yy = img.Height;
	        Color[,] copy = new Color[y, x];

	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        copy[j, i] = img.GetPixel(j, i);
		        }
	        }
	        
	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        img.SetPixel(i, j, copy[(j + y) % y, (i + x) % x]);
		        }
	        }

	        return img;
        }
        
        public static Image Shift(Bitmap img, int x, int y)
        {
	        int xx = img.Width;
	        int yy = img.Height;
	        Color[,] copy = new Color[yy, xx];

	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        copy[j, i] = img.GetPixel(i, j);
		        }
	        }
	        
	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        img.SetPixel(i, j, copy[(j + y) % yy, (i + x) % xx]);
		        }
	        }

	        return img;
        }

        public static Image SymmetryHorizontal(Bitmap img)
        {
	        int xx = img.Width;
	        int yy = img.Height;
	        Color[,] copy = new Color[yy, xx];

	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        copy[j, i] = img.GetPixel(i, j);
		        }
	        }
	        
	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        img.SetPixel(i, yy - j, copy[j, i]);
		        }
	        }

	        return img;
		}
        
        public static Image SymmetryVertical(Bitmap img)
        {
	        int xx = img.Width;
	        int yy = img.Height;
	        Color[,] copy = new Color[yy, xx];

	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        copy[j, i] = img.GetPixel(i, j);
		        }
	        }
	        
	        for (int i = 0; i < xx; i++)
	        {
		        for (int j = 0; j < yy; j++)
		        {
			        img.SetPixel(xx - i, j, copy[j, i]);
		        }
	        }

	        return img;
		}
        
        public static Image SymmetryPoint(Bitmap img, int x, int y)
        {
			//FIXME
	        return img;
		}
        
        public static Image RotationLeft(Bitmap img)
        {
			//FIXME
	        return img;
		}
        
        public static Image RotationRight(Bitmap img)
        {
			//FIXME
	        return img;
		}
    }
}