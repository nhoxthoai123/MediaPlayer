using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private List<string> musicFiles;
        private List<DateTime> listtime;
        private string currentSong;
        private bool isPaused;
        private bool isChangingPosition;
        System.Timers.Timer timer;
        private int indexTime;

        public Form1()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            listtime = new List<DateTime>();
            //listBox2.Items.AddRange(listtime.Select(time => time.ToString()).ToArray());

            isPaused = false;
            isChangingPosition = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 Files | *.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    musicFiles.Add(file);
                    listBox1.Items.Add(Path.GetFileName(file));
                }

                if (musicFiles.Count > 0)
                {
                    btnPlay.Enabled = true;
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }
                else
                {
                    currentSong = musicFiles[listBox1.SelectedIndex];
                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();
                }
                timerPlayback.Enabled = true;
            }
            else if (listBox1.Items.Count > 0)
            {
                currentSong = musicFiles[0];
                musicPlayer.URL = currentSong;
                musicPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Bạn chưa có bài hát nào để phát");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                musicPlayer.Ctlcontrols.pause();
                isPaused = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            isPaused = false;
            timerPlayback.Enabled = false;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Con mẹ nó có nút next thôi mà lằng nhằng vcl
            if (listBox1.SelectedIndex != 0)
            {
                if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
                {
                    listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                    musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                    musicPlayer.Ctlcontrols.play();
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                    musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                    musicPlayer.Ctlcontrols.play();
                }
            }
            else
            {
                listBox1.SelectedIndex += 1;
                musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker.Value;
            listtime.Add(selectedTime);
            listBox2.Items.Add(selectedTime.ToString("HH:mm:ss"));
        }

        private void timerPlayback_Tick(object sender, EventArgs e)
        {
            //code hiển thị thời gian thực và độ dài của bài hát
            if (!isPaused)
            {
                label2.Text = "Lenght: " + FormatTime(musicPlayer.Ctlcontrols.currentPosition) + " / " + FormatTime(musicPlayer.currentMedia.duration);
                //code cho music bar di chuyển và thiết lập độ dài cho nó ko thì nó lỗi vãi loz ra
                MusicBar.Value = (int)this.musicPlayer.Ctlcontrols.currentPosition;
                //tự chạy khi hết thanh musicbar
                musicPlayer.Ctlcontrols.play();
            }
        }
        private string FormatTime(double seconds)
        {
            //Chỉnh format lại cho thời gian
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8 && listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                int nextIndex = listBox1.SelectedIndex += 1;
                if (nextIndex < musicFiles.Count)
                {
                    listBox1.SelectedIndex = nextIndex;
                    currentSong = musicFiles[nextIndex];
                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }
                else
                {
                    musicPlayer.Ctlcontrols.stop();
                    isPaused = false;
                }
            }
            else if (e.newState == 8 && listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = 0;
                musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                isPaused = false;
            }
        }

        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.settings.volume = VolumeBar.Value;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // DateTime currentTime = DateTime.Now;
            // DateTime userTime = dateTimePicker.Value;
            // if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            // {
            //     this.Invoke(new MethodInvoker(delegate ()
            //     {
            //         timer.Stop();
            //         btnNext_Click(sender, e);
            //     }));
            // }
            DateTime currentTime = DateTime.Now;
            for (int i = 0; i < listtime.Count; i++)
            {
                Console.WriteLine("time thuc : " +
                    currentTime.Hour + ":" + currentTime.Minute + ":" + currentTime.Second);
                Console.WriteLine("time list :" +
                    listtime[i].Hour + ":" + listtime[i].Minute + ":" + listtime[i].Second);
                if (currentTime.Hour == listtime[i].Hour &&
                    currentTime.Minute == listtime[i].Minute &&
                    currentTime.Second == listtime[i].Second)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        btnNext_Click(sender, e);
                        listtime.RemoveAt(i);
                        listBox2.Items.RemoveAt(i);
                        i--; // Điều chỉnh chỉ số vì đã xóa một phần tử
                    }));
                }
            }
        }

        //chỉnh được nhạc phát trên thanh musicbar
        private void MusicBar_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.Ctlcontrols.currentPosition = MusicBar.Value;
            MusicBar.Maximum = (int)musicPlayer.currentMedia.duration;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            listtime.RemoveAt(indexTime);
            Console.WriteLine(indexTime);
            listBox2.Items.RemoveAt(indexTime);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTime = listBox2.SelectedIndex;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // Kiểm tra mỗi giây
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            btnPlay_Click(sender, e);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Stop();
            Console.WriteLine("Timer stoped");

        }

        private void btnDeleteSound_Click(object sender, EventArgs e)
        {
            int indexDelete = listBox1.SelectedIndex;
            Console.WriteLine(indexDelete);
            Console.WriteLine(musicFiles[indexDelete]);

            listBox1.Items.RemoveAt(indexDelete);
            musicFiles.RemoveAt(indexDelete);
        }
    }
}
