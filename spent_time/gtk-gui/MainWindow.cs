// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Fixed fixed4;
    
    private Gtk.ComboBoxEntry comboboxentry1;
    
    private Gtk.ToggleButton togglebutton2;
    
    private Gtk.Label label1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.TextView textview2;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        this.Resizable = false;
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.fixed4 = new Gtk.Fixed();
        this.fixed4.Name = "fixed4";
        this.fixed4.HasWindow = false;
        // Container child fixed4.Gtk.Fixed+FixedChild
        this.comboboxentry1 = Gtk.ComboBoxEntry.NewText();
        this.comboboxentry1.WidthRequest = 450;
        this.comboboxentry1.Name = "comboboxentry1";
        this.fixed4.Add(this.comboboxentry1);
        // Container child fixed4.Gtk.Fixed+FixedChild
        this.togglebutton2 = new Gtk.ToggleButton();
        this.togglebutton2.WidthRequest = 50;
        this.togglebutton2.CanFocus = true;
        this.togglebutton2.Name = "togglebutton2";
        this.togglebutton2.UseUnderline = true;
        this.togglebutton2.Label = Mono.Unix.Catalog.GetString("On");
        this.fixed4.Add(this.togglebutton2);
        Gtk.Fixed.FixedChild w2 = ((Gtk.Fixed.FixedChild)(this.fixed4[this.togglebutton2]));
        w2.X = 450;
        // Container child fixed4.Gtk.Fixed+FixedChild
        this.label1 = new Gtk.Label();
        this.label1.WidthRequest = 100;
        this.label1.HeightRequest = 28;
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("00:11:22");
        this.fixed4.Add(this.label1);
        Gtk.Fixed.FixedChild w3 = ((Gtk.Fixed.FixedChild)(this.fixed4[this.label1]));
        w3.X = 500;
        // Container child fixed4.Gtk.Fixed+FixedChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.WidthRequest = 600;
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.textview2 = new Gtk.TextView();
        this.textview2.CanFocus = true;
        this.textview2.Name = "textview2";
        this.GtkScrolledWindow.Add(this.textview2);
        this.fixed4.Add(this.GtkScrolledWindow);
        Gtk.Fixed.FixedChild w5 = ((Gtk.Fixed.FixedChild)(this.fixed4[this.GtkScrolledWindow]));
        w5.Y = 32;
        this.Add(this.fixed4);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 602;
        this.DefaultHeight = 178;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.togglebutton2.Toggled += new System.EventHandler(this.togglebutton2_onClick);
    }
}
