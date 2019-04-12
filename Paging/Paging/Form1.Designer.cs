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
            this.btnAddPage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.lsbTLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbSecondary = new System.Windows.Forms.ListBox();
            this.lsbPhysical = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstChanges
            // 
            this.lstChanges.FormattingEnabled = true;
            this.lstChanges.Location = new System.Drawing.Point(248, 15);
            this.lstChanges.Name = "lstChanges";
            this.lstChanges.Size = new System.Drawing.Size(454, 147);
            this.lstChanges.TabIndex = 33;
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(12, 24);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(214, 30);
            this.btnAddPage.TabIndex = 32;
            this.btnAddPage.Text = "Add Page to Secondary Storage";
            this.btnAddPage.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(214, 28);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear Pages in TLB";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnGlobal
            // 
            this.btnGlobal.Location = new System.Drawing.Point(12, 95);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(214, 28);
            this.btnGlobal.TabIndex = 30;
            this.btnGlobal.Text = "Perform Global Page Swap";
            this.btnGlobal.UseVisualStyleBackColor = true;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 60);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(214, 29);
            this.btnLocal.TabIndex = 29;
            this.btnLocal.Text = "Perform Local Page Swap";
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // lsbTLB
            // 
            this.lsbTLB.FormattingEnabled = true;
            this.lsbTLB.Location = new System.Drawing.Point(488, 189);
            this.lsbTLB.Name = "lsbTLB";
            this.lsbTLB.Size = new System.Drawing.Size(214, 238);
            this.lsbTLB.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(487, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pages currently in the TLB\r\n\r\n";
            // 
            // lsbSecondary
            // 
            this.lsbSecondary.FormattingEnabled = true;
            this.lsbSecondary.Items.AddRange(new object[] {
            "Page 1",
            "Page 2",
            "Page 3",
            "Page 4",
            "Page 5",
            "Page 6",
            "Page 7",
            "Page 8",
            "Page 9",
            "Page 10"});
            this.lsbSecondary.Location = new System.Drawing.Point(248, 189);
            this.lsbSecondary.Name = "lsbSecondary";
            this.lsbSecondary.Size = new System.Drawing.Size(214, 238);
            this.lsbSecondary.TabIndex = 26;
            // 
            // lsbPhysical
            // 
            this.lsbPhysical.FormattingEnabled = true;
            this.lsbPhysical.Location = new System.Drawing.Point(12, 189);
            this.lsbPhysical.Name = "lsbPhysical";
            this.lsbPhysical.Size = new System.Drawing.Size(214, 238);
            this.lsbPhysical.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(245, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Secondary Storage Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Physical Memory Pages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(717, 442);
            this.Controls.Add(this.lstChanges);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.lsbTLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbSecondary);
            this.Controls.Add(this.lsbPhysical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Paging with TLB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChanges;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.ListBox lsbTLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbSecondary;
        private System.Windows.Forms.ListBox lsbPhysical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

