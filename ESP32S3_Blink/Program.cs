using System.Device.Gpio;   //GPIOを使うためのパッケージ
using System.Threading;

namespace ESP32S3_Blink
{
    public class Program
    {
        private static GpioController controller;

        public static void Main()
        {
            GpioController controller = new GpioController();

            //GPIO2を出力モードで使用する
            GpioPin led = controller.OpenPin(2, PinMode.Output);

            //一旦出力をOFFにする
            led.Write(PinValue.Low);

            while (true)
            {
                //出力をONにする
                led.Write(PinValue.High);
                //1秒停止
                Thread.Sleep(1000);
                //出力をOFFにする
                led.Write(PinValue.Low);
                Thread.Sleep(1000);
                //Toggleを使うとONとOFFを切り替えることができる
                led.Toggle();
                Thread.Sleep(1000);
                led.Toggle();
                Thread.Sleep(1000);
            }
        }
    }
}
