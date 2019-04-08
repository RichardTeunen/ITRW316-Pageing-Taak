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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pages currently in Physical memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pages currently in secondary storage";
            // 
            // lsbPhysical
            // 
            this.lsbPhysical.FormattingEnabled = true;
            this.lsbPhysical.Location = new System.Drawing.Point(49, 46);
            this.lsbPhysical.Name = "lsbPhysical";
            this.lsbPhysical.Size = new System.Drawing.Size(214, 238);
            this.lsbPhysical.TabIndex = 2;
            // 
            // lsbSecondary
            // 
            this.lsbSecondary.FormattingEnabled = true;
            this.lsbSecondary.Location = new System.Drawing.Point(350, 46);
            this.lsbSecondary.Name = "lsbSecondary";
            this.lsbSecondary.Size = new System.Drawing.Size(214, 238);
            this.lsbSecondary.TabIndex = 3;
            // 
            // lsbTLB
            // 
            this.lsbTLB.FormattingEnabled = true;
            this.lsbTLB.Location = new System.Drawing.Point(203, 319);
            this.lsbTLB.Name = "lsbTLB";
            this.lsbTLB.Size = new System.Drawing.Size(214, 238);
            this.lsbTLB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pages currently in the TLB\r\n\r\n";
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(600, 46);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(124, 37);
            this.btnLocal.TabIndex = 6;
            this.btnLocal.Text = "Perform local Page Swap";
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // btnGlobal
            // 
            this.btnGlobal.Location = new System.Drawing.Point(600, 107);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(124, 35);
            this.btnGlobal.TabIndex = 7;
            this.btnGlobal.Text = "Perform Global Page Swap";
            this.btnGlobal.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(600, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear pages in TLB";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gpbStats
            // 
            this.gpbStats.Location = new System.Drawing.Point(468, 307);
            this.gpbStats.Name = "gpbStats";
            this.gpbStats.Size = new System.Drawing.Size(247, 250);
            this.gpbStats.TabIndex = 9;
            this.gpbStats.TabStop = false;
            this.gpbStats.Text = "Swapping statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 560);
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

