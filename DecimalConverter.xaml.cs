using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JarkomGuide
{
	public partial class DecimalConverter : ContentPage
	{
		public DecimalConverter()
		{
			InitializeComponent();
			Title = "Decimal Konverter";
		}

		void prosesdecimal(Object sender, EventArgs args)
		{
			int num, binary_val, decimal_val = 0, base_val = 1, rem;
			int numdua, binary_val_dua, remdua, decimal_val_dua = 0, base_val_dua = 1;
			int numtiga, binary_val_tiga, remtiga, decimal_val_tiga = 0, base_val_tiga = 1;
			int numempat, binary_val_empat, remempat, decimal_val_empat = 0, base_val_empat = 1;


			num = int.Parse(binersatu.Text);
			numdua = int.Parse(binerdua.Text);
			numtiga = int.Parse(binertiga.Text);
			numempat = int.Parse(binerempat.Text);

			binary_val_tiga = numtiga;
			binary_val_tiga = numempat;
			binary_val_dua = numdua;
            binary_val = num;

            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem* base_val;
				num = num / 10 ;
                base_val = base_val* 2;
            }

			while (numdua > 0)
			{
				remdua = numdua % 10;
				decimal_val_dua = decimal_val_dua + remdua * base_val_dua;
				numdua = numdua / 10;
				base_val_dua = base_val_dua * 2;
				
			}

			while (numtiga > 0)
			{
				remtiga = numtiga % 10;
				decimal_val_tiga = decimal_val_tiga + remtiga* base_val_tiga;
				numtiga = numtiga / 10;
				base_val_tiga = base_val_tiga* 2;
				
			}

			while (numempat > 0)
			{
				remempat = numempat % 10;
				decimal_val_empat = decimal_val_empat + remempat* base_val_empat;
				numempat = numempat / 10;
				base_val_empat = base_val_empat* 2;
				
			}



			ipsatu.Text = decimal_val.ToString();
			ipdua.Text = decimal_val_dua.ToString();
			iptiga.Text = decimal_val_tiga.ToString();
			ipempat.Text = decimal_val_empat.ToString();
		}
	}
}
