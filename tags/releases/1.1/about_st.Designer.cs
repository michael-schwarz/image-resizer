/*
 * Developed by Michael Schwarz
 * See programs.xe.cx or 7fonline.de.vu for futher information
 * Developed with Sharp Develeop
 */
namespace resizer
{
	partial class about_st
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_st));
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(50, 337);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Versionsnummer:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(50, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(475, 42);
			this.label2.TabIndex = 13;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(167, 337);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ShortcutsEnabled = false;
			this.textBox2.Size = new System.Drawing.Size(355, 20);
			this.textBox2.TabIndex = 17;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(50, 113);
			this.textBox1.MaxLength = 327670;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(475, 150);
			this.textBox1.TabIndex = 12;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(50, 65);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(145, 23);
			this.linkLabel1.TabIndex = 11;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Tag = "";
			this.linkLabel1.Text = "Website";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(50, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(475, 53);
			this.label3.TabIndex = 18;
			this.label3.Text = "Dieses Programm ist Open Source nähere Informationen dazu in der unten befindlich" +
			"en Box.\r\n\r\nUpdates und Problemlösungen sind auf der Herstellerseite programs.xe." +
			"cx verfügbar.";
			// 
			// about_st
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(534, 369);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.linkLabel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "about_st";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Über programs.xe.cx Bildverkleinerer";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
	}
}
