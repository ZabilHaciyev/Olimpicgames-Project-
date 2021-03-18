using BaseApp.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScoreManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindow : Window
    {
        public  List<SportType> Games { get; set; } = new List<SportType>();
        

        public MainWindow()
        {

            InitializeComponent();
            Games.Add(new SportType() { Name="Gules" });
            Games.Add(new SportType() { Name = "Box" });
            Games.Add(new SportType() { Name = "uzguculuk" });
            Games.Add(new SportType() { Name = "qacish" });


            this.DataContext = this;
            
        }
    }
}
