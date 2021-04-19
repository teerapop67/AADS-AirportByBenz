﻿
namespace AADS.Views.ShowCategory
{
    partial class Marker
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
            this.btnShowAiport = new System.Windows.Forms.Button();
            this.btnShowCity = new System.Windows.Forms.Button();
            this.btnShowFixedPoint = new System.Windows.Forms.Button();
            this.panelShowDetail = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowWeaponBattery = new System.Windows.Forms.Button();
            this.btnShowVitalAsset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnShowFireUnit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAiport
            // 
            this.btnShowAiport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAiport.Location = new System.Drawing.Point(16, 16);
            this.btnShowAiport.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAiport.Name = "btnShowAiport";
            this.btnShowAiport.Size = new System.Drawing.Size(121, 72);
            this.btnShowAiport.TabIndex = 0;
            this.btnShowAiport.Text = "Airport";
            this.btnShowAiport.UseVisualStyleBackColor = true;
            this.btnShowAiport.Click += new System.EventHandler(this.btnShowAiport_Click);
            // 
            // btnShowCity
            // 
            this.btnShowCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCity.Location = new System.Drawing.Point(133, 16);
            this.btnShowCity.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCity.Name = "btnShowCity";
            this.btnShowCity.Size = new System.Drawing.Size(121, 72);
            this.btnShowCity.TabIndex = 1;
            this.btnShowCity.Text = "City";
            this.btnShowCity.UseVisualStyleBackColor = true;
            this.btnShowCity.Click += new System.EventHandler(this.btnShowCity_Click);
            // 
            // btnShowFixedPoint
            // 
            this.btnShowFixedPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFixedPoint.Location = new System.Drawing.Point(251, 16);
            this.btnShowFixedPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFixedPoint.Name = "btnShowFixedPoint";
            this.btnShowFixedPoint.Size = new System.Drawing.Size(121, 72);
            this.btnShowFixedPoint.TabIndex = 2;
            this.btnShowFixedPoint.Text = "Fixed Point";
            this.btnShowFixedPoint.UseVisualStyleBackColor = true;
            this.btnShowFixedPoint.Click += new System.EventHandler(this.btnShowFixedPoint_Click);
            // 
            // panelShowDetail
            // 
            this.panelShowDetail.BackColor = System.Drawing.Color.Maroon;
            this.panelShowDetail.Location = new System.Drawing.Point(0, 254);
            this.panelShowDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelShowDetail.Name = "panelShowDetail";
            this.panelShowDetail.Size = new System.Drawing.Size(387, 685);
            this.panelShowDetail.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowWeaponBattery);
            this.panel2.Controls.Add(this.btnShowVitalAsset);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnShowFireUnit);
            this.panel2.Controls.Add(this.btnShowFixedPoint);
            this.panel2.Controls.Add(this.btnShowAiport);
            this.panel2.Controls.Add(this.btnShowCity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 251);
            this.panel2.TabIndex = 4;
            // 
            // btnShowWeaponBattery
            // 
            this.btnShowWeaponBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWeaponBattery.Location = new System.Drawing.Point(16, 164);
            this.btnShowWeaponBattery.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowWeaponBattery.Name = "btnShowWeaponBattery";
            this.btnShowWeaponBattery.Size = new System.Drawing.Size(121, 72);
            this.btnShowWeaponBattery.TabIndex = 6;
            this.btnShowWeaponBattery.Text = "Weapon Battery";
            this.btnShowWeaponBattery.UseVisualStyleBackColor = true;
            this.btnShowWeaponBattery.Click += new System.EventHandler(this.btnShowWeaponBattery_Click);
            // 
            // btnShowVitalAsset
            // 
            this.btnShowVitalAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowVitalAsset.Location = new System.Drawing.Point(251, 90);
            this.btnShowVitalAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowVitalAsset.Name = "btnShowVitalAsset";
            this.btnShowVitalAsset.Size = new System.Drawing.Size(121, 72);
            this.btnShowVitalAsset.TabIndex = 5;
            this.btnShowVitalAsset.Text = "Vital Asset";
            this.btnShowVitalAsset.UseVisualStyleBackColor = true;
            this.btnShowVitalAsset.Click += new System.EventHandler(this.btnShowVitalAsset_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(136, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 72);
            this.button3.TabIndex = 4;
            this.button3.Text = "LandMark";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShowFireUnit
            // 
            this.btnShowFireUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFireUnit.Location = new System.Drawing.Point(16, 90);
            this.btnShowFireUnit.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFireUnit.Name = "btnShowFireUnit";
            this.btnShowFireUnit.Size = new System.Drawing.Size(121, 72);
            this.btnShowFireUnit.TabIndex = 3;
            this.btnShowFireUnit.Text = "Fire Unit";
            this.btnShowFireUnit.UseVisualStyleBackColor = true;
            this.btnShowFireUnit.Click += new System.EventHandler(this.btnShowFireUnit_Click);
            // 
            // Marker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShowDetail);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Marker";
            this.Size = new System.Drawing.Size(387, 942);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAiport;
        private System.Windows.Forms.Button btnShowCity;
        private System.Windows.Forms.Button btnShowFixedPoint;
        private System.Windows.Forms.Panel panelShowDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowVitalAsset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShowFireUnit;
        private System.Windows.Forms.Button btnShowWeaponBattery;
    }
}
