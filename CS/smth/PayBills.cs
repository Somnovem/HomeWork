using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    [Serializable]
    public class PayBill : ISerializable
    {
        static public bool SerializeTotals = false;
        public int SalaryPerDay { get; set; }
        public int DaysWorked { get; set; }
        public int PenaltyPerDay { get; set; }
        public int DaysSkipped { get; set; }
        public int TotalEarned { get { return SalaryPerDay * DaysWorked; }protected set { }}
        public int TotalPenalty { get { return PenaltyPerDay * DaysSkipped; } protected set { } }
        public int TotalToPay { get { return SalaryPerDay - TotalPenalty; } protected set { } }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SalaryPerDay", SalaryPerDay);
            info.AddValue("DaysWroked", DaysWorked);
            info.AddValue("PenaltyPerDay", PenaltyPerDay);
            info.AddValue("DaysSkipped", DaysSkipped);
            info.AddValue("SerializeTotals", SerializeTotals);
            if (SerializeTotals)
            {
                info.AddValue("TotalEarned", TotalEarned);
                info.AddValue("TotalPenalty", TotalPenalty);
                info.AddValue("TotalToPay", TotalToPay);
            }
        }

        public PayBill() { }

        PayBill(SerializationInfo info, StreamingContext context)
        {
            SalaryPerDay = info.GetInt32("SalaryPerDay");
            DaysWorked = info.GetInt32("DaysWroked");
            PenaltyPerDay = info.GetInt32("PenaltyPerDay");
            DaysSkipped = info.GetInt32("DaysSkipped");
            SerializeTotals = info.GetBoolean("SerializeTotals");
            if (SerializeTotals)
            {
                TotalEarned = info.GetInt32("TotalEarned");
                TotalPenalty = info.GetInt32("TotalPenalty");
                TotalToPay = info.GetInt32("TotalToPay");
            }
        }
        public override string ToString()
        {
            return $"Salary per day: {SalaryPerDay}\nDays worked: {DaysWorked}\nPenalty per day: {PenaltyPerDay}\nDays skipped: {DaysSkipped}\nTotal earned: {TotalEarned}\nTotal penalty: {TotalPenalty}\nTotal to pay: {TotalToPay}";
        }
    }
    static class Controller
    {
        static void Main()
        {
            PayBill bill = new PayBill() { SalaryPerDay = 400, DaysWorked = 28, PenaltyPerDay = 100, DaysSkipped = 2 };
            PayBill.SerializeTotals = true;
            Console.WriteLine(bill);
            Console.WriteLine("----------------------------------");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = File.Create("Bill.bin"))
            {
                binaryFormatter.Serialize(stream, bill);
            }
            bill = null;
            using (Stream stream = File.OpenRead("Bill.bin"))
            {
                bill = (PayBill)binaryFormatter.Deserialize(stream);
            }
            Console.WriteLine(bill);
        }
    }
}
