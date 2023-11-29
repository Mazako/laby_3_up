namespace lab3_release_sobota_rano
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoundPlayChooseFileButton = new System.Windows.Forms.Button();
            this.SoundPlayButton = new System.Windows.Forms.Button();
            this.ChosenSoundPlayFileLabel = new System.Windows.Forms.Label();
            this.DirectSoundRadio = new System.Windows.Forms.RadioButton();
            this.MediaPlayerRadio = new System.Windows.Forms.RadioButton();
            this.WaveOutRadio = new System.Windows.Forms.RadioButton();
            this.SoundPlayerRadio = new System.Windows.Forms.RadioButton();
            this.WavHeaderTextBox = new System.Windows.Forms.TextBox();
            this.WavHeaderlabel = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odtwarzanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.label2.Location = new System.Drawing.Point(992, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nagrywanie";
            // 
            // SoundPlayChooseFileButton
            // 
            this.SoundPlayChooseFileButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.SoundPlayChooseFileButton.Location = new System.Drawing.Point(3, 102);
            this.SoundPlayChooseFileButton.Name = "SoundPlayChooseFileButton";
            this.SoundPlayChooseFileButton.Size = new System.Drawing.Size(139, 42);
            this.SoundPlayChooseFileButton.TabIndex = 2;
            this.SoundPlayChooseFileButton.Text = "Wybierz plik";
            this.SoundPlayChooseFileButton.UseVisualStyleBackColor = true;
            this.SoundPlayChooseFileButton.Click += new System.EventHandler(this.SoundPlayChooseFileButton_Click);
            // 
            // SoundPlayButton
            // 
            this.SoundPlayButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.SoundPlayButton.Location = new System.Drawing.Point(163, 102);
            this.SoundPlayButton.Name = "SoundPlayButton";
            this.SoundPlayButton.Size = new System.Drawing.Size(152, 42);
            this.SoundPlayButton.TabIndex = 3;
            this.SoundPlayButton.Text = "Odtwórz";
            this.SoundPlayButton.UseVisualStyleBackColor = true;
            this.SoundPlayButton.Click += new System.EventHandler(this.SoundPlayButton_Click);
            // 
            // ChosenSoundPlayFileLabel
            // 
            this.ChosenSoundPlayFileLabel.AutoSize = true;
            this.ChosenSoundPlayFileLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ChosenSoundPlayFileLabel.Location = new System.Drawing.Point(48, 172);
            this.ChosenSoundPlayFileLabel.Name = "ChosenSoundPlayFileLabel";
            this.ChosenSoundPlayFileLabel.Size = new System.Drawing.Size(157, 23);
            this.ChosenSoundPlayFileLabel.TabIndex = 4;
            this.ChosenSoundPlayFileLabel.Text = "Wybrany plik: brak";
            // 
            // DirectSoundRadio
            // 
            this.DirectSoundRadio.AutoSize = true;
            this.DirectSoundRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.DirectSoundRadio.Location = new System.Drawing.Point(52, 222);
            this.DirectSoundRadio.Name = "DirectSoundRadio";
            this.DirectSoundRadio.Size = new System.Drawing.Size(125, 27);
            this.DirectSoundRadio.TabIndex = 5;
            this.DirectSoundRadio.TabStop = true;
            this.DirectSoundRadio.Text = "Direct Sound";
            this.DirectSoundRadio.UseVisualStyleBackColor = true;
            // 
            // MediaPlayerRadio
            // 
            this.MediaPlayerRadio.AutoSize = true;
            this.MediaPlayerRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.MediaPlayerRadio.Location = new System.Drawing.Point(51, 264);
            this.MediaPlayerRadio.Name = "MediaPlayerRadio";
            this.MediaPlayerRadio.Size = new System.Drawing.Size(124, 27);
            this.MediaPlayerRadio.TabIndex = 6;
            this.MediaPlayerRadio.TabStop = true;
            this.MediaPlayerRadio.Text = "Media Player";
            this.MediaPlayerRadio.UseVisualStyleBackColor = true;
            // 
            // WaveOutRadio
            // 
            this.WaveOutRadio.AutoSize = true;
            this.WaveOutRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.WaveOutRadio.Location = new System.Drawing.Point(52, 306);
            this.WaveOutRadio.Name = "WaveOutRadio";
            this.WaveOutRadio.Size = new System.Drawing.Size(102, 27);
            this.WaveOutRadio.TabIndex = 7;
            this.WaveOutRadio.TabStop = true;
            this.WaveOutRadio.Text = "Wave Out";
            this.WaveOutRadio.UseVisualStyleBackColor = true;
            // 
            // SoundPlayerRadio
            // 
            this.SoundPlayerRadio.AutoSize = true;
            this.SoundPlayerRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.SoundPlayerRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SoundPlayerRadio.Location = new System.Drawing.Point(51, 350);
            this.SoundPlayerRadio.Name = "SoundPlayerRadio";
            this.SoundPlayerRadio.Size = new System.Drawing.Size(123, 27);
            this.SoundPlayerRadio.TabIndex = 8;
            this.SoundPlayerRadio.TabStop = true;
            this.SoundPlayerRadio.Text = "Sound Player";
            this.SoundPlayerRadio.UseVisualStyleBackColor = true;
            // 
            // WavHeaderTextBox
            // 
            this.WavHeaderTextBox.Location = new System.Drawing.Point(29, 442);
            this.WavHeaderTextBox.Multiline = true;
            this.WavHeaderTextBox.Name = "WavHeaderTextBox";
            this.WavHeaderTextBox.Size = new System.Drawing.Size(363, 187);
            this.WavHeaderTextBox.TabIndex = 10;
            // 
            // WavHeaderlabel
            // 
            this.WavHeaderlabel.AutoSize = true;
            this.WavHeaderlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.WavHeaderlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.WavHeaderlabel.Location = new System.Drawing.Point(48, 417);
            this.WavHeaderlabel.Name = "WavHeaderlabel";
            this.WavHeaderlabel.Size = new System.Drawing.Size(156, 23);
            this.WavHeaderlabel.TabIndex = 11;
            this.WavHeaderlabel.Text = "Nagłówek pliku .wav";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(201, 245);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(261, 46);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 641);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.WavHeaderlabel);
            this.Controls.Add(this.WavHeaderTextBox);
            this.Controls.Add(this.SoundPlayerRadio);
            this.Controls.Add(this.WaveOutRadio);
            this.Controls.Add(this.MediaPlayerRadio);
            this.Controls.Add(this.DirectSoundRadio);
            this.Controls.Add(this.ChosenSoundPlayFileLabel);
            this.Controls.Add(this.SoundPlayButton);
            this.Controls.Add(this.SoundPlayChooseFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SoundPlayChooseFileButton;
        private System.Windows.Forms.Button SoundPlayButton;
        private System.Windows.Forms.Label ChosenSoundPlayFileLabel;
        private System.Windows.Forms.RadioButton DirectSoundRadio;
        private System.Windows.Forms.RadioButton MediaPlayerRadio;
        private System.Windows.Forms.RadioButton WaveOutRadio;
        private System.Windows.Forms.RadioButton SoundPlayerRadio;
        private System.Windows.Forms.TextBox WavHeaderTextBox;
        private System.Windows.Forms.Label WavHeaderlabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

