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
        public List<List<int>> processes = new List<List<int>>();
        public List<int> pages = new List<int>();
        public  List<int> primary = new List<int>();
        public List<int> secondary = new List<int>();
        public List<int> tlb = new List<int>();

        Thread localThread,
               globalThread;

        int processCount = 0,
            pageCount = 0,
            primaryMemorySize = 10,
            tlbSize = 15;

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

            localThread = new Thread(LocalNFUPageReplacement);
            globalThread = new Thread(GlobalNFUPageReplacement);
            ListBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void lstChanges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            int pagesAdded = Convert.ToInt32(nudPageCount.Value);
            string letter = "ABCDEFGHJKLMNOPQRSTUVWXYZ"; 

            processes.Add(new List<int>());

            for (int x = 0; x < pagesAdded; x++)
            {
                processes[processCount].Add(pageCount + x);
                pages.Add(0);

                if (primary.Count < primaryMemorySize)
                {
                    primary.Add(pageCount + x);
                    lstPhysical.Items.Add("Page " + (processCount + 1) + letter[x] + " (0)");
                }
                else
                {
                    secondary.Add(pageCount + x);
                    lstSecondary.Items.Add("Page " + (processCount + 1) + letter[x] + " (0)");
                }
            }

            processCount++;
            pageCount += pagesAdded;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                localThread.Suspend();
            }
            catch { }

            try
            {
                globalThread.Suspend();
            }
            catch { }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radLocal.Checked && processes.Count != 0)
                {
                    localThread.Start();
                }
            }
            catch { }

            try
            {
                if (radLocal.Checked && processes.Count != 0)
                {
                    localThread.Resume();
                }
            }
            catch { }

            try
            {
                if (radLocal.Checked && processes.Count != 0)
                {
                    globalThread.Resume();
                }
            }
            catch { }

            try
            {
                if (radGlobal.Checked && processes.Count != 0)
                {
                    globalThread.Start();
                }
            }
            catch { }
        }

        public void LocalNFUPageReplacement()
        {
            Random rdm = new Random();
            int counter = 0;
            while (true)
            {
                UpdateTLB();
                for (int x = 0; x < processes.Count; x++)
                {
                    UpdateTLB();

                    int index = counter % processes[x].Count;
                    int lowestCount = Int32.MaxValue,
                        lowestPage = Int32.MaxValue;

                    for (int y = 0; y < processes[x].Count; y++)
                    {
                        if (primary.Contains(processes[x][y]))
                        {
                            pages[processes[x][y]] += rdm.Next(2);

                            int primaryIndex = primary.IndexOf(processes[x][y]);
                            string primarytext = lstPhysical.Items[primaryIndex].ToString();
                            primarytext = primarytext.Remove(primarytext.IndexOf("(")) + "(" + pages[processes[x][y]] + ")";
                            lstPhysical.Items[primaryIndex] = primarytext;

                            if (pages[processes[x][y]] < lowestCount)
                            {
                                lowestCount = pages[processes[x][y]];
                                lowestPage = processes[x][y];
                            }
                        }

                        UpdateTLB();
                    }

                    if (secondary.Contains(processes[x][index]) && primary.Contains(lowestPage))
                    {
                        int indexPrimary = primary.IndexOf(lowestPage);
                        int indexSecondary = secondary.IndexOf(processes[x][index]);
                        int sleepTime;

                        string output = "";

                        if (tlb.Contains(processes[x][index]))
                        {
                            output = " from the TLB with ";
                            sleepTime = 50 + rdm.Next(150);
                        }
                        else
                        {
                            output = " from the secondary storage with ";
                            sleepTime = 300 + rdm.Next(700);
                        }

                        Thread.Sleep(sleepTime);

                        int temp = primary[indexPrimary];
                        primary[indexPrimary] = secondary[indexSecondary];
                        secondary[indexSecondary] = temp;

                        string currentPrimary = lstPhysical.Items[indexPrimary].ToString();
                        currentPrimary = currentPrimary.Remove(currentPrimary.IndexOf("("));
                        output = currentPrimary + output;

                        currentPrimary += "(" + pages[processes[x][index]] + ")";

                        string currentSecondary = lstSecondary.Items[indexSecondary].ToString();
                        currentSecondary = currentSecondary.Remove(currentSecondary.IndexOf("("));
                        output = output + currentSecondary + " to the primary storage.Time elapsed = " + sleepTime + " ms";

                        currentSecondary += "(" + pages[processes[x][index]] + ")";

                        lstPhysical.Items[indexPrimary] = currentSecondary;
                        lstSecondary.Items[indexSecondary] = currentPrimary;
                        lstChanges.Items.Add(output);
                        
                        Thread.Sleep(1000);
                    }                  
                }

                counter++;
            } 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            while (localThread.ThreadState == ThreadState.WaitSleepJoin)
            {
                try
                {
                    localThread.Abort();
                }
                catch { }
            }

            while (globalThread.ThreadState == ThreadState.WaitSleepJoin)
            {
                try
                {
                    globalThread.Abort();
                }
                catch { }
            }

            processes.Clear();
            pages.Clear();
            secondary.Clear();
            primary.Clear();
            tlb.Clear();

            processCount = 0;
            pageCount = 0;

            lstChanges.Items.Clear();
            lstPhysical.Items.Clear();
            lstSecondary.Items.Clear();
            lstTLB.Items.Clear();
        }

        public void GlobalNFUPageReplacement()
        {
            Random rdm = new Random();
            int counter = 0;
            while (true)
            {
                for (int x = 0; x < processes.Count; x++)
                {
                    int index = counter % processes[x].Count;
                    int lowestCount = Int32.MaxValue,
                        lowestPage = Int32.MaxValue;

                    for (int z = 0; z < processes.Count; z++)
                    {
                        for (int y = 0; y < processes[z].Count; y++)
                        {
                            if (primary.Contains(processes[z][y]))
                            {
                                pages[processes[z][y]] += rdm.Next(2);

                                int primaryIndex = primary.IndexOf(processes[z][y]);
                                string primarytext = lstPhysical.Items[primaryIndex].ToString();
                                primarytext = primarytext.Remove(primarytext.IndexOf("(")) + "(" + pages[processes[z][y]] + ")";
                                lstPhysical.Items[primaryIndex] = primarytext;

                                if (pages[processes[z][y]] < lowestCount)
                                {
                                    lowestCount = pages[processes[z][y]];
                                    lowestPage = processes[z][y];
                                }
                            }
                        }
                    }

                    UpdateTLB();

                    if (secondary.Contains(processes[x][index]) && primary.Contains(lowestPage))
                    {
                        int indexPrimary = primary.IndexOf(lowestPage);
                        int indexSecondary = secondary.IndexOf(processes[x][index]);
                        int sleepTime;

                        string output = "";

                        if (tlb.Contains(processes[x][index]))
                        {
                            output = " from the TLB with ";
                            sleepTime = rdm.Next(200);
                        }
                        else
                        {
                            output = " from the secondary storage with ";
                            sleepTime = 200 + rdm.Next(800);
                        }

                        Thread.Sleep(sleepTime);

                        int temp = primary[indexPrimary];
                        primary[indexPrimary] = secondary[indexSecondary];
                        secondary[indexSecondary] = temp;

                        string currentPrimary = lstPhysical.Items[indexPrimary].ToString();
                        currentPrimary = currentPrimary.Remove(currentPrimary.IndexOf("("));
                        output = currentPrimary + output;

                        currentPrimary += "(" + pages[processes[x][index]] + ")";

                        string currentSecondary = lstSecondary.Items[indexSecondary].ToString();
                        currentSecondary = currentSecondary.Remove(currentSecondary.IndexOf("("));
                        output = output + currentSecondary + " to the primary storage. Time elapsed = " + sleepTime + " ms";

                        currentSecondary += "(" + pages[processes[x][index]] + ")";

                        lstPhysical.Items[indexPrimary] = currentSecondary;
                        lstSecondary.Items[indexSecondary] = currentPrimary;
                        lstChanges.Items.Add(output);

                        Thread.Sleep(1000);
                    }
                }

                counter++;
            }
        }

        public void UpdateTLB()
        {
            List<int> tempList = new List<int>();
            tempList.AddRange(pages);

            string letters = "ABCDEFGH";
            lstTLB.Items.Clear();

            for (int x = 0; x < tlbSize && x < tempList.Count; x++)
            {
                int max = -1,
                    maxX = -1,
                    maxY = -1;

                for (int y = 0; y < processes.Count; y++)
                {
                    for (int z = 0; z < processes[y].Count; z++)
                    {
                        if (tempList[processes[y][z]] > max)
                        {
                            max = tempList[processes[y][z]];
                            maxX = y;
                            maxY = z;
                        }                            
                    }
                }

                try
                {
                    lstTLB.Items.Add("Page " + (maxX + 1) + letters[maxY] + " (" + max + ")");
                    tlb.Add(processes[maxX][maxY]);
                    tempList[processes[maxX][maxY]] = -1;
                }
                catch { }                
            }
        }

        private void cbxPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
