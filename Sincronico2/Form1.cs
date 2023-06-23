using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sincronico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            loadingGIF.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            MessageBox.Show("Ya pasaron los cincos segundos");
            loadingGIF.Visible = false;
        }

        private async Task Esperar()
        {

            await Task.Delay(5000);

        }

    }
}