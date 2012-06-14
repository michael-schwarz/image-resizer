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
using System.IO;
using System.Media;
using System.Threading;
using System.Globalization;
using System.Resources;


namespace resizer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string textBox1OldText = "s-";
		string textBox2OldText = "smaller";
		
		bool enabled_input = false;
		bool enabled_resizing = true;
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.single_file.Checked = true;
			this.percent.Checked = true;
			this.auto_height.Checked = true;
			this.comboBox1.SelectedIndex = 0;
			assignNames();

					
		}
		
		public void enableInput(bool v,string i)
		{	
			this.ok.Enabled = (enabled_resizing && v);
			enabled_input = v;			
		}
		
		public void enableResizing(bool v,string i)
		{	
			this.ok.Enabled = (enabled_input && v);
			enabled_resizing = v;			
		}
		
		
	/// <summary>
	/// Builds the new path for the resized version
	/// </summary>
	/// <param name="old">path of the original version</param>
	/// <returns>path where the resized version is to be stored</returns>
		private string createNewPath(string old)
		{
			string filename = Path.GetFileName(old);
			string path = Path.GetDirectoryName(old);
			
			
			// Changes the extension if this is required
			if(!this.use_same_type.Checked)
			{
				string ex = "";
				string selectedFormatString = "";
				this.Invoke(new MethodInvoker(delegate() 
			                              { 
			                              	selectedFormatString = this.comboBox1.SelectedItem.ToString();
			                              }
			           ));
				
				
				if(selectedFormatString == "PNG")
				{
					ex = ".png";
				}
				if(selectedFormatString == "JPG")
				{
					ex = ".jpg";
				}
				if(selectedFormatString == "BMP")
				{
					ex = ".bmp";
				}
				if(selectedFormatString == "TIFF")
				{
					ex = ".tiff";
				}
				if(selectedFormatString== "GIF")
				{
					ex = ".gif";
				}

				filename = filename.Replace(Path.GetExtension(filename),ex);								
			}
			
			
			
			
			// Add prefix if selected
			if(this.add_prefix.Checked)
			{
				filename = String.Concat(textBox1.Text,filename);
			}
			
			// Add new subfolder to path if required and return it
			if(this.new_subfolder.Checked && this.textBox2.Text!= "")
			{
				string p = Path.Combine(String.Concat(path,Path.DirectorySeparatorChar.ToString(),this.textBox2.Text,Path.DirectorySeparatorChar.ToString()),filename);
				
				string d = Path.GetDirectoryName(p);
				if(!Directory.Exists(d))
						{
							System.IO.Directory.CreateDirectory(d);
						}
				
				return p;
			}
			else
			{
				// rteurn path if no new subfolder needed to be added
				return Path.Combine(path,filename);
			}
			
		}
		
		
		void Browse_singleClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if(openFileDialog1.FileName != "")
				{
					this.input_single.Text = openFileDialog1.FileName;
					
				}
		}
		
		void Browse_directoryClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			if(folderBrowserDialog1.SelectedPath != "")
				{
					this.input_directory.Text = folderBrowserDialog1.SelectedPath;
					
				}
		}
		
		void Single_fileCheckedChanged(object sender, EventArgs e)
		{
			bool state_sf = this.single_file.Checked;

			this.input_directory.Enabled = !state_sf;
			this.browse_directory.Enabled = !state_sf;
			this.include_subdirs.Enabled = !state_sf;
			this.input_single.Enabled = state_sf;
			this.browse_single.Enabled = state_sf;
			
			if(state_sf)
			{
				if(this.input_single.Text  != "")
					{
					enableInput(true,Guid.NewGuid().ToString());
					}
				else
					{
					enableInput(false,Guid.NewGuid().ToString());
					}	
			}
			
			else
			{
				if(this.input_directory.Text  != "")
					{
						enableInput(true,Guid.NewGuid().ToString());
					}
				else
					{
						enableInput(false,Guid.NewGuid().ToString());
					}		
			}

		}
		
		void ResizingEnter(object sender, EventArgs e)
		{
			
		}
		
		void resize_function(string i)
		{
			try
			{
			
			string o = createNewPath(i);
			
			if(!this.use_same_type.Checked)
			{
				ImageFormat f = ImageFormat.Jpeg;
				
				string selectedFormatString = "";
				int quality = 100;
				this.Invoke(new MethodInvoker(delegate() 
				                              { 
				                              	selectedFormatString = this.comboBox1.SelectedItem.ToString();
												quality = trackBar1.Value;
				                              }
				           ));
				
				
				if(selectedFormatString == "PNG")
				{
					f = ImageFormat.Png;
				}
		
				if(selectedFormatString == "JPG")
				{
					f = ImageFormat.Jpeg;
				}
				if(selectedFormatString == "BMP")
				{
					f = ImageFormat.Bmp;
				}
				if(selectedFormatString == "TIFF")
				{
					f = ImageFormat.Tiff;
				}
				if(selectedFormatString == "GIF")
				{
					f = ImageFormat.Gif;
				}

		
		
				if(this.percent.Checked)
					{
						double p = Convert.ToDouble(this.percent_input.Text);
						imgResize.resize(i,o,p/100,f,quality);
					}
				else	
					{
	
						
						if(!this.keep_ratio.Checked)
							{
								imgResize.resize(i,o,Convert.ToInt32(width.Text),Convert.ToInt32(height.Text),f,quality);
							}
						else
							{
								if(this.auto_height.Checked)
								{
									imgResize.resize(i,o,Convert.ToInt32(width.Text),true,f,quality);
								}
								
								else
								{
									imgResize.resize(i,o,Convert.ToInt32(height.Text),false,f,quality);
								}
							}
					}
			}
			
			else
			{
				if(this.percent.Checked)
					{
	
						double p = Convert.ToDouble(this.percent_input.Text);
						imgResize.resize(i,o,p/100);
					}
				else	
					{
	
						
						if(!this.keep_ratio.Checked)
							{
								imgResize.resize(i,o,Convert.ToInt32(width.Text),Convert.ToInt32(height.Text));
							}
						else
							{
								if(this.auto_height.Checked)
								{
									imgResize.resize(i,o,Convert.ToInt32(width.Text),true);
								}
								
								else
								{
									imgResize.resize(i,o,Convert.ToInt32(height.Text),false);
								}
							}
					}	
			}



			


		    if (this.label8.InvokeRequired)
		    {
		    	MethodInvoker method = delegate
        					{
		    				 	this.label8.Text = (Convert.ToInt32(this.label8.Text)+1).ToString();
        					};
		    	label8.Invoke(method);
		    }
		    else
		    {		      
		    	this.label8.Text = (Convert.ToInt32(this.label8.Text)+1).ToString();
		    }

			}
			catch(IOException)
			{
				ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);			
				MessageBox.Show("" + ((string)resourceManager.GetObject("error_acessing_file_1")) + i + ((string)resourceManager.GetObject("error_acessing_file_2")) + "",(string)resourceManager.GetObject("error"),MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			catch(Exception)
			{
				ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);			
				MessageBox.Show("" + ((string)resourceManager.GetObject("resizing_failed_1")) + i + ((string)resourceManager.GetObject("resizing_failed_2")) + "",(string)resourceManager.GetObject("error"),MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void OkClick(object sender, EventArgs e)
		{		
			if((add_prefix.Checked && !String.IsNullOrEmpty(textBox1.Text)) || (new_subfolder.Checked && !String.IsNullOrEmpty(textBox2.Text)))
			{	
				this.label8.Text = "0";
				backgroundWorker1.RunWorkerAsync();
				this.output.Enabled = false;
				this.input.Enabled = false;
				this.resizing.Enabled = false;
				this.ok.Enabled = false;
			}
			else
			{
				ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);			
				MessageBox.Show(((string)resourceManager.GetObject("choose_at_least_prefix_or_folder")),(string)resourceManager.GetObject("error"),MessageBoxButtons.OK,MessageBoxIcon.Error);

			}
		}	
		
		void resizeDirectory(string d)
		{
			if(include_subdirs.Checked)
				{
					//It's important to do this before starting to resize the folder's contents, because otherwise the resizer will resize
					//images in an endless loop (if create_new_subdir is enabled) because it will find it's own output folder
					string[] dirs = Directory.GetDirectories(d);
					
					
					foreach(string f in dirs)
					{
						resizeDirectory(f);
					}	
				}
			
			
			
			foreach(string f in Directory.GetFiles(d))
				{
					string e = Path.GetExtension(f).ToLower();
					if(e == ".jpg" || e == ".jpeg" || e == ".png" || e == ".tiff" || e == ".bmp" || e == ".gif")
					{
						resize_function(f);
					}	
				}
			

			
			
		}
			
			
		void Keep_ratioCheckedChanged(object sender, EventArgs e)
		{
			this.auto_width.Enabled = keep_ratio.Checked;
			this.auto_height.Enabled = keep_ratio.Checked;
			
			if(this.keep_ratio.Checked)
			{
				Auto_widthCheckedChanged(new object(),EventArgs.Empty);
			}
			else
			{
				this.width.Enabled = true;
				this.height.Enabled = true;
			}
		}
		
		void FixCheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.fix.Checked;
			this.percent_input.Enabled = !this.fix.Checked;
			
		}
		
		void Auto_widthCheckedChanged(object sender, EventArgs e)
		{
			this.width.Enabled = !this.auto_width.Checked;
			this.height.Enabled = this.auto_width.Checked;
		}
		
		
		void HeightEnabledChanged(object sender, EventArgs e)
		{
			if(this.fix.Checked == true)
			{
				this.label4.Visible = !this.height.Enabled;
				this.height.Visible = this.height.Enabled;
				this.label2.Visible = this.height.Enabled;
				WidthTextChanged(new object(), EventArgs.Empty);
			}
		}
		

		
		void WidthEnabledChanged(object sender, EventArgs e)
		{			
			if(this.fix.Checked == true)
			{
				this.label5.Visible = !this.width.Enabled;
				this.width.Visible = this.width.Enabled;
				this.label3.Visible = this.width.Enabled;
				WidthTextChanged(new object(), EventArgs.Empty);
			}
		}
		
		void Use_same_typeCheckedChanged(object sender, EventArgs e)
		{
			this.comboBox1.Visible = !use_same_type.Checked;
			this.label7.Visible = !use_same_type.Checked;
			
			if(use_same_type.Checked)
			{
				this.jpeg_quality.Visible = false;
				this.trackBar1.Visible = false;
				this.label11.Visible = false;
			}
			else if(comboBox1.SelectedIndex == 1)
			{

				this.jpeg_quality.Visible = true;
				this.trackBar1.Visible = true;
				this.label11.Visible = true;
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text.Contains("/") || textBox1.Text.Contains("\\") || textBox1.Text.Contains(":") || textBox1.Text.Contains("*") || textBox1.Text.Contains("?") ||textBox1.Text.Contains("\"") || textBox1.Text.Contains("<") || textBox1.Text.Contains(">") ||textBox1.Text.Contains("|"))
			{
				textBox1.Text = textBox1OldText;
				panel3.Visible = true;
			}
			else
			{
				textBox1OldText = textBox1.Text;
			}
		
		}
		
		void assignNames()
		{
			ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);
			
			this.single_file.Text = (string)resourceManager.GetObject("single_file");
			this.directory.Text = (string)resourceManager.GetObject("all_in_directory");
			this.include_subdirs.Text = (string)resourceManager.GetObject("include_subdirs");
			this.browse_directory.Text = (string)resourceManager.GetObject("browse");
			this.browse_single.Text = (string)resourceManager.GetObject("browse");
			this.input.Text = (string)resourceManager.GetObject("source_file");
			this.resizing.Text = (string)resourceManager.GetObject("wanted_size");
			this.percent.Text = (string)resourceManager.GetObject("percent");
			this.fix.Text = (string)resourceManager.GetObject("fix");
			this.auto.Text = (string)resourceManager.GetObject("keep_ratio");
			this.auto_width.Text = (string)resourceManager.GetObject("auto_width");
			this.auto_height.Text = (string)resourceManager.GetObject("auto_height");
			this.keep_ratio.Text = (string)resourceManager.GetObject("auto_one_dimension");
			this.output.Text = (string)resourceManager.GetObject("output_options");
			this.add_prefix.Text = (string)resourceManager.GetObject("add_prefix");
			this.new_subfolder.Text = (string)resourceManager.GetObject("use_new_subfolder");
			this.use_same_type.Text = (string)resourceManager.GetObject("keep_format");
			this.label7.Text = (string)resourceManager.GetObject("format_to_use");
			this.label6.Text = (string)resourceManager.GetObject("error_invalid_characters");
			this.ok.Text = (string)resourceManager.GetObject("resize");
			this.label9.Text = (string)resourceManager.GetObject("resized");
			this.Text = (string)resourceManager.GetObject("program_name");
			this.linkLabel1.Text = (string)resourceManager.GetObject("about");
			this.label10.Text = (string)resourceManager.GetObject("name_and_license");
			this.jpeg_quality.Text = (string)resourceManager.GetObject("jpeg_quality");
		}
		
		void Panel3VisibleChanged(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			this.panel3.Visible = false;
		}
		
		void Add_prefixCheckedChanged(object sender, EventArgs e)
		{
			this.textBox1.Enabled = this.add_prefix.Checked;
		}
		
		void New_subfolderCheckedChanged(object sender, EventArgs e)
		{
			this.textBox2.Enabled = this.new_subfolder.Checked;
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if(textBox2.Text.Contains("/") || textBox2.Text.Contains("\\") || textBox2.Text.Contains(":") || textBox2.Text.Contains("*") || textBox2.Text.Contains("?") ||textBox2.Text.Contains("\"") || textBox2.Text.Contains("<") || textBox2.Text.Contains(">") ||textBox2.Text.Contains("|"))
			{
				textBox2.Text = textBox2OldText;
				panel3.Visible = true;
			}
			else
			{
				textBox2OldText = textBox2.Text;
			}
		}
		
		void InputFieldsTextChanged(object sender, EventArgs e)
		{
			if(((TextBox)sender).Text != "")
			{
				this.enableInput(true,Guid.NewGuid().ToString());
			}
			else
			{
				this.enableInput(false,Guid.NewGuid().ToString());
			}
		}
		
		/// <summary>
		/// Shows a messageBox that tells the user what's wrong
		/// </summary>
		/// <param name="errorType">0: Percent not an int
		/// 1: Width and/or height not an int
		/// </param>
		void showErrorMessage(int errorType)
		{
			ResourceManager resourceManager = new ResourceManager ("resizer.language",GetType ().Assembly);
			
			string message = "";
			if(errorType == 0)
			{
				message = "error_percent_not_int";
			}
			else if(errorType == 1)
			{
				message = "error_width_height_not_int";
			}
			else if(errorType == 2)
			{
				message = "error_file_not_found";
			}
			else if(errorType == 3)
			{
				message = "error_folder_not_found";
			}			
			else
			{
				// Hopefully, will be notice before final release
				throw new NotImplementedException("No such error number");
			}
			
			MessageBox.Show((string)resourceManager.GetObject(message),(string)resourceManager.GetObject("error"),MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		
		
		
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			bool everythingOK = true;
			
			if(this.percent.Checked)
			{
				try
				{
					double w = Convert.ToDouble(this.percent_input.Text);					
				}
				catch(Exception)
				{
					everythingOK = false;
					showErrorMessage(0);
				}
			}
			else
			{				
				try
				{
					if(this.width.Enabled)
					{
						int w = Convert.ToInt32(this.width.Text);
					}
					
					if(this.height.Enabled)
					{
						int w = Convert.ToInt32(this.height.Text);
					}
				}
				catch(Exception)
				{
					everythingOK = false;
					showErrorMessage(1);
				}
			}
			
			
			if(everythingOK)
			{
				
					if(this.single_file.Checked)
					{				
						if(File.Exists(this.input_single.Text))
						  {				
							resize_function(this.input_single.Text);
						  }
						else
						  {
						 	showErrorMessage(2);
						  }
					}
					
					else
					{
						if(Directory.Exists(this.input_directory.Text))
							{
								resizeDirectory(this.input_directory.Text);
							}
						else
						 	{
						 		showErrorMessage(3);
						 	}
					}
				}
				

			
		}
		
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			SystemSounds.Asterisk.Play();
			this.output.Enabled =true;
			this.input.Enabled = true;
			this.resizing.Enabled = true;
			this.ok.Enabled = true;
			
		}
		
		
		void Percent_inputTextChanged(object sender, EventArgs e)
		{
			if(this.percent_input.Text == "")
			{
				enableResizing(false,Guid.NewGuid().ToString());
			}
			
			if(this.percent_input.Text != "")
			{
				enableResizing(true,Guid.NewGuid().ToString());
			}
		}
		
		void WidthTextChanged(object sender, EventArgs e)
		{
			if((((this.width.Text != "" && this.auto_height.Checked) || (this.height.Text != ""  && this.auto_width.Checked)) && this.keep_ratio.Checked) || (this.width.Text != "" && this.height.Text != ""))
			{
				enableResizing(true,Guid.NewGuid().ToString());
			}
			else
			{
				enableResizing(false,Guid.NewGuid().ToString());
			}
			
		}


		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new about_st().ShowDialog();
		}

	
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			bool v = (comboBox1.SelectedIndex == 1);

			this.jpeg_quality.Visible = v;
			this.trackBar1.Visible = v;
			this.label11.Visible = v;
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			this.label11.Text = trackBar1.Value.ToString();
		}
	}
}
