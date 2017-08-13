namespace Logger
{
    using Interfaces;
    using Models;
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;

    public class SetUp
    {
        public static void Main()
        {
            List<IAppender> appenders = new List<IAppender>();
            int appendersCount = int.Parse(Console.ReadLine());
            string appendersNamespace = "Logger.Models.Appenders.";
            string layoutsNamespace = "Logger.Models.Layouts.";

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appendersInfo = Console.ReadLine().Split();
                Type appenderType = Type.GetType(appendersNamespace + appendersInfo[0]);
                Type layoutType = Type.GetType(layoutsNamespace + appendersInfo[1]);
                Object layout = Activator.CreateInstance(layoutType);
                IAppender appender = (IAppender)Activator.CreateInstance(appenderType, new object[] { layout });

                if (appendersInfo.Length > 2)
                {
                    string reportLevelString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(appendersInfo[2].ToLower());
                    ReportLevel reportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevelString);
                    var reportLevelProp = appender.GetType().GetProperty("ReportLevel", BindingFlags.Instance | BindingFlags.Public);
                    reportLevelProp.SetValue(appender, reportLevel);
                }

                appenders.Add(appender);
            }

            Logger logger = new Logger(appenders.ToArray());
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commandInfo = input.Split('|');
                string commandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandInfo[0].ToLower());
                string dateTime = commandInfo[1];
                string message = commandInfo[2];

                var command = typeof(Logger).GetMethod(commandName, BindingFlags.Instance | BindingFlags.Public);
                var loggerInstance = Activator.CreateInstance(typeof(Logger), new object[] { appenders.ToArray() });
                string[] parameters = new[] { dateTime, message };
                command.Invoke(loggerInstance, new object[] { parameters });

                input = Console.ReadLine();
            }

            Console.WriteLine("Logger info");
            foreach (var appender in appenders)
            {
                Console.WriteLine($"Appender type: {appender.GetType().Name}, Layout type: {appender.Layout.GetType().Name}, Report level: {appender.ReportLevel.ToString().ToUpper()}, Messages appended: {appender.MessagesAppended}");
            }
        }
    }
}
