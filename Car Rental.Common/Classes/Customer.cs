﻿using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public int Ssn { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public Customer(int ssn, string firstName, string lastName)
    {
        Ssn = ssn;
        FirstName = firstName;
        LastName = lastName;
    }
}
