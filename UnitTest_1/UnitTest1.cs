using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_1
{
    [TestClass]
    public class zheleznodorozhnoe
    {
        private readonly string m_passengerName;
        private double m_ticket_cost;

        private zheleznodorozhnoe() { }

        public zheleznodorozhnoe(string customerName, double balance)
        {
            m_passengerName = PassengerName;
            m_ticket_cost = ticket_cost;
        }

        public string PassengerName
        {
            get { return m_passengerName; }
        }

        public double ticket_cost
        {
            get { return m_ticket_cost; }
        }

        public void Prefential_cost(double amount)
        {
            if (amount > m_ticket_cost)
            {
                throw new ArgumentOutOfRangeException("not a preferential cost");
            }

            if (amount < 500)
            {
                throw new ArgumentOutOfRangeException("preferential cost");
            }

            m_ticket_cost += amount; // intentionally incorrect code
        }

        public void Not_acost(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("not a cost");
            }

            m_ticket_cost += amount;
        }

        public static void Main()
        {
            zheleznodorozhnoe ba = new zheleznodorozhnoe("Mr ", 120);

            ba.Not_acost(62.67);
            ba.Prefential_cost(456.42);
            Console.WriteLine("Current ticket cost is ${0}", ba.ticket_cost);
        }
    }
}


