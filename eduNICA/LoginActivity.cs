using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace eduNICA
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        Button btnEntrar;
        EditText user;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);
            btnEntrar = FindViewById<Button>(Resource.Id.button1);
            user = FindViewById<EditText>(Resource.Id.editText1);
            btnEntrar.Click += BtnEntrar_Click;
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(SplashActivity));
            (i).PutExtra(SplashActivity.user, user.Text);
            StartActivity(i);
            
        }
        public override void OnBackPressed()
        {
            this.FinishAffinity();
        }
    }
}