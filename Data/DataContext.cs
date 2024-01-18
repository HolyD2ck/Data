using Data.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<Data.Models.Student> Student { get; set; } = default!;

    public void EnsureData()
    {
        if (!Student.Any())
        {
            var data = ReadDataFromFile();
            Student.AddRange(data);
            SaveChanges();
        }
    }

    public List<Student> ReadDataFromFile()
    {
        List<string> lines = File.ReadAllLines("..\\Data\\wwwroot\\Base\\data.csv").ToList();
        List<Student> students = new List<Student>();

        foreach (var line in lines)
        {
            string[] splitLine = line.Split(';');
            var student = new Student
            {
                Фамилия = splitLine[0],
                Имя = splitLine[1],
                Отчество = splitLine[2],
                Рост = int.Parse(splitLine[3]),
                День_Рождения = splitLine[4],
                Группа = splitLine[5],
                Специальность = splitLine[6],
                Стипендия = splitLine[7]
            };
            students.Add(student);
        }

        return students;
    }
}
