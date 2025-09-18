using DLMSCosemSpace;
using System;

namespace DLMS_GET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OBIS code for Active Energy Import (1-0:1.8.0.255)
            var obis = new ObisCode(1, 0, 1, 8, 0, 255);

            // Class ID for Register object is 3
            ushort classId = 3;
            byte attributeId = 2; // e.g., value attribute

            byte[] apdu = GetRequestApdu.CreateGetRequest(obis, classId, attributeId);

            Console.WriteLine("OBIS Code: " + obis);
            Console.WriteLine("GET Request APDU: " + BitConverter.ToString(apdu));

            var dlmsObject = new GET_SET();

            // Define OBIS codes for Voltage and Energy
            byte[] obis_voltage = { 1, 0, 1, 8, 0, 255 };
            byte[] obis_energy = { 1, 0, 3, 8, 0, 255 };

            // SET example
            dlmsObject.dlms_set(obis_voltage, 240);

            // ACTION example (reset all values)
            dlmsObject.dlms_action(obis_energy, "RESET");

            // READ/WRITE using Short Name referencing
            dlmsObject.dlms_read_sn(0x0001);
            dlmsObject.dlms_write_sn(0x0001, 5000);
        }
    }
}
