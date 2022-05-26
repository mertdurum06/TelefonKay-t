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

namespace Final
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            markalist.Items.Add(marka.Text);
            modellist.Items.Add(model.Text);
            renklist.Items.Add(renk.Text);
            fiyatlist.Items.Add(fiyat.Text);

            marka.Text = "";
            model.Text = "";
            renk.Text = "";
            fiyat.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            marka.Text = "";
            model.Text = "";

            markalist.Items.RemoveAt(markalist.SelectedIndex);
            modellist.Items.RemoveAt(modellist.SelectedIndex);
            renklist.Items.RemoveAt(renklist.SelectedIndex);
            fiyatlist.Items.RemoveAt(fiyatlist.SelectedIndex);
        }

        private void ListBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            markalist.Items.Add(marka.Text);
            modellist.Items.Add(model.Text);
            renklist.Items.Add(renk.Text);
            fiyatlist.Items.Add(fiyat.Text);

        }

        private void getir_Click(object sender, RoutedEventArgs e)
        {
            marka.Text = markalist.SelectedItem.ToString();
            model.Text = modellist.SelectedItem.ToString();
            renk.Text = renklist.SelectedItem.ToString();
            fiyat.Text = fiyatlist.SelectedItem.ToString();
        }
    }
}
