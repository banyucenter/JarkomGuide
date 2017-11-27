using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JarkomGuide
{
	public partial class BinerConverter : ContentPage
	{
		public BinerConverter()
		{
			InitializeComponent();
			Title = "Biner Konverter";

		}

		public static string ToBin(int value, int len)
		{
			return (len > 1 ? ToBin(value >> 1, len - 1) : null) + "01"[value & 1];
		}

		void prosesbiner(Object sender, EventArgs args)
		{
			int numsatu = int.Parse(ipsatu.Text);
			int numdua = int.Parse(ipdua.Text);
			int numtiga = int.Parse(iptiga.Text);
			int numempat = int.Parse(ipempat.Text);


			hasilsatu.Text = ToBin(numsatu, 8);
			hasildua.Text = ToBin(numdua, 8);
			hasiltiga.Text = ToBin(numtiga, 8);
			hasilempat.Text = ToBin(numempat, 8);

		}
	}
}
