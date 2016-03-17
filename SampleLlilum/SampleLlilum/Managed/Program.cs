//
// Copyright (c) Microsoft Corporation.    All rights reserved.
//

//#define LPC1768
//#define K64F
//#define STM32F411
#define STM32F401
//#define STM32F091

namespace Managed
{
    using System;
    using Windows.Devices.Gpio;
    using System.Runtime.InteropServices;
    using System.Threading;

#if LPC1768
    using Microsoft.Llilum.LPC1768;
#elif K64F
    using Microsoft.Llilum.K64F;
#elif STM32F411
    using Microsoft.Llilum.STM32F411;
#elif STM32F401
    using Microsoft.Llilum.STM32F401;
#elif STM32F091
    using Microsoft.Llilum.STM32F091;
#endif
    
    class Program
    {
        static void Main()
        {
            var ctlr = GpioController.GetDefault();

            var gpioPin = ctlr.OpenPin((int)PinName.D2);
            
            gpioPin.SetDriveMode(GpioPinDriveMode.Output);
            
            while (true)
            {
                gpioPin.Write(GpioPinValue.High);
                Thread.Sleep(200);
                gpioPin.Write(GpioPinValue.Low);
                Thread.Sleep(200);
            }
        }
    }
}
