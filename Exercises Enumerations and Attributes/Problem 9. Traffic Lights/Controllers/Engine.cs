﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_9.Traffic_Lights.Enums;
using Problem_9.Traffic_Lights.Models;

namespace Problem_9.Traffic_Lights.Controllers
{
    class Engine
    {
        public void Run()
        {
            var devices = this.SetTrafficLightsDevicesDevices();
            var numberOfLightChanges = int.Parse(Console.ReadLine());
            Console.WriteLine(this.ChangeLights(devices, numberOfLightChanges));
        }

        private string ChangeLights(Queue<TrafficLight> devices, int numberOfLightChanges)
        {
            var sb = new StringBuilder();

            while (numberOfLightChanges > 0)
            {
                foreach (var device in devices)
                {
                    device.ChangeLight();
                    sb.Append($"{device.Light} ");
                }

                sb.Remove(sb.Length - 1, 1)
                    .AppendLine();
                numberOfLightChanges--;
            }

            return sb.ToString().Trim();
        }

        private Queue<TrafficLight> SetTrafficLightsDevicesDevices()
        {
            var deviceslightsFromInput = Console.ReadLine().Split();
            var devices = new Queue<TrafficLight>();

            foreach (var lightAsString in deviceslightsFromInput)
            {
                LightColor light;
                var isValid = Enum.TryParse(lightAsString, out light);

                if (isValid)
                {
                    devices.Enqueue(new TrafficLight(light));
                }
            }

            return devices;
        }
    }
}
