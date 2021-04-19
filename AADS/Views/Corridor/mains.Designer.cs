
namespace AADS.Views.Corridor
{
    partial class mains
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSide1 = new System.Windows.Forms.Button();
            this.btnSide2 = new System.Windows.Forms.Button();
            this.listPoint = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corridor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(233, 70);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 3;
            this.cmbType.Text = "Select Type";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnSide1
            // 
            this.btnSide1.Location = new System.Drawing.Point(56, 128);
            this.btnSide1.Name = "btnSide1";
            this.btnSide1.Size = new System.Drawing.Size(75, 23);
            this.btnSide1.TabIndex = 4;
            this.btnSide1.Text = "Side1";
            this.btnSide1.UseVisualStyleBackColor = true;
            this.btnSide1.Click += new System.EventHandler(this.btnSide1_Click);
            // 
            // btnSide2
            // 
            this.btnSide2.Location = new System.Drawing.Point(257, 128);
            this.btnSide2.Name = "btnSide2";
            this.btnSide2.Size = new System.Drawing.Size(75, 23);
            this.btnSide2.TabIndex = 5;
            this.btnSide2.Text = "Side2";
            this.btnSide2.UseVisualStyleBackColor = true;
            this.btnSide2.Click += new System.EventHandler(this.btnSide2_Click);
            // 
            // listPoint
            // 
            this.listPoint.BackColor = System.Drawing.Color.Maroon;
            this.listPoint.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPoint.FormattingEnabled = true;
            this.listPoint.ItemHeight = 16;
            this.listPoint.Location = new System.Drawing.Point(0, 184);
            this.listPoint.Name = "listPoint";
            this.listPoint.Size = new System.Drawing.Size(435, 516);
            this.listPoint.TabIndex = 6;
            // 
            // mains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listPoint);
            this.Controls.Add(this.btnSide2);
            this.Controls.Add(this.btnSide1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mains";
            this.Size = new System.Drawing.Size(435, 670);
            this.Load += new System.EventHandler(this.mains_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSide1;
        private System.Windows.Forms.Button btnSide2;
        private System.Windows.Forms.ListBox listPoint;
    }
}
