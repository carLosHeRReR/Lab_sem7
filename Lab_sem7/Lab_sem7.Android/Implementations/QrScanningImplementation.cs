using Lab_sem7.Interfaces;
using System.Threading.Tasks;
using ZXing.Mobile;
using Xamarin.Forms;
using Lab_sem7.Droid.Implementations;


[assembly: Dependency(typeof(QrScanningImplementation))]
namespace Lab_sem7.Droid.Implementations
{
    public class QrScanningImplementation : IQrScanning
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}