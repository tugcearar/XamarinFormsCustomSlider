using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace XamarinFormsSliderApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());
            UISlider.Appearance.TintColor = UIColor.FromRGBA(119, 38, 232, 255);
            UISlider.Appearance.ThumbTintColor = UIColor.FromRGBA(89, 177, 124, 255);
            return base.FinishedLaunching(app, options);
        }
    }
}
