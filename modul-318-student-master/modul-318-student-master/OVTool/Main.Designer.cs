namespace OVTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Verbindungen = new System.Windows.Forms.TabPage();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.VerbindungenListview = new System.Windows.Forms.ListView();
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindungenSuchen = new System.Windows.Forms.Button();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tbBis = new System.Windows.Forms.TextBox();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.lblBis = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.Abfahrtsplan = new System.Windows.Forms.TabPage();
            this.btnAbfahrtsplanSendMail = new System.Windows.Forms.Button();
            this.listViewAbfahrtsplan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbfahrtsplanSuchen = new System.Windows.Forms.Button();
            this.tbAbfahrtsplanVon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Stationssuche = new System.Windows.Forms.TabPage();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.btnStationSuchen = new System.Windows.Forms.Button();
            this.tbStation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStationNaeheSuchen = new System.Windows.Forms.Button();
            this.lblStationenInDerNaehe = new System.Windows.Forms.Label();
            this.btnStationenNaeheSendMail = new System.Windows.Forms.Button();
            this.ListviewStationenInDerNaehe = new System.Windows.Forms.ListView();
            this.Stationen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAktuelleStation = new System.Windows.Forms.Label();
            this.tbAktuelleStation = new System.Windows.Forms.TextBox();
            this.Tabs.SuspendLayout();
            this.Verbindungen.SuspendLayout();
            this.Abfahrtsplan.SuspendLayout();
            this.Stationssuche.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Verbindungen);
            this.Tabs.Controls.Add(this.Abfahrtsplan);
            this.Tabs.Controls.Add(this.Stationssuche);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(472, 426);
            this.Tabs.TabIndex = 0;
            // 
            // Verbindungen
            // 
            this.Verbindungen.Controls.Add(this.btnSendMail);
            this.Verbindungen.Controls.Add(this.VerbindungenListview);
            this.Verbindungen.Controls.Add(this.time);
            this.Verbindungen.Controls.Add(this.btnVerbindungenSuchen);
            this.Verbindungen.Controls.Add(this.lblZeit);
            this.Verbindungen.Controls.Add(this.lblDatum);
            this.Verbindungen.Controls.Add(this.date);
            this.Verbindungen.Controls.Add(this.tbBis);
            this.Verbindungen.Controls.Add(this.tbVon);
            this.Verbindungen.Controls.Add(this.lblBis);
            this.Verbindungen.Controls.Add(this.lblVon);
            this.Verbindungen.Location = new System.Drawing.Point(4, 22);
            this.Verbindungen.Name = "Verbindungen";
            this.Verbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.Verbindungen.Size = new System.Drawing.Size(464, 400);
            this.Verbindungen.TabIndex = 0;
            this.Verbindungen.Text = "Verbindungen";
            this.Verbindungen.UseVisualStyleBackColor = true;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendMail.Image = global::OVTool.Properties.Resources.Mail;
            this.btnSendMail.Location = new System.Drawing.Point(388, 80);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(48, 35);
            this.btnSendMail.TabIndex = 11;
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // VerbindungenListview
            // 
            this.VerbindungenListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Von,
            this.Bis,
            this.Departure,
            this.Dauer,
            this.Gleis});
            this.VerbindungenListview.Location = new System.Drawing.Point(24, 121);
            this.VerbindungenListview.Name = "VerbindungenListview";
            this.VerbindungenListview.Size = new System.Drawing.Size(412, 231);
            this.VerbindungenListview.TabIndex = 10;
            this.VerbindungenListview.UseCompatibleStateImageBehavior = false;
            this.VerbindungenListview.View = System.Windows.Forms.View.Details;
            // 
            // Von
            // 
            this.Von.Text = "Von";
            this.Von.Width = 127;
            // 
            // Bis
            // 
            this.Bis.Text = "Bis";
            this.Bis.Width = 121;
            // 
            // Departure
            // 
            this.Departure.Text = "Abfahrt";
            // 
            // Dauer
            // 
            this.Dauer.Text = "Dauer";
            this.Dauer.Width = 55;
            // 
            // Gleis
            // 
            this.Gleis.Text = "Gleis";
            this.Gleis.Width = 44;
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(68, 65);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 9;
            // 
            // btnVerbindungenSuchen
            // 
            this.btnVerbindungenSuchen.Location = new System.Drawing.Point(315, 358);
            this.btnVerbindungenSuchen.Name = "btnVerbindungenSuchen";
            this.btnVerbindungenSuchen.Size = new System.Drawing.Size(121, 24);
            this.btnVerbindungenSuchen.TabIndex = 8;
            this.btnVerbindungenSuchen.Text = "Suchen";
            this.btnVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungenSuchen.Click += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(22, 71);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(25, 13);
            this.lblZeit.TabIndex = 6;
            this.lblZeit.Text = "Zeit";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(21, 97);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(68, 91);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 4;
            // 
            // tbBis
            // 
            this.tbBis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbBis.Location = new System.Drawing.Point(68, 38);
            this.tbBis.Name = "tbBis";
            this.tbBis.Size = new System.Drawing.Size(159, 20);
            this.tbBis.TabIndex = 3;
            this.tbBis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbVon
            // 
            this.tbVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbVon.Location = new System.Drawing.Point(68, 12);
            this.tbVon.Name = "tbVon";
            this.tbVon.Size = new System.Drawing.Size(159, 20);
            this.tbVon.TabIndex = 2;
            this.tbVon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Location = new System.Drawing.Point(21, 41);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(21, 13);
            this.lblBis.TabIndex = 1;
            this.lblBis.Text = "Bis";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(21, 15);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(26, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von";
            // 
            // Abfahrtsplan
            // 
            this.Abfahrtsplan.Controls.Add(this.btnAbfahrtsplanSendMail);
            this.Abfahrtsplan.Controls.Add(this.listViewAbfahrtsplan);
            this.Abfahrtsplan.Controls.Add(this.btnAbfahrtsplanSuchen);
            this.Abfahrtsplan.Controls.Add(this.tbAbfahrtsplanVon);
            this.Abfahrtsplan.Controls.Add(this.label5);
            this.Abfahrtsplan.Location = new System.Drawing.Point(4, 22);
            this.Abfahrtsplan.Name = "Abfahrtsplan";
            this.Abfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.Abfahrtsplan.Size = new System.Drawing.Size(464, 400);
            this.Abfahrtsplan.TabIndex = 1;
            this.Abfahrtsplan.Text = "Abfahrtsplan";
            this.Abfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrtsplanSendMail
            // 
            this.btnAbfahrtsplanSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbfahrtsplanSendMail.Image = global::OVTool.Properties.Resources.Mail;
            this.btnAbfahrtsplanSendMail.Location = new System.Drawing.Point(392, 13);
            this.btnAbfahrtsplanSendMail.Name = "btnAbfahrtsplanSendMail";
            this.btnAbfahrtsplanSendMail.Size = new System.Drawing.Size(48, 35);
            this.btnAbfahrtsplanSendMail.TabIndex = 15;
            this.btnAbfahrtsplanSendMail.UseVisualStyleBackColor = true;
            this.btnAbfahrtsplanSendMail.Click += new System.EventHandler(this.btnAbfahrtsplanSendMail_Click);
            // 
            // listViewAbfahrtsplan
            // 
            this.listViewAbfahrtsplan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAbfahrtsplan.Location = new System.Drawing.Point(24, 54);
            this.listViewAbfahrtsplan.Name = "listViewAbfahrtsplan";
            this.listViewAbfahrtsplan.Size = new System.Drawing.Size(416, 301);
            this.listViewAbfahrtsplan.TabIndex = 14;
            this.listViewAbfahrtsplan.UseCompatibleStateImageBehavior = false;
            this.listViewAbfahrtsplan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bis";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abfahrt";
            this.columnHeader3.Width = 48;
            // 
            // btnAbfahrtsplanSuchen
            // 
            this.btnAbfahrtsplanSuchen.Location = new System.Drawing.Point(319, 361);
            this.btnAbfahrtsplanSuchen.Name = "btnAbfahrtsplanSuchen";
            this.btnAbfahrtsplanSuchen.Size = new System.Drawing.Size(121, 24);
            this.btnAbfahrtsplanSuchen.TabIndex = 13;
            this.btnAbfahrtsplanSuchen.Text = "Suchen";
            this.btnAbfahrtsplanSuchen.UseVisualStyleBackColor = true;
            this.btnAbfahrtsplanSuchen.Click += new System.EventHandler(this.btnAbfahrtsplanSuchen_Click);
            // 
            // tbAbfahrtsplanVon
            // 
            this.tbAbfahrtsplanVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAbfahrtsplanVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAbfahrtsplanVon.Location = new System.Drawing.Point(63, 16);
            this.tbAbfahrtsplanVon.Name = "tbAbfahrtsplanVon";
            this.tbAbfahrtsplanVon.Size = new System.Drawing.Size(161, 20);
            this.tbAbfahrtsplanVon.TabIndex = 12;
            this.tbAbfahrtsplanVon.TextChanged += new System.EventHandler(this.txtAbfahrtsplanVon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Von";
            // 
            // Stationssuche
            // 
            this.Stationssuche.Controls.Add(this.gMapControl);
            this.Stationssuche.Controls.Add(this.btnStationSuchen);
            this.Stationssuche.Controls.Add(this.tbStation);
            this.Stationssuche.Controls.Add(this.label6);
            this.Stationssuche.Location = new System.Drawing.Point(4, 22);
            this.Stationssuche.Name = "Stationssuche";
            this.Stationssuche.Size = new System.Drawing.Size(464, 400);
            this.Stationssuche.TabIndex = 2;
            this.Stationssuche.Text = "Stationssuche";
            this.Stationssuche.UseVisualStyleBackColor = true;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(19, 51);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 20;
            this.gMapControl.MinZoom = 7;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(425, 307);
            this.gMapControl.TabIndex = 17;
            this.gMapControl.Zoom = 7D;
            // 
            // btnStationSuchen
            // 
            this.btnStationSuchen.Location = new System.Drawing.Point(323, 364);
            this.btnStationSuchen.Name = "btnStationSuchen";
            this.btnStationSuchen.Size = new System.Drawing.Size(121, 24);
            this.btnStationSuchen.TabIndex = 16;
            this.btnStationSuchen.Text = "Suchen";
            this.btnStationSuchen.UseVisualStyleBackColor = true;
            this.btnStationSuchen.Click += new System.EventHandler(this.btnStationSuchen_Click);
            // 
            // tbStation
            // 
            this.tbStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbStation.Location = new System.Drawing.Point(58, 15);
            this.tbStation.Name = "tbStation";
            this.tbStation.Size = new System.Drawing.Size(168, 20);
            this.tbStation.TabIndex = 14;
            this.tbStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Station";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStationNaeheSuchen);
            this.tabPage1.Controls.Add(this.lblStationenInDerNaehe);
            this.tabPage1.Controls.Add(this.btnStationenNaeheSendMail);
            this.tabPage1.Controls.Add(this.ListviewStationenInDerNaehe);
            this.tabPage1.Controls.Add(this.lblAktuelleStation);
            this.tabPage1.Controls.Add(this.tbAktuelleStation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(464, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Stationen in der Nähe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStationNaeheSuchen
            // 
            this.btnStationNaeheSuchen.Location = new System.Drawing.Point(313, 367);
            this.btnStationNaeheSuchen.Name = "btnStationNaeheSuchen";
            this.btnStationNaeheSuchen.Size = new System.Drawing.Size(121, 24);
            this.btnStationNaeheSuchen.TabIndex = 15;
            this.btnStationNaeheSuchen.Text = "Suchen";
            this.btnStationNaeheSuchen.UseVisualStyleBackColor = true;
            this.btnStationNaeheSuchen.Click += new System.EventHandler(this.btnStationNaeheSuchen_Click);
            // 
            // lblStationenInDerNaehe
            // 
            this.lblStationenInDerNaehe.AutoSize = true;
            this.lblStationenInDerNaehe.Location = new System.Drawing.Point(19, 57);
            this.lblStationenInDerNaehe.Name = "lblStationenInDerNaehe";
            this.lblStationenInDerNaehe.Size = new System.Drawing.Size(113, 13);
            this.lblStationenInDerNaehe.TabIndex = 14;
            this.lblStationenInDerNaehe.Text = "Stationen in der Nähe:";
            // 
            // btnStationenNaeheSendMail
            // 
            this.btnStationenNaeheSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStationenNaeheSendMail.Image = global::OVTool.Properties.Resources.Mail;
            this.btnStationenNaeheSendMail.Location = new System.Drawing.Point(386, 14);
            this.btnStationenNaeheSendMail.Name = "btnStationenNaeheSendMail";
            this.btnStationenNaeheSendMail.Size = new System.Drawing.Size(48, 35);
            this.btnStationenNaeheSendMail.TabIndex = 13;
            this.btnStationenNaeheSendMail.UseVisualStyleBackColor = true;
            this.btnStationenNaeheSendMail.Click += new System.EventHandler(this.btnStationenNaeheSendMail_Click);
            // 
            // ListviewStationenInDerNaehe
            // 
            this.ListviewStationenInDerNaehe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stationen});
            this.ListviewStationenInDerNaehe.Location = new System.Drawing.Point(22, 73);
            this.ListviewStationenInDerNaehe.Name = "ListviewStationenInDerNaehe";
            this.ListviewStationenInDerNaehe.Size = new System.Drawing.Size(412, 288);
            this.ListviewStationenInDerNaehe.TabIndex = 12;
            this.ListviewStationenInDerNaehe.UseCompatibleStateImageBehavior = false;
            this.ListviewStationenInDerNaehe.View = System.Windows.Forms.View.Details;
            // 
            // Stationen
            // 
            this.Stationen.Text = "Station";
            this.Stationen.Width = 408;
            // 
            // lblAktuelleStation
            // 
            this.lblAktuelleStation.AutoSize = true;
            this.lblAktuelleStation.Location = new System.Drawing.Point(19, 17);
            this.lblAktuelleStation.Name = "lblAktuelleStation";
            this.lblAktuelleStation.Size = new System.Drawing.Size(81, 13);
            this.lblAktuelleStation.TabIndex = 1;
            this.lblAktuelleStation.Text = "Aktuelle Station";
            // 
            // tbAktuelleStation
            // 
            this.tbAktuelleStation.Location = new System.Drawing.Point(106, 14);
            this.tbAktuelleStation.Name = "tbAktuelleStation";
            this.tbAktuelleStation.Size = new System.Drawing.Size(148, 20);
            this.tbAktuelleStation.TabIndex = 0;
            this.tbAktuelleStation.TextChanged += new System.EventHandler(this.tbAktuelleStation_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tabs.ResumeLayout(false);
            this.Verbindungen.ResumeLayout(false);
            this.Verbindungen.PerformLayout();
            this.Abfahrtsplan.ResumeLayout(false);
            this.Abfahrtsplan.PerformLayout();
            this.Stationssuche.ResumeLayout(false);
            this.Stationssuche.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Verbindungen;
        private System.Windows.Forms.TabPage Abfahrtsplan;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox tbBis;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Button btnVerbindungenSuchen;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ListView VerbindungenListview;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Bis;
        private System.Windows.Forms.ColumnHeader Departure;
        private System.Windows.Forms.ColumnHeader Dauer;
        private System.Windows.Forms.ColumnHeader Gleis;
        private System.Windows.Forms.ListView listViewAbfahrtsplan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAbfahrtsplanSuchen;
        private System.Windows.Forms.TextBox tbAbfahrtsplanVon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Stationssuche;
        private System.Windows.Forms.Button btnStationSuchen;
        private System.Windows.Forms.TextBox tbStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendMail;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Button btnAbfahrtsplanSendMail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblAktuelleStation;
        private System.Windows.Forms.TextBox tbAktuelleStation;
        private System.Windows.Forms.Label lblStationenInDerNaehe;
        private System.Windows.Forms.Button btnStationenNaeheSendMail;
        private System.Windows.Forms.ListView ListviewStationenInDerNaehe;
        private System.Windows.Forms.ColumnHeader Stationen;
        private System.Windows.Forms.Button btnStationNaeheSuchen;
    }
}

