using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JarkomGuide
{
	public partial class Cek_IP : ContentPage
	{
		public Cek_IP()
		{
			InitializeComponent();
			Title="Cek IP Address";
		}

		void prosesip(Object sender, EventArgs args)
		{
			double kolomsatu = double.Parse(satu.Text);
			double kolomdua = double.Parse(dua.Text);
			double kolomtiga = double.Parse(tiga.Text);
			double kolomempat = double.Parse(empat.Text);

			if (kolomsatu == 127)
			{
				
				kelasnya.Text = "Bukan IP Address";
				subnetnya.Text = "-";
				ipnya.Text = "-";
				networknya.Text = "-";
				prefixnya.Text = "-";
			}
			else if (kolomsatu < 127)
			{
				kelasnya.Text = "Kelas : A";
				subnetnya.Text = "Subnet : 255.0.0.0";
				string barissatu = kolomsatu.ToString();
				string barisdua = kolomdua.ToString();
				string baristiga = kolomtiga.ToString();
				string barisempat = kolomempat.ToString();
				ipnya.Text = barissatu + "." + barisdua + "." + baristiga + "." + barisempat;
				networknya.Text = "Networknya : "+ barissatu + "." + "0" + "." + "0" + "." + "0";
				prefixnya.Text = "Prefix-Length: /8";
			}
			else if (kolomsatu < 192)
			{
				kelasnya.Text = " Kelas : B";
				subnetnya.Text = "Subnet : 255.255.0.0";
				string barissatu = kolomsatu.ToString();
				string barisdua = kolomdua.ToString();
				string baristiga = kolomtiga.ToString();
				string barisempat = kolomempat.ToString();
				ipnya.Text = barissatu + "." + barisdua + "." + baristiga + "." + barisempat;
				networknya.Text = "Networknya : "+ barissatu + "." + barisdua + "." + "0" + "." + "0";
				prefixnya.Text = "Prefix-Length: /16";
			}
			else if (kolomsatu < 224)
			{
				kelasnya.Text = "Kelas : C";
				subnetnya.Text = "Subnet : 255.255.255.0";
				string barissatu = kolomsatu.ToString();
				string barisdua = kolomdua.ToString();
				string baristiga = kolomtiga.ToString();
				string barisempat = kolomempat.ToString();
				ipnya.Text = barissatu + "." + barisdua + "." + baristiga + "." + barisempat;
				networknya.Text = "Networknya : "+ barissatu + "." + barisdua + "." + baristiga + "." + "0";
				prefixnya.Text = "Prefix-Length: /24";
			}

			else if (kolomsatu < 240)
			{
				kelasnya.Text = "Kelas : D";
				subnetnya.Text = "Subnet : -";
				string barissatu = kolomsatu.ToString();
				string barisdua = kolomdua.ToString();
				string baristiga = kolomtiga.ToString();
				string barisempat = kolomempat.ToString();
				ipnya.Text = barissatu + "." + barisdua + "." + baristiga + "." + barisempat;
				networknya.Text = "Network : -";
				prefixnya.Text = "-";

			}

			else if (kolomsatu < 256)
			{
				kelasnya.Text = "Kelas : E";
				subnetnya.Text = "Subnet : -";
				string barissatu = kolomsatu.ToString();
				string barisdua = kolomdua.ToString();
				string baristiga = kolomtiga.ToString();
				string barisempat = kolomempat.ToString();
				ipnya.Text = barissatu + "." + barisdua + "." + baristiga + "." + barisempat;
				networknya.Text = "Network : -";
				prefixnya.Text = "-";

			}

		}
	}
}
