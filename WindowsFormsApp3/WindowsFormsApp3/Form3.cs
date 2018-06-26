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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.database1DataSet.Доставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.database1DataSet.Менеджеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Лодки". При необходимости она может быть перемещена или удалена.
            this.лодкиTableAdapter.Fill(this.database1DataSet.Лодки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);

        }
    }
}
