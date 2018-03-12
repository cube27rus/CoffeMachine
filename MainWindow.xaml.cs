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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<RadioButton> checkedEat = new List<RadioButton>();
        EatFactory eatFactory = new EatFactory();
        Boolean needHam = false;
        Boolean needCheese = false;
        Boolean needJam = false;
        int checkedEatAdditiveCount = 0;

        private List<RadioButton> checkedDrink = new List<RadioButton>();
        CoffeFactory coffeFactory = new CoffeFactory();
        Boolean needMilk = false;
        Boolean needSyrup = false;
        Boolean needSugar = false;
        int checkedDrinkAdditiveCount = 0;
        int? sugar = 0;

        int price = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // DRINK

        private void Drink_Checked(object sender, RoutedEventArgs e)
        {
            checkedDrink.Add((RadioButton)sender);
        }

        private void Drink_Unchecked(object sender, RoutedEventArgs e)
        {
            checkedDrink.Remove((RadioButton)sender);
           
        }

        private void DrinkAdditive_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "Milk":
                    needMilk = true;
                    break;
                case "Syrup":
                    needSyrup = true;
                    break;
                case "Sugar":
                    needSugar = true;
                    break;
            }
            checkedDrinkAdditiveCount++;

        }

        private void DrinkAdditive_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "Milk":
                    needMilk = false;
                    break;
                case "Syrup":
                    needSyrup = false;
                    break;
                case "Sugar":
                    needSugar = false;
                    break;
            }
            checkedDrinkAdditiveCount--;
        }

        private void ChangeShugarValue(object sender, RoutedEventArgs e)
        {
            sugar = this.myUpDownControl.Value;
        }

        //EAT

        private void Eat_Checked(object sender, RoutedEventArgs e)
        {
            checkedEat.Add((RadioButton)sender);
        }

        private void Eat_Unchecked(object sender, RoutedEventArgs e)
        {
            checkedEat.Remove((RadioButton)sender);
        }

        private void EatAdditive_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch (cb.Name){
                case "Ham":
                    needHam = true;
                    break;
                case "Cheese":
                    needCheese = true;
                    break;
                case "Jam":
                    needJam = true;
                    break;
            }
            checkedEatAdditiveCount++;
        }

        private void EatAdditive_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "Ham":
                    needHam = false;
                    break;
                case "Cheese":
                    needCheese = false;
                    break;
                case "Jam":
                    needJam = false;
                    break;
            }
            checkedEatAdditiveCount--;
        }

        //готовит заказ
        private void GetOrder(object sender, RoutedEventArgs e)
        {
            int total = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ваш заказ: ");
            foreach (RadioButton box in checkedDrink)
            {
                string[] result = coffeFactory.MakeFood(box.Name, needMilk, needSyrup, needSugar ? sugar : 0);
                sb.AppendLine(result[0]);
                total += Int32.Parse(result[1]);
              
            }            
            foreach (RadioButton box in checkedEat)
            {
                string[] result = eatFactory.MakeFood(box.Name, needHam, needCheese, needJam);                
                sb.AppendLine(result[0]);
                total += Int32.Parse(result[1]);
               
            }
            price = total;
            //проверка на комплекс
            if (this.Complex.IsChecked == true)
            {
                if(checkedDrinkAdditiveCount == 1 && checkedEatAdditiveCount == 1)
                {
                    if(checkedDrink.Count ==1 && checkedEat.Count ==1)
                    {
                        price = 90;
                    }
                }
            }

            this.Total.Text = price.ToString();
            MessageBox.Show(sb.ToString());
        }
    }
}
