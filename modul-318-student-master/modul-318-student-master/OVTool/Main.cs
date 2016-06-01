using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;

namespace OVTool
{
    public partial class Main : Form
    {
        private readonly GMapOverlay _markersOverlay = new GMapOverlay("markers");
        private GMapMarker _currentMarker;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeMap();
        }

        private void InitializeMap()
        {
            //Setting initial map configs
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl.ShowCenter = false;
            gMapControl.Position = new PointLatLng(46.7976691, 8.2275602);
        }

        readonly Transport _trans = new Transport();

        # region Textboxen mit Vorschlägen befüllen
        //Textboxen mit Vorschlägen befüllen
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbVon.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = SearchStations(tbVon.Text);
                tbVon.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbBis.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = SearchStations(tbBis.Text);
                tbBis.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void txtAbfahrtsplanVon_TextChanged(object sender, EventArgs e)
        {
            if (tbAbfahrtsplanVon.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = SearchStations(tbAbfahrtsplanVon.Text);
                tbAbfahrtsplanVon.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            if (tbStation.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = SearchStations(tbStation.Text);
                tbStation.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void tbAktuelleStation_TextChanged(object sender, EventArgs e)
        {
            if (tbAktuelleStation.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = SearchStations(tbAktuelleStation.Text);
                tbAktuelleStation.AutoCompleteCustomSource = autocompleteList;
            }
        }
        #endregion

        #region Suchen Button Logik
        //Verbindungen suchen 
        private void btnVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbVon.Text) && !string.IsNullOrEmpty(tbBis.Text))
            {
                //Vorherige Ergebnisse löschen
                VerbindungenListview.Items.Clear();

                DateTime zeit = Convert.ToDateTime(time.Text).Date;
                zeit += Convert.ToDateTime(time.Text).TimeOfDay;
                Connections connections = _trans.GetConnectionsTime(tbVon.Text, tbBis.Text, zeit);

                foreach (Connection currentConnection in connections.ConnectionList)
                {
                    DateTime departure = Convert.ToDateTime(currentConnection.From.Departure);
                    string duration = currentConnection.Duration.Remove(0, 3);
                    duration = duration.Remove(5);
                    ListViewItem newConnection = new ListViewItem { Text = currentConnection.From.Station.Name };
                    newConnection.SubItems.Add(currentConnection.To.Station.Name);
                    newConnection.SubItems.Add(departure.ToString("HH:mm"));
                    newConnection.SubItems.Add(duration);
                    newConnection.SubItems.Add(currentConnection.From.Platform);

                    VerbindungenListview.Items.Add(newConnection);
                }
            }
            else
            {
                MessageBox.Show(@"Bitte Station bei Von und Bis auswählen!", @"Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Stationen suchen
        private AutoCompleteStringCollection SearchStations(string query)
        {
            List<Station> stationen = _trans.GetStations(query).StationList;
            AutoCompleteStringCollection autoList = new AutoCompleteStringCollection();
            foreach (Station station in stationen)
            {
                autoList.Add(station.Name);
            }
            return autoList;
        }

        //Abfahrtsplan suchen
        private void btnAbfahrtsplanSuchen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAbfahrtsplanVon.Text))
            {
                //Vorherige Ergebnisse löschen
                listViewAbfahrtsplan.Items.Clear();

                StationBoardRoot stationboards = _trans.GetStationBoard(tbAbfahrtsplanVon.Text,
                    _trans.GetStations(tbAbfahrtsplanVon.Text).StationList.First().Id);

                foreach (StationBoard board in stationboards.Entries)
                {
                    ListViewItem newBoard = new ListViewItem
                    {
                        Text = _trans.GetStations(tbAbfahrtsplanVon.Text).StationList.First().Name
                    };
                    newBoard.SubItems.Add(board.To);
                    newBoard.SubItems.Add(board.Stop.Departure.ToShortTimeString());

                    listViewAbfahrtsplan.Items.Add(newBoard);
                }
            }
            else
            {
                MessageBox.Show(@"Bitte Station bei Von auswählen!", @"Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Stationen auf Maps suchen
        private void btnStationSuchen_Click(object sender, EventArgs e)
        {
            gMapControl.Position = new PointLatLng(
                _trans.GetStations(tbStation.Text).StationList.First().Coordinate.XCoordinate,
                _trans.GetStations(tbStation.Text).StationList.First().Coordinate.YCoordinate);

            //Marker entfernen
            _markersOverlay.Markers.Remove(_currentMarker);

            //In die Station zoomen
            gMapControl.Zoom = 15;

            //Marker setzen
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(_trans.GetStations(tbStation.Text).StationList.First().Coordinate.XCoordinate, _trans.GetStations(tbStation.Text).StationList.First().Coordinate.YCoordinate),
            GMarkerGoogleType.red_dot);
            _markersOverlay.Markers.Add(marker);
            gMapControl.Overlays.Add(_markersOverlay);
            _currentMarker = marker;
        }

        //Stationen in der Nähe suchen 
        private void btnStationNaeheSuchen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAktuelleStation.Text))
            {
                //Vorherige Ergebnisse löschen
                ListviewStationenInDerNaehe.Items.Clear();

                double xCoordinate =
                    _trans.GetStations(tbAktuelleStation.Text).StationList.First().Coordinate.XCoordinate;
                double yCoordinate =
                    _trans.GetStations(tbAktuelleStation.Text).StationList.First().Coordinate.YCoordinate;

                List<Station> stationen = _trans.GetStationsByCoordinate(xCoordinate, yCoordinate).StationList;
                foreach (Station station in stationen)
                {
                    ListViewItem newConnection = new ListViewItem { Text = station.Name };
                    ListviewStationenInDerNaehe.Items.Add(newConnection);
                }
            }
            else
            {
                MessageBox.Show(@"Bitte Station bei Aktuelle Station auswählen!", @"Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Ergebnisse versenden
        //Ergebnisse versenden Buttons
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            SendMail(VerbindungenListview);
        }

        private void btnAbfahrtsplanSendMail_Click(object sender, EventArgs e)
        {
            SendMail(listViewAbfahrtsplan);
        }

        private void btnStationenNaeheSendMail_Click(object sender, EventArgs e)
        {
            SendMail(ListviewStationenInDerNaehe);
        }

        //Öffnet Mail Dialog, falls Ergebnisse nicht leer sind
        private void SendMail(ListView listview)
        {
            if (listview.Items.Count != 0)
            {
                SendMail email = new SendMail(listview);
                email.Show();
            }
            else
            {
                MessageBox.Show(@"Bitte suchen sie zuerst nach gültigen Verbindungen.", @"Keine Resultate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
