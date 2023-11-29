using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using NAudio.Wave;

namespace lab3_release_sobota_rano
{
    public partial class Form1 : Form
    {
        //Sound playing
        private SoundPlayer soundPlayer;
        private AxWindowsMediaPlayer windowsMediaPlayer;
        private WaveOut waveOut = new WaveOut();
        private DirectSoundOut directSoundOut = new DirectSoundOut();
        private string playAudioPath;
        private bool canPlayAudio = false;
        private bool shouldStop = false;

        //Sound recording
        WaveIn sourceStream = null;
        DirectSoundOut soundOut = null;
        WaveFileWriter waveFileWriter = null;

        public Form1()
        {
            InitializeComponent();
            windowsMediaPlayer = axWindowsMediaPlayer1;
            windowsMediaPlayer.CreateControl();
            windowsMediaPlayer.Visible = false;
        }

        private void SoundPlayChooseFileButton_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Audio files (.wav)|*.wav";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                playAudioPath = openFile.FileName;
                ChosenSoundPlayFileLabel.Text = "Wybrany plik: " + playAudioPath;
                canPlayAudio = true;
                setWavHeader();
            }
        }

        private void setWavHeader()
        {
            if (!canPlayAudio && playAudioPath == null)
            {
                return;
            }

            using (BinaryReader reader = new BinaryReader(new FileStream(playAudioPath, FileMode.Open, FileAccess.Read)))
            {
                byte[] header = reader.ReadBytes(44);

                WavHeaderTextBox.AppendText("ChunkID: " + Encoding.ASCII.GetString(header, 0, 4) + Environment.NewLine);
                WavHeaderTextBox.AppendText("ChunkSize: " + BitConverter.ToInt32(header, 4) + Environment.NewLine);
                WavHeaderTextBox.AppendText("Format: " + Encoding.ASCII.GetString(header, 8, 4) + Environment.NewLine);
                WavHeaderTextBox.AppendText("Subchunk1ID: " + Encoding.ASCII.GetString(header, 12, 4) + Environment.NewLine);
                WavHeaderTextBox.AppendText("Subchunk1Size: " + BitConverter.ToInt32(header, 16) + Environment.NewLine);
                WavHeaderTextBox.AppendText("AudioFormat: " + BitConverter.ToInt16(header, 20) + Environment.NewLine);
                WavHeaderTextBox.AppendText("NumChannels: " + BitConverter.ToInt16(header, 22) + Environment.NewLine);
                WavHeaderTextBox.AppendText("SampleRate: " + BitConverter.ToInt32(header, 24) + Environment.NewLine);
                WavHeaderTextBox.AppendText("ByteRate: " + BitConverter.ToInt32(header, 28) + Environment.NewLine);
                WavHeaderTextBox.AppendText("BlockAlign: " + BitConverter.ToInt16(header, 32) + Environment.NewLine);
                WavHeaderTextBox.AppendText("BitsPerSample: " + BitConverter.ToInt16(header, 34) + Environment.NewLine);
                WavHeaderTextBox.AppendText("Subchunk2ID: " + Encoding.ASCII.GetString(header, 36, 4) + Environment.NewLine);
                WavHeaderTextBox.AppendText("Subchunk2Size: " + BitConverter.ToInt32(header, 40) + Environment.NewLine);
            }
        }

        private void SoundPlayButton_Click(object sender, EventArgs e)
        {

            if (!canPlayAudio && playAudioPath == null)
            {
                MessageBox.Show("Nie wybrano żadnego pliku");
                return;
            }
            if (!shouldStop)
            {
                handleStartPlaying();
            } else
            {
                handleStopPlaying();
            }

        }

        private void handleStopPlaying()
        {
            if (DirectSoundRadio.Checked)
            {
                directSoundOut.Stop();
            }
            else if (MediaPlayerRadio.Checked)
            {
                windowsMediaPlayer.Ctlcontrols.stop();
                windowsMediaPlayer.Visible = false;
            }
            else if (WaveOutRadio.Checked)
            {
                waveOut.Stop();
            }
            else if (SoundPlayerRadio.Checked) 
            {
                soundPlayer.Stop();
            }
            shouldStop = false;
            SoundPlayButton.Text = "Odtwórz";
        }

        private void handleStartPlaying()
        {
            if (DirectSoundRadio.Checked)
            {
                directSoundOut.Init(new AudioFileReader(playAudioPath));
                directSoundOut.Play();
            }
            else if (MediaPlayerRadio.Checked)
            {
                axWindowsMediaPlayer1.Visible = true;
                windowsMediaPlayer.URL = playAudioPath;
                windowsMediaPlayer.Ctlcontrols.play();

            }
            else if (WaveOutRadio.Checked)
            {
                waveOut.Init(new WaveChannel32(new WaveFileReader(playAudioPath)));
                waveOut.Play();
            }
            else if (SoundPlayerRadio.Checked)
            {
                soundPlayer = new SoundPlayer(playAudioPath);
                soundPlayer.Play();
            } else
            {
                MessageBox.Show("nie wybrano żadnej opcji");
                return;
            }
            shouldStop = true;
            SoundPlayButton.Text = "Stop";

        }

    }
}
