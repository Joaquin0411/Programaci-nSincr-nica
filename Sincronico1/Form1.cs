using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sincronico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            //MessageBox.Show("Ya pasaron los cinco segundos");
            loadingGIF.Visible = true;
            await Task.Delay(5000);
            loadingGIF.Visible = false;
        }

        private void loadingGIF_Click(object sender, EventArgs e)
        {

        }
    }
}