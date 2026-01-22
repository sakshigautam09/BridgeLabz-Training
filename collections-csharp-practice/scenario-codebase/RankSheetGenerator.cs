using System;
using System.Collections.Generic;
class RankSheetGenerator
{
    // -------- Student class --------
    public class Student
    {
        public string Name { get; set; }
        public string District { get; set; }
        public int Score { get; set; }

        public Student(string name, string district, int score)
        {
            Name = name;
            District = district;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} ({District}) - {Score}";
        }
    }

    // -------- Merge Sort --------
    public void MergeSort(List<Student> students)
    {
        if (students.Count <= 1) return;
        MergeSortRecursive(students, 0, students.Count - 1);
    }

    private void MergeSortRecursive(List<Student> students, int left, int right)
    {
        if (left >= right) return;

        int mid = left + (right - left) / 2;
        MergeSortRecursive(students, left, mid);
        MergeSortRecursive(students, mid + 1, right);
        Merge(students, left, mid, right);
    }

    private void Merge(List<Student> students, int left, int mid, int right)
    {
        List<Student> temp = new List<Student>();
        int i = left, j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (students[i].Score >= students[j].Score)
            {
                temp.Add(students[i]);
                i++;
            }
            else
            {
                temp.Add(students[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(students[i]);
            i++;
        }

        while (j <= right)
        {
            temp.Add(students[j]);
            j++;
        }

        for (int k = 0; k < temp.Count; k++)
        {
            students[left + k] = temp[k];
        }
    }

    // -------- Utility to print list --------
    public void PrintList(List<Student> list)
    {
        foreach (Student student in list)
            Console.WriteLine(student);
    }

    static void Main()
    {
        RankSheetGenerator generator = new RankSheetGenerator();

        // Example: district-wise sorted lists
        List<Student> district1 = new List<Student>
        {
            new Student("Alice", "District1", 95),
            new Student("Bob", "District1", 90),
            new Student("Charlie", "District1", 90)
        };

        List<Student> district2 = new List<Student>
        {
            new Student("David", "District2", 98),
            new Student("Eve", "District2", 85)
        };

        // Merge all district lists into one final list
        List<Student> finalList = new List<Student>();
        finalList.AddRange(district1);
        finalList.AddRange(district2);

        Console.WriteLine("Before Sorting:");
        generator.PrintList(finalList);

        generator.MergeSort(finalList);

        Console.WriteLine("\nFinal State-Wise Rank List:");
        generator.PrintList(finalList);
    }
}
