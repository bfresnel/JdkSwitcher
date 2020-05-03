using System;
using System.Windows.Forms;

namespace JdkSwitcher
{
    public partial class Form1 : Form
    {
        private static string JDK_VAR = "JAVA_HOME";
        private static string MAVEN_VAR = "M2_HOME";
        private string jdk;
        private string maven;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPath();
            txtbJdk.Text = jdk;
            txtbMaven.Text = maven;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbJdk.Text = fbd.SelectedPath;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbMaven.Text = fbd.SelectedPath;
            }
        }

        private void LoadPath()
        {
            jdk = Environment.GetEnvironmentVariable(JDK_VAR, EnvironmentVariableTarget.User);
            maven = Environment.GetEnvironmentVariable(MAVEN_VAR, EnvironmentVariableTarget.User);
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Application des modifications...");

            if (jdk != txtbJdk.Text)
            {
                Environment.SetEnvironmentVariable(JDK_VAR, txtbJdk.Text, EnvironmentVariableTarget.User);
                jdk = txtbJdk.Text;
                Console.WriteLine("JDK : {0}", jdk);
            }

            if (maven != txtbMaven.Text)
            {
                Environment.SetEnvironmentVariable(MAVEN_VAR, txtbMaven.Text, EnvironmentVariableTarget.User);
                maven = txtbMaven.Text;
                Console.WriteLine("MAVEN : {0}", maven);
            }
        }
    }
}
