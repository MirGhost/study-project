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

namespace app.calendar
{
    /// <summary>
    /// Логика взаимодействия для menuBottom.xaml
    /// </summary>
    public partial class menuBottom : UserControl
    {
        public menuBottom()
        {
            InitializeComponent();
        }
       
        
        
        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value) ; }
        }

        public static  readonly DependencyProperty CaptionProperty = DependencyProperty.
            Register("Caption",typeof(string),typeof(menuBottom));

        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.
            Register("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(menuBottom));

    }
}
