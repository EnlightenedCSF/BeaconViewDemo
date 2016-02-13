using System;

namespace TrilaterationDemo
{
    partial class MainForm
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
            this.picBoxTrilateration = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelTrilaterationMethods = new System.Windows.Forms.Panel();
            this.rBtnEPTA = new System.Windows.Forms.RadioButton();
            this.rBtnBoth = new System.Windows.Forms.RadioButton();
            this.rBtnPowerCenter = new System.Windows.Forms.RadioButton();
            this.rBtnRayTracing = new System.Windows.Forms.RadioButton();
            this.rBtnTrilateration = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBeacon3 = new System.Windows.Forms.Label();
            this.lblBeacon2 = new System.Windows.Forms.Label();
            this.lblBeacon1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrilateration)).BeginInit();
            this.panelTrilaterationMethods.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxTrilateration
            // 
            this.picBoxTrilateration.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBoxTrilateration.Location = new System.Drawing.Point(12, 48);
            this.picBoxTrilateration.Name = "picBoxTrilateration";
            this.picBoxTrilateration.Size = new System.Drawing.Size(665, 450);
            this.picBoxTrilateration.TabIndex = 0;
            this.picBoxTrilateration.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(552, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelTrilaterationMethods
            // 
            this.panelTrilaterationMethods.Controls.Add(this.rBtnEPTA);
            this.panelTrilaterationMethods.Controls.Add(this.rBtnBoth);
            this.panelTrilaterationMethods.Controls.Add(this.rBtnPowerCenter);
            this.panelTrilaterationMethods.Controls.Add(this.rBtnRayTracing);
            this.panelTrilaterationMethods.Controls.Add(this.rBtnTrilateration);
            this.panelTrilaterationMethods.Location = new System.Drawing.Point(13, 1);
            this.panelTrilaterationMethods.Name = "panelTrilaterationMethods";
            this.panelTrilaterationMethods.Size = new System.Drawing.Size(533, 41);
            this.panelTrilaterationMethods.TabIndex = 2;
            // 
            // rBtnEPTA
            // 
            this.rBtnEPTA.AutoSize = true;
            this.rBtnEPTA.Location = new System.Drawing.Point(358, 11);
            this.rBtnEPTA.Name = "rBtnEPTA";
            this.rBtnEPTA.Size = new System.Drawing.Size(53, 17);
            this.rBtnEPTA.TabIndex = 3;
            this.rBtnEPTA.TabStop = true;
            this.rBtnEPTA.Text = "EPTA";
            this.rBtnEPTA.UseVisualStyleBackColor = true;
            this.rBtnEPTA.CheckedChanged += new System.EventHandler(this.rBtnMethod_CheckedChanged);
            // 
            // rBtnBoth
            // 
            this.rBtnBoth.AutoSize = true;
            this.rBtnBoth.Location = new System.Drawing.Point(457, 11);
            this.rBtnBoth.Name = "rBtnBoth";
            this.rBtnBoth.Size = new System.Drawing.Size(47, 17);
            this.rBtnBoth.TabIndex = 4;
            this.rBtnBoth.TabStop = true;
            this.rBtnBoth.Text = "Both";
            this.rBtnBoth.UseVisualStyleBackColor = true;
            this.rBtnBoth.CheckedChanged += new System.EventHandler(this.rBtnBoth_CheckedChanged);
            // 
            // rBtnPowerCenter
            // 
            this.rBtnPowerCenter.AutoSize = true;
            this.rBtnPowerCenter.Location = new System.Drawing.Point(238, 11);
            this.rBtnPowerCenter.Name = "rBtnPowerCenter";
            this.rBtnPowerCenter.Size = new System.Drawing.Size(89, 17);
            this.rBtnPowerCenter.TabIndex = 2;
            this.rBtnPowerCenter.Text = "Power Center";
            this.rBtnPowerCenter.UseVisualStyleBackColor = true;
            this.rBtnPowerCenter.CheckedChanged += new System.EventHandler(this.rBtnMethod_CheckedChanged);
            // 
            // rBtnRayTracing
            // 
            this.rBtnRayTracing.AutoSize = true;
            this.rBtnRayTracing.Location = new System.Drawing.Point(121, 11);
            this.rBtnRayTracing.Name = "rBtnRayTracing";
            this.rBtnRayTracing.Size = new System.Drawing.Size(83, 17);
            this.rBtnRayTracing.TabIndex = 1;
            this.rBtnRayTracing.Text = "Ray Tracing";
            this.rBtnRayTracing.UseVisualStyleBackColor = true;
            this.rBtnRayTracing.CheckedChanged += new System.EventHandler(this.rBtnMethod_CheckedChanged);
            // 
            // rBtnTrilateration
            // 
            this.rBtnTrilateration.AutoSize = true;
            this.rBtnTrilateration.Checked = true;
            this.rBtnTrilateration.Location = new System.Drawing.Point(3, 11);
            this.rBtnTrilateration.Name = "rBtnTrilateration";
            this.rBtnTrilateration.Size = new System.Drawing.Size(109, 17);
            this.rBtnTrilateration.TabIndex = 0;
            this.rBtnTrilateration.TabStop = true;
            this.rBtnTrilateration.Text = "Circle Intersection";
            this.rBtnTrilateration.UseVisualStyleBackColor = true;
            this.rBtnTrilateration.CheckedChanged += new System.EventHandler(this.rBtnMethod_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblBeacon3);
            this.panel1.Controls.Add(this.lblBeacon2);
            this.panel1.Controls.Add(this.lblBeacon1);
            this.panel1.Location = new System.Drawing.Point(683, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 486);
            this.panel1.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(18, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // lblBeacon3
            // 
            this.lblBeacon3.AutoSize = true;
            this.lblBeacon3.Location = new System.Drawing.Point(18, 87);
            this.lblBeacon3.Name = "lblBeacon3";
            this.lblBeacon3.Size = new System.Drawing.Size(35, 13);
            this.lblBeacon3.TabIndex = 2;
            this.lblBeacon3.Text = "label3";
            // 
            // lblBeacon2
            // 
            this.lblBeacon2.AutoSize = true;
            this.lblBeacon2.Location = new System.Drawing.Point(18, 51);
            this.lblBeacon2.Name = "lblBeacon2";
            this.lblBeacon2.Size = new System.Drawing.Size(35, 13);
            this.lblBeacon2.TabIndex = 1;
            this.lblBeacon2.Text = "label2";
            // 
            // lblBeacon1
            // 
            this.lblBeacon1.AutoSize = true;
            this.lblBeacon1.Location = new System.Drawing.Point(18, 17);
            this.lblBeacon1.Name = "lblBeacon1";
            this.lblBeacon1.Size = new System.Drawing.Size(35, 13);
            this.lblBeacon1.TabIndex = 0;
            this.lblBeacon1.Text = "label1";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(3, 141);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(273, 342);
            this.log.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTrilaterationMethods);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picBoxTrilateration);
            this.Name = "MainForm";
            this.Text = "Trilateration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrilateration)).EndInit();
            this.panelTrilaterationMethods.ResumeLayout(false);
            this.panelTrilaterationMethods.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTrilateration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelTrilaterationMethods;
        private System.Windows.Forms.RadioButton rBtnPowerCenter;
        private System.Windows.Forms.RadioButton rBtnRayTracing;
        private System.Windows.Forms.RadioButton rBtnTrilateration;
        private System.Windows.Forms.RadioButton rBtnBoth;
        private System.Windows.Forms.RadioButton rBtnEPTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBeacon3;
        private System.Windows.Forms.Label lblBeacon2;
        private System.Windows.Forms.Label lblBeacon1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox log;
    }
}

