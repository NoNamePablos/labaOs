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
using System.Data;
using Microsoft.Win32;
using System.IO;

namespace Lab13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CountryDBDataSet _countryDBDataSet;
        private CountryDBDataSetTableAdapters.continentTableAdapter _countryDBDataSetContinentTableAdapter;
        CountryDBDataSetTableAdapters.countryTableAdapter _countryDBDataSetCountryTableAdapter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _countryDBDataSet = ((CountryDBDataSet)(FindResource("countryDBDataSet")));
            // Load data into the table continent. You can modify this code as needed.
            _countryDBDataSetContinentTableAdapter = new CountryDBDataSetTableAdapters.continentTableAdapter();
            _countryDBDataSetContinentTableAdapter.Fill(_countryDBDataSet.continent);
            CollectionViewSource continentViewSource = ((CollectionViewSource)(FindResource("continentViewSource")));
            continentViewSource.View.MoveCurrentToFirst();
            // Load data into the table country. You can modify this code as needed.
            _countryDBDataSetCountryTableAdapter = new CountryDBDataSetTableAdapters.countryTableAdapter();
            _countryDBDataSetCountryTableAdapter.Fill(_countryDBDataSet.country);
            CollectionViewSource countryViewSource = ((CollectionViewSource)(FindResource("countryViewSource")));
            countryViewSource.View.MoveCurrentToFirst();
        }

        private void SaveContinent_Click(object sender, RoutedEventArgs e)
        {
            _countryDBDataSetContinentTableAdapter.Update(_countryDBDataSet.continent);
        }

        private void DeleteContinent_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < continentDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = continentDataGrid.SelectedItems[i] as DataRowView;

                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
        }

        private void SaveCountry_Click(object sender, RoutedEventArgs e)
        {
            _countryDBDataSetCountryTableAdapter.Update(_countryDBDataSet.country);
        }

        private void DeleteCountry_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < countryDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = countryDataGrid.SelectedItems[i] as DataRowView;

                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
        }

        private void loadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (countryDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = countryDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as CountryDBDataSet.countryRow;
                        if (dataRow != null)
                        {
                            dataRow.photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}
