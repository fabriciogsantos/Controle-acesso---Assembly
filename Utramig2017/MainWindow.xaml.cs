using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Utramig2017
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += WindowLoaded;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            var gridview = new GridView();
            listEvento.View = gridview;
            gridview.Columns.Add(new GridViewColumn() { Header="Evento", DisplayMemberBinding = new Binding("Evento"), Width= (listEvento.Width / 2) });
            gridview.Columns.Add(new GridViewColumn() { Header = "Data Hora", DisplayMemberBinding = new Binding("Data_hora"), Width= (listEvento.Width / 2) });
            
            this.listEvento.Items.Add(new itensList { Evento = "Alerta", Data_hora = "05/05/2017" });
        }
    }

    public class itensList:TextBlock
    {
        public string Evento { get; set; }

        

        public string Data_hora { get; set; }
    }
}
