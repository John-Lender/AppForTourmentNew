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

namespace AppForTourment
{

    class Tourment
    {
        public string Name
        {
            get => name;
        }

        public string FullNamejudje
        {
            get => fullNamejudge;
        }

        public int MinScore
        {
            get => minScore;
        }

        public string FirstDate
        {
            get => firstDate;
        }

        public string SecondDate
        {
            get => secondDate;
        }

        private int ID  = 10005;
        private int minScore = 1;
        private string firstDate;
        private string secondDate;
        private string name = "firstTur";
        private string fullNamejudge = "Andrey vladimirovich Isakov";
        private string result;
       // private
        private List<int> listOfMembers = new List<int>();

        public Tourment(string date)
        {
            string[] parsedDate = date.Split(' ');
            firstDate = parsedDate[0];
            secondDate = parsedDate[1];

        }
    }

    class User
    {
        static public int Get_hash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            int sum = 0;

            foreach (byte b in bytes)
                for (int i = 0; i < 8; i++)
                    sum += (b >> i) & 1;
            return sum;
        }

        /*public string GetfirstName()
        {
            return firstName;
        }*/

        public string FirstName
        {
            get => firstName;
        }

        public string LastName
        {
            get => lastName;
        }

        public string MiddleName
        {
            get => middleName;
        }

        public int Status
        {
            get => status;
        }

        public int ID
        {
            get => id;
        }

        public int Score
        {
            get => score;
        }

        private string firstName = "Иван";
        private string lastName = "Покидов";
        private string middleName = "Анатольевич";
        private string login = "YourHate";
        private int password = Get_hash("ivan19years");
        private string keyInTime;
        private int status = 0;
        private int id = 6001;
        private int score = 1;
        private string invites = "10001 10002 10003";
        private List<Tourment> tourment = new List<Tourment>();

    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Tourment tur = new Tourment("11.11.2011 11.12.2011");
            User ivan = new User();
            FirstName.Text = ivan.FirstName;
            LastName.Text = ivan.LastName;
            MiddleName.Text = ivan.MiddleName;

            List<Tourment> alltour = new List<Tourment>();
            alltour.Add(new Tourment("01.01.1999 10.01.1999"));
            alltour.Add(tur);
            alltour.Add(new Tourment("03.04.2010 04.05.2010"));

            for (int i = 0; i < alltour.Count; i++)
            {
                TorList.Items.Add("Название турнира: " + alltour[i].Name + "\n" + "Дата проведения: " + alltour[i].FirstDate + "-" + alltour[i].SecondDate + "\n" + "рейтинг: " + alltour[i].MinScore + "\n" + "судья: " + alltour[i].FullNamejudje);
                Button but = new Button { Content = "Подать заявку" };
                but.Height = 30;
                but.Name = "btn1";
                but.Click += btn1_Click;
                TorList.Items.Add(but);

            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            TorList.Width = 12;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ListInfo.Margin = new Thickness(35, 0, 0, 0);
            UsersPhoto.Visibility = Visibility.Collapsed;
            UsersInfoInLeftMenu.Visibility = Visibility.Visible;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ListInfo.Margin = new Thickness(200, 0, 0, 0);
            UsersPhoto.Visibility = Visibility.Visible;
            UsersInfoInLeftMenu.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            listOfTur lot = new listOfTur();
            
            lot.Owner = this;
            lot.Show();
            //lot.myGrid.Children.Clear();
           // lot.TorList1.Items.Add("qqqqqqqqqqqqqqqqqqqqqqqq");
            //lot.Show();
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
