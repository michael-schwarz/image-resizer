// programs.xe.cx Bildverkleinerer: Resizes images
// Copyright (C) 2010  Michael Schwarz
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
			Image picture = resize_do(Image.FromFile(input),width,height);
			picture.Save(output,format);	
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
			Image picture = Image.FromFile(input);
			
			ImageFormat format = picture.RawFormat;
			
			picture = resize_do(picture,width,height);
			picture.Save(output,format);				
		}
		
		/// <summary>
		/// Resizes an image: New_size = Old_size*percent
		/// </summary>
		/// <param name="input">Path + Filename input</param>
		/// <param name="output">Path + Filename output</param>
		/// <param name="percent">factor of resizing</param>
		public static void resize(string input,string output,double percent)
		{
			Image picture = Image.FromFile(input);
			
			int width = Convert.ToInt32(picture.Size.Width*percent);
			int height = Convert.ToInt32(picture.Size.Height*percent);
			
			ImageFormat format = picture.RawFormat;
			
			picture = resize_do(picture,width,height);
			picture.Save(output,format);		
			
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
			Image picture = Image.FromFile(input);
			
			int width = Convert.ToInt32(picture.Size.Width*percent);
			int height = Convert.ToInt32(picture.Size.Height*percent);
				
			picture = resize_do(picture,width,height);
			picture.Save(output,format);		
			
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
			picture = resize_do(picture,width,height);
			picture.Save(output,format);					
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
			picture = resize_do(picture,width,height);
			picture.Save(output,format);					
		}
		
		/// <summary>
		/// Internal function that does the actaul resizing
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
	}
}
