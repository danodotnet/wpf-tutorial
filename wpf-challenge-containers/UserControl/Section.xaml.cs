﻿using System;
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

namespace wpf_challenge_containers
{
    /// <summary>
    /// Interaction logic for Section.xaml
    /// </summary>
    public partial class Section : UserControl
    {
        public Section()
        {
            InitializeComponent();
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Section), new PropertyMetadata(string.Empty));



        public bool OnlyText
        {
            get { return (bool)GetValue(OnlyTextProperty); }
            set { SetValue(OnlyTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OnlyText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OnlyTextProperty =
            DependencyProperty.Register("OnlyText", typeof(bool), typeof(Section), new PropertyMetadata(true, new PropertyChangedCallback(OnOnlyText)));

        public static void OnOnlyText(DependencyObject dp, DependencyPropertyChangedEventArgs e)
        {
            var control = dp as Section;
            var value = bool.Parse(e.NewValue.ToString());
            //control.icon.Visibility = value ? Visibility.Collapsed : Visibility.Visible;
        }

    }
}
