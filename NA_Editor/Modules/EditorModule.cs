using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NA_Editor.Modules
{
    public class EditorModule
    {
        public string DisplayName { get; set; }
        public string InternalName { get; set; }
        public string Header { get; set; }
        public Type UCType { get; set; }

        public EditorModule(string displayname, Type ucType)
        {
            DisplayName = displayname;
            UCType = ucType;
            SetInternalName();
        }

        private void SetInternalName()
        {
            string mod = "mod_";
            string name = DisplayName.Replace(' ', '_');
            InternalName = mod + name;
        }

        public virtual void OpenModule(TabItem ti, int height, int width)
        {
            var newUC = (UserControl)Activator.CreateInstance(UCType);
            if (newUC != null)
            {
                newUC.Height = height;
                newUC.Width = width;
                ti.Content = newUC;
            }
        }
    }
}
