using Interfaces.Services;
using MaterialDesignThemes.Wpf;
using Services;
using HighSolution.Infrastructure.Commands;
using HighSolution.ViewModels;
using HighSolution.ViewModels.Base;
using System.Windows;
using System.Windows.Controls;

namespace HighSolution.Views
{
    /// <summary>
    /// Логика взаимодействия для Window_Customer.xaml
    /// </summary>
    public partial class Window_Customer : Window
    {
        public Window_Customer(IOrderService orderService, IClientService clientService, IExecutorService executorService, ITServiceService itService,  int ID_user)
        {
           InitializeComponent();
            DataContext = new ViewModel_Customer(this, orderService, clientService, executorService, itService, ID_user);
        }

        //private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // Проверяем, что выбрана вкладка, на которую вы хотите отреагировать
        //    if (TabControl.SelectedItem == Profile_View)
        //    {

        //        // Вызываем команду ViewModel_Customer
        //        if (DataContext is ViewModel_Customer yourViewModel && yourViewModel.UpdateProfileCommand.CanExecute(null))
        //        {
        //            yourViewModel.UpdateProfileCommand.Execute(null);
        //        }

        //    }
        //}
    }
}
