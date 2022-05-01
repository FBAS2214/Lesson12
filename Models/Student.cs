namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public float Score { get; set; }
        public DateOnly BirthDate { get; set; }


        public static List<Student> GetStudents() => new List<Student>
        {
            new Student{ Id = 1, Name = "Ceyhun", Surname = "Abdullayev", Score = 10, BirthDate = new DateOnly(2002, 4, 25) },
            new Student{ Id = 2, Name = "Ferman", Surname = "Asadov", Score = 8.9f, BirthDate = new DateOnly(2005, 8, 16) },
            new Student{ Id = 3, Name = "Nihad", Surname = "Axundzade", Score = 10.8f, BirthDate = new DateOnly(2006, 2, 17) },
            new Student{ Id = 4, Name = "Cefer", Surname = "Imamaliyev", Score = 10.5f, BirthDate = new DateOnly(1996, 11, 24) },
            new Student{ Id = 5, Name = "Leyla", Surname = "Qocayeva", Score = 11.6f, BirthDate = new DateOnly(2002, 11, 4) },
            new Student{ Id = 6, Name = "Aga", Surname = "Akberzade", Score = 12, BirthDate = new DateOnly(2006, 6, 12) },
            new Student{ Id = 7, Name = "Nihat", Surname = "Rustemli", Score = 9.7f, BirthDate = new DateOnly(2004, 10, 18) },
            new Student{ Id = 8, Name = "Elgun", Surname = "Salmanov", Score = 9.7f, BirthDate = new DateOnly(2004, 4, 24) },
            new Student{ Id = 9, Name = "Sebine", Surname = "Shukurova", Score = 11.3f, BirthDate = new DateOnly(2002, 7, 8) }
        };

        public override string ToString() => $@"
    Id: {Id}
    Name: {Name}
    Surname: {Surname}
    Score: {Score}
    BirthDate: {BirthDate.ToShortDateString()}";

    }
}