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
    public partial class WinformsToolWindowControl : UserControl
    {
        
        public WinformsToolWindowControl()
        {
            InitializeComponent();
        }

        public WinformsToolWindowControl(WinformsToolWindowData data) : this()
        {
            EnvDTE.DTE dte = data.Dte;
            EnvDTE.Solution sln = dte.Solution;

            foreach (EnvDTE.Project project in sln.Projects)
            {
                lbProjects.Items.Add($"Projct Name: {project.Name}");

                ProjectItems projectItems = project.ProjectItems;
                ScanProjectItems(projectItems, 1);
            }
        }

        private void ScanProjectItems(ProjectItems projectItems, int level)
        {
            foreach (ProjectItem projectItem in projectItems)
            {
                string itemName = "Name: " + projectItem.Name + " " + level.ToString();
                lbProjects.Items.Add($"\t {itemName}");

                ProjectItems projectItems2 = projectItem.ProjectItems;
                if (projectItems2 != null)
                {
                    ScanProjectItems(projectItems2, level++);
                }
            }
        }
    }
}
