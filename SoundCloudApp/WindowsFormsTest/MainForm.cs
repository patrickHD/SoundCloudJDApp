using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WindowsFormsTest
{
    public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
        public string art;
        public bool artGood = false;
		private void openButton_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog dialog = new CommonOpenFileDialog()
			{
				InitialDirectory = "D:\\Download\\"
			};
            if(fileRadio.Checked == true){
                dialog.Multiselect = true;
            }
            else{
                dialog.IsFolderPicker = true;
            }
			string[] files;
			string[] artists = { "" };
			bool good = false;
			TagLib.File targetFile;
			TagLib.Id3v2.AttachedPictureFrame pic;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				good = true;
			}
            if (dialog.IsFolderPicker == true)
            {
                files = Directory.GetFiles(dialog.FileName);
            }
            else
            {
                files = dialog.FileNames.ToArray();
            }

            if(good == true)
            {
                if (dispRadio.Checked == true)
                {
                    for (int i = 0; i < files.Length; i += 2)
                    {
                        outText.AppendText(files[i].Split('-').Last().Split('.')[0].Trim(' '));
                        outText.AppendText(Environment.NewLine);
                    }
                    outText.AppendText("Done");
                    outText.AppendText(Environment.NewLine);
                }
                else
                {
                    if (folderRadio.Checked == true)
                    {
                        for (int i = 0; i < files.Length - 1; i++)
                        {
                            if (files[i].Split('\\').Last().Split('_')[0] == files[i + 1].Split('\\').Last().Split('_')[0] && files[i].Split('.').Last() == "mp3" || files[i].Split('.').Last() == "wav")
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
                    }
                    else
                    {
                        if (artGood == true)
                        {
                            for (int i = 0; i < files.Length; i++)
                            {
                                pic = new TagLib.Id3v2.AttachedPictureFrame()
                                {
                                    TextEncoding = TagLib.StringType.Latin1,
                                    MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
                                    Type = TagLib.PictureType.FrontCover,
                                    Data = TagLib.ByteVector.FromPath(art)
                                };
                                targetFile = TagLib.File.Create(files[i]);
                                targetFile.Tag.Pictures = new TagLib.IPicture[1] { pic };
                                targetFile.Save();
                            }
                        }
                        else
                        {
                            outText.AppendText("Need art");
                            outText.AppendText(Environment.NewLine);
                        }

                    }
                    outText.AppendText("Done");
                    outText.AppendText(Environment.NewLine);
                }
            }
            else
            {
                outText.AppendText("Not good");
                outText.AppendText(Environment.NewLine);
            }
            
		}

        private void artButton_Click(object sender, EventArgs e)
        {
            artGood = true;
            folderRadio.Checked = false;
            fileRadio.Checked = true;
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = "D:\\Download\\",
                Multiselect = false
            };
            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                art = dialog.FileName;
                outText.AppendText(art);
                outText.AppendText(Environment.NewLine);
            }
            else
            {
                outText.AppendText("Bad");
                outText.AppendText(Environment.NewLine);
            }
        }
    }



}
