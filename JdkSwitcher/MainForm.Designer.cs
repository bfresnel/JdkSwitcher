namespace JdkSwitcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtbJdk = new System.Windows.Forms.TextBox();
            this.lblJdk = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtbJdk
            // 
            this.txtbJdk.Location = new System.Drawing.Point(15, 29);
            this.txtbJdk.Name = "txtbJdk";
            this.txtbJdk.Size = new System.Drawing.Size(229, 22);
            this.txtbJdk.TabIndex = 0;
            // 
            // lblJdk
            // 
            this.lblJdk.AutoSize = true;
            this.lblJdk.Location = new System.Drawing.Point(12, 9);
            this.lblJdk.Name = "lblJdk";
            this.lblJdk.Size = new System.Drawing.Size(42, 17);
            this.lblJdk.TabIndex = 1;
            this.lblJdk.Text = "JDK :";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.Location = new System.Drawing.Point(250, 27);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(96, 27);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(15, 60);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(331, 61);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Apply";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Location = new System.Drawing.Point(12, 169);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(100, 17);
            this.lblConfiguration.TabIndex = 8;
            this.lblConfiguration.Text = "Configuration :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblConfiguration);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblJdk);
            this.Controls.Add(this.txtbJdk);
            this.Controls.Add(this.buttonBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "JdkSwitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbJdk;
        private System.Windows.Forms.Label lblJdk;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

