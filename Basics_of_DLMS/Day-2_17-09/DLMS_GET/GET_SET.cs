using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMS_GET
{
    internal class GET_SET
    {
        void dlms_get(byte obis[6])
        {
            for (int i = 0; i < meterObjectCount; i++) {
                if (obis_match(obis, meterObjectCount; i++)) {
                Console.WriteLine([GET] "%s = %d\n", meterObjects[i].name, meterObjects[i].value);
                return;

                }

             }
        Console.Writeline([GET] "");
        } 

        void dlms_set(uint8_t obis[6], int32_t newValue)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (obis_match(obis, meterObjects[i].obis)) {
                    meterObjects[i].value = newValue;
                Console.WriteLine([SET] "%s updated to %d\n", meterObjects[i].name, = newValue);
                return;

            }

        }
        Console.Writeline([SET] "OBIS not found");
        } 
    }
}
