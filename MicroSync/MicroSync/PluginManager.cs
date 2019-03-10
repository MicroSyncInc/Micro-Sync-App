using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MicroSync
{
    class PluginManager
    {
        private static Dictionary<string, IPlugin> Plugins = new Dictionary<string, IPlugin>();
        private static string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Plugins");
        public static void LoadPlugins()
        {
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileInfo dll = ReadFromGoogle.DownloadFileFromURLToPath(@"https://drive.google.com/file/d/1V7Z3pMwORkhhTuYMJV83Ucx8irJ-duTc/view?usp=sharing", Path.Combine(path, "Test.dll"));
            while(dll == null)
            {

            }
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fis = di.GetFiles("*.dll");
            foreach (FileInfo fpth in fis)
            {
            Assembly a = Assembly.LoadFrom(dll.FullName);
            foreach (Type t in a.GetTypes())
            {
                if (t.GetInterface("IPlugin") != null)
                {
                try
                {
                     IPlugin plugin = Activator.CreateInstance(t) as IPlugin;
                     Plugins.Add(plugin.ID, plugin);
                     }
                     catch
                     {
                     }
               }
                
            }
          }
        }

        public static IPlugin GetPlugin(string ID)
        {
            if (Plugins == null || Plugins.Count == 0)
            {
                LoadPlugins();
            }
            return Plugins[ID];
        }
    }
}
