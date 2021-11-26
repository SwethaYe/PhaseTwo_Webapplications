using System;

namespace Day4_CoreViewModelApplication.Models
{
    public class Customer
    {
        public int CustomerId {  get; set; }
        public string Name {  get; set; }
        public string City {  get; set; }
        public string Amount {  get; set; }
        public string Gender { get; internal set; }

       
    }
}
