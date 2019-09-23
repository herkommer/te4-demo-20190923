using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.GUI
{
    public partial class Form1 : Form
    {
        ArrayList Customers = new ArrayList();

        public Form1()
        {
            //Constructor .ctor
            //Metoden nedanför skapar UI som vi drag and droppat
            InitializeComponent();

            //Nu har vi fått vårt GUI på plats
            //Dvs vi kan nu prata med objekten

            button1.Text = "Add Customer";
            button2.Text = "Show Customers";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Här hamnar vi när användaren klickar på knappen
            //Läs av det som står i textboxarna
            //Skapa en ny kund
            //Spara kunden  

            Customers.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text });
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Skriv ut alla kunder i listboxen
            listBox1.Items.Clear();

            foreach (Customer c in Customers)
            {
                listBox1.Items.Add(c.FirstName);
            }
        }
    }
}
