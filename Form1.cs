using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLCreator
{
    public partial class XMLCreator : Form
    {
        public XMLCreator()
        {
            InitializeComponent();
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = openFileDialog1.FileName;
            }
            openFileDialog1.FileName = "";
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string sUrl = txt_url.Text;
                if (!sUrl.EndsWith("/"))
                    sUrl += "/";
                //Get the fileversion
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(txt_path.Text);
                
                //Create a new XML-file
                XmlDocument doc = new XmlDocument();
                //Add XML-header
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                //Add <sharpUpdate> note
                XmlNode sharpUpdate = doc.CreateElement("sharpUpdate");
                doc.AppendChild(sharpUpdate);

                //Add <update AppId="?">
                XmlNode update = doc.CreateElement("update");
                XmlAttribute updateAttrib = doc.CreateAttribute("appId");
                updateAttrib.Value = Path.GetFileName(fvi.FileName).Substring(0, Path.GetFileName(fvi.FileName).IndexOf(".exe"));
                update.Attributes.Append(updateAttrib);
                sharpUpdate.AppendChild(update);

                //Add <version>
                XmlNode updateInfo = doc.CreateElement("version");
                updateInfo.AppendChild(doc.CreateTextNode(fvi.FileVersion));
                update.AppendChild(updateInfo);

                //Add <file> - for main Executeable
                XmlNode file = doc.CreateElement("file");
                XmlNode url = doc.CreateElement("url");
                url.AppendChild(doc.CreateTextNode(sUrl + Path.GetFileName(fvi.FileName)));
                file.AppendChild(url);
                XmlNode filename = doc.CreateElement("filename");
                filename.AppendChild(doc.CreateTextNode(Path.GetFileName(fvi.FileName)));
                file.AppendChild(filename);
                XmlNode md5 = doc.CreateElement("md5");
                md5.AppendChild(doc.CreateTextNode(MakeHashString(MD5.Create().ComputeHash(new FileStream(txt_path.Text, FileMode.Open)))));
                file.AppendChild(md5);
                update.AppendChild(file);

                //Add <file> - for each resource
                string[] ss = txt_files.Text.Split('\n');
                foreach (string s in ss)
                {
                    if (s != "")
                    {
                        string sFile = "";
                        if (s.EndsWith("\r"))
                            sFile = s.Remove(s.Length - 1);
                        else
                            sFile = s;
                        XmlNode fileLoop = doc.CreateElement("file");
                        XmlNode urlLoop = doc.CreateElement("url");
                        urlLoop.AppendChild(doc.CreateTextNode(sUrl + Path.GetFileName(sFile)));
                        fileLoop.AppendChild(urlLoop);
                        XmlNode filenameLoop = doc.CreateElement("filename");
                        filenameLoop.AppendChild(doc.CreateTextNode(Path.GetFileName(sFile)));
                        fileLoop.AppendChild(filenameLoop);
                        XmlNode md5Loop = doc.CreateElement("md5");
                        md5Loop.AppendChild(doc.CreateTextNode(MakeHashString(MD5.Create().ComputeHash(new FileStream(sFile, FileMode.Open)))));
                        fileLoop.AppendChild(md5Loop);
                        update.AppendChild(fileLoop);
                    }
                }

                //Add <description>
                XmlNode description = doc.CreateElement("description");
                description.AppendChild(doc.CreateTextNode(txt_description.Text));
                update.AppendChild(description);

                //Add <launchArgs>
                XmlNode lauchArgs = doc.CreateElement("launchArgs");
                lauchArgs.AppendChild(doc.CreateTextNode(txt_args.Text));
                update.AppendChild(lauchArgs);

                //Save XML-file to main executeable path 
                doc.Save(new FileStream(Path.GetDirectoryName(txt_path.Text) + "\\update.xml", FileMode.Create));
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                MessageBox.Show("Vorgang abgeschlossen");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog2.FileNames)
                {
                    txt_files.Text += s + Environment.NewLine;
                }
            }
        }

        private static string MakeHashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder();

            foreach (byte b in hash)
                s.Append(b.ToString("x2").ToLower());

            return s.ToString();
        }
    }
}
