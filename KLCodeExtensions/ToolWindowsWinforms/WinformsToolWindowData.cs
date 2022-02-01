using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;

namespace KLCodeExtensions
{
    public class WinformsToolWindowData
    {
        public EnvDTE.DTE Dte { get; set; }
        
        /*public EnvDTE.ProjectItems ProjectItems { get; set; }
        public List<string> ProjectNames { get; set; }

        public List<string> GetProjectitems()
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            EnvDTE.Solution sln = Dte.Solution;
            this.ProjectNames = new List<string>();

            foreach (EnvDTE.Project project in sln.Projects)
            {
                this.ProjectNames.Add(project.FullName);
                ScanProjectItems(project.ProjectItems, 1);
            }
            return ProjectNames;
        }

        private void ScanProjectItems(ProjectItems projectItems, int level)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            foreach (ProjectItem projectItem in projectItems)
            {
                this.ProjectNames.Add(projectItem.Name);
                ProjectItems projectItems2 = projectItem.ProjectItems;
                if (projectItems2 != null)
                {
                    ScanProjectItems(projectItems2, level++);
                }
            }
        }*/
    }
}
