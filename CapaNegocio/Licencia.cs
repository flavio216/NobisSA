using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public static class Licencia
    {
        public static void CheckLicense()
        {
            string hash = GetHash(GetHardwareId("c")); //disco duro

            string cpu = GetCPUID().ToString(); // codigo del procesador
            if (hash != "f826ac0a5e86b116993d2e955c9880c9" || cpu != "BFEBFBFF000306A9")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MessageBox.Show("Licencia de esta pc no valida, comunicate con: flavio_ezequiel54@hotmail.com ");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
        //f826ac0a5e86b116993d2e955c9880c9   disco duro

        //Metodos de ofuscacion o encryptar

        //"BFEBFBFF000306A9" procesador
        static string GetHardwareId(string drive)
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");   // CONSULTAR
            dsk.Get();

            string volumeSerial = dsk["VolumeSerialNumber"].ToString();    // CONSULTAR
            return volumeSerial;
        }
        public static String GetCPUID()
        {
            string processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from win32_processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach ( ManagementObject obj in mObject)   // CONSULTAR
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
                
        }
        static string GetHash(string str)
        {
            MD5 obj = MD5.Create();
            string result = string.Empty;
            try
            {
                byte[] buf = obj.ComputeHash(Encoding.ASCII.GetBytes(str));
                StringBuilder o5b = new StringBuilder();

                foreach (byte thisByte in buf)
                {
                    o5b.Append(thisByte.ToString("x2")); // Consultar es o5b?
                }
                result = o5b.ToString().ToLower();
            }
            catch (Exception anyEx)
            {
                result = "[hash computing error]";
                throw;
            }
            return result;
        }
    }
}

