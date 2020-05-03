using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace JdkSwitcher
{
    static class PathUtility
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void checkPathVariable()
        {
            bool bResult = true;
            string pathToModify = "";
            List<string> pathsToCheck = new List<string>();
            string[] paths = Environment.GetEnvironmentVariable("PATH").Split(';');
            List<string> pathsList = paths.ToList();
            isPathAlreadyExisting(ref bResult, ref pathToModify, pathsToCheck, pathsList);

            if (bResult)
            {
                modifyPathVariable();
            }
        }

        private static void modifyPathVariable()
        {
            throw new NotImplementedException();
        }

        private static void isPathAlreadyExisting(ref bool bResult, ref string pathToModify, List<string> pathsToCheck, List<string> pathsList)
        {
            foreach (string path in pathsList)
            {
                if (path.Contains("\\bin"))
                {
                    pathsToCheck.Add(path);
                }
            }

            if (pathsToCheck.Count() > 0)
            {
                foreach (string path in pathsToCheck)
                {
                    if (executeJavaVersion(path))
                    {
                        bResult = true;
                        pathToModify = path;
                    }
                }
            }
        }

        private static bool executeJavaVersion(string pathToTest)
        {
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
                Logger.Error(e, e.Message);
                return false;
            }
            return true;
        }
    }
}
