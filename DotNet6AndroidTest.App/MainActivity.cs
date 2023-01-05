using DotNet6AndroidTest.Library;
using AndroidX.AppCompat.App;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace DotNet6AndroidTest.App
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        SKCanvasView skiaView;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            skiaView = FindViewById<SKCanvasView>(Resource.Id.skiaView);

            var binding = new Binding.activity_main (this);
            binding.myText.Text = "It Worked!";

            
            var class1 = new Class1 ();
            Console.WriteLine ($"DEBUG={class1.GetFoo ()}");
            var id = class1.GetId ();
            if (id == 1)
                StartActivity (typeof (Sample));

        }

        protected override void OnResume()
        {
            base.OnResume();

            skiaView.PaintSurface += OnPaintSurface;
        }

        protected override void OnPause()
        {
            skiaView.PaintSurface -= OnPaintSurface;

            base.OnPause();
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            // the the canvas and properties
            var canvas = e.Surface.Canvas;

            // make sure the canvas is blank
            canvas.Clear(SKColors.White);

            // draw some text
            var paint = new SKPaint
            {
                Color = SKColors.Black,
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                TextAlign = SKTextAlign.Center,
                TextSize = 24
            };
            var coord = new SKPoint(e.Info.Width / 2, (e.Info.Height + paint.TextSize) / 2);
            canvas.DrawText("SkiaSharp", coord, paint);
        }

    }
}