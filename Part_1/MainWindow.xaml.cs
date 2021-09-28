/// Chapter No. 11 - Homework5_Part_1
/// File Name: homework5.java
/// @author: Rossana Palma
/// Date:  September 25, 2021
///
/// Problem Statement: Write a program that calculates a person’s Body Mass Index (BMI) and displays a message 
/// about the user's health range. Use a GUI for the input and output.
///  
/// 
/// Overall Plan:
/// 1) Declare variables
/// 2) Convert inputs to double
/// 3) Calculate BMI and convert to string
/// 4) Use statement if else to identify and brush the calculated health range
/// 5) Display results on the screen

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

namespace Part_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            double weight;
            double height;
            double bmi;
            //Convert value into double
            weight = double.Parse(weightTextBox.Text);
            height = double.Parse(heightTextBox.Text);
            bmi = (weight * 720) / (height * height);
            //Convert bmi to string and assign it to resultTextBox
            resultTextBox.Text = bmi.ToString();
            if(bmi > 26) // above : yellow
            {
                bmiCanvas.Background = Brushes.Yellow;
                messageTextBox.Text = ("You are above the health range");
            }
            else if(bmi >= 15 && bmi <=26) // healthy : green
            {
                bmiCanvas.Background = Brushes.Green;
                messageTextBox.Text = ("You are healthy");
            }
            else if(bmi < 15)
            {
                bmiCanvas.Background = Brushes.Blue;
                messageTextBox.Text = ("You are under the health range");
            }
        }
    }
}
