/*
 * Bits and pieces lifted from 
 * https://github.com/Redth/ZXing.Net.Mobile/blob/master/src/ZXing.Net.Mobile/Common/MobileBarcodeScanningOptions.cs
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dESCO.MvvmCross.Plugins.ZXing
{
    public class MobileBarcodeScanningOptions
    {
        public bool UseCustomOverlay { get; set; }
        public string TopText { get; set; }
        public string BottomText { get; set; }
        public string CancelButtonText { get; set; }
        public string FlashButtonText { get; set; }
        public string CameraUnsupportedMessage { get; set; }
    }
}
