using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using MailKit.Net.Smtp;
using MimeKit;
namespace Lab05
{
    public partial class Client : Form
    {
        private Socket _clientSocket;
        private Dictionary<string, (int price, List<string> rooms)> _movies;
        private List<CheckBox> _seats = new List<CheckBox>();
        private Dictionary<string, List<string>> _purchasedTickets = new Dictionary<string, List<string>>();
        private string _selectedSeats = "";
        public Client()
        {
            InitializeComponent();
            InitializeSeats();
            LoadMoviesFromJson();
        }
        private void LoadMoviesFromJson()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);

                        if (!string.IsNullOrEmpty(jsonContent))
                        {
                            var moviesData = JsonConvert.DeserializeObject<List<Movie>>(jsonContent);

                            if (moviesData != null && moviesData.Count > 0)
                            {
                                if (ValidateMoviesData(moviesData))
                                {
                                    _movies = moviesData.ToDictionary(movie => movie.TenPhim, movie => (movie.GiaVeChuan, movie.PhongChieu));
                                    PopulateComboBoxes();
                                    MessageBox.Show("Dữ liệu phim đã được tải thành công từ tệp JSON.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tệp JSON không chứa dữ liệu phim hợp lệ.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tệp JSON trống.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc dữ liệu từ tệp JSON: " + ex.Message);
            }
        }
        private bool ValidateMoviesData(List<Movie> moviesData)
        {
            foreach (var movie in moviesData)
            {
                if (string.IsNullOrEmpty(movie.TenPhim) || movie.GiaVeChuan <= 0 || movie.PhongChieu == null || movie.PhongChieu.Count == 0)
                {
                    MessageBox.Show("Cấu trúc của file JSON không đúng. Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public class Movie
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public List<string> PhongChieu { get; set; }
        }
        private void PopulateComboBoxes()
        {
            if (_movies != null)
            {
                foreach (var movie in _movies)
                {
                    comboBox1.Items.Add(movie.Key);
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
        private void InitializeSeats()
        {
            _seats.AddRange(new CheckBox[] { A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5 });
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtto.Text))
            {
                MessageBox.Show("Vui lòng nhập email của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedMovie = comboBox1.SelectedItem.ToString();
            string selectedRoom = comboBox2.SelectedItem.ToString();
            _selectedSeats = string.Join(", ", _seats.Where(seat => seat.Checked).Select(seat => seat.Name));
            if (string.IsNullOrEmpty(_selectedSeats))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = $"{selectedMovie};{selectedRoom};{_selectedSeats}";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            _clientSocket.Send(buffer);
            ClientRecv();
        }
        private void ClientRecv()
        {
            int totalPrice = 0;

            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead = _clientSocket.Receive(buffer);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] parts = response.Split(';');

                if (parts[0] == "Fail")
                {
                    MessageBox.Show("Ghế đã được chọn vui lòng chọn ghế khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string selectedSeats = parts[1];
                    string movieName = parts[2];
                    string roomName = parts[3];

                    foreach (string seat in selectedSeats.Split(','))
                    {
                        totalPrice += CalculateSeatPrice(movieName, seat.Trim());
                    }

                    MessageBox.Show($"Họ tên: {nameTextBox.Text}\nPhim: {movieName}\nPhòng chiếu: {roomName}\nTổng tiền: {totalPrice}đ");
                    SendEmail(parts, selectedSeats, movieName, roomName, totalPrice);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CalculateSeatPrice(string movieName, string seat)
        {
            int basePrice = _movies[movieName].price;

            switch (seat)
            {
                case "A1":
                case "A5":
                case "B1":
                case "B5":
                case "C1":
                case "C5":
                    return basePrice / 4;
                case "B2":
                case "B3":
                case "B4":
                    return basePrice * 2;
                default:
                    return basePrice;
            }
        }

        private void SendEmail(string[] parts, string selectedSeats, string movieName, string roomName, int totalPrice)
        {
            string imageUrl = GetMovieImageUrl(movieName);
            SmtpClient smtpClient = new SmtpClient();

            try
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate(parts[4], parts[5]);

                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("", parts[4]));
                mimeMessage.To.Add(new MailboxAddress("", txtto.Text));
                mimeMessage.Body = new TextPart("html")
                {
                    Text = $@"
                        <html>
                            <body>
                                <p>Xin chào,</p>
                                <p>Đây là email xác nhận đặt vé của bạn.</p>
                                <p>Thông tin đặt vé:</p>
                                <ul>
                                    <li><strong>Họ tên:</strong> {nameTextBox.Text}</li>
                                    <li><strong>Phim:</strong> {movieName}</li>
                                    <li><strong>Phòng chiếu:</strong> {roomName}</li>
                                    <li><strong>Số ghế:</strong> {selectedSeats}</li>
                                    <li><strong>Tổng tiền:</strong> {totalPrice}đ</li>
                                </ul>
                                <img src=""{imageUrl}"" alt=""Your Image"">
                                <p>Rạp phim kính chúc quý khách xem phim vui vẻ. Rất hân hạnh được phục vụ.</p>
                            </body>
                        </html>"
                };

                smtpClient.Send(mimeMessage);
                MessageBox.Show("Đã gửi email");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi gửi email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMovieImageUrl(string movieName)
        {
            switch (movieName)
            {
                case "Đào, phở và piano":
                    return "https://images2.thanhnien.vn/528068263637045248/2024/2/19/18a-1708362773728296435986.jpg";
                case "Mai":
                    return "https://vntravel.org.vn/uploads/images/2024/02/20/poster-mai-scaled-1708403724.jpg";
                case "Gặp lại chị bầu":
                    return "https://cdn.galaxycine.vn/media/2024/2/6/gap-lai-chi-bau-750_1707203931695.jpg";
                case "Tarot":
                    return "https://cdn.galaxycine.vn/media/2024/4/17/tarot-750_1713325464295.jpg";
                default:
                    return "";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMovie = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(_movies[selectedMovie].rooms.ToArray());

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }
      
    }
}

