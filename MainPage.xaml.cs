using ListViewBug.Models;

namespace ListViewBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		var OBJECT1 = new ListViewTextClass()
		{
			text1 = "This is a test on",
			text2 = "Dot NET MAUI"
		};

        var OBJECT2 = new ListViewTextClass()
        {
            text1 = "test",
            text2 = "2"
        };

        var listContent = new List<ListViewTextClass>();
		listContent.Add(OBJECT1);
		listContent.Add(OBJECT2);

		testListView.ItemsSource = null;
		testListView.ItemsSource = listContent;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

