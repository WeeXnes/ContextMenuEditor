using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace ContextMenuEditor
{
    public partial class MainWindow : Form
    {
        public const string fileMenuRegistry = @"\*\shell";
        public const string bgMenuRegistry = @"\Directory\Background\shell";
        public const string folderMenuRegistry = @"\Directory\shell";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MenuType menu;
            if (rb_filemenu.Checked)
            {
                menu = MenuType.FileMenu;
            }
            else if(rb_bgmenu.Checked)
            {
                menu = MenuType.BackgroundMenu;
            }
            else
            {
                menu = MenuType.FolderMenu;
            }

            if (!String.IsNullOrEmpty(tb_text.Text))
            {
                if (!String.IsNullOrEmpty(tb_filepath.Text))
                {
                    if (File.Exists(tb_filepath.Text))
                    {
                        if (!String.IsNullOrEmpty(tb_iconpath.Text))
                        {
                            if (File.Exists(tb_iconpath.Text))
                            {
                                writeToRegistry(menu, tb_text.Text, tb_filepath.Text, tb_iconpath.Text);
                            }
                            else
                            {
                                MessageBox.Show("The provided icon path does not exist");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dont leave textbox \"icon path:\" empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The provided .exe path does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Dont leave textbox \".exe path:\" empty");
                }
            }
            else
            {
                MessageBox.Show("Dont leave textbox \"Text:\" empty");
            }
        }

        public enum MenuType
        {
            FileMenu,
            BackgroundMenu,
            FolderMenu
        }
        public static void writeToRegistry(MenuType type, string text, string command, string icon)
        {
            string key;
            string suffix;
            
            if (type == MenuType.FileMenu)
            {
                key = fileMenuRegistry;
                suffix = "\"%1\"";
            }
            else if (type == MenuType.BackgroundMenu)
            {
                key = bgMenuRegistry;
                suffix = "\"%V\"";
            }
            else if (type == MenuType.FolderMenu)
            {
                key = folderMenuRegistry;
                suffix = "\"%V\"";
            }
            else
            {
                key = fileMenuRegistry;
                suffix = "\"%1\"";
            }

            using (var shellKey = Registry.ClassesRoot.OpenSubKey(key, true))
            {
                shellKey.CreateSubKey(text);
                using (var menuEntryKey = shellKey.OpenSubKey(text, true))
                {
                    menuEntryKey.SetValue("icon", icon);
                    menuEntryKey.CreateSubKey("Command");
                    using (var commandKey = menuEntryKey.OpenSubKey("Command", true))
                    {
                        commandKey.SetValue("", "\"" + command + "\" " + suffix);

                    }
                }

            }
        }
        
    }
}