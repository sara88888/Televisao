namespace TelevisaoCet30GUI
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Tv minhaTV;

        public Form1()
        {
            InitializeComponent();
            minhaTV = new Tv();
            TvDesligada();
            LabelStatus.Text = minhaTV.Mensagem;
        }

        private void TvDesligada()
        {
            ButtonAumentaCanal.Enabled = false;
            ButtonDiminuiCanal.Enabled = false;
            ButtonAumentaVolume.Enabled = false;
            ButtonDiminuiVolume.Enabled = false;
            TrackBarVolume1.Enabled = false;
            LabelCanal.Text = "- -";
            LabelVolume.Text = "- -";
        }

        private void TvLigada()
        {
            ButtonAumentaCanal.Enabled = true;
            ButtonDiminuiCanal.Enabled = true;
            ButtonAumentaVolume.Enabled = true;
            ButtonDiminuiVolume.Enabled = true;
            TrackBarVolume1.Enabled = true;
        }

        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (!minhaTV.Estado)
            {
                minhaTV.LigaTv();
                LabelStatus.Text = minhaTV.Mensagem;
                ButtonOnOff.Text = "OFF";
                TvLigada();
                LabelCanal.Text = minhaTV.Canal.ToString();
            }
            else
            {
                minhaTV.DesligaTv();
                LabelStatus.Text = minhaTV.Mensagem;
                ButtonOnOff.Text = "ON";
                TvDesligada();
            }
       
        }

        private void ButtonAumentaCanal_Click(object sender, EventArgs e)
        {
            minhaTV.Canal++;
            LabelCanal.Text = minhaTV.Canal.ToString();
        }

        private void ButtonDiminuiCanal_Click(object sender, EventArgs e)
        {
            minhaTV.Canal--;
            LabelCanal.Text = minhaTV.Canal.ToString();
        }
        //validações podem ser feitas no programa ou na classe

        private void ButtonAumentaVolume_Click(object sender, EventArgs e)
        {
         if (minhaTV.Volume<30)
            {
                minhaTV.AumentaVolume(1);
                LabelVolume.Text = minhaTV.Volume.ToString();
                TrackBarVolume1.Value = minhaTV.Volume;
            }
        }

        private void ButtonDiminuiVolume_Click(object sender, EventArgs e)
        {
            if (minhaTV.Volume >0)
            {
                minhaTV.DiminuiVolume(1);
                LabelVolume.Text = minhaTV.Volume.ToString();
                TrackBarVolume1.Value = minhaTV.Volume;
            }          
        }

        private void TrackBarVolume1_Scroll(object sender, EventArgs e)
        {
            minhaTV.Volume= TrackBarVolume1.Value;
            LabelVolume.Text = minhaTV.Volume.ToString();
        }
    }
}


