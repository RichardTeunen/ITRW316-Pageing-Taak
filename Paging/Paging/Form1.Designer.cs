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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbPhysical = new System.Windows.Forms.ListBox();
            this.lsbSecondary = new System.Windows.Forms.ListBox();
            this.lsbTLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpbStats = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physical Memory Pages ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(258, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secondary Storage Pages";
            // 
            // lsbPhysical
            // 
            this.lsbPhysical.FormattingEnabled = true;
            this.lsbPhysical.Location = new System.Drawing.Point(13, 81);
            this.lsbPhysical.Name = "lsbPhysical";
            this.lsbPhysical.Size = new System.Drawing.Size(214, 238);
            this.lsbPhysical.TabIndex = 2;
            // 
            // lsbSecondary
            // 
            this.lsbSecondary.FormattingEnabled = true;
            this.lsbSecondary.Location = new System.Drawing.Point(233, 81);
            this.lsbSecondary.Name = "lsbSecondary";
            this.lsbSecondary.Size = new System.Drawing.Size(214, 238);
            this.lsbSecondary.TabIndex = 3;
            // 
            // lsbTLB
            // 
            this.lsbTLB.FormattingEnabled = true;
            this.lsbTLB.Location = new System.Drawing.Point(453, 81);
            this.lsbTLB.Name = "lsbTLB";
            this.lsbTLB.Size = new System.Drawing.Size(214, 238);
            this.lsbTLB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(483, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pages Currently in TLB\r\n\r\n";
            // 
            // btnLocal
            // 
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLocal.Location = new System.Drawing.Point(14, 12);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(213, 37);
            this.btnLocal.TabIndex = 6;
            this.btnLocal.Text = "Perform local Page Swap";
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // btnGlobal
            // 
            this.btnGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGlobal.Location = new System.Drawing.Point(233, 14);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(214, 35);
            this.btnGlobal.TabIndex = 7;
            this.btnGlobal.Text = "Perform Global Page Swap";
            this.btnGlobal.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(453, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(214, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear pages in TLB";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gpbStats
            // 
            this.gpbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gpbStats.Location = new System.Drawing.Point(14, 325);
            this.gpbStats.Name = "gpbStats";
            this.gpbStats.Size = new System.Drawing.Size(653, 206);
            this.gpbStats.TabIndex = 9;
            this.gpbStats.TabStop = false;
            this.gpbStats.Text = "Swapping statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 548);
            this.Controls.Add(this.gpbStats);
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
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbPhysical;
        private System.Windows.Forms.ListBox lsbSecondary;
        private System.Windows.Forms.ListBox lsbTLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpbStats;
    }
}

