namespace ThreeMinAlert;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Alarm();
	}
	private async void Alarm(){
		var time = int.Parse(entry.Text);

		// for(var i = time; time > 0; i--){
		// 	var Remtime = Convert.ToString(i);
		// 	RemainingTime.Text = Remtime;
		// 	await Task.Delay(1000);
		// }
		while(time != 0){
			var Remtime = Convert.ToString(time);
			RemainingTime.Text = Remtime;
			await Task.Delay(1000);
			time--;
		}
		AlarmUp();
	}
	private void AlarmUp(){
		var title = "time up";
		label.Text = title;
	}
}

