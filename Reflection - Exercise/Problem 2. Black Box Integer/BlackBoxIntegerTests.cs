﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Problem_2.Black_Box_Integer
{
    public class BlackBoxIntegerTests
    {
        private StringBuilder testResult;

        public BlackBoxIntegerTests()
        {
            this.testResult = new StringBuilder();
        }

        public string Run(Type type)
        {
            var classInstance = Activator.CreateInstance(type, true);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var command = Console.ReadLine().Split('_');

            while (command[0] != "END")
            {
                var num = int.Parse(command[1]);
                methods.FirstOrDefault(m => m.Name == command[0])?.Invoke(classInstance, new object[] { num });

                foreach (var field in fields)
                {
                    testResult.AppendLine(field.GetValue(classInstance).ToString());
                }

                command = Console.ReadLine().Split('_');
            }

            return this.testResult.ToString().Trim();
        }
    }
}
