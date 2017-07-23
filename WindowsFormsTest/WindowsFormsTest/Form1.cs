using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WindowsFormsTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog dialog = new CommonOpenFileDialog()
			{
				InitialDirectory = "D:\\Download\\",
				IsFolderPicker = true
			};
			string[] files;
			string[] artists = { "" };
			bool good = false;
			TagLib.File targetFile;
			TagLib.Id3v2.AttachedPictureFrame pic;
			if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				good = true;
			}

			if (good == true)
			{
				files = Directory.GetFiles(dialog.FileName);
				if (dispRadio.Checked == true)
				{
					for (int i = 0; i < files.Length; i += 2)
					{
						outText.AppendText(files[i].Split('-').Last().Split('.')[0].Trim(' '));
						outText.AppendText(Environment.NewLine);
					}
				}
				else
				{
					for (int i = 0; i < files.Length - 1; i++)
					{
						if (files[i].Split('\\').Last().Split('_')[0] == files[i + 1].Split('\\').Last().Split('_')[0] && files[i].Split('.').Last() == "mp3")
						{
							pic = new TagLib.Id3v2.AttachedPictureFrame()
							{
								TextEncoding = TagLib.StringType.Latin1,
								MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
								Type = TagLib.PictureType.FrontCover,
								Data = TagLib.ByteVector.FromPath(files[i + 1])
							};

							targetFile = TagLib.File.Create(files[i]);
							targetFile.Tag.Pictures = new TagLib.IPicture[1] { pic };
							targetFile.Tag.Album = files[i].Split('\\').Last().Split('_')[0];
							artists[0] = files[i].Split('-').Last().Split('.')[0].Trim(' ');
							targetFile.Tag.AlbumArtists = artists;
							targetFile.Save();
						}
					}
					outText.AppendText("Done");
					outText.AppendText(Environment.NewLine);
				}
				
			}
		}
	}



}
