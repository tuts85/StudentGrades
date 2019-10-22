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
using System.Windows.Shapes;

namespace StudentGrades
{
    /// <summary>
    /// Interaction logic for Add_Student.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> StudentList = new List<Student>();
        List<Grades> GradesList = new List<Grades>();

        public MainWindow()
        {
            InitializeComponent();    




          
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItemCombo = sender as ComboBox;
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<String> gradeList = new List<string>();
            gradeList.Add("");
            gradeList.Add("Freshman (9th Year)");
            gradeList.Add("Sophomore (10th Year)");
            gradeList.Add("Junior (11th Year)");
            gradeList.Add("Senior (12th Year)");

            var combo = sender as ComboBox;
            combo.ItemsSource = gradeList;
            combo.SelectedIndex = 0;
        }

        private void cancelbtnstudent_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            StudentList.Add(new Student(firstNametxbx.Text, lastNametxbx.Text, dobpicker.Text, highschoolgradebox.Text));

            this.studentLV.Items.Add(new Student(firstNametxbx.Text, lastNametxbx.Text, dobpicker.Text, highschoolgradebox.Text));

            this.DataContext = this;

            firstNametxbx.Clear();
            lastNametxbx.Clear();
            dobpicker.SelectedDate = null;
            highschoolgradebox.SelectedIndex = 0;

        }

        private void studentLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

 
            
                           
        }

    }
}
