using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_V01{


    public partial class Form1 : Form{
        Random Enemigo = new Random();
        //Jugador
        double VPlayer = 100, APlayer = 20, DPlayer = 50;
        //Enemigos (Slime)
        double VChico = 20, AChico = 10, DChico = 10;
        //Enemigos (Esquelleto)
        double VMedio = 40, AMedio = 20, DMedio = 15;
        //Enemigos (Golem)
        double VGrande = 60, AGrande = 25, DGrande = 20;

        private void btnHuir_Click(object sender, EventArgs e)
        {

        }

        //Otros
        int Total = 0, Item;
        public void Items()
        {
            Random Items = new Random();
            int Seleccion = Items.Next(1, 4);

            switch (Seleccion)
            {
                case 1:
                    label7.Text = ("Afilador encontrado ").ToString();
                    listBox1.Items.Add("Afilador");
                    Item = 1;
                    
                    break;
                case 2:
                    label7.Text = ("Pedazo de armadura encontrado ").ToString();
                    listBox1.Items.Add("Escudo");
                    Item = 2;

                    break;
                case 3:
                    label7.Text = ("Botella de elixir encontrada ").ToString();
                    listBox1.Items.Add("Elixir");
                    Item = 3;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e){
            Total = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex == 1){
                
            }


        }


        private void button4_Click(object sender, EventArgs e){
            if (EChico.Visible==true){
                label6.Text = ("Pelea con Slimne Iniciada").ToString();
                if (VChico == 0) {
                    label6.Text = ("ENEMIGO DERROTADO").ToString();
                    Items();
                    btnAtacar.Visible = false;
                    btnHuir.Visible = false;
                    btnAdentrar.Visible = true;
                    EChico.Visible = false;
                    Total++;
                }
                else{
                    //double DañoC = DPlayer / AChico;
                    VPlayer = VPlayer - AChico;
                    TxtVida.Text = VPlayer.ToString();

                    //double DañoP = DChico / APlayer;
                    VChico = VChico - APlayer;
                    label7.Text = ("Vida Enemigo: " + VChico).ToString();
                }

            }if(EMedio.Visible==true){
                label6.Text = ("Pelea con Esqueleto Iniciada").ToString();
                if (VMedio == 0){
                    label6.Text = ("ENEMIGO DERROTADO").ToString();
                    Items();
                    btnAtacar.Visible = false;
                    btnHuir.Visible = false;
                    btnAdentrar.Visible = true;
                    EMedio.Visible = false;
                    Total ++;
                }
                else{
                   // double DañoM = DPlayer / AMedio;
                    VPlayer = VPlayer - AMedio;
                    TxtVida.Text = VPlayer.ToString();

                    //double DañoP = DMedio / APlayer;
                    VMedio = VMedio - APlayer;
                    label7.Text = ("Vida Enemigo: " + VMedio).ToString();
                }
            }else{
                label6.Text = ("Pelea con Golem Iniciada").ToString();
                if (VGrande == 0)
                {
                    label6.Text = ("ENEMIGO DERROTADO").ToString();
                    Items();
                    btnAtacar.Visible = false;
                    btnHuir.Visible = false;
                    btnAdentrar.Visible = true;
                    EGrande.Visible = false;
                    Total++;
                }
                else{
                   // double DañoG = DPlayer / AGrande;
                    VPlayer = VPlayer - AGrande;
                    TxtVida.Text = VPlayer.ToString();

                    //double DañoP = DGrande / APlayer;
                    VGrande = VGrande - APlayer;
                    label7.Text = ("Vida Enemigo: " + VGrande).ToString();
                }
            }



        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int Ene = Enemigo.Next(1, 4);
            EChico.Visible = false;
            EMedio.Visible = false;
            EGrande.Visible = false;
            switch (Ene) {
                case 1:
                    label6.Text = ("Slime Generado ").ToString();
                    EChico.Visible = true;
                    label7.Text = ("Que desea hacer? ").ToString();
                    btnAtacar.Visible = true;
                    btnHuir.Visible = true;
                    break;
                case 2:
                    label6.Text = ("Esqueleto Generado ").ToString();
                    EMedio.Visible = true;
                    label7.Text = ("Que desea hacer? ").ToString();
                    btnAtacar.Visible = true;
                    btnHuir.Visible = true;
                    break;
                case 3:
                    label6.Text = ("Golem Generado ").ToString();
                    EGrande.Visible = true;
                    label7.Text = ("Que desea hacer? ").ToString();
                    btnAtacar.Visible = true;
                    btnHuir.Visible = true;
                    break;
            }
            btnAdentrar.Visible = false;
              // button5.Enabled = false;
        }

    private void Form1_Load(object sender, EventArgs e){
            TxtVida.Text = VPlayer.ToString();
            TxtAtaque.Text = APlayer.ToString();
            TxtDefensa.Text = DPlayer.ToString();
            if (VPlayer<=0){
                MessageBox.Show("HEROE ELIMINADO");
                MessageBox.Show("Enemigos derrotados: "+Total);
            }

        }
    }

}
