using Cwiczenia3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Zadanie3i4.xaml
    /// </summary>
    public partial class Zadanie3i4 : Window
    {
        public ObservableCollection <Student> ListaStudentow;
        public Zadanie3i4()
        {
            InitializeComponent();

            ListaStudentow = new ObservableCollection<Student>();
            ListaStudentow.Add(new Student {Imie="Jan",Nazwsiko="Kowalski",Index="s12345" });
            ListaStudentow.Add(new Student {Imie="Anna",Nazwsiko="Lewandowska",Index="s12346" });

            Tabela.ItemsSource = ListaStudentow;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(Imie.Text !=null && Nazwisko.Text != null && NrIndex.Text.StartsWith("s"))
            {
                try
                {
                    int n;
                    Int32.TryParse(NrIndex.Text.Substring(1),out n);
                    ListaStudentow.Add(new Student { Imie = Imie.Text, Nazwsiko = Nazwisko.Text, Index = NrIndex.Text });
                }
                catch (Exception)
                {
                    throw;
                }
            }
            Tabela.ItemsSource = null;
            Tabela.ItemsSource = ListaStudentow;
        }
        
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ListaStudentow.Remove((Student)Tabela.SelectedItem);
            Tabela.ItemsSource = null;
            Tabela.ItemsSource = ListaStudentow;
        }
        private void Tabela_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student student=(Student)(Tabela.SelectedItem);
            StudentEditDialog studentEditDialog = new StudentEditDialog(student ,Tabela,ListaStudentow);
            studentEditDialog.Show();
        }
    }
}
