using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRNProject
{
    public partial class Music_Player : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private Random random;
        private bool isPlaybackInProgress = false;
        private Thread playbackThread;
        private List<int> randomizeArray = new List<int>();
        private int previousSong = -1;
        int currentSelectedIndex = 0;
        public Music_Player()
        {
            InitializeComponent();
            lbSongList.Items.Clear();
            waveOutDevice = new WaveOut();
            random = new Random();

        }
        private int currentSongIndex = 0;
        private bool isRandomized = false;

        private void playeASong(int songIndex)
        {
            // Lấy ra tên bài từ mảng randomizeArray
            string selectedSongName = lbSongList.Items[randomizeArray[songIndex]].ToString();
            string selectedFilePath = "";

            // Lấy ra path của bài
            string currentFolderPath = lblCurrentMusicFolder.Text.Replace("Current folder: ", "");
            string mp3FilePath = Path.Combine(currentFolderPath, selectedSongName + ".mp3");
            string wavFilePath = Path.Combine(currentFolderPath, selectedSongName + ".wav");

            // Kiểm tra sự tồn tại của tệp .mp3
            if (File.Exists(mp3FilePath))
            {
                selectedFilePath = mp3FilePath;
            }
            // Kiểm tra sự tồn tại của tệp .wav nếu tệp .mp3 không tồn tại
            else if (File.Exists(wavFilePath))
            {
                selectedFilePath = wavFilePath;
            }
            else
            {
                MessageBox.Show("Selected song file not found: " + selectedSongName);
                return;
            }

            IWaveProvider waveProvider;
            try
            {
                if (songIndex != previousSong)
                {

                    // Khởi tạo IWavePlayer
                    waveOutDevice = new WaveOut();

                    // Kiểm tra phần mở rộng của tệp
                    string fileExtension = Path.GetExtension(selectedFilePath);


                    if (fileExtension == ".mp3")
                    {
                        // Nếu là tệp MP3, sử dụng Mp3FileReader từ NAudio
                        waveProvider = new Mp3FileReader(selectedFilePath);
                    }
                    else if (fileExtension == ".wav")
                    {
                        // Nếu là tệp WAV, sử dụng WaveFileReader từ NAudio
                        waveProvider = new WaveFileReader(selectedFilePath);
                    }
                    else
                    {
                        // Phần mở rộng tệp không được hỗ trợ
                        MessageBox.Show("Selected song file format is not supported: " + fileExtension);
                        return;
                    }

                    // Chạy nhạc
                    waveOutDevice.Init(waveProvider);
                    waveOutDevice.Play();


                }
                waveOutDevice.PlaybackStopped += (sender, args) =>
                {
                    // Xử lý sự kiện khi phát lại dừng
                    waveOutDevice = new WaveOut();
                    waveProvider = null;
                };
                //waveOutDevice.Play();
                previousSong = songIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing the selected song: " + ex.Message);
            }
        }
        private async void ptrbPlay_Click(object sender, EventArgs e)
        {
            ptrbPlay.BackColor = Color.Gold;
            ptrbStop.BackColor = System.Drawing.Color.Transparent;
            if (lbSongList.Items.Count == 0)
            {
                MessageBox.Show("No songs available. Please select a folder and load songs.");
                return;
            }

            //nếu biến randomize là true, tạo mảng mới
            if (isRandomized)
            {
                for (int i = 0; i < lbSongList.Items.Count; i++)
                {
                    Console.WriteLine(i);
                    randomizeArray.Add(i);
                }
                GenerateRandomArray();
            }
            else
            //nếu false, tạo mảng mặc định
            {
                randomizeArray = new List<int>();
                for (int i = 0; i < lbSongList.Items.Count; i++)
                {
                    randomizeArray.Add(i);
                }
            }

            for (int i = 0; i < randomizeArray.Count; i++)
            {
                //lấy ra index của bài được chọn trong mảng randomizeArray
                if (randomizeArray[i] == lbSongList.SelectedIndex)
                {
                    currentSelectedIndex = i;
                    break;
                }
            }
            if (waveOutDevice.PlaybackState == PlaybackState.Paused)

            {
                ptrbPlay.BackColor = Color.Gold;
                ptrbStop.BackColor = System.Drawing.Color.Transparent;
                waveOutDevice.Play();
            }
            //chạy nhạc
            if (previousSong != currentSelectedIndex)
            {
                waveOutDevice.Dispose();
            }

            while (true)
            {

                if (waveOutDevice.PlaybackState == PlaybackState.Stopped && waveOutDevice != null)
                {
                    playeASong(currentSelectedIndex);
                    currentSelectedIndex++;
                    if (currentSelectedIndex == randomizeArray.Count)
                    {
                        if (isRandomized)
                        {
                            GenerateRandomArray();
                        }
                        currentSelectedIndex = 0;
                    }
                }
                await Task.Delay(500);
            }

        }

        private void ptrbBrowse_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wowy");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                lblCurrentMusicFolder.Text = "Current folder: " + selectedPath;

                string[] mp3Files = Directory.GetFiles(selectedPath, "*.mp3");
                string[] wavFiles = Directory.GetFiles(selectedPath, "*.wav");

                List<string> songNames = new List<string>();

                foreach (string filePath in mp3Files)
                {
                    string songName = Path.GetFileNameWithoutExtension(filePath);
                    songNames.Add(songName);
                }

                foreach (string filePath in wavFiles)
                {
                    string songName = Path.GetFileNameWithoutExtension(filePath);
                    songNames.Add(songName);
                }

                songNames.Sort(); // Sắp xếp theo thứ tự chữ cái

                lbSongList.Items.Clear();

                foreach (string songName in songNames)
                {
                    lbSongList.Items.Add(songName);
                }
            }
        }





        private void ptrbStop_Click(object sender, EventArgs e)
        {
            ptrbPlay.BackColor = System.Drawing.Color.Transparent;
            ptrbStop.BackColor = Color.Gold;
            waveOutDevice.Pause();
        }

        private void ptrbRandomize_Click(object sender, EventArgs e)
        {
            isRandomized = !isRandomized;

            if (isRandomized)
            {
                ptrbRandomize.BackColor = Color.Gold;
            }
            else
            {
                ptrbRandomize.BackColor = System.Drawing.Color.Transparent;
            }
            for (int i = 0; i < randomizeArray.Count; i++)
            {
                //tìm bài, nếu khớp lấy ra index của bài được chọn trong mảng randomizeArray
                if (randomizeArray[i] == lbSongList.SelectedIndex)
                {
                    currentSelectedIndex = i;
                    break;
                }
            }
        }
        private int countForRandom = 0;
        private int? tempForRandom;
        private void GenerateRandomArray()
        {
            int randomIndex, swap;

            if (lbSongList.Items.Count > 1)
            {
                if (countForRandom >= 1)
                {
                    tempForRandom = randomizeArray[randomizeArray.Count - 1];
                }
                for (int i = 0; i < lbSongList.Items.Count - 2; i++)
                {
                    randomIndex = random.Next(0, lbSongList.Items.Count);
                    swap = randomizeArray[i];
                    randomizeArray[i] = randomizeArray[randomIndex];
                    randomizeArray[randomIndex] = swap;
                }
                countForRandom++;

                if (tempForRandom == randomizeArray[randomizeArray.Count - 1])
                {
                    GenerateRandomArray();
                }
            }

        }

        private async void ptrbBackward_Click(object sender, EventArgs e)
        {
            currentSelectedIndex--;
            waveOutDevice.Dispose();
            if (currentSongIndex == randomizeArray.Count)
            {
                currentSongIndex = 0;
            }
            while (true)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Stopped && waveOutDevice != null)
                {
                    playeASong(currentSelectedIndex);
                    currentSelectedIndex++;
                    if (currentSelectedIndex == randomizeArray.Count)
                    {
                        if (isRandomized)
                        {
                            GenerateRandomArray();
                        }
                        currentSelectedIndex = 0;
                    }
                }
                await Task.Delay(500);
            }
        }

        private async void ptrbForward_Click(object sender, EventArgs e)
        {
            waveOutDevice.Dispose();
            while (true)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Stopped && waveOutDevice != null)
                {
                    if (currentSelectedIndex == randomizeArray.Count)
                    {
                        if (isRandomized)
                        {
                            GenerateRandomArray();
                        }
                        currentSelectedIndex = 0;
                    }
                    playeASong(currentSelectedIndex++);

                }
                await Task.Delay(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Form1();
            frmHome.ShowDialog();
        }
    }
}
