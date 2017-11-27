using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JarkomGuide
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			Title="JARKOM GUIDES";
			Children.Add (new Cek_IP());
			Children.Add (new BinerConverter());
			Children.Add(new DecimalConverter());
			//Children.Add (new TabelJaringan());
			//Children.Add (new StaticRoute());
			//Children.Add(new Tutorial());


		}
	}
}
