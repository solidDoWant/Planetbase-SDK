using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace Planetbase_SDK.Projects.NewMod
{
    public class Wizard : IWizard
    {
        private Dictionary<string, string> Replacements { get; set; }

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
            var projectDirectory = Replacements["$destinationdirectory$"];

            //Create asset directories
            if (
                Replacements["$shouldCreateImageAssetsFolder$"] == "True" ||
                Replacements["$shouldCreate3DModelAssetsFolder$"] == "True" ||
                Replacements["$shouldCreateLocalizationAssetsFolder$"] == "True"
            )
                Directory.CreateDirectory(Path.Combine(projectDirectory, "assets"));

            if(Replacements["$shouldCreateImageAssetsFolder$"] == "True")
                Directory.CreateDirectory(Path.Combine(projectDirectory, "assets", "png"));

            if (Replacements["$shouldCreate3DModelAssetsFolder$"] == "True")
                Directory.CreateDirectory(Path.Combine(projectDirectory, "assets", "obj"));

            if (Replacements["$shouldCreateLocalizationAssetsFolder$"] == "True")
                Directory.CreateDirectory(Path.Combine(projectDirectory, "assets", "strings"));
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects
                // input for the custom message.
                var inputForm = new NewModProjectForm();

                //Attempt to get the mod name from the project name and update the form with it's value
                var projectName = replacementsDictionary["$projectname$"];
                var matchedRegex = Regex.Match(projectName, $"^Planetbase-({NewModProjectForm.ClassNameRegex})$");
                if (matchedRegex.Success)
                    inputForm.ModName = matchedRegex.Groups[1].Value;
                
                inputForm.ShowDialog();

                if(inputForm.DialogResult == DialogResult.Cancel)
                    throw new WizardCancelledException("The user chose to cancel project creation.");

                // Add custom parameters from the form
                replacementsDictionary.Add("$modName$", inputForm.ModName);
                replacementsDictionary.Add("$modderName$", inputForm.ModderName);
                replacementsDictionary.Add("$shouldInjectPatches$", inputForm.ShouldInjectPatches.ToString());
                replacementsDictionary.Add("$shouldCreateImageAssetsFolder$", inputForm.ShouldCreateImageAssetsFolder.ToString());
                replacementsDictionary.Add("$shouldCreate3DModelAssetsFolder$", inputForm.ShouldCreate3DModelAssetsFolder.ToString());
                replacementsDictionary.Add("$shouldCreateLocalizationAssetsFolder$", inputForm.ShouldCreateLocalizationAssetsFolder.ToString());

                //Add other custom parameters
                var modFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Planetbase", "Mods");
                replacementsDictionary.Add("$modFolderPath", modFolderPath);

                Replacements = replacementsDictionary;
            }
            catch (Exception ex)
            {
                // Rethrow to cancel creation
                if (ex is WizardCancelledException)
                    throw;

                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}