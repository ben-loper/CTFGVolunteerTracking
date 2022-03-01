using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.DTOs
{
    public class VolunteerSignUp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> PreferredContactMethods { get; set; }
        public List<string> Interests { get; set; }
        public List<string> Skills { get; set; }
        public HeadingCommitteeInterestResponse InterestedInHeadingCommittee { get; set; } = HeadingCommitteeInterestResponse.NO;
    }
}
