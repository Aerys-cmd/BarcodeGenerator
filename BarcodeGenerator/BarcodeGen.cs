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
            var MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(barcode, BarcodeEncoding.EAN13,400,200).ResizeTo(400, 100).AddBarcodeValueTextBelowBarcode();
            return MyBarCode;
        }
        private void btn_Uret_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < richTextBox1.Lines.Count(); i++)
                {
                    currentNumber = richTextBox1.Lines[i];
                    currentBarcode = DrawBarcode(currentNumber);
                    currentBarcode.SaveAsJpeg(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Barkod/Barkodno " + currentNumber + ".jpeg");
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message.ToString());
            }
           

        }

        private void BarcodeGen_Load(object sender, EventArgs e)
        {

        }
        }
    }

