using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using SunCorp.IRecover.ViewModels.Add;
using SunCorp.IRecover.ViewModels.New;

namespace SunCorp.Irecover.Android.UI.Activities.New
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppThemeNoActionBar", ScreenOrientation = ScreenOrientation.Portrait,
        LaunchMode = LaunchMode.SingleTop, Name = "suncorp.irecover.android.ui.activities.NewWitnessActivity")]
    public class NewWitnessActivity : MvxAppCompatActivity
    {

        public new NewWitnessViewModel ViewModel
        {
            get { return (NewWitnessViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Window.AddFlags(WindowManagerFlags.KeepScreenOn);
            SetContentView(Resource.Layout.activity_new_witness);

            var toolbarTitle = FindViewById<TextView>(Resource.Id.toolbar_title);
            toolbarTitle.Text = "Add Witness";
        }
    }
}