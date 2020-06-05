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

namespace Course
{
    public partial class FormDBAddData : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        int count = 0;
        public FormDBAddData()
        {
            InitializeComponent();
        }

        private async void buttonAddData_Click(object sender, EventArgs e)
        {
            labelValidationError1.Text = String.Empty;
            labelValidationError2.Text = String.Empty;
            labelValidationError3.Text = String.Empty;
            labelValidationError4.Text = String.Empty;
            labelSuccessAdd.Text = String.Empty;
            await Task.Delay(200);

            if (String.IsNullOrEmpty(textBoxProductName.Text) || String.IsNullOrEmpty(textBoxManufacture.Text) || String.IsNullOrEmpty(textBoxPriceForOne.Text) || String.IsNullOrEmpty(textBoxAmountInPack.Text) || String.IsNullOrEmpty(textBoxPharmNumber.Text) || String.IsNullOrEmpty(dateTimePickerExpired.Text))
            {
                labelValidationError1.Text = "Все поля должны быть заполнены";
            } else
            {
                double PriceForOne;
                int AmountInPack, PharmNumber;
                if(!double.TryParse(textBoxPriceForOne.Text, out PriceForOne) || PriceForOne <= 0 || (double.TryParse(textBoxPriceForOne.Text, out PriceForOne) && Convert.ToDouble(textBoxPriceForOne.Text) > 100000))
                {
                    labelValidationError2.Text = "Поле должно быть числом и в диапазоне от 0 до 100000 \n (дробное число через запятую) ";
                }

                if (!int.TryParse(textBoxAmountInPack.Text, out AmountInPack) || AmountInPack <= 0)
                {
                    labelValidationError3.Text = "Поле должно быть числом и в промежутке от 1 до 2147483647";
                }

                if (!int.TryParse(textBoxPharmNumber.Text, out PharmNumber) || PharmNumber <= 0)
                {
                    labelValidationError4.Text = "Поле должно быть числом и в промежутке от 1 до 2147483647";
                }

                if (PriceForOne == 0  || PriceForOne > 100000|| AmountInPack == 0 || PharmNumber == 0)
                {
                    return;
                }

                Array.Resize(ref pharmacies, pharmacies.Length + 1);
                pharmacies[count] = new Pharmacy(textBoxProductName.Text, textBoxManufacture.Text, Convert.ToDouble(textBoxPriceForOne.Text), Convert.ToInt32(textBoxAmountInPack.Text), Convert.ToInt32(textBoxPharmNumber.Text), dateTimePickerExpired.Value);
                count++;
                // clear all text boxes
                foreach (var c in this.Controls)
                {
                    if (c is TextBox) ((TextBox)c).Text = String.Empty;
                }
                labelSuccessAdd.Text = "Данные успешно добавлены";
            }
        }

        private void buttonAddBreak_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(FileDB.fs, Encoding.UTF8);

            foreach (Pharmacy p in pharmacies) {
                bw.Write(p.Name);
                bw.Write(p.Manufacturer);
                bw.Write(p.Price);
                bw.Write(p.Amount);
                bw.Write(p.PharmNumber);
                bw.Write(p.DateExpired.ToString());
            }
            bw.Close();
            FileDB.CloseFile();
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
