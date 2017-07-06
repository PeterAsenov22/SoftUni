namespace PIN_Validation
{
    using System;
    using System.Text.RegularExpressions;

    public class PINValidation
    {
        public static void Main()
        {
            var personName = Console.ReadLine();
            var nameRegex = new Regex(@"^[A-Z][a-z]+\s[A-Z][a-z]+$");
            var nameIsValid = true;
            if (!nameRegex.IsMatch(personName))
            {
                Console.WriteLine("<h2>Incorrect data</h2>");
                nameIsValid = false;
            }

            if (nameIsValid)
            {
                var gender = Console.ReadLine();
                var PIN = Console.ReadLine();
                var PINregex = new Regex(@"^\d{10}$");
                if (PINregex.IsMatch(PIN))
                {
                    if (int.Parse(PIN[8].ToString()) % 2 == 0)
                    {
                        if (gender == "male")
                        {
                            var day = int.Parse($"{PIN[4]}{PIN[5]}");
                            var isDayValid = false;
                            if (day >= 1 && day <= 31)
                            {
                                isDayValid = true;
                            }

                            var month = int.Parse($"{PIN[2]}{PIN[3]}");
                            var isMonthValid = false;
                            if ((month >= 1 && month <= 12) ||
                                (month >= 21 && month <= 32) ||
                                (month >= 41 && month <= 52))
                            {
                                isMonthValid = true;
                            }

                            if (isMonthValid && isDayValid)
                            {
                                var sum = 0;
                                var array = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                                for (int i = 0; i < PIN.Length - 1; i++)
                                {
                                    sum += int.Parse(PIN[i].ToString()) * array[i];
                                }
                                var checkSum = (sum % 11) % 10;
                                if (checkSum != int.Parse(PIN[9].ToString()))
                                {
                                    Console.WriteLine("<h2>Incorrect data</h2>");
                                }
                                else
                                {
                                    Console.WriteLine($"{{\"name\":\"{personName}\",\"gender\":\"{gender}\",\"pin\":\"{PIN}\"}}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("<h2>Incorrect data</h2>");
                            }

                        }
                        else
                        {
                            Console.WriteLine("<h2>Incorrect data</h2>");
                        }
                    }
                    else
                    {
                        if (gender == "female")
                        {
                            var day = int.Parse($"{PIN[4]}{PIN[5]}");
                            var isDayValid = false;
                            if (day >= 1 && day <= 31)
                            {
                                isDayValid = true;
                            }

                            var month = int.Parse($"{PIN[2]}{PIN[3]}");
                            var isMonthValid = false;
                            if ((month >= 1 && month <= 12) ||
                                (month >= 21 && month <= 32) ||
                                (month >= 41 && month <= 52))
                            {
                                isMonthValid = true;
                            }

                            if (isMonthValid && isDayValid)
                            {
                                var sum = 0;
                                var array = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                                for (int i = 0; i < PIN.Length - 1; i++)
                                {
                                    sum += int.Parse(PIN[i].ToString()) * array[i];
                                }
                                var checkSum = (sum % 11) % 10;

                                if (checkSum != int.Parse(PIN[9].ToString()))
                                {
                                    Console.WriteLine("<h2>Incorrect data</h2>");
                                }
                                else
                                {
                                    Console.WriteLine(
                                        $"{{\"name\":\"{personName}\",\"gender\":\"{gender}\",\"pin\":\"{PIN}\"}}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("<h2>Incorrect data</h2>");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("<h2>Incorrect data</h2>");
                }
            }
        }
    }
}
