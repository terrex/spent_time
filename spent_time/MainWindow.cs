using System;
using Gtk;
using spent_time;

public partial class MainWindow : Gtk.Window
{

	Timer timer = new Timer();

	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected virtual void togglebutton2_onClick (object sender, System.EventArgs e)
	{
		if (this.togglebutton2.Label == "On") {
			this.togglebutton2.Label = "Off";
			this.timer.start();
		} else {
			this.togglebutton2.Label = "On";
			this.timer.stop();
			this.label1.Text = this.timer.getTime();
			this.textview2.Buffer.Text = this.comboboxentry1.Entry.Text +
				";" + this.timer.getTime() + "\n" + this.textview2.Buffer.Text;
		}
	}
	
}
