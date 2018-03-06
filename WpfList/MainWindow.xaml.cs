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
            //items.Add(new TodoItem() { Title = "Complete this WPF tutotrial", Completion = 45 });
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
        private void todoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Title = (TodoListBox.SelectedItem as TodoItem).Title;
        }
        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            //if(TodoListBox.SelectedItem != null)
            foreach (var item in TodoListBox.SelectedItems)
            {
                MessageBox.Show((item as TodoItem).Title);
            }
            MessageBox.Show((TodoListBox.SelectedItem as TodoItem).Title);
        }
        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            TodoListBox.SelectedIndex = TodoListBox.Items.Count - 1;
        }
        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if((TodoListBox.SelectedIndex >= 0) &&(TodoListBox.SelectedIndex < (TodoListBox.Items.Count -1)))
            {
                nextIndex = TodoListBox.SelectedIndex + 1;
            }
            TodoListBox.SelectedIndex = nextIndex;
        }
        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                if((item is TodoItem) && ((item as TodoItem).Title.Contains("C#")))
                {
                    TodoListBox.SelectedItem = item;
                }
            }
        }
        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                TodoListBox.SelectedItems.Add(item);
            }
        }
    }
    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }




}
