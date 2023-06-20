using System.Collections.ObjectModel;

namespace EntryIssue;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> StringList { get; set; }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        StringList = new ObservableCollection<string>();
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        // Add the entered string to the stringList
        StringList.Add(entry.Text);

        // Clear the entry field
        entry.Text = string.Empty;

        // Notify the UI to update the binding
        OnPropertyChanged(nameof(StringList));
    }
}

