using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MysticPartyTracker.Views;

public partial class SpellsView : ContentPage
{
	public SpellsView()
	{
		InitializeComponent();
		LoadSpells();
	}

	private async void LoadSpells()
	{
		var spells = await FetchSpellsAsync();
		SpellsListView.ItemsSource = spells.Results;
	}
	
	private async Task<Response> FetchSpellsAsync()
	{
		using (var client = new HttpClient())
		{
			var response = await client.GetStringAsync("https://5e-bits.github.io/docs/api/get-list-of-spells-with-opitional-filtering");
			return JsonConvert.DeserializeObject<Response>(response);
		}
	}
}

public class Result
{
	public string Index { get; set; }
    public string Name { get; set; }
	public int Level { get; set; }
	public string Url { get; set; }
}

public class Response
{
	public int Count { get; set; }
	public List<Result> Results { get; set; }
}