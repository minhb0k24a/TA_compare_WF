using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_compare_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
		{

		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void File1_button_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			textBox1.Text = openFileDialog1.FileName;
		}

		private void File2_button_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
			textBox2.Text = openFileDialog2.FileName;
		}

		private void File3_button_Click(object sender, EventArgs e)
		{
			openFileDialog3.ShowDialog();
			textBox3.Text = openFileDialog3.FileName;
		}

		private void File4_button_Click(object sender, EventArgs e)
		{
			openFileDialog4.ShowDialog();
			textBox4.Text = openFileDialog4.FileName;
		}

		private void button0_Click(object sender, EventArgs e)
		{
			string[] output = null;
			if (verify_input())
			{
				if (!File.Exists(textBox1.Text) && !File.Exists(textBox2.Text))
				{
					output = null;
				}
				else if (!File.Exists(textBox1.Text))
				{
					output = File.ReadAllLines(textBox2.Text);
				}
				else if (!File.Exists(textBox2.Text))
				{
					output = File.ReadAllLines(textBox1.Text);
				}
				else
				{
					output = compare_file(File.ReadAllLines(textBox1.Text), File.ReadAllLines(textBox2.Text));
				}

				if (File.Exists(textBox3.Text) && output != null)
				{
					output = compare_file(output, File.ReadAllLines(textBox3.Text));
				}
				else if (File.Exists(textBox3.Text) && output == null)
				{
					output = File.ReadAllLines(textBox3.Text);
				}

				if (File.Exists(textBox4.Text))
				{
					output = compare_file(output, File.ReadAllLines(textBox4.Text));
				}

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile()))
					{
						for (int i = 0; i < output.Length; i++)
						{
							writer.WriteLine(output[i]);
						}
					}
					System.Diagnostics.Process.Start(Path.GetFullPath(saveFileDialog1.FileName));
				}
			}
		}
		private Boolean verify_input()
		{
			int count = 0;
			foreach (string name in new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }) {
				if (!String.IsNullOrEmpty(name)) {
					if (!File.Exists(name))
					{
						MessageBox.Show("File "+ name + " không tồn tại.");
						return false;
					}
					count++;
				}
			}

			if (count <= 1)
			{
				MessageBox.Show("Chọn ít nhất 2 file để so sánh!");
				count = 0;
				return false;
			}
			return true;
		}
		private string[] compare_file(string[] file1, string[] file2)
		{
			string[] ret;
			List<string> list = new List<string>();

			foreach (string line1 in file1)
			{
				foreach (string line2 in file2)
				{
					if (line1.Equals(line2))
					{
						list.Add(line1);
					}
				}
			}
			ret = list.ToArray();
			return ret;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Update();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox2.Update();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			textBox3.Update();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			textBox4.Update();
		}
	}
}
