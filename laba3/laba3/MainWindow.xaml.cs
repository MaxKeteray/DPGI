using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CurrencyConverter
{
    public partial class MainWindow : Window
    {
        private readonly Dictionary<string, double> rates = new()
        {
            { "USD", 40.0 },
            { "EUR", 42.5 },
            { "PLN", 9.5 }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToUAH_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(InputAmountTextBox.Text, out double amount) &&
                CurrencyComboBox.SelectedItem is ComboBoxItem selectedCurrency)
            {
                string currency = selectedCurrency.Content.ToString().Split(' ')[1]; 
                double rate = rates[currency];
                double result = amount * rate;
                ResultTextBlock.Text = $"{amount} {currency} = {result:F2} грн";
            }
            else
            {
                ResultTextBlock.Text = "Будь ласка, введіть коректні дані.";
            }
        }

        private void ConvertFromUAH_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(InputAmountTextBox.Text, out double amount) &&
                CurrencyComboBox.SelectedItem is ComboBoxItem selectedCurrency)
            {
                string currency = selectedCurrency.Content.ToString().Split(' ')[1];
                double rate = rates[currency];
                double result = amount / rate;
                ResultTextBlock.Text = $"{amount} грн = {result:F2} {currency}";
            }
            else
            {
                ResultTextBlock.Text = "Будь ласка, введіть коректні дані.";
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
                button.Opacity = 0.85;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
                button.Opacity = 1.0;
        }
    }
}
