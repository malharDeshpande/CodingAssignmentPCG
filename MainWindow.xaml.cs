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
using System.Collections.Generic;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Student> students = new List<Student>
        {
            new Student {First="John", Last="Doe", ID=1, Assignments= new List<Assignment> {
                new Assignment{Name = "Data Structures",Marks = 80},new Assignment{Name = "Web Design",Marks = 90}, new Assignment{Name = "BI",Marks = 82}
                                                                                               }
                        },
           new Student {First="Sarah", Last="Marriot", ID=2, Assignments= new List<Assignment> {
                new Assignment{Name = "Data Structures",Marks = 70},new Assignment{Name = "Web Design",Marks = 70}, new Assignment{Name = "BI",Marks = 55}
                                                                                               }
                        },
         new Student {First="Abraham", Last="Paredes", ID=3, Assignments= new List<Assignment> {
                new Assignment{Name = "Data Structures",Marks = 50},new Assignment{Name = "Web Design",Marks = 90}, new Assignment{Name = "BI",Marks = 80}
                                                                                               }
                        },
 new Student {First="Chris", Last="Fisher", ID=4, Assignments= new List<Assignment> {
                new Assignment{Name = "Data Structures",Marks = 50},new Assignment{Name = "Web Design",Marks = 48}, new Assignment{Name = "BI",Marks = 80}
                                                                                               }
                        },
                         new Student {First="Truman", Last="Giosa", ID=5, Assignments= new List<Assignment> {
                new Assignment{Name = "Data Structures",Marks = 90},new Assignment{Name = "Web Design",Marks = 90}, new Assignment{Name = "BI",Marks = 80}
                                                                                               }
                        },
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int Average = 0;
            foreach (Student student in students)
            {
                int totalScore = student.Assignments[0].Marks + student.Assignments[1].Marks + student.Assignments[2].Marks;
                Average = totalScore / 3;
                if (Average >= 95)
                    student.Grade = 'A';
                else if (Average >= 70 && Average < 95)
                    student.Grade = 'B';
                else if (Average >= 60 && Average < 80)
                    student.Grade = 'C';
                else if (Average >= 50 && Average < 70)
                   student.Grade = 'D';
                else
                   student.Grade = 'F';
               
                MessageBox.Show(student.First + " "+ student.Last +" "+student.Grade);
               
               
                
            }
        }

       
        

 
       

       
    }
}