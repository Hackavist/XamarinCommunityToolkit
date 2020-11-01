using System;
namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
	public class IntToBoolConverterViewModel:BaseViewModel
	{
		int _index;
		public int Number
		{
			get => _index;
			set
			{
				_index = value;
				OnPropertyChanged(nameof(Number));
			}
		}
	}
}
