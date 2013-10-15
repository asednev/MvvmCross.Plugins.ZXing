using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ZXing.Mobile;
using Cirrious.CrossCore.Droid;
using Cirrious.CrossCore;
using System.Threading.Tasks;
using Cirrious.CrossCore.Droid.Platform;

namespace dESCO.MvvmCross.Plugins.ZXing.Droid
{
    public class MvxZXingScanner : MvxAndroidTask, IMvxZXingScanner
    {
        private Context _context;
        private Context Context
        {
            get
            {
                if (_context == null)
                {
                    _context = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
                }
                return _context;
            }
        }

        public void Scan(Action<MvxZXingResult> callback)
        {
            StartScanning(null, callback);
        }

        public void Scan(MobileBarcodeScanningOptions options, Action<MvxZXingResult> callback)
        {
            StartScanning(options, callback);
        }

        async void StartScanning(MobileBarcodeScanningOptions options, Action<MvxZXingResult> callback)
        {

            MobileBarcodeScanner scanner = new MobileBarcodeScanner(Context);

            if (options != null)
            {
                //Tell our scanner to use the default overlay
                scanner.UseCustomOverlay = options.UseCustomOverlay;

                //We can customize the top and bottom text of the default overlay
                scanner.TopText = options.TopText;
                scanner.BottomText = options.BottomText;

                scanner.CameraUnsupportedMessage = options.CameraUnsupportedMessage;

                scanner.CancelButtonText = options.CancelButtonText;
                scanner.FlashButtonText = options.FlashButtonText;
            }

            //Start scanning
            var result = await scanner.Scan();

            if (result != null)
            {
                var mvxResult = new MvxZXingResult()
                {
                    Text = result.Text,
                    RawBytes = result.RawBytes,
                    Timestamp = result.Timestamp
                };
                callback.Invoke(mvxResult);
            }
            else
            {
                callback.Invoke(null);
            }
        }
    }
}