public class ListingActivity : Activity
{
    public string _userResponse { get; set; }
    public ListingActivity(string nameActivity) : base(nameActivity)
    {
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DisplayPrompt()
    {
        
    }

}