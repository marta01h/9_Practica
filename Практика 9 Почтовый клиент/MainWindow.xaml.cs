using System.Windows;
using System.Windows.Controls;

namespace MailClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Подписка на событие клика по кнопке авторизации
            LoginButton.Click += LoginButton_Click;

            // Подписка на событие изменения выбранной папки
            FoldersListBox.SelectionChanged += FoldersListBox_SelectionChanged;

            // Подписка на событие изменения выбранного письма
            MailListView.SelectionChanged += MailListView_SelectionChanged;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика авторизации и проверка на успешную авторизацию

            // Если авторизация успешна, скрываем окно авторизации и показываем основное окно
            LoginGrid.Visibility = Visibility.Collapsed;
            MainGrid.Visibility = Visibility.Visible;
        }

        private void FoldersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логика загрузки сообщений из выбранной папки
        }

        private void MailListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логика отображения выбранного письма
        }
    }
}

