using System.Data;
using System.Security.Principal;

namespace BLOCK_APP
{
    public partial class MainForm : Form
    {
        private const string HostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";
        private const string RedirectIp = "127.0.0.1";
        public MainForm()
        {
            InitializeComponent();
            LoadBlockedUrls();
        }
        private void LoadBlockedUrls()
        {
            if (File.Exists(HostsFilePath))
            {
                var lines = File.ReadAllLines(HostsFilePath);
                var blockedUrls = lines
                    .Where(line => line.StartsWith(RedirectIp))
                    .Select(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                listBoxUrls.Items.AddRange(blockedUrls.ToArray());
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("Please run the application as administrator.");
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var url = txtUrl.Text.Trim();
            if (!string.IsNullOrWhiteSpace(url) && !listBoxUrls.Items.Contains(url))
            {
                listBoxUrls.Items.Add(url);
                AppendToHostsFile(url);
                txtUrl.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxUrls.SelectedItem != null)
            {
                var url = listBoxUrls.SelectedItem.ToString();
                listBoxUrls.Items.Remove(url);
                RemoveFromHostsFile(url);
            }
        }
        private void AppendToHostsFile(string url)
        {
            using (StreamWriter sw = File.AppendText(HostsFilePath))
            {
                sw.WriteLine($"{RedirectIp} {url}");
            }
        }
        private void RemoveFromHostsFile(string url)
        {
            var lines = File.ReadAllLines(HostsFilePath).Where(line => !line.Contains(url)).ToList();
            File.WriteAllLines(HostsFilePath, lines);
        }
        private bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
