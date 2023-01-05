using AndroidX.Fragment.App;
namespace DotNet6AndroidTest.Library
{
    public class TestDialog : AndroidX.Fragment.App.DialogFragment {
        public override Dialog OnCreateDialog(Bundle savedInstanceState) {
            return new AlertDialog.Builder(RequireContext())
                    .SetMessage(GetString(Resource.String.test_dialog_text))
                    .SetPositiveButton(GetString(Resource.String.ok), (dialog, which) => {} )
                    .Create();
        }
        public static string TAG = "TestDialog";
    }

}