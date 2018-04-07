using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;
using RadioPi.MCP;
using System.Threading.Tasks;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace RadioPi
{
    public sealed class StartupTask : IBackgroundTask
    {
        int lcd_rs = 0;
        int lcd_en = 1;
        int lcd_d4 = 2;
        int lcd_d5 = 3;
        int lcd_d6 = 4;
        int lcd_d7 = 5;
        int lcd_red = 6;
        int lcd_green = 7;
        int lcd_blue = 8;

        int lcd_columns = 16;
        int lcd_rows = 2;

        // Entry flags
        int LCD_ENTRYRIGHT = 0x00;
        int LCD_ENTRYLEFT = 0x02;
        int LCD_ENTRYSHIFTINCREMENT = 0x01;
        int LCD_ENTRYSHIFTDECREMENT = 0x00;

        // Control flags
        int LCD_DISPLAYON = 0x04;
        int LCD_DISPLAYOFF = 0x00;
        int LCD_CURSORON = 0x02;
        int LCD_CURSOROFF = 0x00;
        int LCD_BLINKON = 0x01;
        int LCD_BLINKOFF = 0x00;

        // Move flags
        int LCD_DISPLAYMOVE = 0x08;
        int LCD_CURSORMOVE = 0x00;
        int LCD_MOVERIGHT = 0x04;
        int LCD_MOVELEFT = 0x00;

        // Function set flags
        int LCD_8BITMODE = 0x10;
        int LCD_4BITMODE = 0x00;
        int LCD_2LINE = 0x08;
        int LCD_1LINE = 0x00;
        int LCD_5x10DOTS = 0x04;
        int LCD_5x8DOTS = 0x00;

        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            var defferal = taskInstance.GetDeferral();

            var mcp = new MCP23017();
            await mcp.Init();
            mcp.SetDriveMode(Pin.GPA0, PinMode.Ouput);
            mcp.SetDriveMode(Pin.GPA1, PinMode.Ouput);
            mcp.SetDriveMode(Pin.GPA2, PinMode.Ouput);
            mcp.SetDriveMode(Pin.GPA3, PinMode.Ouput);
            mcp.SetDriveMode(Pin.GPA4, PinMode.Ouput);
            mcp.SetDriveMode(Pin.GPA5, PinMode.Ouput);

            mcp.Write(0, 0x33);
            mcp.Write(0, 0x32);

            mcp.Write(0x08, (byte)(LCD_DISPLAYON | LCD_CURSOROFF | LCD_BLINKOFF));
            mcp.Write(0x20, (byte)(LCD_4BITMODE | LCD_1LINE | LCD_2LINE | LCD_5x8DOTS));
            mcp.Write(0x04, (byte)(LCD_ENTRYLEFT | LCD_ENTRYSHIFTDECREMENT));

            mcp.Write(0, 0x01);
            await Task.Delay(3000);
            mcp.Write(0x65, 0x00);
            await Task.Delay(3000);
            //mcp.Dispose();

            defferal.Complete();
        }
    }
}
