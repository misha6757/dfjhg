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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Партнеры". При необходимости она может быть перемещена или удалена.
            this.партнерыTableAdapter.Fill(this.database1DataSet.Партнеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.database1DataSet.Менеджеры);

        }
    }
}
