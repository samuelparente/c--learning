//Samuel Parente - C# programming exercises

using System;

namespace TaskManager
{
    class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }
    }

    class taskManager
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        MarkTaskAsCompleted();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            tasks.Add(new Task(description));
            Console.WriteLine("Task added successfully.");
        }

        static void ListTasks()
        {
            Console.WriteLine("Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. [{(tasks[i].IsCompleted ? "X" : " ")}] {tasks[i].Description}");
                }
            }
        }

        static void MarkTaskAsCompleted()
        {
            Console.Write("Enter task number to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].IsCompleted = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void DeleteTask()
        {
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
