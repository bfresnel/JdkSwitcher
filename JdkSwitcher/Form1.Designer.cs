﻿namespace JdkSwitcher
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbJdk = new System.Windows.Forms.TextBox();
            this.lblJdk = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbJdk
            // 
            this.txtbJdk.Location = new System.Drawing.Point(15, 29);
            this.txtbJdk.Name = "txtbJdk";
            this.txtbJdk.Size = new System.Drawing.Size(229, 22);
            this.txtbJdk.TabIndex = 0;
            // 
            // label1
            // 
            this.lblJdk.AutoSize = true;
            this.lblJdk.Location = new System.Drawing.Point(12, 9);
            this.lblJdk.Name = "label1";
            this.lblJdk.Size = new System.Drawing.Size(42, 17);
            this.lblJdk.TabIndex = 1;
            this.lblJdk.Text = "JDK :";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(250, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Parcourir...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(15, 60);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(331, 61);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Appliquer";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 144);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblJdk);
            this.Controls.Add(this.txtbJdk);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JdkSwitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbJdk;
        private System.Windows.Forms.Label lblJdk;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValidate;
    }
}

