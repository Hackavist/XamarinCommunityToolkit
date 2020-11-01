namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
	public class IndexToArrayItemConverterViewModel : BaseViewModel
	{
		int _index;
		public int Index
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
