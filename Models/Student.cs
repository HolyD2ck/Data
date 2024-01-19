using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Student
    {
        public int id { get; set; }
        public string? Фамилия { get; set; }
        public string? Имя { get; set; }
        public string? Отчество { get; set; }
        public int Рост { get; set; }
        public string? День_Рождения { get; set; }
        public string? Группа { get; set; }
        public string? Специальность { get; set; }
        public string? Стипендия { get; set; } 
        public int? Возраст { get; set; }
    }
    public class View
    {
        public int id { get; set; }
        public string? Фамилия { get; set; }
        public string? Имя { get; set; }
        public string? Отчество { get; set; }
        public int Рост { get; set; }
        public string? День_Рождения { get; set; }
        public string? Группа { get; set; }
        public string? Специальность { get; set; }
        public string? Стипендия { get; set; }
        public int? Возраст { get; set; }
    }
    public class Prepod
    {
        public int id { get; set; }
        public string? Фамилия { get; set; }
        public string? Имя { get; set; }
        public string? Отчество { get; set; }
        public string? Куратор_Группы { get; set; }
        public string? Профессия { get; set; }

        [DataType(DataType.Date)]
        public DateTime День_Рождения { get; set; }
        public int Номер_Кабинета { get; set; }
        public int Зарплата { get; set; }
        public int Стаж { get; set; }
    }
}
