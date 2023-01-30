namespace ParserProgram;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnParserClicked(object sender, EventArgs e)
	{
        string[] expressions = textEditor.Text.Split("\r", StringSplitOptions.RemoveEmptyEntries);
        string[] results = new string[expressions.Length];
		
        for (int i = 0; i < expressions.Length; i++)
        {
            results[i] = $"{i}:\t{expressions[i]} is {Parse(expressions[i])}";
        }
		
        ParseRslt.Text = string.Join("\n", results);
		SemanticScreenReader.Announce(ParseRslt.Text);

    }

	private bool Parse(string text)
	{



		return false;
	}
}

