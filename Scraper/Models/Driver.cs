﻿namespace ScraperApp.Models;

public class Driver
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }

    //public int TeamId { get; set; }
    public List<Team> Team { get; set; }
}
