using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace BarcodeGenerator
{
    public partial class BarcodeGen : Form
    {
        public BarcodeGen()
        {
            InitializeComponent();


        }

        string GenerateBarcode()
        {
            Random rnd = new Random();
            string productCode="";
            for (int i = 0; i < 5; i++)
            {
               productCode += rnd.Next(0, 9);
            }

            return productCode;


        }
        GeneratedBarcode currentBarcode;
        string currentNumber;
        GeneratedBarcode DrawBarcode(string barcode)
        {
            var MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(barcode, BarcodeEncoding.EAN13,400,200).ResizeTo(400, 100).AddBarcodeValueTextBelowBarcode().;
            return MyBarCode;
        }
        private void btn_Uret_Click(object sender, EventArgs e)
        {
          string  productCode = GenerateBarcode();
            string barcode= txt_CountryCode.Text+txt_FirmCode.Text+productCode;
            lbl_BarcodeNum.Text = txt_CountryCode.Text+" "+txt_FirmCode.Text+" "+productCode;
            currentBarcode = DrawBarcode(barcode);
            pictureBox2.Image = currentBarcode.Image;
            currentNumber = barcode;
            

        }

        private void BarcodeGen_Load(object sender, EventArgs e)
        {
            txt_CountryCode.Text = "999";
            txt_FirmCode.Text = "9999";
            currentBarcode = DrawBarcode("999999999999");
            pictureBox2.Image = currentBarcode.Image;
            lbl_BarcodeNum.Text = "999 9999 99999";
            currentNumber = "999999999999";
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            
            currentBarcode.SaveAsPdf("Barkodno "+currentNumber+".pdf");
        }
    }
}
