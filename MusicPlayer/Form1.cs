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
        private List<string> dateTime;
        private string currentSong;
        private bool isPaused;
        private bool isChangingPosition;
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            dateTime = new List<string>();
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
                listBox1.SelectedIndex = listBox1.Items.Count -1;
                musicPlayer.URL = musicFiles[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Con mẹ nó có nút next thôi mà lằng nhằng vcl
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

        private void btnSet_Click(object sender, EventArgs e)
        {
            foreach (var datetime in dateTime)
            {
                listBox2.Items.Add(datetime.ToString());
            }
            timer.Start();
        }
        
        private void timerPlayback_Tick(object sender, EventArgs e)
        {
            //code hiển thị thời gian thực và độ dài của bài hát
            if (!isPaused)
            {
                label2.Text = "Lenght: " + FormatTime(musicPlayer.Ctlcontrols.currentPosition) + " / " + FormatTime(musicPlayer.currentMedia.duration);
                //code cho music bar di chuyển và thiết lập độ dài cho nó ko thì nó lỗi vãi loz ra
                MusicBar.Value = (int)this.musicPlayer.Ctlcontrols.currentPosition;
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
            if (e.newState == 8)
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
        }

        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.settings.volume = VolumeBar.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            ListBox listBox1 = new ListBox();
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second) 
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    timer.Stop();
                    btnNext_Click(sender, e);
                }));
            }
        }

        private void MusicBar_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.Ctlcontrols.currentPosition = MusicBar.Value;
            MusicBar.Maximum = (int)musicPlayer.currentMedia.duration;
        }
    }
}
