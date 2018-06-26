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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.database1DataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Счет". При необходимости она может быть перемещена или удалена.
            this.счетTableAdapter.Fill(this.database1DataSet.Счет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Партнеры". При необходимости она может быть перемещена или удалена.
            this.партнерыTableAdapter.Fill(this.database1DataSet.Партнеры);

        }
    }
}
