using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paging
{
    public partial class Form1 : Form
    {
        List<int[]> primary = new List<int[]>();
        List<int[]> secondary = new List<int[]>();
        List<int[]> tlb = new List<int[]>();

        int pageCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x <= 10; x++)
            {
                secondary.Add(new int[] { x, 0 });
                lstSecondary.Items.Add("Page " + x);
                pageCount++;
            }           
        }

        private void lstChanges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            secondary.Add(new int[] { pageCount++, 0 });
            lstSecondary.Items.Add("Page " + pageCount);
        }
    }
}
