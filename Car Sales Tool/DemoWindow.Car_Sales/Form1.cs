using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Sales.Businesss;
using Car_Sales.DAL;
namespace DemoWindow.Car_Sales
{
    public partial class Form1 : Form
    {
        Repostory Respo = new Repostory();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add";
            button2.Text = "Show";
            label1.Text = "Brand";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car NewCar = new Car() { Brand = textBox1.Text };
            Respo.Save(NewCar);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Car> TempList = Respo.GetList();
            listBox1.Items.Clear();
            foreach (Car x in TempList)
            {
                listBox1.Items.Add(x.Brand);
                
            }
            
        }
    }
}
