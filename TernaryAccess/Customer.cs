using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccess
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }
    }
}
