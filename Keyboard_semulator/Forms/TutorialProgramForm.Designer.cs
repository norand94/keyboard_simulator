﻿namespace Keyboard_semulator.Forms
{
    partial class TutorialProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialProgramForm));
            this.tutorialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tutorialTextBox
            // 
            this.tutorialTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tutorialTextBox.Location = new System.Drawing.Point(12, 12);
            this.tutorialTextBox.Multiline = true;
            this.tutorialTextBox.Name = "tutorialTextBox";
            this.tutorialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tutorialTextBox.Size = new System.Drawing.Size(570, 317);
            this.tutorialTextBox.TabIndex = 0;
            this.tutorialTextBox.TextChanged += new System.EventHandler(this.tutorialTextBox_TextChanged);
            // 
            // TutorialProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 475);
            this.Controls.Add(this.tutorialTextBox);
            this.Name = "TutorialProgramForm";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.AboutProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tutorialTextBox;
    }
}