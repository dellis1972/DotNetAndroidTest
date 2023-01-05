using System.Globalization;
using Humanizer;

namespace DotNet6AndroidTest.Library
{
    public class Class1
    {
        public int GetId () {
            return Resource.Layout.sample;
        }

        public string GetFoo () {
            var c = new CultureInfo ("es-ES");
            return $"DEBUG={DateTime.UtcNow.AddHours(-30).Humanize(culture:c)}";
        }
    }
}
