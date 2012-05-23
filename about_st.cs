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

namespace resizer
{

	public partial class about_st : Form
	{
		public about_st()
		{
			InitializeComponent();
			textBox2.Text = Application.ProductVersion;

		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://programs.xe.cx/");			
		}
	}
}
