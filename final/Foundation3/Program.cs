using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // For event 1

        string title1 = "Wedding M&J";
        string description1 = "Event to express the intention to share their lives in front of their family and God.";
        string date1 = "07/30/2031";
        string time1 = "16:45 (04:45pm)";

        // Address 1
        string street1 = "742 N 900 E St";
        string city1 = "American Fork";
        string state1 = "Utah";
        string country1 = "USA";

        Address address1 = new Address(street1, city1, state1, country1);

        string email1 = "weddingmj@specialevents.org";

        Reception reception = new Reception(title1, description1, date1, time1, address1, email1);

        // For event 2

        string title2 = "Foundation of Chemistry";
        string description2 = "Introduction to the understanding the connection between the macroscopic world that we experience and the microscopic world of atoms and molecules.";
        string date2 = "03/03/2025";
        string time2 = "09:20am";

        // Address 2
        string street2 = "Universidad Av";
        string city2 = "Cumana";
        string state2 = "Sucre";
        string country2 = "Venezuela";

        Address address2 = new Address(street2, city2, state2, country2);

        string speakPerson2 = "Roxis Lezama";
        int capacity2 = 45;

        Lecture lecture = new Lecture(title2, description2, date2, time2, address2, speakPerson2, capacity2);

        // For event 3

        string title3 = "Tea Party";
        string description3 = "All the guests will enjoy the landscape, listening to the water falls and humming birds. Entertaiment from the different types of seating from a cabana style, swing set and the elevations of the landscaped will make it very relaxing for the family.";
        string date3 = "06/14/2024";
        string time3 = "15:00 (3:00pm)";

        // Address 3
        string street3 = "Silver Hawk Dr";
        string city3 = "Diamond Bar";
        string state3 = "California";
        string country3 = "United States";

        Address address3 = new Address(street3, city3, state3, country3);

        string weatherForecast = "Sunny";

        OutdoorGathering outdoorGathering = new OutdoorGathering(title3, description3, date3, time3, address3, weatherForecast);

        List<Event> events = new List<Event>() {
            reception,
            lecture,
            outdoorGathering
        };

        int i = 0;

        foreach (Event eventInfo in events)
        {
            i++;

            Console.WriteLine($"Event {i}: \n");

            Console.WriteLine($"Standard Info: \n{eventInfo.GetStandardDetails()}\n");
            Console.WriteLine($"Detailed Info: \n{eventInfo.GetFullDetails()}\n");
            Console.WriteLine($"Superficial Info: \n{eventInfo.GetShortDescription()}\n");
        }
    }
}