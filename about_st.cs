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
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace resizer
{

	public partial class about_st : Form
	{
		public about_st()
		{
			InitializeComponent();
			textBox2.Text = Application.ProductVersion;

			
			
			ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);
			
			this.Text = (string)resourceManager.GetObject("about_image_resizer");
			this.label3.Text = (string)resourceManager.GetObject("open_source_message");
			this.label2.Text = (string)resourceManager.GetObject("icon_copyright");
			this.label5.Text = (string)resourceManager.GetObject("version");
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);
			System.Diagnostics.Process.Start((string)resourceManager.GetObject("support_uri"));
		}
	}
}
