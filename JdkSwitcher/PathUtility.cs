using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdkSwitcher
{
    static class PathUtility
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void checkPathVariable()
        {
            List<String> pathsToCheck = new List<string>();
            String[] paths = Environment.GetEnvironmentVariable("PATH").Split(';');
            foreach(String path in paths)
            {
                if (path.Contains("\\bin"))
                {
                    pathsToCheck.Add(path);
                }
            }

            if (pathsToCheck.Count() > 0)
            {
                foreach(String path in pathsToCheck)
                {
                    bool bResult = executeJavaVersion(path);
                }
            }
        }

        private static bool executeJavaVersion(String pathToTest)
        {
            Logger.Debug("TEST LOGGER");
            Process process = new Process();
            process.StartInfo.FileName = pathToTest + "\\java.exe";
            process.StartInfo.Arguments = "-version";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            try
            {
                process.Start();
                string sOutput = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            catch (Win32Exception e)
            {
                Logger.Error(e, "Well...");
                return false;
            }
            return true;
        }
    }
}
