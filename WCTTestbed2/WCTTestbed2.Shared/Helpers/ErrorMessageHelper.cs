using Windows.ApplicationModel.Resources;

namespace WCTTestbed2.Shared.Helpers
{
    public static class ErrorMessageHelper
    {
        private static ResourceLoader _resourceLoader = ResourceLoader.GetForViewIndependentUse("ErrorMessages");

        public static string GetErrorMessageResource(string name)
        {
            return _resourceLoader.GetString(name);
        }
    }
}
