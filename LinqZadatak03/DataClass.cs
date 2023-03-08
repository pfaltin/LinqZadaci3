namespace LinqZadatak03
{
    internal class DataClass
    {
        public DataClass()
        {


        }

        public List<Participant> participantList = new List<Participant>()

        { 
           new Participant{ Id = 1, NameSurname = "Neko Jedan", CourseID = 1 } ,
           new Participant{ Id = 10, NameSurname = "Jeko Jedan", CourseID = 2 },
           new Participant{ Id = 1, NameSurname = "Qeko Jedan", CourseID = 2 },
           new Participant{ Id = 7, NameSurname = "Jeko Tre", CourseID = 2 },
           new Participant{ Id = 9, NameSurname = "Neko Dva", CourseID = 3 },
           new Participant{ Id = 3, NameSurname = "Eeko Tri", CourseID = 1 },
           new Participant{ Id = 4, NameSurname = "Reko Cetiri", CourseID = 2 },
           new Participant{ Id = 2, NameSurname = "Jeko Dva", CourseID = 2 },
           new Participant{ Id = 8, NameSurname = "Jeko Cetr", CourseID = 2 },
           new Participant{ Id = 5, NameSurname = "Teko Pet", CourseID = 3 },
           new Participant{ Id = 6, NameSurname = "Jeko Sedam", CourseID = 1 },

        };





        public List<Course> courseList = new List<Course>()
        {
            new Course{Id = 1, Title = "kukucanje" },
            new Course{Id = 2, Title = "bojanje" },
            new Course{Id = 3, Title = "stolarija" },
        };








    }
}
