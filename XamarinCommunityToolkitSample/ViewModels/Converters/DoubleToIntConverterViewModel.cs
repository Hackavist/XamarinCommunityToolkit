namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
	public class DoubleToIntConverterViewModel : BaseViewModel
	{
		double _index;
		public double Index
		{
			get => _index;
			set
			{
				_index = value;
				OnPropertyChanged(nameof(Index));
			}
		}
	}
}
