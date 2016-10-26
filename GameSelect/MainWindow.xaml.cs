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

namespace GameSelect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectGame_Click_1(object sender, RoutedEventArgs e)
        {

            List<String> gameList = new List<String>();
            gameList.Add("Smite");
            gameList.Add("Overwatch");
            gameList.Add("Battleborn");
            gameList.Add("Payday2");
            gameList.Add("Planetside 2");
            gameList.Add("Elite Dangerous");
            gameList.Add("Rainbow 6 Siege");
            gameList.Add("OMDU");
            gameList.Add("Code AlcCalc");
            gameList.Add("Improve GameSelect");
            gameList.Add("Civ V");
            gameList.Add("Movie Night!");
            gameList.Add("Write the Hawk Book.");
            gameList.Add("Do that roll20 script.");
            gameList.Add("Judge a homebrew.");
            gameList.Add("Work on Cyberpunk 5e");
            gameList.Add("Get new carbon monoxide pipes.");
            gameList.Add("Wash car.");
            gameList.Add("Replace water heater");
            Random randy = new Random();
            int indext = randy.Next(1, gameList.Count);

            txtGameResult.Text = gameList[indext-1];
        }
    }
}
