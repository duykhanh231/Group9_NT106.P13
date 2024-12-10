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
    /// Interaction logic for FindOpponentWindow.xaml
    /// </summary>
    public partial class FindOpponentWindow : Window
    {
        public FindOpponentWindow()
        {
            InitializeComponent();
            RefreshButton.Click += RefreshButton_Click;

        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            StatusBarText.Text = "Đang làm mới danh sách...";
            OpponentListBox.Items.Clear();
            OpponentListBox.Items.Add("Người chơi 1 - Online");
            OpponentListBox.Items.Add("Người chơi 2 - Busy");
            StatusBarText.Text = "Danh sách đã được làm mới.";
        }
        private void InviteButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy đối thủ được chọn từ ListBox
            if (OpponentListBox.SelectedItem != null)
            {
                string selectedOpponent = OpponentListBox.SelectedItem.ToString();
                StatusBarText.Text = $"Đang mời {selectedOpponent} chơi...";

                // Thực hiện gửi lời mời (giả định gửi mời thành công)
                // Bạn có thể thay đổi đoạn mã này để kết nối với server hoặc xử lý mời chơi thực tế
                System.Threading.Tasks.Task.Delay(1000).ContinueWith(t =>
                {
                    Dispatcher.Invoke(() => StatusBarText.Text = $"Đã gửi lời mời đến {selectedOpponent}.");
                });
            }
            else
            {
                StatusBarText.Text = "Vui lòng chọn đối thủ để mời!";
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Khi cửa sổ được tải, cập nhật thanh trạng thái
            StatusBarText.Text = "Sẵn sàng. Vui lòng chọn đối thủ.";
        }
    }
}
