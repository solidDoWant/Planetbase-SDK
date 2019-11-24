using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Planetbase_SDK.Projects.NewMod
{
    public partial class NewModProjectForm : Form
    {
        public const string ClassNameRegex = "[a-zA-Z_][A-Za-z0-9_]*";

        public string ModName
        {
            get => modNameBox.Text;
            set => modNameBox.Text = value;
        }

        public string ModderName
        {
            get => modderNameBox.Text;
            set => modderNameBox.Text = value;
        }

        public bool ShouldInjectPatches
        {
            get => injectPatchesCheckBox.Checked;
            set => injectPatchesCheckBox.Checked = value;
        }

        public bool ShouldCreateImageAssetsFolder
        {
            get => createImageAssetsFolderBox.Checked;
            set => createImageAssetsFolderBox.Checked = value;
        }

        public bool ShouldCreate3DModelAssetsFolder
        {
            get => create3DModelAssetsFolderBox.Checked;
            set => create3DModelAssetsFolderBox.Checked = value;
        }

        public bool ShouldCreateLocalizationAssetsFolder
        {
            get => createLocalizationAssetsFolderBox.Checked;
            set => createLocalizationAssetsFolderBox.Checked = value;
        }

        public NewModProjectForm()
        {
            InitializeComponent();

            //Disable tab stops on non-input components
            globalConfigurationBox.TabStop = false;
            modOptionsBox.TabStop = false;
            modName.TabStop = false;
            modderName.TabStop = false;
            assetOptions.TabStop = false;

            MaximizeBox = false;
        }

        private void modNameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Regex.IsMatch(modNameBox.Text, $"^{ClassNameRegex}$")) return;

            // Invalidate the text if it's not a valid class name
            MessageBox.Show(
                "Invalid mod name",
                "Mod name must be a valid C# class name, ending in \"Mod\". For example, \"MyNewMod\".",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            e.Cancel = true;
        }

        private void createProjectButton_Click(object sender, System.EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
