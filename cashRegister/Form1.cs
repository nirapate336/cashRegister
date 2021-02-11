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


namespace cashRegister
{
    public partial class Form1 : Form
    {// global variables that are zero
        double pencilPrice = 1.25;
        double binderPrice = 3.00;
        double backpackPrice = 15.00;
        double pencilAmount;
        double binderAmount;
        double backpackAmount;
        double subTotal;
        double taxRate = 0.13;
        double taxAmount;
        double taxTotal;
        double tenderedAmount;
        double change;


         






        public Form1()
        {// global variables not zero/ that are calculations
             

          

            InitializeComponent();
        }

        private void TotalsButton_Click(object sender, EventArgs e)
        {// variable calculations

            try { 



            pencilAmount = Convert.ToInt32(inputPencil.Text);
            binderAmount = Convert.ToInt32(inputBinders.Text);
            backpackAmount = Convert.ToInt32(inputBackpacks.Text);
            subTotal = pencilAmount * pencilPrice + binderAmount * binderPrice + backpackAmount * backpackPrice;
            taxAmount = subTotal * taxRate;
            taxTotal = subTotal + taxAmount;


            outputSubTotal.Text = $"{subTotal.ToString("C")}";
            outputTax.Text = $"{taxAmount.ToString("C")}";
            outputTotal.Text = $"{taxTotal.ToString("C")}";
                receiptOutput.Text = "";

            }

            catch {

                receiptOutput.Text = "Please enter a number";
                Thread.Sleep(1000);
                this.Refresh();
                SoundPlayer printErrorOne = new SoundPlayer(Properties.Resources.printTwo);
                printErrorOne.Play();


            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // change calculations

            tenderedAmount = Convert.ToInt32(inputTendered.Text);

            change = tenderedAmount - taxTotal;
            outputChange.Text = $"{change.ToString("C")}";
            receiptOutput.Text = "";
            }
            catch
            {
            receiptOutput.Text = "Please enter a number";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printError = new SoundPlayer(Properties.Resources.printTwo);
             printError.Play();
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {//printing the receipt with pauses and sounds in between
            receiptButton.Text = "Re-Print Receipt";

            receiptOutput.Text = $"Funky's School Supply Store";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printOne = new SoundPlayer(Properties.Resources.printTwo);
            printOne.Play();

            receiptOutput.Text += $"\n\n\n Pecils X {pencilAmount} @  {pencilPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printTwo = new SoundPlayer(Properties.Resources.printTwo);
            printTwo.Play();

            receiptOutput.Text += $"\n Binders X {binderAmount} @  {binderPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printThree = new SoundPlayer(Properties.Resources.printTwo);
            printThree.Play();

            receiptOutput.Text += $"\n Backpacks X {backpackAmount} @ {backpackPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printFour = new SoundPlayer(Properties.Resources.printTwo);
            printFour.Play();


            receiptOutput.Text += $"\n\n Sub Total {subTotal.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printFive = new SoundPlayer(Properties.Resources.printTwo);
            printFive.Play();


            receiptOutput.Text += $"\n Tax {taxAmount.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printSix = new SoundPlayer(Properties.Resources.printTwo);
            printSix.Play();


            receiptOutput.Text += $"\n\n Total {taxTotal.ToString ("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printSeven = new SoundPlayer(Properties.Resources.printTwo);
            printSeven.Play();


            receiptOutput.Text += $"\n\n Tendered {tenderedAmount.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printEight = new SoundPlayer(Properties.Resources.printTwo);
            printEight.Play();


            receiptOutput.Text += $"\n Change  {change.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printNine = new SoundPlayer(Properties.Resources.printTwo);
            printNine.Play();


            receiptOutput.Text += $"\n\n Thank you for your purchase. ";
            Thread.Sleep(1000);
            this.Refresh();
            receiptOutput.Text += $"\n Have a great day :)";
            Thread.Sleep(1000);
            this.Refresh();
            SoundPlayer printTen = new SoundPlayer(Properties.Resources.service_bell_daniel_simion);
            printTen.Play();


        }

        private void NewButton_Click(object sender, EventArgs e)
        {
        // reset everything to be blank or be zero

            inputBackpacks.Text = "";
            inputBinders.Text = "";
            inputTendered.Text = "";
            inputPencil.Text = "";
            binderAmount = 0;
            pencilAmount = 0;
            backpackAmount = 0;
            tenderedAmount = 0;


            subTotal = 0;
            taxAmount = 0;
            taxTotal = 0;
            change = 0;

            outputSubTotal.Text = $"{subTotal.ToString("C")}";
            outputTax.Text = $"{taxAmount.ToString("C")}";
            outputTotal.Text = $"{taxTotal.ToString("C")}";
            outputChange.Text = $"{change.ToString("C")}";

            receiptButton.Text = "Print Receipt";

            





        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Hello There";

        }
    }
}
