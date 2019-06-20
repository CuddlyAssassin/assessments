using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _4CSM_Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentInfoPage : Page
    {
        public StudentInfoPage()
        {
            this.InitializeComponent();
        }
        //save
        public static List<students> studentList = new List<students>();
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //id
            if (id.Text == "")
            {
                var dialogMessage1 = new MessageDialog("Error! Student ID cannot be left blank!");
                await dialogMessage1.ShowAsync();
            }
            //id
            if (name.Text == "")
            {
                var dialogMessage1 = new MessageDialog("Error! Student Name cannot be left blank!");
                await dialogMessage1.ShowAsync();
            }
            //id
            if (email.Text == "")
            {
                var dialogMessage1 = new MessageDialog("Error! Student Email cannot be left blank!");
                await dialogMessage1.ShowAsync();
            }
            //id
            if (number.Text == "")
            {
                var dialogMessage1 = new MessageDialog("Error! Student Tel. Number cannot be left blank!");
                await dialogMessage1.ShowAsync();
            }
            //del
            studentList = null;
            //save
            var new_student = new students()
            {
                Id = id.Text,
                Name = name.Text,
                Email = email.Text,
                Number = number.Text
            };
            studentList.Add(new_student);
            var dialogMessage = new MessageDialog("Student details saved!");
            await dialogMessage.ShowAsync();
            //go back to main page
            Frame.Navigate(typeof(MainPage));
            
        }
    }
}
