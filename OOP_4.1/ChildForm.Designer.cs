
namespace OOP_4._1
{
    partial class viewController
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
            this.txtBxA = new System.Windows.Forms.TextBox();
            this.txtBxB = new System.Windows.Forms.TextBox();
            this.txtBxC = new System.Windows.Forms.TextBox();
            this.nmrcUpDownA = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDownB = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDownC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "A         <=         B      <=      C\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxA
            // 
            this.txtBxA.Location = new System.Drawing.Point(77, 131);
            this.txtBxA.Name = "txtBxA";
            this.txtBxA.Size = new System.Drawing.Size(172, 23);
            this.txtBxA.TabIndex = 1;
            this.txtBxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxA_KeyDown);
            // 
            // txtBxB
            // 
            this.txtBxB.Location = new System.Drawing.Point(321, 131);
            this.txtBxB.Name = "txtBxB";
            this.txtBxB.Size = new System.Drawing.Size(172, 23);
            this.txtBxB.TabIndex = 2;
            this.txtBxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxB_KeyDown);
            // 
            // txtBxC
            // 
            this.txtBxC.Location = new System.Drawing.Point(547, 131);
            this.txtBxC.Name = "txtBxC";
            this.txtBxC.Size = new System.Drawing.Size(172, 23);
            this.txtBxC.TabIndex = 3;
            this.txtBxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxC_KeyDown);
            // 
            // nmrcUpDownA
            // 
            this.nmrcUpDownA.Location = new System.Drawing.Point(77, 160);
            this.nmrcUpDownA.Name = "nmrcUpDownA";
            this.nmrcUpDownA.Size = new System.Drawing.Size(172, 23);
            this.nmrcUpDownA.TabIndex = 4;
            this.nmrcUpDownA.ValueChanged += new System.EventHandler(this.nmrcUpDownA_ValueChanged);
            // 
            // nmrcUpDownB
            // 
            this.nmrcUpDownB.Location = new System.Drawing.Point(321, 160);
            this.nmrcUpDownB.Name = "nmrcUpDownB";
            this.nmrcUpDownB.Size = new System.Drawing.Size(172, 23);
            this.nmrcUpDownB.TabIndex = 5;
            this.nmrcUpDownB.ValueChanged += new System.EventHandler(this.nmrcUpDownB_ValueChanged);
            // 
            // nmrcUpDownC
            // 
            this.nmrcUpDownC.Location = new System.Drawing.Point(547, 160);
            this.nmrcUpDownC.Name = "nmrcUpDownC";
            this.nmrcUpDownC.Size = new System.Drawing.Size(172, 23);
            this.nmrcUpDownC.TabIndex = 6;
            this.nmrcUpDownC.ValueChanged += new System.EventHandler(this.nmrcUpDownC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(77, 189);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(172, 45);
            this.trackBarA.TabIndex = 7;
            this.trackBarA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarA_MouseUp);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(321, 189);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(172, 45);
            this.trackBarB.TabIndex = 8;
            this.trackBarB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarB_MouseUp);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(547, 189);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(172, 45);
            this.trackBarC.TabIndex = 9;
            this.trackBarC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarC_MouseUp);
            // 
            // viewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.nmrcUpDownC);
            this.Controls.Add(this.nmrcUpDownB);
            this.Controls.Add(this.nmrcUpDownA);
            this.Controls.Add(this.txtBxC);
            this.Controls.Add(this.txtBxB);
            this.Controls.Add(this.txtBxA);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "viewController";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ChildForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewController_FormClosed);
            this.Load += new System.EventHandler(this.viewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxA;
        private System.Windows.Forms.TextBox txtBxB;
        private System.Windows.Forms.TextBox txtBxC;
        private System.Windows.Forms.NumericUpDown nmrcUpDownA;
        private System.Windows.Forms.NumericUpDown nmrcUpDownB;
        private System.Windows.Forms.NumericUpDown nmrcUpDownC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
    }
}