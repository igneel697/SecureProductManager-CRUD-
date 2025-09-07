using System;

namespace SecureProductManager.Helpers
{
    public static class UrlHelper
    {
        public static bool IsLocalUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return false;

            if (url.StartsWith("/") && !url.StartsWith("//") && !url.StartsWith("/\\"))
                return true;

            if (url.StartsWith("~/"))
                return true;

            return false;
        }
    }
}