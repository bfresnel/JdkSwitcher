using System;
using System.Windows.Forms;

namespace JdkSwitcher
{
    public partial class Form1 : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string JDK_VAR = "JAVA_HOME";
        private string jdk;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jdk = Environment.GetEnvironmentVariable(JDK_VAR, EnvironmentVariableTarget.User);
            txtbJdk.Text = jdk;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbJdk.Text = fbd.SelectedPath;
            }
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            PathUtility.UpdatingPathWithNewJdk(Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.User) + "\\bin", txtbJdk.Text + "\\bin");
            Environment.SetEnvironmentVariable("JAVA_HOME", txtbJdk.Text.Trim(), EnvironmentVariableTarget.User);
            btnValidate.Enabled = false;
            string message = "Configuration appliquée";
            string caption = "caption";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, caption, buttons, icon);

        }
    }
}
