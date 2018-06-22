using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSnake
{
    public partial class Form1 : Form
    {
        Cola cabeza;
        Graphics g;
        comida comida;

        int xdir=0, ydir=0;
        Boolean ejex = true, ejey = true;
        int cuadro=10;
        int puntaje = 0;
        
       
        public Form1()
        {
            
            InitializeComponent();
           
            

            cabeza = new Cola(50,28);
            comida = new comida();
            g = pantalla.CreateGraphics();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void movimiento()
        {
            cabeza.setx(cabeza.verx() + xdir, cabeza.very() + ydir);
        }
        private void bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            cabeza.dibujar(g);
            movimiento();
            comida.dibujar(g);
            choqueCuerpo();
            choqueParedes();
            CooX.Text = xdir.ToString();
            CooY.Text = ydir.ToString();
            if(cabeza.interseccion(comida))
            {
                comida.colocar();
                cabeza.meter();
                puntaje++;
                score.Text = puntaje.ToString();
                

            }

        }

        private void pantalla_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        public void choqueParedes()
        {
            if(cabeza.verx()<0|| cabeza.verx()>490||cabeza.very()<0||cabeza.very()>270)
            {
                GameOver();
            }
        }
        public void choqueCuerpo()
        {
            Cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }catch(Exception err)
            {
                temp = null;
            }
            while(temp!=null)
            {
                if(cabeza.interseccion(temp))
                {
                    GameOver();
                }else
                {
                    temp = temp.verSiguiente();
                }
            }
        }
        public void GameOver()
        {
            puntaje = 0;
            score.Text = "0";
            ejex = true;
            ejey = true;
            xdir = 0;
            ydir = 0;
            CooX.Text = "0";
            CooY.Text = "0";
            cabeza = new Cola(10, 10);
            comida = new comida();
            
            MessageBox.Show("***GAME OVER***");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(ejex)
            {
                if(e.KeyCode==Keys.Up)
                {
                    ydir = -cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if(ejey)
            {
               if (e.KeyCode==Keys.Right)
               {
                   ydir = 0;
                   xdir = cuadro;
                   ejex = true;
                   ejey = false;
               }
               if (e.KeyCode == Keys.Left)
               {
                   ydir = 0;
                   xdir = -cuadro;
                   ejex = true;
                   ejey = false;
               }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pantalla_Click(object sender, EventArgs e)
        {
           
        }
    }
}
