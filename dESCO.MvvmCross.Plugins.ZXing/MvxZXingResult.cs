using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dESCO.MvvmCross.Plugins.ZXing
{
    public class MvxZXingResult
    {
        /// <returns>raw text encoded by the barcode, if applicable, otherwise <code>null</code></returns>
        public String Text { get; set; }

        /// <returns>raw bytes encoded by the barcode, if applicable, otherwise <code>null</code></returns>
        public byte[] RawBytes { get; set; }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        public long Timestamp { get; set; }

    }
}
