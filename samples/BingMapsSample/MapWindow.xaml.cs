using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BingMapsSample
{
    /// <summary>
    /// Interaction logic for MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        public MapWindow()
        {
            InitializeComponent();

            //plot.Tag = bingmap;

            //List<double> lat = new List<double>(), lon = new List<double>(), data = new List<double>();
            //using (var reader = new StreamReader(@"..\..\crop_area.csv"))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //        lon.Add(Double.Parse(values[0], CultureInfo.InvariantCulture));
            //        lat.Add(Double.Parse(values[1], CultureInfo.InvariantCulture));
            //        data.Add(Double.Parse(values[2], CultureInfo.InvariantCulture));
            //    }
            //}

            //markers.PlotColor(lon.ToArray(), lat.ToArray(), data.ToArray());
        }
    }
}
