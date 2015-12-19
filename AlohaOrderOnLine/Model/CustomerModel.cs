using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlohaOrderOnLine.Model
{
    public class CustomerModel
    {
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string VoicePhone { get; set; }
        public string VoicePhoneExtension { get; set; }
        public string DepartmentName { get; set; }
        public string AltPhone { get; set; }
        public string AltPhoneExtension { get; set; }
        public int FavoriteSiteId { get; set; }
        public string LoyaltyCardNumber { get; set; }
        public string SecondaryEmailAddress { get; set; }

        public AddressesModel Addresses { get; set; }

        public string Birthday { get; set; }
        public string LoyaltyZipCode { get; set; }
        public int FacebookId { get; set; }


    }
}
