MvvmCross.Plugins.ZXing
=======================
MvvmCross plugin wrapper around <a href="https://github.com/Redth/ZXing.Net.Mobile">ZXing.Net.Mobile</a> library for scanning barcodes and QR codes. Currently, platform specific implementation is only available for Android, however iOS and Windows Phone are coming soon.

<h3>Android</h3>
Few things to keep in mind for Android:
<ul>
<li>
Add <strong>CAMERA</strong> permission to AndroidManifest.
</li>
<li>
Android 2.2+
</li>
<li>
Need to register along with other plugins in Setup class
</li>
</ul>
  ```c#
public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager)
{
    //...
    pluginManager.EnsurePluginLoaded<dESCO.MvvmCross.Plugins.ZXing.PluginLoader>();

    base.LoadPlugins(pluginManager);
}
  ```
  
  The plugin is consumed just like any other MvvmCross plugins. Here's a simple example:
  
  ```c#

void DoScanBarcode()
{
  var scanner = Mvx.Resolve<IMvxZXingScanner>();
  scanner.Scan(Scan_Complete);
}    

void Scan_Complete(MvxZXingResult result)
{
    string szCode =result.Text;
    //...
}
```
<h3>Thanks</h3>
<ul>
<li>
Stuart Lodge for MvvmCross - https://github.com/MvvmCross/MvvmCross
</li>
<li>
Redth for ZXing.NetMobile - https://github.com/Redth/ZXing.Net.Mobile
</li>
</ul>




