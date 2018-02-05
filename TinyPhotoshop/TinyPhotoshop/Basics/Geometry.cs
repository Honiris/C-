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
			//FIXME
			throw new NotImplementedException();
		}

        public static Image SymmetryHorizontal(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
        
        public static Image SymmetryVertical(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
        
        public static Image SymmetryPoint(Bitmap img, int x, int y)
        {
			//FIXME
			throw new NotImplementedException();
		}
        
        public static Image RotationLeft(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
        
        public static Image RotationRight(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
    }
}