using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Критерии_доставки". При необходимости она может быть перемещена или удалена.
            this.критерии_доставкиTableAdapter.Fill(this.database1DataSet.Критерии_доставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.database1DataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.database1DataSet.Доставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Аксессуары_лодочные". При необходимости она может быть перемещена или удалена.
            this.аксессуары_лодочныеTableAdapter.Fill(this.database1DataSet.Аксессуары_лодочные);

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
