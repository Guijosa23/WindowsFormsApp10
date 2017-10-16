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

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        //global constants
        const double PAELLA = 18.00;
        const double CHORIZO = 9.00;
        const double VINO = 48.00;
        const double TAX = 0.13;

        //global variables
        int numofPaellas = 0;
        int numofChorizos = 0;
        int numofVinos = 0;
        double totalPrice = 0;
        double subTotal = 0;
        

        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                numofPaellas = Convert.ToInt16(paellaTextbox.Text);
                numofChorizos = Convert.ToInt16(chorizoTextbox.Text);
                numofVinos = Convert.ToInt16(vinoTextbox.Text);

                double subTotal = numofPaellas * PAELLA + numofChorizos * CHORIZO + numofVinos
                    * VINO;
                double totalPrice = subTotal * TAX;
                double total = subTotal * TAX + subTotal;

                priceLabel.Text = "SubTotal              " + subTotal.ToString("C");
                priceLabel.Text += "\nTax                      " + TAX.ToString("C");
                priceLabel.Text += "\nTotal                    " + total.ToString("C");
               
            }
            catch
            {
                priceLabel.Text = "ERROR";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subTotal = numofPaellas * PAELLA + numofChorizos * CHORIZO + numofVinos
                    * VINO;
            double totalPrice = subTotal * TAX;
            double total = subTotal * TAX + subTotal;
            
            

            //blank screen
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            priceLabel.Visible = false;
            paellaLabel.Visible = false;
            chorizoLabel.Visible = false;
            vinoLabel.Visible = false;
            paellaTextbox.Visible = false;
            chorizoTextbox.Visible = false;
            vinoTextbox.Visible = false;
            calcButton.Visible = false;
            printButton.Visible = false;


            Graphics fg = this.CreateGraphics();
            Font JuiceITC = new Font("Juice ITC", 32, FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.Black, 7);
            fg.FillRectangle(redBrush, 0, 0, 460, 145);
            fg.FillRectangle(yellowBrush, 0, 145, 460, 155);
            fg.FillRectangle(redBrush, 0, 300, 460, 145);
            fg.DrawRectangle(drawPen, 72, 12, 310, 405);



            //paper ticket
            SolidBrush drawBrush = new SolidBrush(Color.White);
            fg.FillRectangle(drawBrush, 75, 15, 305, 400);


            Font drawFont = new Font("Juice ITC", 32, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            fg.DrawString("Casa", drawFont, blackBrush, 100, 55);

            drawFont = new Font("Juice ITC", 66, FontStyle.Bold);
            fg.DrawString("Pepe", drawFont, blackBrush, 165, 15);

           

            Thread.Sleep(500);
            drawFont = new Font("Courier New", 12, FontStyle.Bold);
            fg.DrawString("October 12, 2017", drawFont, blackBrush, 180, 117);
            fg.DrawString("Order N*:  001", drawFont, blackBrush, 90, 140);
            Thread.Sleep(500);

            Thread.Sleep(500);
            drawFont = new Font("Courier New", 11, FontStyle.Bold);
            fg.DrawString("\nPaella        x" + numofPaellas + "....." + numofPaellas * 
                PAELLA + " $", drawFont, blackBrush, 95, 155);
            Thread.Sleep(1150);

            Thread.Sleep(500);
            fg.DrawString("\nChorizo       x" + numofChorizos + "....." + numofChorizos *
              CHORIZO + " $", drawFont, blackBrush, 95, 180);
            Thread.Sleep(500);

            Thread.Sleep(500);
            fg.DrawString("\nVino Botella  x" + numofVinos + "....." + numofVinos *
             VINO + " $", drawFont, blackBrush, 95, 210);
            Thread.Sleep(500)

             Thread.Sleep(500);
            fg.DrawString("SubTotal: ..........." + subTotal.ToString("C"), 
                drawFont, blackBrush, 90, 270);
             Thread.Sleep(500);

            Thread.Sleep(500);
            fg.DrawString("Tax:      ..........." + TAX.ToString("C"), 
                drawFont, blackBrush, 90, 290);
            Thread.Sleep(500);

            Thread.Sleep(500);
            fg.DrawString("SubTotal: ..........." + total.ToString("C"), 
                drawFont, blackBrush, 90, 310);
            Thread.Sleep(500);



        }
    }
}
