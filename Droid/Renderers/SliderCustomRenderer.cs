using System;
using Android.Content;
using Android.Graphics;
using Android.Text;
using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsSliderApp.Controls;
using XamarinFormsSliderApp.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomSlider), typeof(SliderCustomRenderer))]
namespace XamarinFormsSliderApp.Droid.Renderers
{
    public class SliderCustomRenderer : SliderRenderer
    {
        private int mThumbSize;
        private TextPaint mTextPaint;

        public SliderCustomRenderer(Context context): base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                // progressbar and progressbar background color
                //Control.ProgressDrawable.SetColorFilter(
                //    new PorterDuffColorFilter(
                //    Xamarin.Forms.Color.Orange.ToAndroid(),
                //    PorterDuff.Mode.SrcIn));



                // Set custom drawable resource
                Control.SetProgressDrawableTiled(
                    Resources.GetDrawable(
                        Resource.Drawable.custom_progressbar_style, (this.Context).Theme
                    )
                );

                // Set Progress bar Thumb color
                Control.Thumb.SetColorFilter(
                Xamarin.Forms.Color.Orange.ToAndroid(),
                PorterDuff.Mode.SrcIn);

               
            }
        }
    }
}