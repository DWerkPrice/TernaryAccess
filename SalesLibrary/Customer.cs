using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccess
{
    public class Customer {

        private static int NextId = 1;
        public int Id { get; private set; } // private before set prevents people from changing id
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }

        public static string PrintNextId() {
            return $"Next id is {NextId}";
        }
        public Customer(string Name) {
            this.Id = NextId;
            this.Name = Name;
            NextId++;
        }
    }
}
