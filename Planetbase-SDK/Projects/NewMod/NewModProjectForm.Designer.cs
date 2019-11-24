namespace Planetbase_SDK.Projects.NewMod
{
    partial class NewModProjectForm
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
            this.modNameBox = new System.Windows.Forms.TextBox();
            this.modName = new System.Windows.Forms.Label();
            this.injectPatchesCheckBox = new System.Windows.Forms.CheckBox();
            this.globalConfigurationBox = new System.Windows.Forms.GroupBox();
            this.modderName = new System.Windows.Forms.Label();
            this.modderNameBox = new System.Windows.Forms.TextBox();
            this.modOptionsBox = new System.Windows.Forms.GroupBox();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.assetOptions = new System.Windows.Forms.GroupBox();
            this.createLocalizationAssetsFolderBox = new System.Windows.Forms.CheckBox();
            this.create3DModelAssetsFolderBox = new System.Windows.Forms.CheckBox();
            this.createImageAssetsFolderBox = new System.Windows.Forms.CheckBox();
            this.globalConfigurationBox.SuspendLayout();
            this.modOptionsBox.SuspendLayout();
            this.assetOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // modNameBox
            // 
            this.modNameBox.Location = new System.Drawing.Point(94, 19);
            this.modNameBox.Name = "modNameBox";
            this.modNameBox.Size = new System.Drawing.Size(100, 20);
            this.modNameBox.TabIndex = 0;
            this.modNameBox.Text = "ReallyCoolThing";
            this.modNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.modNameBox_Validating);
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.Location = new System.Drawing.Point(6, 22);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(60, 13);
            this.modName.TabIndex = 1;
            this.modName.Text = "Mod name:";
            // 
            // injectPatchesCheckBox
            // 
            this.injectPatchesCheckBox.AutoSize = true;
            this.injectPatchesCheckBox.Location = new System.Drawing.Point(6, 19);
            this.injectPatchesCheckBox.Name = "injectPatchesCheckBox";
            this.injectPatchesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.injectPatchesCheckBox.TabIndex = 2;
            this.injectPatchesCheckBox.Text = "Inject patches";
            this.injectPatchesCheckBox.UseVisualStyleBackColor = true;
            // 
            // globalConfigurationBox
            // 
            this.globalConfigurationBox.Controls.Add(this.modderName);
            this.globalConfigurationBox.Controls.Add(this.modderNameBox);
            this.globalConfigurationBox.Controls.Add(this.modName);
            this.globalConfigurationBox.Controls.Add(this.modNameBox);
            this.globalConfigurationBox.Location = new System.Drawing.Point(12, 12);
            this.globalConfigurationBox.Name = "globalConfigurationBox";
            this.globalConfigurationBox.Size = new System.Drawing.Size(200, 75);
            this.globalConfigurationBox.TabIndex = 4;
            this.globalConfigurationBox.TabStop = false;
            this.globalConfigurationBox.Text = "Global configuration";
            // 
            // modderName
            // 
            this.modderName.AutoSize = true;
            this.modderName.Location = new System.Drawing.Point(6, 48);
            this.modderName.Name = "modderName";
            this.modderName.Size = new System.Drawing.Size(75, 13);
            this.modderName.TabIndex = 3;
            this.modderName.Text = "Modder name:";
            // 
            // modderNameBox
            // 
            this.modderNameBox.Location = new System.Drawing.Point(94, 45);
            this.modderNameBox.Name = "modderNameBox";
            this.modderNameBox.Size = new System.Drawing.Size(100, 20);
            this.modderNameBox.TabIndex = 1;
            // 
            // modOptionsBox
            // 
            this.modOptionsBox.Controls.Add(this.injectPatchesCheckBox);
            this.modOptionsBox.Location = new System.Drawing.Point(12, 93);
            this.modOptionsBox.Name = "modOptionsBox";
            this.modOptionsBox.Size = new System.Drawing.Size(200, 46);
            this.modOptionsBox.TabIndex = 5;
            this.modOptionsBox.TabStop = false;
            this.modOptionsBox.Text = "Mod options";
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(12, 242);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(98, 23);
            this.createProjectButton.TabIndex = 7;
            this.createProjectButton.Text = "Create project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(116, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // assetOptions
            // 
            this.assetOptions.Controls.Add(this.createLocalizationAssetsFolderBox);
            this.assetOptions.Controls.Add(this.create3DModelAssetsFolderBox);
            this.assetOptions.Controls.Add(this.createImageAssetsFolderBox);
            this.assetOptions.Location = new System.Drawing.Point(12, 145);
            this.assetOptions.Name = "assetOptions";
            this.assetOptions.Size = new System.Drawing.Size(200, 91);
            this.assetOptions.TabIndex = 6;
            this.assetOptions.TabStop = false;
            this.assetOptions.Text = "Asset options";
            // 
            // createLocalizationAssetsFolderBox
            // 
            this.createLocalizationAssetsFolderBox.AutoSize = true;
            this.createLocalizationAssetsFolderBox.Location = new System.Drawing.Point(6, 65);
            this.createLocalizationAssetsFolderBox.Name = "createLocalizationAssetsFolderBox";
            this.createLocalizationAssetsFolderBox.Size = new System.Drawing.Size(174, 17);
            this.createLocalizationAssetsFolderBox.TabIndex = 5;
            this.createLocalizationAssetsFolderBox.Text = "Create localization assets folder";
            this.createLocalizationAssetsFolderBox.UseVisualStyleBackColor = true;
            // 
            // create3DModelAssetsFolderBox
            // 
            this.create3DModelAssetsFolderBox.AutoSize = true;
            this.create3DModelAssetsFolderBox.Location = new System.Drawing.Point(6, 42);
            this.create3DModelAssetsFolderBox.Name = "create3DModelAssetsFolderBox";
            this.create3DModelAssetsFolderBox.Size = new System.Drawing.Size(167, 17);
            this.create3DModelAssetsFolderBox.TabIndex = 4;
            this.create3DModelAssetsFolderBox.Text = "Create 3D model assets folder";
            this.create3DModelAssetsFolderBox.UseVisualStyleBackColor = true;
            // 
            // createImageAssetsFolderBox
            // 
            this.createImageAssetsFolderBox.AutoSize = true;
            this.createImageAssetsFolderBox.Location = new System.Drawing.Point(6, 19);
            this.createImageAssetsFolderBox.Name = "createImageAssetsFolderBox";
            this.createImageAssetsFolderBox.Size = new System.Drawing.Size(150, 17);
            this.createImageAssetsFolderBox.TabIndex = 3;
            this.createImageAssetsFolderBox.Text = "Create image assets folder";
            this.createImageAssetsFolderBox.UseVisualStyleBackColor = true;
            // 
            // NewModProjectForm
            // 
            this.AcceptButton = this.createProjectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(224, 282);
            this.Controls.Add(this.assetOptions);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.modOptionsBox);
            this.Controls.Add(this.globalConfigurationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewModProjectForm";
            this.Text = "New mod project";
            this.globalConfigurationBox.ResumeLayout(false);
            this.globalConfigurationBox.PerformLayout();
            this.modOptionsBox.ResumeLayout(false);
            this.modOptionsBox.PerformLayout();
            this.assetOptions.ResumeLayout(false);
            this.assetOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label modName;
        private System.Windows.Forms.GroupBox globalConfigurationBox;
        private System.Windows.Forms.GroupBox modOptionsBox;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox modNameBox;
        private System.Windows.Forms.CheckBox injectPatchesCheckBox;
        private System.Windows.Forms.Label modderName;
        private System.Windows.Forms.TextBox modderNameBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox assetOptions;
        private System.Windows.Forms.CheckBox createImageAssetsFolderBox;
        private System.Windows.Forms.CheckBox create3DModelAssetsFolderBox;
        private System.Windows.Forms.CheckBox createLocalizationAssetsFolderBox;
    }
}