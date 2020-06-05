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
    public partial class FormEditDB : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        int productId = 0;
        public FormEditDB()
        {
            InitializeComponent();

            BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
            int count = 0;

            while (br.PeekChar() > -1)
            {
                Array.Resize(ref pharmacies, pharmacies.Length + 1);
                pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));
                count++;
            }
            br.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pharmacies.Length; i++) { 
                if (textBoxDBEditSearch.Text.Equals(pharmacies[i].Name))
                {
                    labelError.Text = String.Empty;
                    panelEditDB.Visible = true;
                    textBoxProductName.Text = pharmacies[i].Name;
                    textBoxManufacture.Text = pharmacies[i].Manufacturer;
                    textBoxPriceForOne.Text = Convert.ToString(pharmacies[i].Price);
                    textBoxAmountInPack.Text = Convert.ToString(pharmacies[i].Amount);
                    textBoxPharmNumber.Text = Convert.ToString(pharmacies[i].PharmNumber);
                    dateTimePickerDateExpired.Value = pharmacies[i].DateExpired;
                    productId = i;
                    return;
                } else
                {
                    labelError.Text = "Товара с указанным именем не существует";
                }
            }
        }

        private async void buttonEditDBApply_Click(object sender, EventArgs e)
        {
            labelValidationError1.Text = String.Empty;
            labelValidationError2.Text = String.Empty;
            labelValidationError3.Text = String.Empty;
            labelValidationError4.Text = String.Empty;
            labelSuccessAdd.Text = String.Empty;
            await Task.Delay(200);

            if (String.IsNullOrEmpty(textBoxProductName.Text) || String.IsNullOrEmpty(textBoxManufacture.Text) || String.IsNullOrEmpty(textBoxPriceForOne.Text) || String.IsNullOrEmpty(textBoxAmountInPack.Text) || String.IsNullOrEmpty(textBoxPharmNumber.Text) || String.IsNullOrEmpty(dateTimePickerDateExpired.Text))
            {
                labelValidationError1.Text = "Все поля должны быть заполнены";
            }
            else
            {
                double PriceForOne;
                int AmountInPack, PharmNumber;
                if (!double.TryParse(textBoxPriceForOne.Text, out PriceForOne) || PriceForOne <= 0 || (double.TryParse(textBoxPriceForOne.Text, out PriceForOne) && Convert.ToDouble(textBoxPriceForOne.Text) > 100000)) 
                {
                    labelValidationError2.Text = "Поле должно быть числом и > 0 \n (дробное число через запятую) ";
                }

                if (!int.TryParse(textBoxAmountInPack.Text, out AmountInPack) || AmountInPack <= 0)
                {
                    labelValidationError3.Text = "Поле должно быть числом и > 0 ";
                }

                if (!int.TryParse(textBoxPharmNumber.Text, out PharmNumber) || PharmNumber <= 0)
                {
                    labelValidationError4.Text = "Поле должно быть числом и > 0 ";
                }

                if (PriceForOne == 0 || PriceForOne > 100000 || AmountInPack == 0 || PharmNumber == 0)
                {
                    return;
                }

                pharmacies[productId].Name = textBoxProductName.Text;
                pharmacies[productId].Manufacturer = textBoxManufacture.Text;
                pharmacies[productId].Price = Convert.ToDouble(textBoxPriceForOne.Text);
                pharmacies[productId].Amount = Convert.ToInt32(textBoxAmountInPack.Text);
                pharmacies[productId].PharmNumber = Convert.ToInt32(textBoxPharmNumber.Text);
                pharmacies[productId].DateExpired = dateTimePickerDateExpired.Value;

                // clear all text boxes
                foreach (var c in this.Controls)
                {
                    if (c is TextBox) ((TextBox)c).Text = String.Empty;
                }
                labelSuccessAdd.Text = "Данные успешно обновлены";
            }
        }

        private void buttonEditDBCancel_Click(object sender, EventArgs e)
        {
            FileDB.CloseFile();
            FileDB.OpenAndRewriteFile();
            BinaryWriter bw = new BinaryWriter(FileDB.fs, Encoding.UTF8);

            foreach (Pharmacy p in pharmacies)
            {
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
