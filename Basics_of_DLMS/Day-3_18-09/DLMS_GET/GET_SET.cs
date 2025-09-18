using System;
using System.Collections.Generic;

namespace DLMS_GET
{
    internal class MeterObject
    {
        public string Name { get; set; }
        public byte[] Obis { get; set; } = new byte[6];
        public int Value { get; set; }
    }

    internal class GET_SET
    {
        private List<MeterObject> meterObjects;

        public GET_SET()
        {
            // Example initialization
            meterObjects = new List<MeterObject>
            {
                new MeterObject { Name = "Voltage", Obis = new byte[]{1,0,1,8,0,255}, Value = 230 },
                new MeterObject { Name = "Current", Obis = new byte[]{1,0,2,8,0,255}, Value = 10 },
                new MeterObject { Name = "Energy",  Obis = new byte[]{1,0,3,8,0,255}, Value = 1000 }
            };
        }

        private bool ObisMatch(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i]) return false;
            return true;
        }

        // ==== GET Service ====
        public void DlmsGet(byte[] obis)
        {
            foreach (var obj in meterObjects)
            {
                if (ObisMatch(obis, obj.Obis))
                {
                    Console.WriteLine($"[GET] {obj.Name} = {obj.Value}");
                    return;
                }
            }
            Console.WriteLine("[GET] Obis code not found.");
        }

        // ==== SET Service ====
        public void dlms_set(byte[] obis, int newValue)
        {
            foreach (var obj in meterObjects)
            {
                if (ObisMatch(obis, obj.Obis))
                {
                    obj.Value = newValue;
                    Console.WriteLine($"[SET] {obj.Name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[SET] Obis code not found.");
        }

        // ==== ACTION Service ====
        public void dlms_action(byte[] obis, string method)
        {
            if (method == "RESET")
            {
                Console.WriteLine("[ACTION] Resetting meter values ...");
                foreach (var obj in meterObjects)
                {
                    obj.Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method == "SYNC_TIME")
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time ...");
                // Time sync logic here
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }

        // ==== READ (Short Name referencing) ====
        public void dlms_read_sn(ushort shortName)
        {
            Console.WriteLine($"[READ-SN] Reading object with Short Name: 0x{shortName:X4}");
            // Here, map SN to OBIS and return the value
        }

        // ==== WRITE (Short Name referencing) ====
        public void dlms_write_sn(ushort shortName, int newValue)
        {
            Console.WriteLine($"[WRITE-SN] Writing value {newValue} to Short Name: 0x{shortName:X4}");
            // Here, map SN to OBIS and set the value
        }
    }
}
