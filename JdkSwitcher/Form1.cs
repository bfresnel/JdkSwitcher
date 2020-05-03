using System;
using System.Windows.Forms;

namespace JdkSwitcher
{
    public partial class Form1 : Form
    {
        private static readonly string JDK_VAR = "JAVA_HOME";
        private string jdk;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPath();
            txtbJdk.Text = jdk;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbJdk.Text = fbd.SelectedPath;
            }
        }

        private void LoadPath()
        {
            jdk = Environment.GetEnvironmentVariable(JDK_VAR, EnvironmentVariableTarget.User);
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Application des modifications...");
            PathUtility.checkPathVariable();

            /*if (jdk != txtbJdk.Text)
            {
                Environment.SetEnvironmentVariable(JDK_VAR, txtbJdk.Text, EnvironmentVariableTarget.User);
                jdk = txtbJdk.Text;
                Console.WriteLine("JDK : {0}", jdk);
            }*/
        }
    }
}
