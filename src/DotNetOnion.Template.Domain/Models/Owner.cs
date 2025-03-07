﻿namespace DotNetOnion.Template.Domain.Models
{
    public class Owner
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
