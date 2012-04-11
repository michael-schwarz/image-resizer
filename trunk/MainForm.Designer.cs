/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Michael Schwarz
 * Datum: 03.07.2010
 * Zeit: 12:59
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace resizer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.single_file = new System.Windows.Forms.RadioButton();
			this.directory = new System.Windows.Forms.RadioButton();
			this.input = new System.Windows.Forms.GroupBox();
			this.include_subdirs = new System.Windows.Forms.CheckBox();
			this.input_directory = new System.Windows.Forms.TextBox();
			this.browse_directory = new System.Windows.Forms.Button();
			this.input_single = new System.Windows.Forms.TextBox();
			this.browse_single = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.resizing = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.auto = new System.Windows.Forms.GroupBox();
			this.auto_height = new System.Windows.Forms.RadioButton();
			this.auto_width = new System.Windows.Forms.RadioButton();
			this.keep_ratio = new System.Windows.Forms.CheckBox();
			this.width = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fix = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.percent_input = new System.Windows.Forms.TextBox();
			this.percent = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.ok = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.use_same_type = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.new_subfolder = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.add_prefix = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.input.SuspendLayout();
			this.resizing.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.auto.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.output.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// single_file
			// 
			this.single_file.Location = new System.Drawing.Point(6, 19);
			this.single_file.Name = "single_file";
			this.single_file.Size = new System.Drawing.Size(557, 24);
			this.single_file.TabIndex = 0;
			this.single_file.TabStop = true;
			this.single_file.Text = "single_file Lorem ipsum dolor sit amet";
			this.single_file.UseVisualStyleBackColor = true;
			this.single_file.CheckedChanged += new System.EventHandler(this.Single_fileCheckedChanged);
			// 
			// directory
			// 
			this.directory.Location = new System.Drawing.Point(6, 78);
			this.directory.Name = "directory";
			this.directory.Size = new System.Drawing.Size(557, 24);
			this.directory.TabIndex = 1;
			this.directory.TabStop = true;
			this.directory.Text = "directory  Lorem ipsum dolor sit amet";
			this.directory.UseVisualStyleBackColor = true;
			// 
			// input
			// 
			this.input.Controls.Add(this.include_subdirs);
			this.input.Controls.Add(this.input_directory);
			this.input.Controls.Add(this.browse_directory);
			this.input.Controls.Add(this.input_single);
			this.input.Controls.Add(this.browse_single);
			this.input.Controls.Add(this.directory);
			this.input.Controls.Add(this.single_file);
			this.input.Location = new System.Drawing.Point(12, 12);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(580, 164);
			this.input.TabIndex = 2;
			this.input.TabStop = false;
			this.input.Text = "input";
			// 
			// include_subdirs
			// 
			this.include_subdirs.Location = new System.Drawing.Point(26, 134);
			this.include_subdirs.Name = "include_subdirs";
			this.include_subdirs.Size = new System.Drawing.Size(537, 24);
			this.include_subdirs.TabIndex = 6;
			this.include_subdirs.Text = "include_subdirs";
			this.include_subdirs.UseVisualStyleBackColor = true;
			// 
			// input_directory
			// 
			this.input_directory.Location = new System.Drawing.Point(26, 108);
			this.input_directory.Name = "input_directory";
			this.input_directory.Size = new System.Drawing.Size(447, 20);
			this.input_directory.TabIndex = 5;
			this.input_directory.TextChanged += new System.EventHandler(this.InputFieldsTextChanged);
			// 
			// browse_directory
			// 
			this.browse_directory.Location = new System.Drawing.Point(479, 106);
			this.browse_directory.Name = "browse_directory";
			this.browse_directory.Size = new System.Drawing.Size(84, 23);
			this.browse_directory.TabIndex = 4;
			this.browse_directory.Text = "browse";
			this.browse_directory.UseVisualStyleBackColor = true;
			this.browse_directory.Click += new System.EventHandler(this.Browse_directoryClick);
			// 
			// input_single
			// 
			this.input_single.Location = new System.Drawing.Point(26, 49);
			this.input_single.Name = "input_single";
			this.input_single.Size = new System.Drawing.Size(447, 20);
			this.input_single.TabIndex = 3;
			this.input_single.TextChanged += new System.EventHandler(this.InputFieldsTextChanged);
			// 
			// browse_single
			// 
			this.browse_single.Location = new System.Drawing.Point(479, 47);
			this.browse_single.Name = "browse_single";
			this.browse_single.Size = new System.Drawing.Size(84, 23);
			this.browse_single.TabIndex = 2;
			this.browse_single.Text = "browse";
			this.browse_single.UseVisualStyleBackColor = true;
			this.browse_single.Click += new System.EventHandler(this.Browse_singleClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DereferenceLinks = false;
			this.openFileDialog1.Filter = "Supported image files|*.BMP;*.JPG;*.JPEG;*.GIF;*.TIFF;*.PNG;*.bmp;*.jpg;*.jpeg;*." +
			"gif;*.tiff;*.png";
			// 
			// resizing
			// 
			this.resizing.Controls.Add(this.panel2);
			this.resizing.Controls.Add(this.fix);
			this.resizing.Controls.Add(this.label1);
			this.resizing.Controls.Add(this.panel1);
			this.resizing.Controls.Add(this.percent_input);
			this.resizing.Controls.Add(this.percent);
			this.resizing.Location = new System.Drawing.Point(12, 182);
			this.resizing.Name = "resizing";
			this.resizing.Size = new System.Drawing.Size(580, 186);
			this.resizing.TabIndex = 7;
			this.resizing.TabStop = false;
			this.resizing.Text = "resizing";
			this.resizing.Enter += new System.EventHandler(this.ResizingEnter);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.height);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.auto);
			this.panel2.Controls.Add(this.width);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Enabled = false;
			this.panel2.Location = new System.Drawing.Point(193, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(381, 140);
			this.panel2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(29, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 14;
			this.label5.Text = "auto";
			this.label5.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(136, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "auto";
			// 
			// height
			// 
			this.height.Enabled = false;
			this.height.Location = new System.Drawing.Point(135, 54);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(49, 20);
			this.height.TabIndex = 7;
			this.height.Visible = false;
			this.height.TextChanged += new System.EventHandler(this.WidthTextChanged);
			this.height.EnabledChanged += new System.EventHandler(this.HeightEnabledChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(125, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(191, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "px";
			this.label2.Visible = false;
			// 
			// auto
			// 
			this.auto.Controls.Add(this.auto_height);
			this.auto.Controls.Add(this.auto_width);
			this.auto.Controls.Add(this.keep_ratio);
			this.auto.Location = new System.Drawing.Point(218, 3);
			this.auto.Name = "auto";
			this.auto.Size = new System.Drawing.Size(160, 132);
			this.auto.TabIndex = 11;
			this.auto.TabStop = false;
			this.auto.Text = "auto";
			// 
			// auto_height
			// 
			this.auto_height.Checked = true;
			this.auto_height.Location = new System.Drawing.Point(6, 102);
			this.auto_height.Name = "auto_height";
			this.auto_height.Size = new System.Drawing.Size(142, 24);
			this.auto_height.TabIndex = 14;
			this.auto_height.TabStop = true;
			this.auto_height.Text = "auto_height";
			this.auto_height.UseVisualStyleBackColor = true;
			// 
			// auto_width
			// 
			this.auto_width.Location = new System.Drawing.Point(6, 72);
			this.auto_width.Name = "auto_width";
			this.auto_width.Size = new System.Drawing.Size(142, 24);
			this.auto_width.TabIndex = 13;
			this.auto_width.Text = "auto_width";
			this.auto_width.UseVisualStyleBackColor = true;
			this.auto_width.CheckedChanged += new System.EventHandler(this.Auto_widthCheckedChanged);
			// 
			// keep_ratio
			// 
			this.keep_ratio.Checked = true;
			this.keep_ratio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.keep_ratio.Location = new System.Drawing.Point(7, 37);
			this.keep_ratio.Name = "keep_ratio";
			this.keep_ratio.Size = new System.Drawing.Size(147, 34);
			this.keep_ratio.TabIndex = 0;
			this.keep_ratio.Text = "keep ratio";
			this.keep_ratio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.keep_ratio.UseVisualStyleBackColor = true;
			this.keep_ratio.CheckedChanged += new System.EventHandler(this.Keep_ratioCheckedChanged);
			// 
			// width
			// 
			this.width.Location = new System.Drawing.Point(29, 117);
			this.width.Name = "width";
			this.width.Size = new System.Drawing.Size(49, 20);
			this.width.TabIndex = 9;
			this.width.TextChanged += new System.EventHandler(this.WidthTextChanged);
			this.width.EnabledChanged += new System.EventHandler(this.WidthEnabledChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(84, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "px";
			// 
			// fix
			// 
			this.fix.Location = new System.Drawing.Point(185, 19);
			this.fix.Name = "fix";
			this.fix.Size = new System.Drawing.Size(207, 24);
			this.fix.TabIndex = 12;
			this.fix.Text = "fixed";
			this.fix.UseVisualStyleBackColor = true;
			this.fix.CheckedChanged += new System.EventHandler(this.FixCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(127, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "%";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(178, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 160);
			this.panel1.TabIndex = 4;
			// 
			// percent_input
			// 
			this.percent_input.Location = new System.Drawing.Point(87, 58);
			this.percent_input.Name = "percent_input";
			this.percent_input.Size = new System.Drawing.Size(34, 20);
			this.percent_input.TabIndex = 3;
			this.percent_input.Text = "50";
			this.percent_input.TextChanged += new System.EventHandler(this.Percent_inputTextChanged);
			// 
			// percent
			// 
			this.percent.Checked = true;
			this.percent.Location = new System.Drawing.Point(6, 19);
			this.percent.Name = "percent";
			this.percent.Size = new System.Drawing.Size(91, 24);
			this.percent.TabIndex = 0;
			this.percent.TabStop = true;
			this.percent.Text = "percent";
			this.percent.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Red;
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(374, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 54);
			this.panel3.TabIndex = 6;
			this.panel3.Visible = false;
			this.panel3.VisibleChanged += new System.EventHandler(this.Panel3VisibleChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(41, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 41);
			this.label6.TabIndex = 16;
			this.label6.Text = "label6";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// ok
			// 
			this.ok.Enabled = false;
			this.ok.Location = new System.Drawing.Point(472, 511);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(120, 23);
			this.ok.TabIndex = 8;
			this.ok.Text = "OK";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.OkClick);
			// 
			// output
			// 
			this.output.Controls.Add(this.label7);
			this.output.Controls.Add(this.panel3);
			this.output.Controls.Add(this.comboBox1);
			this.output.Controls.Add(this.use_same_type);
			this.output.Controls.Add(this.textBox2);
			this.output.Controls.Add(this.new_subfolder);
			this.output.Controls.Add(this.textBox1);
			this.output.Controls.Add(this.add_prefix);
			this.output.Location = new System.Drawing.Point(12, 375);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(580, 130);
			this.output.TabIndex = 13;
			this.output.TabStop = false;
			this.output.Text = "output";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(161, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"PNG",
									"JPG",
									"BMP",
									"GIF",
									"TIFF"});
			this.comboBox1.Location = new System.Drawing.Point(306, 102);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(64, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.Visible = false;
			// 
			// use_same_type
			// 
			this.use_same_type.Checked = true;
			this.use_same_type.CheckState = System.Windows.Forms.CheckState.Checked;
			this.use_same_type.Location = new System.Drawing.Point(6, 100);
			this.use_same_type.Name = "use_same_type";
			this.use_same_type.Size = new System.Drawing.Size(239, 24);
			this.use_same_type.TabIndex = 4;
			this.use_same_type.Text = "use_same_type";
			this.use_same_type.UseVisualStyleBackColor = true;
			this.use_same_type.CheckedChanged += new System.EventHandler(this.Use_same_typeCheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(252, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "smaller";
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// new_subfolder
			// 
			this.new_subfolder.Checked = true;
			this.new_subfolder.CheckState = System.Windows.Forms.CheckState.Checked;
			this.new_subfolder.Location = new System.Drawing.Point(6, 49);
			this.new_subfolder.Name = "new_subfolder";
			this.new_subfolder.Size = new System.Drawing.Size(239, 24);
			this.new_subfolder.TabIndex = 2;
			this.new_subfolder.Text = "new_subfolder";
			this.new_subfolder.UseVisualStyleBackColor = true;
			this.new_subfolder.CheckedChanged += new System.EventHandler(this.New_subfolderCheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(252, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "s-";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// add_prefix
			// 
			this.add_prefix.Location = new System.Drawing.Point(6, 19);
			this.add_prefix.Name = "add_prefix";
			this.add_prefix.Size = new System.Drawing.Size(239, 24);
			this.add_prefix.TabIndex = 0;
			this.add_prefix.Text = "add_prefix";
			this.add_prefix.UseVisualStyleBackColor = true;
			this.add_prefix.CheckedChanged += new System.EventHandler(this.Add_prefixCheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 6000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 511);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(228, 23);
			this.progressBar1.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(318, 516);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "0";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(246, 516);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "label9";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(554, 4);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(44, 17);
			this.linkLabel1.TabIndex = 16;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Location = new System.Drawing.Point(0, 540);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(603, 25);
			this.panel4.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(67, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(317, 17);
			this.label10.TabIndex = 18;
			this.label10.Text = "label10";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(601, 561);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.output);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.resizing);
			this.Controls.Add(this.input);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "resizer";
			this.input.ResumeLayout(false);
			this.input.PerformLayout();
			this.resizing.ResumeLayout(false);
			this.resizing.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.auto.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.output.ResumeLayout(false);
			this.output.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox new_subfolder;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox use_same_type;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox add_prefix;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox output;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton auto_width;
		private System.Windows.Forms.RadioButton auto_height;
		private System.Windows.Forms.RadioButton fix;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox height;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox width;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox keep_ratio;
		private System.Windows.Forms.GroupBox auto;
		private System.Windows.Forms.TextBox percent_input;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton percent;
		private System.Windows.Forms.GroupBox resizing;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button browse_single;
		private System.Windows.Forms.TextBox input_single;
		private System.Windows.Forms.Button browse_directory;
		private System.Windows.Forms.TextBox input_directory;
		private System.Windows.Forms.CheckBox include_subdirs;
		private System.Windows.Forms.GroupBox input;
		private System.Windows.Forms.RadioButton directory;
		private System.Windows.Forms.RadioButton single_file;
	}
}
