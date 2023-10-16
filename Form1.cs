using System.Media;

namespace EuNaoSeiQueNomeDarPraIssoKkkkkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("vai toma no cu", "qual foi po", MessageBoxButtons.YesNo);

            if(retorno == DialogResult.Yes)
            {
                SoundPlayer sound = new SoundPlayer(@"C:\Users\hikki\source\repos\EuNaoSeiQueNomeDarPraIssoKkkkkk\Assets\GangstaParadiseChoir.wav");
                sound.Play();
                kkkkkkkk pagina = new kkkkkkkk();
                pagina.Show();
                
            }
            else
            {
                SoundPlayer sound = new SoundPlayer(@"C:\Users\hikki\source\repos\EuNaoSeiQueNomeDarPraIssoKkkkkk\Assets\Boo-womp.wav");
                sound.Play();
                No pagina = new No();
                pagina.Show();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}