using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prodAdapter.Fill(prodDataSet1);
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            prodAdapter.Update(prodDataSet1, "prod");
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            prodDataSet1.prod.RejectChanges();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
        }

        private void Btn_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
