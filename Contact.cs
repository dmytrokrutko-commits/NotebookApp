using System;

namespace NotebookApp
{
    public enum RelationType
    {
        Friend        = 0,  
        Colleague     = 1,   
        Relative      = 2,   
        Acquaintance  = 3,   
        Other         = 4    
    }

    public class Contact
    {
        
        public Guid Id { get; set; } = Guid.NewGuid();

      
        public string LastName   { get; set; } = "";
        public string FirstName  { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public DateTime? BirthDate { get; set; }

       
        public string Phone   { get; set; } = "";
        public string Email   { get; set; } = "";
        public string Address { get; set; } = "";

       
        public string WorkPlace { get; set; } = "";
        public string Position  { get; set; } = "";


        public RelationType RelationType      { get; set; } = RelationType.Acquaintance;
        public string       BusinessQualities { get; set; } = "";
        public string       Notes             { get; set; } = "";

    
        public DateTime LastModified { get; set; } = DateTime.Now;
        public DateTime CreatedAt    { get; set; } = DateTime.Now;

       
        public string FullName =>
            $"{LastName} {FirstName} {MiddleName}".Trim();

        public bool HasBirthdayToday()
        {
            if (!BirthDate.HasValue) return false;
            var today = DateTime.Today;
            return BirthDate.Value.Month == today.Month
                && BirthDate.Value.Day   == today.Day;
        }

        public int? Age
        {
            get
            {
                if (!BirthDate.HasValue) return null;
                var today = DateTime.Today;
                int age = today.Year - BirthDate.Value.Year;
                if (BirthDate.Value.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string RelationTypeDisplay()
        {
            return RelationType switch
            {
                RelationType.Friend       => "Друг",
                RelationType.Colleague    => "Колега",
                RelationType.Relative     => "Родич",
                RelationType.Acquaintance => "Знайомий",
                RelationType.Other        => "Інший",
                _                         => ""
            };
        }
    }
}
