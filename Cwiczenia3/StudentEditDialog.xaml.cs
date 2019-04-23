using Cwiczenia3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for StudentEditDialog.xaml
    /// </summary>
    public partial class StudentEditDialog : Window
    {
        private Student student;
        private DataGrid Tabela;
        private ObservableCollection<Student> ListaStudentow;

        public StudentEditDialog(Student student,DataGrid Tabela, ObservableCollection<Student> ListaStudentow)
        {
            InitializeComponent();
            Imie.Text =student.Imie;
            Nazwisko.Text = student.Nazwsiko;
            NrIndex.Text = student.Index;
            this.student = student;
            this.Tabela = Tabela;
            this.ListaStudentow = ListaStudentow;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            student.Imie = Imie.Text;
            student.Nazwsiko = Nazwisko.Text;
            student.Index = NrIndex.Text;
            Tabela.ItemsSource = null;
            Tabela.ItemsSource = ListaStudentow;
            Close();
        }
    }
}
