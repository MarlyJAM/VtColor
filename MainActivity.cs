using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Views;
using Android.Widget;
using System;
using Android.Content;
using Android.Text;
using Android.Graphics.Drawables;
using System.Security.Cryptography;
using AndroidX.Core.Widget;
using Android.Graphics;

namespace VtColor
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ImageButton ibutton1=FindViewById<ImageButton>(Resource.Id.imageButton1);
            ImageButton ibutton2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            ImageButton ibutton3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            
            ImageView img1 = FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView img2 = FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView img3 = FindViewById<ImageView>(Resource.Id.imageView3);
            ColorFilter c1 =  img1.ColorFilter;
            ColorFilter c2 = img2.ColorFilter;
            ColorFilter c3 = img3.ColorFilter;

            ColorFilter[] c = new ColorFilter[] { c1, c2, c3 };

            ImageView[] img = new ImageView[] { img1, img2, img3 };
           
            Drawable d1 = img1.Drawable;
            Drawable d2 = img2.Drawable;
            Drawable d3 = img3.Drawable;
            Drawable[] dbl = new Drawable[] {d1,d2,d3 };

            Drawable d11 = ibutton1.Drawable;
            Drawable d12 = ibutton2.Drawable;
            Drawable d13 = ibutton3.Drawable;
         

            ibutton1.Click += delegate

            {
                for (int a = 0 ; a < c.Length ; a++)
                {
                       if (c[a] !=null )
                        {
                               img[a].SetImageDrawable(GetDrawable(Resource.Drawable.blue));


                        }
                   break;
                   }
             };
            //ibutton2.Click += delegate
            //{
                
            //     for (int c = 0; c < dbl.Length; c++){
             //       if (dbl[c] != null)
             //       {
             //           img[c].SetImageDrawable(GetDrawable(Resource.Drawable.green));
                        

                   // }
                   // break;
                // }

           // };
            //ibutton3.Click += delegate
            //{ 
             //      for (int b= 0; b < dbl.Length; b++){
              //      if (dbl[b] != null)
              //      {
              //          img[b].SetImageDrawable(GetDrawable(Resource.Drawable.red));

              //      }
               //     break;
               //    }

           // };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}