using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EduConnectEmailValidator
{
    // Model with Annotation + Regex
    public class EmailModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,6}$",
            ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }

        public EmailModel(string email)
        {
            Email = email;
        }
    }

    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("EduConnect College Admission Portal");
            Console.WriteLine("-----------------------------------");

            List<EmailModel> validEmails = new List<EmailModel>();

            try
            {
                Console.Write("Enter number of users: ");
                int count = int.Parse(Console.ReadLine());

                List<Task> tasks = new List<Task>();

                for (int i = 0; i < count; i++)
                {
                    tasks.Add(Task.Run(() =>
                    {
                        try
                        {
                            Console.Write("Enter Email: ");
                            string input = Console.ReadLine();

                            EmailModel model = new EmailModel(input);

                            var context = new ValidationContext(model);
                            var results = new List<ValidationResult>();

                            bool isValid = Validator.TryValidateObject(model, context, results, true);

                            if (isValid)
                            {
                                lock (validEmails)
                                {
                                    validEmails.Add(model);
                                }
                                Console.WriteLine("Valid Email");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Email");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }));
                }

                await Task.WhenAll(tasks);

                // Write to JSON file
                string json = JsonConvert.SerializeObject(validEmails, Formatting.Indented);
                File.WriteAllText("emails.json", json);

                Console.WriteLine("\nAll valid emails saved to emails.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error: " + ex.Message);
            }
        }
    }
}
