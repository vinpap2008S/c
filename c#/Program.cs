using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var clients = new[]
        {
            new { Month = 1, Year = 2022, ClientCode = 1, Duration = 5 },
            new { Month = 2, Year = 2022, ClientCode = 2, Duration = 7 },
            new { Month = 3, Year = 2022, ClientCode = 3, Duration = 9 }
        };

        var maxDurationClient = clients.OrderByDescending(c => c.Duration).ThenByDescending(c => c.Year).ThenByDescending(c => c.Month).First();
        Console.WriteLine($"Максимальная продолжительность занятий: {maxDurationClient.Duration}, Год: {maxDurationClient.Year}, Месяц: {maxDurationClient.Month}");

        var applicants = new[]
        {
            new { Year = 2022, SchoolNumber = 1, LastName = "Иванов" },
            new { Year = 2022, SchoolNumber = 2, LastName = "Петров" },
            new { Year = 2023, SchoolNumber = 1, LastName = "Сидоров" }
        };

        var groupedApplicants = applicants.GroupBy(a => a.Year)
                                          .Select(group => new { Year = group.Key, Count = group.Count() })
                                          .OrderByDescending(g => g.Count)
                                          .ThenBy(g => g.Year);

        foreach (var group in groupedApplicants)
        {
            Console.WriteLine($"{group.Count} абитуриентов поступили в {group.Year} году");
        }


        var applicants = new[]
        {
            new { LastName = "Иванов", SchoolNumber = 1, Year = 2022 },
            new { LastName = "Петров", SchoolNumber = 2, Year = 2022 },
            new { LastName = "Сидоров", SchoolNumber = 1, Year = 2023 }
        };

        var maxApplicantsBySchool = applicants.GroupBy(a => a.SchoolNumber)
                                              .Select(group => new { SchoolNumber = group.Key, Count = group.Count() })
                                              .OrderByDescending(g => g.Count)
                                              .First();

        var maxApplicantsFromSchool = applicants.Where(a => a.SchoolNumber == maxApplicantsBySchool.SchoolNumber)
                                                .OrderBy(a => a.SchoolNumber)
                                                .ThenBy(a => a.LastName);

        foreach (var applicant in maxApplicantsFromSchool)
        {
            Console.WriteLine($"{applicant.SchoolNumber} - {applicant.LastName}");
        }

        var students = new[]
        {
            new { FirstName = "Иван", LastName = "Иванов", Age = 20, AverageScore = 4.5 },
            new { FirstName = "Петр", LastName = "Петров", Age = 21, AverageScore = 4.8 },
            new { FirstName = "Сидор", LastName = "Сидоров", Age = 19, AverageScore = 4.2 }
        };

        var topStudent = students.OrderByDescending(s => s.AverageScore).First();
        Console.WriteLine($"Студент с самым высоким средним баллом: {topStudent.FirstName} {topStudent.LastName}, Возраст: {topStudent.Age}, Средний балл: {topStudent.AverageScore}");


        var numbers = new[] { 10, 20, 30, 40, 50 };
        double sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        double average = sum / numbers.Length;
        Console.WriteLine($"Среднее арифметическое чисел: {average}");
    }
}
