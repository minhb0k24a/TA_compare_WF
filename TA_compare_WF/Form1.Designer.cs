
namespace TA_compare_WF
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button0 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.File1_button = new System.Windows.Forms.Button();
			this.File_button = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.File3_button = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.File4_button = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(403, 250);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(106, 43);
			this.button0.TabIndex = 0;
			this.button0.Text = "So sánh";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.button0_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "File 1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(153, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// File1_button
			// 
			this.File1_button.Location = new System.Drawing.Point(434, 49);
			this.File1_button.Name = "File1_button";
			this.File1_button.Size = new System.Drawing.Size(75, 23);
			this.File1_button.TabIndex = 3;
			this.File1_button.Text = "File 1";
			this.File1_button.UseVisualStyleBackColor = true;
			this.File1_button.Click += new System.EventHandler(this.File1_button_Click);
			// 
			// File_button
			// 
			this.File_button.Location = new System.Drawing.Point(434, 94);
			this.File_button.Name = "File_button";
			this.File_button.Size = new System.Drawing.Size(75, 23);
			this.File_button.TabIndex = 6;
			this.File_button.Text = "File 2";
			this.File_button.UseVisualStyleBackColor = true;
			this.File_button.Click += new System.EventHandler(this.File2_button_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "File 2";
			// 
			// File3_button
			// 
			this.File3_button.Location = new System.Drawing.Point(434, 140);
			this.File3_button.Name = "File3_button";
			this.File3_button.Size = new System.Drawing.Size(75, 23);
			this.File3_button.TabIndex = 9;
			this.File3_button.Text = "File 3";
			this.File3_button.UseVisualStyleBackColor = true;
			this.File3_button.Click += new System.EventHandler(this.File3_button_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(153, 140);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(240, 22);
			this.textBox3.TabIndex = 8;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "File 3";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(153, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(240, 22);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// File4_button
			// 
			this.File4_button.Location = new System.Drawing.Point(434, 191);
			this.File4_button.Name = "File4_button";
			this.File4_button.Size = new System.Drawing.Size(75, 23);
			this.File4_button.TabIndex = 12;
			this.File4_button.Text = "File 4";
			this.File4_button.UseVisualStyleBackColor = true;
			this.File4_button.Click += new System.EventHandler(this.File4_button_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(153, 191);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(240, 22);
			this.textBox4.TabIndex = 11;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "File 4";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// openFileDialog3
			// 
			this.openFileDialog3.FileName = "openFileDialog3";
			// 
			// openFileDialog4
			// 
			this.openFileDialog4.FileName = "openFileDialog4";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "Output";
			this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 320);
			this.Controls.Add(this.File4_button);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.File3_button);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.File_button);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.File1_button);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button0);
			this.Name = "Form1";
			this.Text = "TA_compare_tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button File1_button;
		private System.Windows.Forms.Button File_button;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button File3_button;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button File4_button;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.OpenFileDialog openFileDialog3;
		private System.Windows.Forms.OpenFileDialog openFileDialog4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

