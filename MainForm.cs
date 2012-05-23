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
			language_support(0);

					
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
		

		private string createNewPath(string old)
		{
			string filename = Path.GetFileName(old);
			string path = Path.GetDirectoryName(old);
			
			if(this.add_prefix.Checked)
			{
				if(!this.use_same_type.Checked)
				{
					string ex = "";
					
					if(this.comboBox1.SelectedItem.ToString() == "PNG")
					{
						ex = ".png";
					}

					if(this.comboBox1.SelectedItem.ToString() == "JPG")
					{
						ex = ".jpg";
					}
					if(this.comboBox1.SelectedItem.ToString() == "BMP")
					{
						ex = ".bmp";
					}
					if(this.comboBox1.SelectedItem.ToString() == "TIFF")
					{
						ex = ".tiff";
					}
					if(this.comboBox1.SelectedItem.ToString() == "GIF")
					{
						ex = ".gif";
					}

					filename = filename.Replace(Path.GetExtension(filename),ex);
					
					
				}
				
				
				filename = String.Concat(textBox1.Text,filename);
			}
			
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
				
				if(this.comboBox1.SelectedItem.ToString() == "PNG")
				{
					f = ImageFormat.Png;
				}
		
				if(this.comboBox1.SelectedItem.ToString() == "JPG")
				{
					f = ImageFormat.Jpeg;
				}
				if(this.comboBox1.SelectedItem.ToString() == "BMP")
				{
					f = ImageFormat.Bmp;
				}
				if(this.comboBox1.SelectedItem.ToString() == "TIFF")
				{
					f = ImageFormat.Tiff;
				}
				if(this.comboBox1.SelectedItem.ToString() == "GIF")
				{
					f = ImageFormat.Gif;
				}

		
		
				if(this.percent.Checked)
					{
						double p = Convert.ToDouble(this.percent_input.Text);
						imgResize.resize(i,o,p/100,f);
					}
				else	
					{
	
						
						if(!this.keep_ratio.Checked)
							{
								imgResize.resize(i,o,Convert.ToInt32(width.Text),Convert.ToInt32(height.Text),f);
							}
						else
							{
								if(this.auto_height.Checked)
								{
									imgResize.resize(i,o,Convert.ToInt32(width.Text),true,f);
								}
								
								else
								{
									imgResize.resize(i,o,Convert.ToInt32(height.Text),false,f);
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
				MessageBox.Show("Fehler beim Dateizugriff.\\r\\nDatei unter " + i +" konnte nicht verkleinert werden.","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			catch(Exception)
			{
				MessageBox.Show("Die Datei unter " + i +" konnte nicht verkleinert werden.","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void OkClick(object sender, EventArgs e)
		{		
			this.label8.Text = "0";
			backgroundWorker1.RunWorkerAsync();
			this.output.Enabled = false;
			this.input.Enabled = false;
			this.resizing.Enabled = false;
			this.ok.Enabled = false;
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
		
		void language_support(int lang)
		{
			if(lang == 0)
			{
				this.single_file.Text = "Eine einzelne Datei verkleinern";
				this.directory.Text = "Alle Dateien in einem Verzeichnis verkleinern";
				this.include_subdirs.Text = "Unterverzeichnisse mit einbeziehen";
				this.browse_directory.Text = "Durchsuchen";
				this.browse_single.Text = "Durchsuchen";
				this.input.Text = "Quelldateien";
				this.resizing.Text = "Gewünschte Größe";
				this.percent.Text = "Prozentual";
				this.fix.Text ="Absolut";
				this.auto.Text ="Seitenverhältnisse beibehalten";
				this.auto_width.Text = "Breite angleichen";
				this.auto_height.Text = "Höhe angelichen";
				this.keep_ratio.Text = "Eine Seitenlänge automatisch angleichen";
				this.output.Text = "Ausgabeoptionen";
				this.add_prefix.Text = "Dem Dateinamen Folgendes vorstellen";
				this.new_subfolder.Text = "Einen neuen Unterordner verwenden";
				this.use_same_type.Text = "Dateiformat beibehalten";
				this.label7.Text = "Zu verwendendes Format";
				this.label6.Text = "Der eingegebene Wert enthält für einen Dateinamen nicht zulässige Zeichen.";
				this.ok.Text = "Bilder verkleinern";
				this.label9.Text = "Verkleinert:";
				this.Text = "programs.xe.cx Bildverkleinerer";
				this.linkLabel1.Text = "Über";
				this.label10.Text = "programs.xe.cx Bildverkleinerer (GNU GPL v3 or later)";
			}
			
			
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
		
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			bool everythingOK = true;
			
			if(this.percent.Checked == true)
			{
				try
				{
					double w = Convert.ToDouble(this.percent_input.Text);					
				}
				catch(Exception)
				{
					everythingOK = false;
					MessageBox.Show("Der Prozentwert ist keine Zahl.","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
					MessageBox.Show("Einer der Werte für Breite / Höhe ist keine ganze Zahl.","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
						 	MessageBox.Show("Diese Datei konnte nicht gefunden werden.","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
						 		MessageBox.Show("Dieses Verzeichnis konnte nicht gefunden werden.","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

		


	}
}
