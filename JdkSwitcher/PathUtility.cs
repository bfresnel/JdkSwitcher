using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JdkSwitcher
{
    static class PathUtility
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<string> GetPathValuesAsList()
        {
            return Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User).Split(';').ToList();
        }

        public static void UpdatingPathWithNewJdk(string oldPath, string pathToNewJdk)
        {
            List<string> updatedPath = GetPathValuesAsList();
            Logger.Debug("OLD PATH : " + Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User));
            int indexToRemove = updatedPath.IndexOf(oldPath);
            updatedPath.RemoveAt(indexToRemove);
            updatedPath.Insert(indexToRemove, pathToNewJdk);
            string updatedPathString = String.Join(";", updatedPath);
            Logger.Debug("NEW PATH : " + updatedPathString);
            Environment.SetEnvironmentVariable("PATH", updatedPathString, EnvironmentVariableTarget.User);
        }

        public static bool IsJavaPathAlreadyExisting(List<string> pathsList)
        {
            List<string> pathsToCheck = new List<string>();
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
                    Logger.Debug("Testing {0}", path);
                    if (IsJavaExeIsPresent(path))
                    {
                        Logger.Info("Java executable detected : {0}{1}", path, "\\java.exe");
                        return true;
                    }
                    Logger.Debug("Not available");
                }
            }

            return false;
        }

        private static bool IsJavaExeIsPresent(string pathToTest)
        {
            return File.Exists(pathToTest + "\\java.exe");
        }

        private static string executeJavaVersion(string pathToTest)
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
                Logger.Debug("Sortie sOuput {0}", sOutput);
                process.WaitForExit();
            }
            catch (Win32Exception e)
            {
                Logger.Error(e, e.Message);
                return "bidule";
            }
            return "endOfMethod";
        }
    }
}
