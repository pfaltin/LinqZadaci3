namespace LinqZadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\tHello, Zadatak 3!");
            DataClass dataClass = new DataClass();

            List<Participant> participantsList = dataClass.participantList;

            //Grupirati polaznike po ID-u tečaja uz pomoć LINQ metode GroupBy(primjer zad_3_1.png)


            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            var participants = participantsList.GroupBy(e => (e.CourseID));


            foreach (var participant in participants)
            {
                // Console.WriteLine("{0} ", participant.Key);
                foreach (var participant2 in participant)
                {
                    Console.WriteLine("{0} je na {1}", participant2.NameSurname, participant2.CourseID);
                }
            }



            //Grupirati polaznike po ID-u tečaja uz pomoć LINQ metode GroupBy. 
            //Kod ispisa podataka, umjesto Id-a tečaja ispišite naziv tečaja(primjer zad_3_2.png)

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            var participantsCourseName = participantsList.GroupBy(e => (e.CourseID));


            foreach (var participant in participantsCourseName)
            {
                // Console.WriteLine("{0} ", participant.Key);
                foreach (var participant2 in participant)
                {
                    Console.WriteLine("{0} je na {1}", participant2.NameSurname, dataClass.courseList.FirstOrDefault(e => e.Id == participant2.CourseID).Title);
                }
            }




            //Grupirati polaznike po prvom slovu imena i prezimena, a u listi polaznika ispiši naziv tečaja umjesto Id-a(primjer zad_3_3.png)

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            var participantsGroupByName = participantsList.GroupBy(e => (e.NameSurname.ToCharArray().First()));


            foreach (var participant in participantsGroupByName)
            {
                // Console.WriteLine("{0} ", participant.Key);
                foreach (var participant2 in participant)
                {
                    Console.WriteLine("{0} je na {1}", participant2.NameSurname, dataClass.courseList.FirstOrDefault(e => e.Id == participant2.CourseID).Title);
                }
            }




        }
    }
}