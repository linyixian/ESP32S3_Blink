using System.Device.Gpio;   //GPIO���g�����߂̃p�b�P�[�W
using System.Threading;

namespace ESP32S3_Blink
{
    public class Program
    {
        private static GpioController controller;

        public static void Main()
        {
            GpioController controller = new GpioController();

            //GPIO2���o�̓��[�h�Ŏg�p����
            GpioPin led = controller.OpenPin(2, PinMode.Output);

            //��U�o�͂�OFF�ɂ���
            led.Write(PinValue.Low);

            while (true)
            {
                //�o�͂�ON�ɂ���
                led.Write(PinValue.High);
                //1�b��~
                Thread.Sleep(1000);
                //�o�͂�OFF�ɂ���
                led.Write(PinValue.Low);
                Thread.Sleep(1000);
                //Toggle���g����ON��OFF��؂�ւ��邱�Ƃ��ł���
                led.Toggle();
                Thread.Sleep(1000);
                led.Toggle();
                Thread.Sleep(1000);
            }
        }
    }
}
