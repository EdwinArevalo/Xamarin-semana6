using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6
{
	public class PersonModel
	{
		public string FullName { get; set; }
		public string Age { get; set; }
		public PersonModel()
		{
		}
	}

	public class GroupedPersonModel : ObservableCollection<PersonModel>
	{
		public string LongName { get; set; }
		public string ShortName { get; set; }
	}


	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
	{
		private ObservableCollection<GroupedPersonModel> grouped { get; set; }
			public ListViewGroup()
			{
				InitializeComponent();
				grouped = new ObservableCollection<GroupedPersonModel>();
				var males = new GroupedPersonModel() { LongName = "Varones", ShortName = "V" };
				var females = new GroupedPersonModel() { LongName = "Mujeres", ShortName = "M" };

				males.Add(new PersonModel() { FullName = "Edwin Arévalo", Age = "20" });
				males.Add(new PersonModel() { FullName = "Juan Perez", Age = "27" });
				males.Add(new PersonModel() { FullName = "Rodrigo Chávez ", Age = "35" });
				males.Add(new PersonModel() { FullName = "Alex Pineda", Age = "19" });

				females.Add(new PersonModel() { FullName = "Sofía Llanos",  Age = "24" });
				females.Add(new PersonModel() { FullName = "Paola Campos", Age = "18" });
				females.Add(new PersonModel() { FullName = "Gabriela Aguilera", Age = "33" });

				grouped.Add(males); grouped.Add(females);
				lstView.ItemsSource = grouped;
			}
		}
}