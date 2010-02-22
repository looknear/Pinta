// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Pinta {
    
    
    public partial class CurvesDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label labelMap;
        
        private Gtk.HSeparator hseparatorMap;
        
        private Gtk.HBox hbox2;
        
        private Gtk.ComboBox comboMap;
        
        private Gtk.Alignment alignment3;
        
        private Gtk.Label labelPoint;
        
        private Gtk.DrawingArea drawing;
        
        private Gtk.HBox hbox3;
        
        private Gtk.CheckButton checkRed;
        
        private Gtk.CheckButton checkGreen;
        
        private Gtk.CheckButton checkBlue;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.Button buttonReset;
        
        private Gtk.Label labelTip;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Pinta.CurvesDialog
            this.Name = "Pinta.CurvesDialog";
            this.Title = Mono.Unix.Catalog.GetString("Curves");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Resizable = false;
            this.AllowGrow = false;
            // Internal child Pinta.CurvesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.labelMap = new Gtk.Label();
            this.labelMap.Name = "labelMap";
            this.labelMap.LabelProp = Mono.Unix.Catalog.GetString("Transfer Map");
            this.hbox1.Add(this.labelMap);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.labelMap]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hseparatorMap = new Gtk.HSeparator();
            this.hseparatorMap.Name = "hseparatorMap";
            this.hbox1.Add(this.hseparatorMap);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.hseparatorMap]));
            w3.Position = 1;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.comboMap = Gtk.ComboBox.NewText();
            this.comboMap.AppendText(Mono.Unix.Catalog.GetString("RGB"));
            this.comboMap.AppendText(Mono.Unix.Catalog.GetString("Luminosity"));
            this.comboMap.Name = "comboMap";
            this.comboMap.Active = 1;
            this.hbox2.Add(this.comboMap);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.comboMap]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.alignment3 = new Gtk.Alignment(1F, 0.5F, 0F, 0F);
            this.alignment3.Name = "alignment3";
            // Container child alignment3.Gtk.Container+ContainerChild
            this.labelPoint = new Gtk.Label();
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.LabelProp = Mono.Unix.Catalog.GetString("(256, 256)");
            this.alignment3.Add(this.labelPoint);
            this.hbox2.Add(this.alignment3);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.alignment3]));
            w7.PackType = ((Gtk.PackType)(1));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            w1.Add(this.hbox2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.hbox2]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.drawing = new Gtk.DrawingArea();
            this.drawing.WidthRequest = 256;
            this.drawing.HeightRequest = 256;
            this.drawing.CanFocus = true;
            this.drawing.Events = ((Gdk.EventMask)(795646));
            this.drawing.Name = "drawing";
            w1.Add(this.drawing);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.drawing]));
            w9.Position = 2;
            w9.Padding = ((uint)(8));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            // Container child hbox3.Gtk.Box+BoxChild
            this.checkRed = new Gtk.CheckButton();
            this.checkRed.CanFocus = true;
            this.checkRed.Name = "checkRed";
            this.checkRed.Label = Mono.Unix.Catalog.GetString("Red  ");
            this.checkRed.Active = true;
            this.checkRed.DrawIndicator = true;
            this.checkRed.UseUnderline = true;
            this.hbox3.Add(this.checkRed);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox3[this.checkRed]));
            w10.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.checkGreen = new Gtk.CheckButton();
            this.checkGreen.CanFocus = true;
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Label = Mono.Unix.Catalog.GetString("Green");
            this.checkGreen.Active = true;
            this.checkGreen.DrawIndicator = true;
            this.checkGreen.UseUnderline = true;
            this.hbox3.Add(this.checkGreen);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox3[this.checkGreen]));
            w11.Position = 1;
            // Container child hbox3.Gtk.Box+BoxChild
            this.checkBlue = new Gtk.CheckButton();
            this.checkBlue.CanFocus = true;
            this.checkBlue.Name = "checkBlue";
            this.checkBlue.Label = Mono.Unix.Catalog.GetString("Blue ");
            this.checkBlue.Active = true;
            this.checkBlue.DrawIndicator = true;
            this.checkBlue.UseUnderline = true;
            this.hbox3.Add(this.checkBlue);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox3[this.checkBlue]));
            w12.Position = 2;
            // Container child hbox3.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.hbox3.Add(this.alignment1);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox3[this.alignment1]));
            w13.Position = 3;
            // Container child hbox3.Gtk.Box+BoxChild
            this.buttonReset = new Gtk.Button();
            this.buttonReset.WidthRequest = 81;
            this.buttonReset.HeightRequest = 30;
            this.buttonReset.CanFocus = true;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseUnderline = true;
            this.buttonReset.Label = Mono.Unix.Catalog.GetString("Reset");
            this.hbox3.Add(this.buttonReset);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox3[this.buttonReset]));
            w14.Position = 4;
            w14.Expand = false;
            w14.Fill = false;
            w1.Add(this.hbox3);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(w1[this.hbox3]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.labelTip = new Gtk.Label();
            this.labelTip.Name = "labelTip";
            this.labelTip.LabelProp = Mono.Unix.Catalog.GetString("Tip : Right-click to remove control points.");
            w1.Add(this.labelTip);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(w1[this.labelTip]));
            w16.Position = 4;
            w16.Expand = false;
            w16.Fill = false;
            // Internal child Pinta.CurvesDialog.ActionArea
            Gtk.HButtonBox w17 = this.ActionArea;
            w17.Name = "dialog1_ActionArea";
            w17.Spacing = 10;
            w17.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w18 = ((Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonCancel]));
            w18.Expand = false;
            w18.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w19 = ((Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonOk]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 269;
            this.DefaultHeight = 418;
            this.checkRed.Hide();
            this.checkGreen.Hide();
            this.checkBlue.Hide();
            this.Show();
        }
    }
}
