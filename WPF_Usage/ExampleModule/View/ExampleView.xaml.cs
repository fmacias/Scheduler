﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Unity;
using WPF_Usage.ExampleModule.View;

namespace WPF_Usage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ExampleView : Window, IExampleView
    {
        private event EventHandler<RoutedEventArgs> ClickEventHandler;
        private delegate void RoutedEventHandler(object sender, RoutedEventArgs e);
        public ExampleView()
        {
            InitializeComponent();
            ClickEventHandler = HandleTaskFinished;
        }
        [Unity.Dependency]
        public IExamplePresenter ExamplePresenter { get; set; }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }
        private void HandleTaskFinished(object sender, RoutedEventArgs e)
        {
            var o = sender;
        }

        private void lstNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
