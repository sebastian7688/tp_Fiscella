using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
//    Crear una estructura con:
//4 botones
//2 listas con 10 nombres en cada una(Ya tienen que estar ingresados en el diseño)

//1. Cuando se presiona en el primer boton ordenar los listados
//2. Con el segundo boton borran todos los nombres que tengan hasta 5 letras
//3. Con el tercer boton intercambiar los nombres que tengan hasta 5 letras
//4. Intercambiar el primer y ultimo elemento de ambas listas.Tienen que quedar en el primer lugar y en el ultimo
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox2.Sorted=true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text.Length<5)
            {
                listBox1.Items.Remove(listBox1.Items);
                listBox2.Items.Remove(listBox2.Items);  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text.Length < 5)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.Remove(listBox2.Text);
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Items);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Items[listBox1.Items.Count-1]);
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);

            listBox1.Items.Add(listBox2.Items[listBox2.Items.Count - 2]);
            listBox2.Items.RemoveAt(listBox2.Items.Count - 2);

            listBox1.Items.Insert(0, listBox2.Items[0]);
            listBox2.Items.RemoveAt(0);

            listBox2.Items.Insert(0, listBox1.Items[1]);
            listBox1.Items.RemoveAt(1);


        }
    }
}
