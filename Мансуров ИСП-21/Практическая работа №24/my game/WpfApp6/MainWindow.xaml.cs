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
using System.Xml.Serialization;

namespace WpfApp6
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

        int killsCounter = 0;

        private void start_Game(object sender, RoutedEventArgs e)
        {
            update_frame();
            
        }

        void ct_win_game()
        {
            stats_tab.Visibility = Visibility.Hidden;
            awp.Visibility = Visibility.Hidden;
            enemy_1.Visibility = Visibility.Hidden;
            enemy_2.Visibility = Visibility.Hidden;
            crosshair.Visibility = Visibility.Hidden;
            friend.Visibility = Visibility.Hidden;
            ct_win_logo.Visibility = Visibility.Visible;
            fire_particle.Visibility = Visibility.Hidden;
            blood_particle.Visibility = Visibility.Hidden;
        }

        void tt_win_game()
        {
            stats_tab.Visibility = Visibility.Hidden;
            awp.Visibility = Visibility.Hidden;
            enemy_1.Visibility = Visibility.Hidden;
            enemy_2.Visibility = Visibility.Hidden;
            crosshair.Visibility = Visibility.Hidden;
            friend.Visibility = Visibility.Hidden;
            tt_win_logo.Visibility = Visibility.Visible;
            fire_particle.Visibility = Visibility.Hidden;
            blood_particle.Visibility = Visibility.Hidden;
        }

        private void gaben_Killed(object sender, RoutedEventArgs e)
        {
           
        }

        void shoot_fire()
        {

            check_hitboxes();
            

        }

        void update_frame()
        {
            killsCounter = 0;
            stats_tab.Text = "Kills: 0";
            stats_tab.Visibility = Visibility.Visible;
            awp.Visibility = Visibility.Visible;
            enemy_1.Visibility = Visibility.Visible;
            enemy_2.Visibility = Visibility.Visible;
            crosshair.Visibility = Visibility.Visible;
            friend.Visibility = Visibility.Visible;
            tt_win_logo.Visibility = Visibility.Hidden;
            ct_win_logo.Visibility = Visibility.Hidden;
            fire_particle.Visibility = Visibility.Hidden;
            blood_particle.Visibility = Visibility.Hidden;
        }

        void check_hitboxes()
        {

            // first enemy
            if (Canvas.GetTop(crosshair) > 251 && Canvas.GetLeft(crosshair) > 506 && Canvas.GetTop(crosshair) < 251 + 93 && Canvas.GetLeft(crosshair) < 506 + 85 && enemy_1.Visibility != Visibility.Hidden)
            {
                blood_particle.Visibility = Visibility.Hidden;
                killsCounter++;
                stats_tab.Text = $"Kills: {killsCounter}";
                Canvas.SetTop(blood_particle, Canvas.GetTop(crosshair));
                Canvas.SetLeft(blood_particle, Canvas.GetLeft(crosshair));
                blood_particle.Visibility = Visibility.Visible;
                enemy_1.Visibility = Visibility.Hidden;


            }
            // second enemy
            else if (Canvas.GetTop(crosshair) > 217 && Canvas.GetLeft(crosshair) > 261 && Canvas.GetTop(crosshair) < 217 + 104 && Canvas.GetLeft(crosshair) < 261 + 108 && enemy_2.Visibility != Visibility.Hidden)
            {
                blood_particle.Visibility = Visibility.Hidden;
                killsCounter++;
                stats_tab.Text = $"Kills: {killsCounter}";
                Canvas.SetTop(blood_particle, Canvas.GetTop(crosshair));
                Canvas.SetLeft(blood_particle, Canvas.GetLeft(crosshair));
                blood_particle.Visibility = Visibility.Visible;
                enemy_2.Visibility = Visibility.Hidden;

            }
            // ally
            else if (Canvas.GetTop(crosshair) > 187 && Canvas.GetLeft(crosshair) > 53 && Canvas.GetTop(crosshair) < 187 + 147 && Canvas.GetLeft(crosshair) < 53 + 135 && friend.Visibility != Visibility.Hidden)
            {
                friend.Visibility = Visibility.Hidden;
                blood_particle.Visibility = Visibility.Hidden;      
                Canvas.SetTop(blood_particle, Canvas.GetTop(crosshair));
                Canvas.SetLeft(blood_particle, Canvas.GetLeft(crosshair));
                blood_particle.Visibility = Visibility.Visible;
                friend.Visibility = Visibility.Hidden;
                
                tt_win_game();
            }
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Canvas.SetTop(crosshair, Canvas.GetTop(crosshair) - 10);
            }
            if (e.Key == Key.A)
            {
                Canvas.SetLeft(crosshair, Canvas.GetLeft(crosshair) - 10);
            }
            if (e.Key == Key.S)
            {
                Canvas.SetTop(crosshair, Canvas.GetTop(crosshair) + 10);
            }
            if (e.Key == Key.D)
            {
                Canvas.SetLeft(crosshair, Canvas.GetLeft(crosshair) + 10);
            }
            if (e.Key == Key.Space)
            {
                shoot_fire();
                if (killsCounter == 2)
                {
                    ct_win_game();
                }
            }
        }

    }
}
