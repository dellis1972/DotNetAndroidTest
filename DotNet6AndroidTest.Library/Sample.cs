using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
namespace DotNet6AndroidTest.Library
{
    [Activity(Label = "@string/lib_text", MainLauncher = false, Theme="@style/AppTheme1")]
    public class Sample :  FragmentActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.sample);

            var fm = SupportFragmentManager;

            new TestDialog().Show(fm, TestDialog.TAG);
        }
    }
}