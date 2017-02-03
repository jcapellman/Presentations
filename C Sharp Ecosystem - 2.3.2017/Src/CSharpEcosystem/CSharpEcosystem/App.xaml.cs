using Xamarin.Forms;

namespace CSharpEcosystem
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new CSharpEcosystem.MainPage();
		}

		protected override void OnStart ()
		{
		}

		protected override void OnSleep ()
		{
		}

		protected override void OnResume ()
		{
		}
	}
}