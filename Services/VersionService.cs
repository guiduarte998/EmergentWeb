using System.Text.RegularExpressions;

namespace Services
{
    public class VersionService : IVersionService
    {
        public bool IsValidVersion(string version)
        {
            // Simple regex to validate version format
            return Regex.IsMatch(version, @"^\d+(\.\d+)*$");
        }

        public bool IsVersionGreaterThan(string baseVersion, string compareVersion)
        {
            var baseParts = baseVersion.Split('.').Select(int.Parse).ToArray();
            var compareParts = compareVersion.Split('.').Select(int.Parse).ToArray();

            for (int i = 0; i < Math.Max(baseParts.Length, compareParts.Length); i++)
            {
                int baseValue = i < baseParts.Length ? baseParts[i] : 0;
                int compareValue = i < compareParts.Length ? compareParts[i] : 0;
                if (compareValue > baseValue) return true;
                if (compareValue < baseValue) return false;
            }
            return false;
        }
    }
}
