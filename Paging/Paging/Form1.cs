using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paging
{
    public partial class Form1 : Form
    {
        List<List<int[]>> processes = new List<List<int[]>>();
        List<int> primary = new List<int>();
        List<int> secondary = new List<int>();
        List<int> tlb = new List<int>();

        int processCount = 0,
            pageCount = 0,
            primaryMemorySize = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radLocal.Checked = true;
            /*
            for (int x = 1; x <= 3; x++)
            {
                secondary.Add(new object[] { x, 0 });
                lstSecondary.Items.Add("Page " + x);
                pageCount++;
            } 
            */
        }

        private void lstChanges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            int pagesAdded = Convert.ToInt32(nudPageCount.Value);
            string letter = "ABCDEFGH"; 

            processes.Add(new List<int[]>());

            for (int x = 0; x < pagesAdded; x++)
            {
                processes[processCount].Add(new int[] { pageCount + x, 0 });

                if (primary.Count < primaryMemorySize)
                {
                    primary.Add(pageCount + x);
                    lstPhysical.Items.Add("Page " + (processCount + 1) + letter[x]);
                }
                else
                {
                    secondary.Add(pageCount + x);
                    lstSecondary.Items.Add("Page " + (processCount + 1) + letter[x]);
                }
            }

            processCount++;
            pageCount += pagesAdded;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radLocal.Checked)
            {
                
            }
        }

        public void LocalClockPageReplacement()
        {
            /*
            while (true)
            {
                int counter = 0;

                for (int x = 0; x < processes.Count; x++)
                {
                    int index = counter % processes[x].Count;

                    //if (primary.Le)

                }

                Thread.Sleep(1000);
            } 
            */
        }

        private void cbxPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
