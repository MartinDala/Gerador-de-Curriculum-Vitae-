using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace VitaeUi
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int LX, LY;
        public Form1(){


            InitializeComponent();


         
         
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
          

            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            minimiz.Visible = true;
            maximize.Visible = false;

      
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            minimiz.Visible = true;
            maximize.Visible = false;
        }

        private void minimiz_Click(object sender, EventArgs e)
        {
            this.Size = new Size(968, 600);
            this.Location = new Point(LX, LY);
            minimiz.Visible = false;
            maximize.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi");
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi");
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);

                pictureBox3.Image = bmp;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 imprimir = new Form2(txtNome.Text,txtFiliacao.Text,txtEde.Text,txtNascimento.Text,txtNatural.Text,txtProvincia.Text,txtEstadoCivil.Text,txtNaaacionalidade.Text,txtResidencia.Text,txtNumeroBI.Text,txtTelefone.Text,txtCorreio.Text,txtCursoMedio.Text,txtEscolaMedio.Text,txtAnoFimMedio.Text,txtClasseMedio.Text,txtCursoEspecialidade1.Text,CursoEspecialidade2.Text,txtCursoEspecialidade3.Text,txtCursoEscolaEspecialidade1.Text,txtCursoEscolaEspecialidade2.Text,txtCursoEscolaEspecialidade3.Text,txtCompetencia1.Text,txtCompetencia2.Text,txtCompetencia3.Text,txtTrabalheiComo1.Text,txtTrabalheiComo2.Text,txtTrabalheiComo3.Text,txtTrabalheiOnde1.Text,txtTrabalheiOnde2.Text,txtTrabalheiOnde3.Text,txtAnoInicio1.Text,txtAnoInicio2.Text,txtAnoInicio3.Text,txtAnoFim1.Text,txtAnoFim2.Text,txtAnoFim3.Text,txtIdioma1.Text,txtIdioma2.Text,txtObjectivo.Text );
            imprimir.Show();
           
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 imprimir = new Form3(txtNome.Text, txtFiliacao.Text, txtEde.Text, txtNascimento.Text, txtNatural.Text, txtProvincia.Text, txtEstadoCivil.Text, txtNaaacionalidade.Text, txtResidencia.Text, txtNumeroBI.Text, txtTelefone.Text, txtCorreio.Text, txtCursoMedio.Text, txtEscolaMedio.Text, txtAnoFimMedio.Text, txtClasseMedio.Text, txtCursoEspecialidade1.Text, CursoEspecialidade2.Text, txtCursoEspecialidade3.Text, txtCursoEscolaEspecialidade1.Text, txtCursoEscolaEspecialidade2.Text, txtCursoEscolaEspecialidade3.Text, txtCompetencia1.Text, txtCompetencia2.Text, txtCompetencia3.Text, txtTrabalheiComo1.Text, txtTrabalheiComo2.Text, txtTrabalheiComo3.Text, txtTrabalheiOnde1.Text, txtTrabalheiOnde2.Text, txtTrabalheiOnde3.Text, txtAnoInicio1.Text, txtAnoInicio2.Text, txtAnoInicio3.Text, txtAnoFim1.Text, txtAnoFim2.Text, txtAnoFim3.Text, txtIdioma1.Text, txtIdioma2.Text, txtObjectivo.Text);
            imprimir.Show();
        }
    }
}
