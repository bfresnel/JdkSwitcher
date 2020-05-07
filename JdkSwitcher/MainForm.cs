using System;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace JdkSwitcher
{
    public partial class MainForm : Form
    {
        private static readonly string JDK_VAR = "JAVA_HOME";
        private string jdk;

        public MainForm()
        {
            InitializeComponent();
            this.jdk = Environment.GetEnvironmentVariable(JDK_VAR, EnvironmentVariableTarget.User);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbJdk.Text = jdk;
            string jsonString = File.ReadAllText("C:\\app\\JdkSwitcher\\JdkSwitcher\\Save.json");
            PathConfiguration pc = JsonSerializer.Deserialize<PathConfiguration>(jsonString);
            comboBox1.Items.Add(pc);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
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
            btnValidate.Enabled = false;
            PathUtility.UpdatingPathWithNewJdk(Environment.GetEnvironmentVariable(JDK_VAR, EnvironmentVariableTarget.User) + "\\bin", txtbJdk.Text + "\\bin");
            Environment.SetEnvironmentVariable(JDK_VAR, txtbJdk.Text.Trim(), EnvironmentVariableTarget.User);
            btnValidate.Enabled = true;

            string message = "Configuration applied with success !";
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, caption, buttons, icon);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            PathConfiguration pc = new PathConfiguration("JDK8", "C\\Test\\LOUL");
            string jsonString = JsonSerializer.Serialize(pc);
            File.WriteAllText("C:\\app\\JdkSwitcher\\JdkSwitcher\\Save.json", jsonString);
        }
    }
}
