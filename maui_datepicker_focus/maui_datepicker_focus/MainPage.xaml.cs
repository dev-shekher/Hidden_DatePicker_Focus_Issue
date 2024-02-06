namespace maui_datepicker_focus;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        var cdp = this.FindByName("datePickerVisible") as DatePicker;
        cdp?.Focus();
    }

    void Button_Clicked_2(System.Object sender, System.EventArgs e)
    {
        var dp = this.FindByName("datePickerHidden") as DatePicker;
        dp?.Focus();
    }

    void Button_Clicked_3(System.Object sender, System.EventArgs e)
    {
        var cdp = this.FindByName("timeHidden") as TimePicker;
        cdp?.Focus();
    }

    void Button_Clicked_4(System.Object sender, System.EventArgs e)
    {
        var dp = this.FindByName("timeVisible") as TimePicker;
        dp?.Focus();
    }
}


