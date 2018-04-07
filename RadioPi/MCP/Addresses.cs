namespace RadioPi.MCP
{
    public static class Addresses
    {
        private static byte i2cAddress = 0x20;

        static Addresses()
        {
            PORT_EXPANDER_I2C_ADDRESS = BASE_PORT_EXPANDER_I2C_ADDRESS;
        }

        public static void SetDeviceIndex(int deviceIndex)
        {
            if (deviceIndex > 0)
                PORT_EXPANDER_I2C_ADDRESS = (byte)(BASE_PORT_EXPANDER_I2C_ADDRESS + deviceIndex);
            else
                PORT_EXPANDER_I2C_ADDRESS = BASE_PORT_EXPANDER_I2C_ADDRESS;
        }

        public static byte BASE_PORT_EXPANDER_I2C_ADDRESS { get { return 0x20; } } // 7-bit I2C address of the first port expander

        public static byte PORT_EXPANDER_IODIRA_REGISTER_ADDRESS { get { return 0x00; } } // IODIR register controls the direction of the GPIO on the port expander
        public static byte PORT_EXPANDER_IODIRB_REGISTER_ADDRESS { get { return 0x01; } } // IODIR register controls the direction of the GPIO on the port expander

        public static byte PORT_EXPANDER_IPOLA_REGISTER_ADDRESS { get { return 0x02; } } // Input Polarity Register
        public static byte PORT_EXPANDER_IPOLB_REGISTER_ADDRESS { get { return 0x03; } } // Input Polarity Register

        public static byte PORT_EXPANDER_GPINTA_ADDRESS { get { return 0x04; } } // Interrput on Change pin 
        public static byte PORT_EXPANDER_GPINTB_ADDRESS { get { return 0x05; } } // Interrput on Change pin 

        public static byte PORT_EXPANDER_DEFVALA_ADDRESS { get { return 0x06; } } // Default Compare Register for Interrupt-on-change
        public static byte PORT_EXPANDER_DEFVALB_ADDRESS { get { return 0x07; } } // Default Compare Register for Interrupt-on-change

        public static byte PORT_EXPANDER_INTCONA_ADDRESS { get { return 0x08; } } // Interrupt Control Register
        public static byte PORT_EXPANDER_INTCONB_ADDRESS { get { return 0x09; } } // Interrupt Control Register

        public static byte PORT_EXPANDER_IOCON_ADDRESS { get { return 0x0A; } }  // I/O Expander Configruation Register

        public static byte PORT_EXPANDER_GPPUA_ADDRESS { get { return 0x0C; } } // GPIO Pull-up Resistor Register
        public static byte PORT_EXPANDER_GPPUB_ADDRESS { get { return 0x0D; } } // GPIO Pull-up Resistor Register

        public static byte PORT_EXPANDER_INTFA_ADDRESS { get { return 0x0E; } } //Interrupt Flag Register
        public static byte PORT_EXPANDER_INTFB_ADDRESS { get { return 0x0F; } } //Interrupt Flag Register

        public static byte PORT_EXPANDER_INTCAPA_ADDRESS { get { return 0x10; } } //Interrupt Capture Register
        public static byte PORT_EXPANDER_INTCAPB_ADDRESS { get { return 0x11; } } //Interrupt Capture Register

        public static byte PORT_EXPANDER_GPIOA_REGISTER_ADDRESS { get { return 0x12; } } // GPIO register is used to read the pins input
        public static byte PORT_EXPANDER_GPIOB_REGISTER_ADDRESS { get { return 0x13; } } // GPIO register is used to read the pins input

        public static byte PORT_EXPANDER_OLATA_REGISTER_ADDRESS { get { return 0x14; } } // Output Latch register is used to set the pins output high/low
        public static byte PORT_EXPANDER_OLATB_REGISTER_ADDRESS { get { return 0x15; } } // Output Latch register is used to set the pins output high/low

        public static byte PORT_EXPANDER_I2C_ADDRESS
        {
            get { return i2cAddress; }
            private set { i2cAddress = value; }
        }
    }
}
