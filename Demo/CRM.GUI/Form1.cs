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
        public Form1()
        {
            //Constructor .ctor
            //Metoden nedanför skapar UI som vi drag and droppat
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Här hamnar vi när användaren klickar på knappen
            //Läs av det som står i textboxarna
            //Skapa en ny kund
            //Spara kunden  

            
            ArrayList Customers = new ArrayList();
            Customers.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text });
        }
    }
}
