

namespace EDU_Management_App;

public partial class MainPage : ContentPage
{
    int count = 0;
    int count2 = 0; 
    
    public MainPage()
    {
        InitializeComponent();
    }

    private void StudentLoginClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            StudentBtn.Text = $"Clicked {count} time";
        else
            StudentBtn.Text = $"Clicked {count} times";
        
    }
    
    private void InstructorLoginClicked(object sender, EventArgs e)
    {
        count2++;

        if (count2 == 1)
            InstructorBtn.Text = $"Clicked {count2} time";
        else
            InstructorBtn.Text = $"Clicked {count2} times";

    }
}