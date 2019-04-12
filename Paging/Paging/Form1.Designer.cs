namespace Paging
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstChanges = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lsbTLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSecondary = new System.Windows.Forms.ListBox();
            this.lstPhysical = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.gbxAddProcess = new System.Windows.Forms.GroupBox();
            this.nudPageCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGlobal = new System.Windows.Forms.RadioButton();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbxAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstChanges
            // 
            this.lstChanges.FormattingEnabled = true;
            this.lstChanges.Location = new System.Drawing.Point(15, 320);
            this.lstChanges.Name = "lstChanges";
            this.lstChanges.Size = new System.Drawing.Size(690, 134);
            this.lstChanges.TabIndex = 33;
            this.lstChanges.SelectedIndexChanged += new System.EventHandler(this.lstChanges_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(427, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 28);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lsbTLB
            // 
            this.lsbTLB.FormattingEnabled = true;
            this.lsbTLB.Location = new System.Drawing.Point(491, 133);
            this.lsbTLB.Name = "lsbTLB";
            this.lsbTLB.Size = new System.Drawing.Size(214, 160);
            this.lsbTLB.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(490, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pages currently in the TLB\r\n\r\n";
            // 
            // lstSecondary
            // 
            this.lstSecondary.FormattingEnabled = true;
            this.lstSecondary.Location = new System.Drawing.Point(251, 133);
            this.lstSecondary.Name = "lstSecondary";
            this.lstSecondary.Size = new System.Drawing.Size(214, 160);
            this.lstSecondary.TabIndex = 26;
            // 
            // lstPhysical
            // 
            this.lstPhysical.FormattingEnabled = true;
            this.lstPhysical.Location = new System.Drawing.Point(15, 133);
            this.lstPhysical.Name = "lstPhysical";
            this.lstPhysical.Size = new System.Drawing.Size(214, 160);
            this.lstPhysical.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(248, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Secondary Storage Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Physical Memory Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Changes";
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(22, 60);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(85, 21);
            this.btnAddPage.TabIndex = 32;
            this.btnAddPage.Text = "Add a process";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // gbxAddProcess
            // 
            this.gbxAddProcess.Controls.Add(this.nudPageCount);
            this.gbxAddProcess.Controls.Add(this.label5);
            this.gbxAddProcess.Controls.Add(this.btnAddPage);
            this.gbxAddProcess.Location = new System.Drawing.Point(127, 9);
            this.gbxAddProcess.Name = "gbxAddProcess";
            this.gbxAddProcess.Size = new System.Drawing.Size(137, 93);
            this.gbxAddProcess.TabIndex = 38;
            this.gbxAddProcess.TabStop = false;
            this.gbxAddProcess.Text = "Add Process and Pages";
            // 
            // nudPageCount
            // 
            this.nudPageCount.Location = new System.Drawing.Point(23, 34);
            this.nudPageCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageCount.Name = "nudPageCount";
            this.nudPageCount.Size = new System.Drawing.Size(84, 20);
            this.nudPageCount.TabIndex = 39;
            this.nudPageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Number of pages";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGlobal);
            this.groupBox1.Controls.Add(this.radLocal);
            this.groupBox1.Location = new System.Drawing.Point(283, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 92);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swapping Type";
            // 
            // radGlobal
            // 
            this.radGlobal.AutoSize = true;
            this.radGlobal.Location = new System.Drawing.Point(25, 56);
            this.radGlobal.Name = "radGlobal";
            this.radGlobal.Size = new System.Drawing.Size(55, 17);
            this.radGlobal.TabIndex = 1;
            this.radGlobal.TabStop = true;
            this.radGlobal.Text = "Global";
            this.radGlobal.UseVisualStyleBackColor = true;
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(25, 33);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(51, 17);
            this.radLocal.TabIndex = 0;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "Local";
            this.radLocal.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(427, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 28);
            this.btnStop.TabIndex = 40;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(427, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 28);
            this.btnStart.TabIndex = 41;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(717, 472);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAddProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstChanges);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lsbTLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSecondary);
            this.Controls.Add(this.lstPhysical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Paging with TLB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAddProcess.ResumeLayout(false);
            this.gbxAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChanges;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lsbTLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSecondary;
        private System.Windows.Forms.ListBox lstPhysical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.GroupBox gbxAddProcess;
        private System.Windows.Forms.NumericUpDown nudPageCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGlobal;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

