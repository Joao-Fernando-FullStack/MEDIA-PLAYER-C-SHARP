using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace Player
{
    public partial class Form1 : Form
    {
        private WMPLib.IWMPPlaylist playlist;
        private string videoDirectory="";
        private bool mover = false;
        private Point posicaoInicial;
        //private int Play { get; set; }
        private void PlayFile(String url)
        {
            player.URL = url;
            player.Ctlcontrols.play();
        }

        //int num { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir Midia";
            openFileDialog1.Filter = "Selecione a Midia|";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            stPlaylist.Visible = true;
            pnList.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                playlist = player.playlistCollection.newPlaylist("PlayList");
                btPlay.Visible = false;
                btPausa.Visible = true;
                foreach (var arquivo in openFileDialog1.FileNames)
                {
                    playlist.appendItem(player.newMedia(arquivo));
                    stPlaylist.Items.Add(arquivo);
                    player.currentPlaylist = playlist;
                    player.Ctlcontrols.play();
                    lbTituloMusica.Text = player.currentMedia.name;
                }
                txtContList.Text = stPlaylist.Items.Count.ToString();
                MusicTitle();
            }
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir a PlayList";
            openFileDialog1.Filter = "Arquivo texto|*.txt";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            btPlay.Visible = false;
            btPausa.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                stPlaylist.Items.Clear();
                StreamReader arquivo = new StreamReader(openFileDialog1.FileName);
                while (arquivo.Peek() != -1)
                {
                    stPlaylist.Items.Add(arquivo.ReadLine());
                    stPlaylist.Visible = true;
                    pnList.Visible = true;
                }
                arquivo.Close();
                txtContList.Text = stPlaylist.Items.Count.ToString();
            }
        }

        private void stPlaylist_DoubleClick(object sender, EventArgs e)
        {
            //PlayFile(stPlaylist.SelectedItem.ToString());
            if (stPlaylist.Items.Count > 0)
            {
                player.URL = stPlaylist.SelectedItem.ToString();
                player.Ctlcontrols.play();
                pnList.Visible = false;
                stPlaylist.Visible = false;
                lbTituloMusica.Text = player.currentMedia.name;
                btPlay.Visible = false;
                btPausa.Visible = true;
                MusicTitle();
            }
            txtContList.Text = stPlaylist.Items.Count.ToString() + "/" + (stPlaylist.SelectedIndex+1).ToString();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            stPlaylist.Items.Clear();
            this.Text = "Player";
            lbTituloMusica.Text = "Título:";
            txtContList.Text = "00\00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbLeft.Text = player.Ctlcontrols.currentPositionString;
            lbRight.Text = player.Ctlcontrols.currentItem.durationString;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MusicTitle();
                timer1.Start();
                //player.Ctlcontrols.play();
                //PlayFile(stPlaylist.SelectedItem.ToString());
                //btPlay_Click_1(sender, System.EventArgs.Empty);
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                btPausa.Visible = false;
                btPlay.Visible = true;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //stPlaylist_DoubleClick(sender, EventArgs.Empty);
                //stPlaylist_SelectedIndexChanged(sender, EventArgs.Empty);
                //btNext_Click(sender, EventArgs.Empty);
                //MessageBox.Show("hh");
                //PlayFile(stPlaylist.SelectedItem.ToString());
                //btPlay_Click_1(sender, System.EventArgs.Empty);
                //this.Show();
                //player.Ctlcontrols.next();
                //play();
                lbTituloMusica.Text = player.currentMedia.name;
                MusicTitle();
                PlayFile(stPlaylist.SelectedItem.ToString());
                btPausa.Visible = false;
                btPlay.Visible = true;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (stPlaylist.Items.Count > 0)
            {
                saveFileDialog1.Title = "Salvar PlayList";
                saveFileDialog1.Filter = "Arquivo text|*.txt";
                saveFileDialog1.FileName = "";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter arquivo = new StreamWriter(saveFileDialog1.FileName, false);
                    for (int i = 0; i < stPlaylist.Items.Count; i++)
                    {
                        arquivo.WriteLine(stPlaylist.Items[i].ToString());
                    }
                    arquivo.Close();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stPlaylist.Visible = false;
            pnList.Visible = false;
            btPlay.Visible = false;
        }

        private void btPausar(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            btPausa.Visible = false;
            btPlay.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            player.close();
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            player.close();
            Application.Exit();
        }

        private void stPlaylist_MouseLeave(object sender, EventArgs e)
        {
            stPlaylist.Visible = false;
            pnList.Visible = false;
        }

        private void btPlay_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            btPlay.Visible = false;
            btPausa.Visible = true;
        }

        private void btStop(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btPlayList(object sender, EventArgs e)
        {
            stPlaylist.Visible = true;
            pnList.Visible = true;
        }
        private void btReAvançar(object sender, EventArgs e)
        {
            btPausa.Visible = false;
            btPlay.Visible = true;
            player.Ctlcontrols.fastReverse();
        }

        private void btAvancar(object sender, EventArgs e)
        {
            btPausa.Visible = false;
            btPlay.Visible = true;
            player.Ctlcontrols.fastForward();
        }

        private void MusicTitle()
        {
            this.Text = "Player - " + player.currentMedia.name;
        }

        private void bt_Back(object sender, EventArgs e)
        {
            //Back();
            lbTituloMusica.Text = player.currentMedia.name;
            MusicTitle();
            if (stPlaylist.SelectedIndex == 0)
            {
                stPlaylist.SelectedIndex = stPlaylist.Items.Count - 1;
            }
            else
            {
                stPlaylist.SelectedIndex--;
            }

            stPlaylist_DoubleClick(sender, e);
            stPlaylist_SelectedIndexChanged(sender, e);
            txtContList.Text = stPlaylist.Items.Count.ToString() + "/" + (stPlaylist.SelectedIndex + 1).ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            lbTituloMusica.Text = player.currentMedia.name;
            MusicTitle();
            if (stPlaylist.SelectedIndex == stPlaylist.Items.Count - 1)
            {
                stPlaylist.SelectedIndex = 0;
            }
            else
            {
                stPlaylist.SelectedIndex++;
            }
            stPlaylist_DoubleClick(sender, e);
            stPlaylist_SelectedIndexChanged(sender, e);
            txtContList.Text = stPlaylist.Items.Count.ToString() + "/" + (stPlaylist.SelectedIndex + 1).ToString();
        }

        //private int Num()
        //{
        //    num++;
        //    this.num = num;
        //    return num;
        //}
        //private int NumR()
        //{
        //    num--;
        //    this.num = num;
        //    return num;
        //}
        //private void Next()
        //{
        //    if (stPlaylist.Items.Count > 0)
        //    {
        //        try
        //        {
        //            player.URL = stPlaylist.Items[Num()].ToString();
        //            player.Ctlcontrols.next();
        //        }
        //        catch (Exception)
        //        {
        //            num = 0;
        //        }

        //    }
        //}
        //private void Back()
        //{
        //    if (stPlaylist.Items.Count > 0)
        //    {
        //        try
        //        {
        //            player.URL = stPlaylist.Items[NumR()].ToString();
        //            player.Ctlcontrols.next();
        //        }
        //        catch (Exception)
        //        {
        //            num = stPlaylist.Items.Count;
        //        }
        //    }
        //}

        private void AbrirPasta_Click(object sender, EventArgs e)
        {
            stPlaylist.Visible = true;
            try
            {
                var fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    videoDirectory = fdl.SelectedPath;
                    var difo = new DirectoryInfo(videoDirectory);
                    var files = difo.GetFiles().Where(a => (a.Extension.Equals(".mp3") || a.Extension.Equals(".mp4") || a.Extension.Equals(".wmv") || a.Extension.Equals(".webm") || a.Extension.Equals(".3pg") || a.Extension.Equals(".avi") || a.Extension.Equals(".rmvb") || a.Extension.Equals(".m4a") || a.Extension.Equals(".wma") || a.Extension.Equals(".wav")));
                    stPlaylist.Items.Clear();
                    
                    foreach (var video in files)
                    {

                        stPlaylist.Items.Add(video.Name);
                    }
                    //stPlaylist_SelectedIndexChanged(sender, e);
                    txtContList.Text = stPlaylist.Items.Count.ToString() + "/" + (stPlaylist.SelectedIndex + 1).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private int play()
        //{
        //    this.Play = 1;

        //    if (Play == 1)
        //    {
        //        player.Ctlcontrols.play();
        //    }

        //    player.Ctlcontrols.play();

        //    return Play;
        //}
        private void stPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                
                if (stPlaylist.Items.Count > 0)
                {
                var selectedVideo = stPlaylist.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(selectedVideo) && !string.IsNullOrEmpty(videoDirectory))
                {
                    var fullPath = Path.Combine(videoDirectory, selectedVideo);
                        player.URL = fullPath;
                        player.Ctlcontrols.play();
                        pnList.Visible = false;
                        stPlaylist.Visible = false;
                        lbTituloMusica.Text = player.currentMedia.name;
                        btPlay.Visible = false;
                        btPausa.Visible = true;
                        MusicTitle();
                        //stPlaylist_DoubleClick(sender, e);    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
