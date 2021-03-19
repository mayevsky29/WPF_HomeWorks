using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ExceptionsWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, 
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        // DispatcherUnhandledException дозволяє обробляє необроболені винятки
        // DispatcherUnhandledException="Application_DispatcherUnhandledException потрібно додати як ресурс в app.xampl

        // присвоєння властивості e.Handled значення true вказує про завершення роботи над необробленим винятком
        {
            MessageBox.Show("Щойно стався необроблений виняток: " 
                + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
        // Таким чином, в програмуванні бажано використовувати обробку винятків глобально
        // оскільки локальна обробка більш деталізована, що дозволяє вирішувати проблему іншим способом
    }
}
