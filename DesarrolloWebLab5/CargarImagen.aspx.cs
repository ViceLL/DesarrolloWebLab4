
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWebLab5
{
    public partial class CargarImagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (fuArchivo.HasFile)
            {           
                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient("AKIAU237D6H3ABPEH36F", "t0OBXrRM77w+5D/5h+pxCGMLtjDBZ0eGBicfsZ1Z", Amazon.RegionEndpoint.USEast1);

                Amazon.Rekognition.Model.Image image = new Amazon.Rekognition.Model.Image();

                image.Bytes = new System.IO.MemoryStream(fuArchivo.FileBytes);


                DetectModerationLabelsRequest detectModerationLabelsRequest = new DetectModerationLabelsRequest()
                {
                    Image = image,
                    MinConfidence = 60
                };
               DetectModerationLabelsResponse detectModerationLabelsResponse = rekognitionClient.DetectModerationLabels(detectModerationLabelsRequest);


               foreach (var item in detectModerationLabelsResponse.ModerationLabels)
                {
                    txtSalida.Text = txtSalida.Text + item.Name + "-" + item.ParentName + "-" + item.Confidence.ToString() + "\n";
                }

              
                fuArchivo.SaveAs(MapPath("Imagenes") + @"\" + fuArchivo.FileName);
                imgFoto.ImageUrl = "./Imagenes/" + fuArchivo.FileName;
            }
            
        }
    }
}