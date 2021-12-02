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
using System.Windows.Shapes;

namespace Wireframe
{
    /// <summary>
    /// Логика взаимодействия для Wireframe_Slide3.xaml
    /// </summary>
    public partial class Wireframe_Slide3 : Window
    {
        public Wireframe_Slide3()
        {
            InitializeComponent();

            dataGridView1.Items.Add(new Atlantic { Logo1 = "/Elipse1.png", TeamName1= "TeamName", Roster1= "Roster", Matchup1= "Matchup", FirstLineup1= "FirstLineup" });
            dataGridView1.Items.Add(new Atlantic { Logo1 = "/Elipse1.png", TeamName1= "TeamName", Roster1= "Roster", Matchup1= "Matchup", FirstLineup1= "FirstLineup" });
            dataGridView1.Items.Add(new Atlantic { Logo1 = "/Elipse1.png", TeamName1= "TeamName", Roster1= "Roster", Matchup1= "Matchup", FirstLineup1= "FirstLineup" });
            dataGridView1.Items.Add(new Atlantic { Logo1 = "/Elipse1.png", TeamName1= "TeamName", Roster1= "Roster", Matchup1= "Matchup", FirstLineup1= "FirstLineup" });
            dataGridView1.Items.Add(new Atlantic { Logo1 = "/Elipse1.png", TeamName1= "TeamName", Roster1= "Roster", Matchup1= "Matchup", FirstLineup1= "FirstLineup" });

            dataGridView2.Items.Add(new Central { Logo2= "/Elipse1.png", TeamName2 = "TeamName", Roster2 = "Roster", Matchup2 = "Matchup", FirstLineup2 = "FirstLineup" });
            dataGridView2.Items.Add(new Central { Logo2= "/Elipse1.png", TeamName2 = "TeamName", Roster2 = "Roster", Matchup2 = "Matchup", FirstLineup2 = "FirstLineup" });
            dataGridView2.Items.Add(new Central { Logo2= "/Elipse1.png", TeamName2 = "TeamName", Roster2 = "Roster", Matchup2 = "Matchup", FirstLineup2 = "FirstLineup" });
            dataGridView2.Items.Add(new Central { Logo2= "/Elipse1.png", TeamName2 = "TeamName", Roster2 = "Roster", Matchup2 = "Matchup", FirstLineup2 = "FirstLineup" });
            dataGridView2.Items.Add(new Central { Logo2= "/Elipse1.png", TeamName2 = "TeamName", Roster2 = "Roster", Matchup2 = "Matchup", FirstLineup2 = "FirstLineup" });

            dataGridView3.Items.Add(new Southeast { Logo3= "/Elipse1.png", TeamName3 = "TeamName", Roster3 = "Roster", Matchup3 = "Matchup", FirstLineup3 = "FirstLineup" });
            dataGridView3.Items.Add(new Southeast { Logo3= "/Elipse1.png", TeamName3 = "TeamName", Roster3 = "Roster", Matchup3 = "Matchup", FirstLineup3 = "FirstLineup" });
            dataGridView3.Items.Add(new Southeast { Logo3= "/Elipse1.png", TeamName3 = "TeamName", Roster3 = "Roster", Matchup3 = "Matchup", FirstLineup3 = "FirstLineup" });
            dataGridView3.Items.Add(new Southeast { Logo3= "/Elipse1.png", TeamName3 = "TeamName", Roster3 = "Roster", Matchup3 = "Matchup", FirstLineup3 = "FirstLineup" });
            dataGridView3.Items.Add(new Southeast { Logo3= "/Elipse1.png", TeamName3 = "TeamName", Roster3 = "Roster", Matchup3 = "Matchup", FirstLineup3 = "FirstLineup" });


        }
    }

    public class Atlantic
    {
        public string Logo1 { get; set; }
        public string TeamName1 { get; set; }
        public string Roster1 { get; set; }
        public string Matchup1 { get; set; }
        public string FirstLineup1 { get; set; }

    }

    public class Central
    {
        public string Logo2{ get; set; }
        public string TeamName2 { get; set; }
        public string Roster2 { get; set; }
        public string Matchup2 { get; set; }
        public string FirstLineup2 { get; set; }

    }  
    public class Southeast
    {
        public string Logo3{ get; set; }
        public string TeamName3 { get; set; }
        public string Roster3 { get; set; }
        public string Matchup3 { get; set; }
        public string FirstLineup3 { get; set; }

    }
}
