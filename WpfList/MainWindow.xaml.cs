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

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            //items.Add(new TodoItem() { Title = "Complete this WPF tutotrial", Completion = 45});
            //items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            //items.Add(new TodoItem() { Title = "Got to shop", Completion = 100 });
            //items.Add(new TodoItem() { Title = "Buy stuff", Completion = 10 });
            items.Add(new TodoItem() { FirstName = "Lincoln", LastName = "Lampton", Completion = 10 });
            items.Add(new TodoItem() { FirstName = "Candis", LastName = "Cardenas", Completion = 11 });
            items.Add(new TodoItem() { FirstName = "Rebbecca", LastName = "Reece", Completion = 12 });
            items.Add(new TodoItem() { FirstName = "Deshawn", LastName = "Derrick", Completion = 13 });
            items.Add(new TodoItem() { FirstName = "Hipolito", LastName = "Hibler", Completion = 14 });
            items.Add(new TodoItem() { FirstName = "Roseanna", LastName = "Roseborough", Completion = 15 });
            items.Add(new TodoItem() { FirstName = "Rufina", LastName = "Ravenscroft", Completion = 16 });
            items.Add(new TodoItem() { FirstName = "Marlin", LastName = "Mattson", Completion = 17 });
            items.Add(new TodoItem() { FirstName = "Esmeralda", LastName = "Elmendorf", Completion = 18 });
            items.Add(new TodoItem() { FirstName = "Yetta", LastName = "Yamasaki", Completion = 19 });


            TodoListBox.ItemsSource = items;

        }
    }
    public class TodoItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Completion { get; set; }
    }




}
