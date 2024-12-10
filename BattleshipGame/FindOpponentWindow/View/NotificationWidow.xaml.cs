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

namespace FindOpponent_NotificationWindow.View
{
    /// <summary>
    /// Interaction logic for NotificationWidow.xaml
    /// </summary>
    public partial class NotificationWindow : Window
    {
        private readonly string _message;

        public NotificationWindow(string message)
        {
            InitializeComponent();
            _message = message;
            NotificationMessage.Text = _message;  // Cập nhật nội dung thông báo
        }

        // Sự kiện khi nhấn nút "Chấp Nhận"
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            // Thực hiện hành động chuyển đến form set up trận
            MessageBox.Show("Chấp nhận! Chuyển đến form tiếp theo.");
            this.Close();  // Đóng cửa sổ thông báo

            // Mở form tiếp theo (form set up trận)

        }

        // Sự kiện khi nhấn nút "Từ Chối"
        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            // Quay lại giao diện tìm đối thủ
            MessageBox.Show("Từ chối! Quay lại giao diện tìm đối thủ.");
            this.Close();  // Đóng cửa sổ thông báo

            // Mở lại cửa sổ FindOpponentWindow
            var findOpponentWindow = new FindOpponentWindow();
            findOpponentWindow.Show();
        }
    }
}
