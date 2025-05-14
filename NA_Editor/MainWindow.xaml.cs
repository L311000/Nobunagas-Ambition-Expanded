using NA_Editor.Modules;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NA_Editor;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<EditorModule> Modules { get; set; }
    public MainWindow()
    {
        InitializeComponent();

        InitPremadeModules();
        InitMainMenu();
    }

    private void InitPremadeModules()
    {
        var list = new List<EditorModule>
        {
            new("Emblem Editor", typeof(ucMonEdit)) {Header = "Emblem Editor"}
        };
        Modules = list;
    }

    private void InitMainMenu()
    {
        Menu_Main.Items.Clear();
        Menu_Main.ItemsSource = null;

        TabControl_Modules.Items.Clear();
        TabControl_Modules.ItemsSource = null;

        foreach (var m in Modules)
        {
            var menuitem = new MenuItem();
            menuitem.Header = m.DisplayName;
            menuitem.Name = m.InternalName;
            menuitem.Click += MenuItemClick_OpenNewModule;
            Menu_Main.Items.Add(menuitem);
        }
        Menu_Main.Items.Refresh();
    }

    private void MenuItemClick_OpenNewModule(object sender, RoutedEventArgs e)
    {
        var tabitem = new TabItem();
        var name = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
        var module = Modules.Where(x => x.InternalName == name).FirstOrDefault();
        if (module != null)
        {
            tabitem.Header = module.Header;
            module.OpenModule(tabitem, 1011, 1388);
            TabControl_Modules.Items.Add(tabitem);
            TabControl_Modules.SelectedItem = TabControl_Modules.Items[TabControl_Modules.Items.Count - 1];
        }
    }
}