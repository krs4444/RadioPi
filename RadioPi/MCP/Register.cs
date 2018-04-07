namespace RadioPi.MCP
{
    public sealed class Register
    {
        public byte GPIOA { get { return Addresses.PORT_EXPANDER_GPIOA_REGISTER_ADDRESS; } }
        public byte GPIOB { get { return Addresses.PORT_EXPANDER_GPIOB_REGISTER_ADDRESS; } }
        public byte IODIRA { get { return Addresses.PORT_EXPANDER_GPIOA_REGISTER_ADDRESS; } }
        public byte IODIRB { get { return Addresses.PORT_EXPANDER_IODIRB_REGISTER_ADDRESS; } }
        public byte GPINTA { get { return Addresses.PORT_EXPANDER_GPINTA_ADDRESS; } }
        public byte GPINTB { get { return Addresses.PORT_EXPANDER_GPINTB_ADDRESS; } }
        public byte IPOLA { get { return Addresses.PORT_EXPANDER_IPOLA_REGISTER_ADDRESS; } }
        public byte IPOLB { get { return Addresses.PORT_EXPANDER_IPOLB_REGISTER_ADDRESS; } }
        public byte DEFVALA { get { return Addresses.PORT_EXPANDER_DEFVALA_ADDRESS; } }
        public byte DEFVALB { get { return Addresses.PORT_EXPANDER_DEFVALB_ADDRESS; } }
        public byte INTCON { get { return Addresses.PORT_EXPANDER_IOCON_ADDRESS; } }
        public byte GPPUA { get { return Addresses.PORT_EXPANDER_GPPUA_ADDRESS; } }
        public byte GPPUB { get { return Addresses.PORT_EXPANDER_GPPUB_ADDRESS; } }
        public byte INTFA { get { return Addresses.PORT_EXPANDER_INTFA_ADDRESS; } }
        public byte INTFB { get { return Addresses.PORT_EXPANDER_INTFB_ADDRESS; } }
        public byte INTCAPA { get { return Addresses.PORT_EXPANDER_INTCAPA_ADDRESS; } }
        public byte INTCAPB { get { return Addresses.PORT_EXPANDER_INTCAPB_ADDRESS; } }
        public byte OLATA { get { return Addresses.PORT_EXPANDER_OLATA_REGISTER_ADDRESS; } }
        public byte OLATB { get { return Addresses.PORT_EXPANDER_OLATB_REGISTER_ADDRESS; } }
    }
}
