using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp
{
    public class Person
    {
            public string FName { get; set; }
            public string LName { get; set; }
            public string MPhone { get; set; }
            public string HPhone { get; set; }
            public string Email { get; set; }

            public Person(string Fname, string Lname, string Mphone, string Hphone, string email)
            {
                FName = Fname;
                LName = Lname;
                MPhone = Mphone;
                HPhone = Hphone;
                Email = email;
            }

            public Person()
            {
                FName=LName =MPhone = HPhone = Email = "";
            }
    }
}
