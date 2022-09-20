
using QRCoder;
using System.Reflection.Emit;
using System.Security.Policy;

namespace QRCode_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Version 1 : affiche du texte
            //Cr�ation de l'objet qui permet de g�n�rer le QR code, la data qui va avec, et d'un objet qui r�cup�re la data pour en cr�er une image
            /*QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrData = QrGenerator.CreateQrCode("Version 1: affiche du texte !", QRCodeGenerator.ECCLevel.L, true);
            QRCode QrCode = new QRCode(QrData);
            Bitmap QrImage = QrCode.GetGraphic(5);
            QRPicture.Image = QrImage;*/

            // Version 2 : affiche un lien (url)
            // Seul diff�rence est la cr�ation de l'objet payload(url)
            /*PayloadGenerator.Payload payload = new PayloadGenerator.Url("https://www.google.com/");
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrData = QrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.L);
            QRCode QrCode = new QRCode(QrData);
            Bitmap QrImage = QrCode.GetGraphic(5);
            QRPicture.Image = QrImage;*/

            // Version 3 : Connexion auto au wifi inscrit dans le QR code
            // Seul diff�rence est la creation de l'objet wifi
            PayloadGenerator.WiFi MyWiFi = new PayloadGenerator.WiFi("SFR_9178", "58wdty7dtb49eygx2yes", PayloadGenerator.WiFi.Authentication.WPA);
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrData = QrGenerator.CreateQrCode(MyWiFi, QRCodeGenerator.ECCLevel.L);
            QRCode QrCode = new QRCode(QrData);
            Bitmap QrImage = QrCode.GetGraphic(5);
            QRPicture.Image = QrImage;
        }
    }
}