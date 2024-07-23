using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Thiết lập mã hóa UTF-8 cho console
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Anh", Age = 16 },
            new Student { Id = 2, Name = "Bình", Age = 15 },
            new Student { Id = 3, Name = "An", Age = 18 },
            new Student { Id = 4, Name = "Cường", Age = 17 },
            new Student { Id = 5, Name = "Dũng", Age = 19 }
        };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sách toàn bộ học sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
        Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
        foreach (var student in ageRangeStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        var nameAStudents = students.Where(s => s.Name.StartsWith("A")).ToList();
        Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
        foreach (var student in nameAStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh trong danh sách
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        var sortedStudents = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sách học sinh theo tuổi tăng dần:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}