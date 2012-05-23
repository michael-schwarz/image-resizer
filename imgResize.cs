// mbscWare Image Resizer: Resizes images
// German version called "mbscWare Bildverkleinerer"
// Copyright (C) 2010-2012  Michael Schwarz
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 3
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace resizer
{

	public class imgResize
	{
		public imgResize()
		{
		}
		
		#region Recursive overloads of resize(...) that do nothing but call resize() with quality set to -1 (= quality won't be changed)
		/// <summary>
		/// Resizes an image to a fixed size
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="width">new width</param>
		/// <param name="height">new height</param>
		/// <param name="format">new ImageFormat</param>
		public static void resize(string input,string output,int width,int height,ImageFormat format)
		{
			resize(input,output,width,height,format,-1);
		}
		
		/// <summary>
		/// Resizes an image
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="size1">size (either width or height)</param>
		/// <param name="size_type">true: size1 is width
		/// false: size1 is height </param>
		/// <param name="format">new ImageFormat</param>
		public static void resize(string input,string output,int size1,bool size_type,ImageFormat format)
		{
			resize(input,output,size1,size_type,format,-1);
		}
		
		/// <summary>
		/// Resizes an image to a fixed size
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="width">new width</param>
		/// <param name="height">new height</param>
		public static void resize(string input,string output,int width,int height)
		{
			resize(input,output,width,height,-1);
		}
		
		/// <summary>
		/// Resizes an image: New_size = Old_size*percent
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="percent">factor of resizing</param>
		public static void resize(string input,string output,double percent)
		{
			resize(input,output,percent,-1);
		}
		
		/// <summary>
		/// Resizes an image: New_size = Old_size*percent
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="percent">factor of resizing</param>
		/// <param name="format">new ImageFormat</param>
		public static void resize(string input,string output,double percent,ImageFormat format)
		{
			resize(input,output,percent,format);
		}
		
		/// <summary>
		/// Resizes an image
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="size1">size (either width or height)</param>
		/// <param name="size_type">true: size1 is width
		/// false: size1 is height </param>
		public static void resize(string input,string output,int size1,bool size_type)
		{
			resize(input,output,size1,size_type,-1);
		}
		#endregion
		
		
		
		/// <summary>
		/// Resizes an image to a fixed size
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="width">new width</param>
		/// <param name="height">new height</param>
		/// <param name="format">new ImageFormat</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,int width,int height,ImageFormat format,long quality)
		{
			saveResizedPicture(resize_do(Image.FromFile(input),width,height),output,format,quality);	
		}
		
		
		/// <summary>
		/// Resizes an image to a fixed size
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="width">new width</param>
		/// <param name="height">new height</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,int width,int height,long quality)
		{
			Image picture = Image.FromFile(input);
			
			ImageFormat format = picture.RawFormat;
			
			saveResizedPicture(resize_do(picture,width,height),output,format,quality);		
		}
		
		
		/// <summary>
		/// Resizes an image: New_size = Old_size*percent
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="percent">factor of resizing</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,double percent,long quality)
		{
			Image picture = Image.FromFile(input);
			
			int width = Convert.ToInt32(picture.Size.Width*percent);
			int height = Convert.ToInt32(picture.Size.Height*percent);
			
			ImageFormat format = picture.RawFormat;
			
			saveResizedPicture(resize_do(picture,width,height),output,format,quality);	
		}
		

		
		/// <summary>
		/// Resizes an image: New_size = Old_size*percent
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="percent">factor of resizing</param>
		/// <param name="format">new ImageFormat</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,double percent,ImageFormat format,long quality)
		{
			Image picture = Image.FromFile(input);
			
			int width = Convert.ToInt32(picture.Size.Width*percent);
			int height = Convert.ToInt32(picture.Size.Height*percent);
				
			saveResizedPicture(resize_do(picture,width,height),output,format,quality);			
		}
		
		

		/// <summary>
		/// Resizes an image
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="size1">size (either width or height)</param>
		/// <param name="size_type">true: size1 is width
		/// false: size1 is height </param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,int size1,bool size_type,long quality)
		{
			Image picture = Image.FromFile(input);
			
			ImageFormat format = picture.RawFormat;
			
			int width = 0;
			int height = 0;
			
			if(size_type)
			{
				width = size1;
				double f = Convert.ToDouble(width)/Convert.ToDouble(picture.Size.Width);
				height = Convert.ToInt32(f*picture.Size.Height);					
			}
			
			else
			{
				height = size1;
				double f = Convert.ToDouble(height)/Convert.ToDouble(picture.Size.Height);
				width = Convert.ToInt32(f*picture.Size.Width);					
			}
			
			saveResizedPicture(resize_do(picture,width,height),output,format,quality);						
		}
		


		/// <summary>
		/// Resizes an image
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="size1">size (either width or height)</param>
		/// <param name="size_type">true: size1 is width
		/// false: size1 is height </param>
		/// <param name="format">new ImageFormat</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		public static void resize(string input,string output,int size1,bool size_type,ImageFormat format,long quality)
		{
			Image picture = Image.FromFile(input);
			
			int width = 0;
			int height = 0;
			
			if(size_type)
				{
					width = size1;
					double f = Convert.ToDouble(width)/Convert.ToDouble(picture.Size.Width);
					height = Convert.ToInt32(f*picture.Size.Height);					
				}
			
			else
				{
					height = size1;
					double f = Convert.ToDouble(height)/Convert.ToDouble(picture.Size.Height);
					width = Convert.ToInt32(f*picture.Size.Width);					
				}
			
			saveResizedPicture(resize_do(picture,width,height),output,format,quality);					
		}
		
		
		#region Private methods that do the actual resizing and saving
		
		/// <summary>
		/// Internal method that does the saving of the file
		/// </summary>
		/// <param name="i">resized Image</param>
		/// <param name="file">path of the file</param>
		/// <param name="f">ImageFormat the file should be saved in</param>
		/// <param name="quality">jpeg-quality between 0 and 100; -1 to use standard values or if image is not to be saved as jpeg</param>
		private static void saveResizedPicture(Image i,string file,ImageFormat f,long quality)
		{
			if(quality == -1 || f != ImageFormat.Jpeg)
			{
				i.Save(file,f);
			}
			else
			{
				if(quality < 0 || quality > 100)
				{
					throw new ArgumentOutOfRangeException("Quality must be between 0 and 100");
				}
				
				
				ImageCodecInfo enc = getEncoderInfo("image/jpeg");
				EncoderParameters encParams = new EncoderParameters(1);
				encParams.Param[0] = new EncoderParameter(Encoder.Quality,quality);	
				
				i.Save(file,enc,encParams);
			}
				
			
		}
		
		/// <summary>
		/// Find the ImageCodecInfo for a specific mimeType
		/// </summary>
		/// <param name="mimeType">the mimeType to look for</param>
		/// <returns>ImageCodecInfo or null if there is non for mimeType</returns>
		private static ImageCodecInfo getEncoderInfo(string mimeType)
		{
    		ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
   			for(int i = 0; i < encoders.Length; i++)
    		{
        		if(encoders[i].MimeType == mimeType)
        		{
            		return encoders[i];
        		}
    		}
    		
   			// Not found -> return null
   			return null;
		}
		
		
		/// <summary>
		/// Internal function that does the actual resizing
		/// </summary>
		/// <param name="input">Image that should be resized</param>
		/// <param name="width">New width</param>
		/// <param name="height">New height</param>
		/// <returns>Resized Image</returns>
		private static Image resize_do(Image input,int width,int height)
		{
			if(width<1)
			{
				width =1;
			}
			
			if(height<1)
			{
				height=1;
			}
			return new System.Drawing.Bitmap(input, width, height);
		}
		
		#endregion
	}
}
