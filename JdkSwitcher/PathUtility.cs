using System;
using System.Collections.Generic;
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
            string updatedPathString = string.Join(";", updatedPath);
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
                    if (File.Exists(path + "\\java.exe"))
                    {
                        Logger.Info("Java executable detected : {0}{1}", path, "\\java.exe");
                        return true;
                    }
                    Logger.Debug("Not available");
                }
            }

            return false;
        }
    }
}
