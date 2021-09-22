using Dead_By_Daylight_Mod_Installer.Presenter;
using Dead_By_Daylight_Mod_Installer.View;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dead_By_Daylight_Mod_Installer
{
    public partial class InstallerForm : Form, IInstallerView
    {
        public InstallerForm()
        {
            InitializeComponent();
        }

        public InstallerPresenter Presenter { private get; set; }

        public string PaksPath
        {
            get => this.paksPathTextBox.Text;
            set => this.paksPathTextBox.Text = value;
        }


        // === WIN CONTROLS
        private void CloseToolbarButton_Click(object sender, EventArgs e) => this.Close();
        private void MinimizeToolbarButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private async void ToolbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            toolbarPanel.Capture = false; await Task.Run(() =>
            {
                Message mouse = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref mouse);
            });
        }


        // === MAIN BUTTONS + PAKS FOLDER FIELD
        private void InstallButton_Click(object sender, EventArgs e) => Presenter.InstallMod();
        private void UninstallButton_Click(object sender, EventArgs e) => Presenter.UninstallMod();
        private void ChangePaksPathButton_Click(object sender, EventArgs e)
        {
            //TODO: move to the service
            using (FolderBrowserDialog paksPathBrowser = new FolderBrowserDialog())
            {
                DialogResult dialogResult = paksPathBrowser.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Presenter.ChangePaksPath(paksPathBrowser.SelectedPath);
                    Globals.PakFolderPath = paksPathBrowser.SelectedPath;
                }
            }
        }
        private void CreatePackageButton_Click(object sender, EventArgs e) => Presenter.DisplayCreator();
    }
}
