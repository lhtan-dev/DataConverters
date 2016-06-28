using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Converters
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<Song> songs = new List<Song>(
            new[]
            {
                new Song
                {
                    title = "Song A",
                    artist = "Artist A",
                    availability = false,
                    date = "1/1/1991",
                },
                new Song
                {  title = "Song B",
                    artist = "Artist B",
                    availability = true,
                    date = "1/1/1992",
                },
                new Song
                {
                      title = "Song C",
                    artist = "Artist C",
                    availability = true,
                    date = "1/1/1993",
                },
                new Song
                {
                      title = "Song D",
                    artist = "Artist D",
                    availability = false,
                    date = "1/1/1994",
                },
                new Song
                {
                    title = "Song E",
                    artist = "Artist E",
                    availability = false,
                    date = "1/1/1995",
                },
            });

        public MainPage()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ExampleListView.ItemsSource = songs;
            base.OnNavigatedTo(e);
        }

        public class Song
        {
            public string title { get; set; }
            public string artist { get; set; }
            public string date { get; set; }
            public bool availability { get; set; }

        }
    }
}
