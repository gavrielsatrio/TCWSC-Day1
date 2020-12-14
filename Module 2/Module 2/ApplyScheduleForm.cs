using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Module_2
{
    public partial class ApplyScheduleForm : Form
    {
        private Module2Entities db = new Module2Entities();

        public ApplyScheduleForm()
        {
            InitializeComponent();
        }

        private void ApplyScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog()
            { 
                InitialDirectory = Application.StartupPath,
                Filter = "CSV Files (*.csv;)|*.csv;"
            };

            if(open.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = open.FileName.Split('\\').Last();

                var file = File.ReadAllText(open.FileName);
                var lines = file.Split('\n');

                var successCount = 0;
                var dupCount = 0;
                var missCount = 0;

                foreach (var line in lines)
                {
                    try
                    {
                        var type = line.Split(',')[0];
                        var date = DateTime.Parse(line.Split(',')[1]);
                        var time = TimeSpan.Parse(line.Split(',')[2] + ":00");
                        var flightNumber = line.Split(',')[3];
                        var fromAirport = line.Split(',')[4];
                        var toAirport = line.Split(',')[5];

                        var fromAirportID = db.Airports.Where(x => x.IATACode == fromAirport).Select(x => x.ID).ToArray()[0];
                        var toAirportID = db.Airports.Where(x => x.IATACode == toAirport).Select(x => x.ID).ToArray()[0];

                        var aircraftID = int.Parse(line.Split(',')[6]);
                        var price = int.Parse(line.Split(',')[7].Split('.')[0]);
                        var active = line.Split(',')[8].Trim() == "OK" ? true : false;

                        var routeID = db.Routes.Where(x => x.DepartureAirportID == fromAirportID && x.ArrivalAirportID == toAirportID).Select(x => x.ID).ToArray()[0];

                        if (type == "ADD")
                        {
                            if(db.Schedules.Where(x => x.Date == date && x.FlightNumber == flightNumber).Select(x => x.ID).ToArray().Length > 0)
                            {
                                dupCount++;
                            }
                            else
                            {
                                db.Schedules.Add(new Schedule
                                {
                                    Date = date,
                                    Time = time,
                                    AircraftID = aircraftID,
                                    RouteID = routeID,
                                    EconomyPrice = price,
                                    Confirmed = active,
                                    FlightNumber = flightNumber
                                });
                                db.SaveChanges();

                                successCount++;
                            }
                        }
                        else
                        {
                            var scheduleID = db.Schedules.Where(x => x.Date == date && x.FlightNumber == flightNumber).Select(x => x.ID).ToArray()[0];
                            var query = db.Schedules.Find(scheduleID);

                            query.Time = time;
                            query.AircraftID = aircraftID;
                            query.RouteID = routeID;
                            query.EconomyPrice = price;
                            query.Confirmed = active;

                            db.SaveChanges();
                            successCount++;
                        }
                    }
                    catch
                    {
                        missCount++;
                    }
                }

                txtSuccess.Text = successCount.ToString();
                txtDuplicate.Text = dupCount.ToString();
                txtMissing.Text = missCount.ToString();
            }
        }
    }
}
