using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dESCO.MvvmCross.Plugins.ZXing
{
    public interface IMvxZXingScanner
    {
        void Scan(Action<MvxZXingResult> callback);
        void Scan(MobileBarcodeScanningOptions options, Action<MvxZXingResult> callback);
    }
}
