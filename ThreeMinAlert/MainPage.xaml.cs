namespace ThreeMinAlert;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		label.Text = "カウントスタート";
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
		RemainingTime.Text = "";
		AlarmUp();
	}
	private void AlarmUp(){
		label.Text = "time up";
	}
}

