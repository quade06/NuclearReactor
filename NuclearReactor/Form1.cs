using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Siren_Noise_KevanGC_1337458893);

            player.Play();
            //change the colour of the state labels 

            reactor1StateLabel.BackColor = Color.Red;

            reactor2StateLabel.BackColor = Color.Red;



            //change the message in the output label 

            outputLabel.Text = "Meltdown Imminent";

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;

            reactor2StateLabel.BackColor = Color.White;

            outputLabel.ForeColor = Color.White;

            outputLabel.BackColor = Color.Red;

            Refresh();

            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;

            reactor2StateLabel.BackColor = Color.Red;

            outputLabel.ForeColor = Color.Red;

            outputLabel.BackColor = Color.White;

            Refresh();

            Thread.Sleep(1000);
        }

    }
    }

