using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10_FileUploadApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUploadStatus.Text = "";
            lblDownloadStatus.Text = "";
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                string uploadFolder = Server.MapPath("~/Uploads/");

                // Create Uploads folder if not exists
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string fileName = Path.GetFileName(FileUpload.FileName);
                string filePath = uploadFolder + fileName;

                try
                {
                    // Save file to server
                    FileUpload.SaveAs(filePath);

                    lblUploadStatus.Text = "✅ File uploaded successfully!";
                    lblFileName.Text = fileName;
                    btnDownload.Visible = true; // Show Download Button
                }
                catch (Exception ex)
                {
                    lblUploadStatus.Text = "❌ Error: " + ex.Message;
                }
            }
            else
            {
                lblUploadStatus.Text = "⚠️ Please select a file to upload.";
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            string fileName = lblFileName.Text;
            string filePath = Server.MapPath("~/Uploads/") + fileName;

            if (File.Exists(filePath))
            {
                Response.ContentType = MimeMapping.GetMimeMapping(filePath);
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
                Response.TransmitFile(filePath);
                Response.End();
            }
            else
            {
                lblDownloadStatus.Text = "⚠️ File not found!";
            }
        }
    }
}