using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using Component = System.ComponentModel.Component;
using IComponent = OnlineShop.Models.Products.Components.IComponent;

namespace OnlineShop.Core
{
    public class Controller:IController
    {
        private readonly IDictionary<int, IComputer> computers;
        private readonly IDictionary<int, IComponent> components;
        private readonly IDictionary<int, IPeripheral> peripherals;

        public Controller()
        {
            computers = new Dictionary<int, IComputer>();
            components = new Dictionary<int, IComponent>();
            peripherals = new Dictionary<int, IPeripheral>();
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (computers.ContainsKey(id))
            {
                throw new ArgumentException("Computer with this id already exists.");
            }

            IComputer computer;
            if (computerType=="Laptop")
            {
                computer = new Laptop(id,manufacturer,model,price);
            }
            else if (computerType== "DesktopComputer")
            {
                computer = new DesktopComputer(id,manufacturer,model,price);
            }
            else
            {
                throw new ArgumentException("Computer type is invalid.");
            }

            computers.Add(id,computer);
            return $"Computer with id {id} added successfully.";
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {
            if (!computers.ContainsKey(computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            if (components.ContainsKey(id))
            {
                throw new ArgumentException("Component with this id already exists.");
            }

            IComponent component = null;
            if (componentType == "Motherboard")
            {
                component = new Motherboard(id,manufacturer,model,price,overallPerformance,generation);
            }
            else if (componentType == "RandomAccessMemory")
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "SolidStateDrive")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "VideoCard")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType== "PowerSupply")
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);

            }
            else
            {
                throw new ArgumentException("Component type is invalid.");
            }
            
            computers[id].AddComponent(component);
            components.Add(id, component);
            return $"Component {componentType} with id {id} added successfully in computer with id {computerId}.";
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            if (!computers.ContainsKey(computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            IComponent component = computers[computerId].RemoveComponent(componentType);
                components.Remove(components.FirstOrDefault(c => c.GetType().Name == componentType));
                return $"Successfully removed {componentType} with id {component.Id}.";
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
            double overallPerformance, string connectionType)
        {
            if (!computers.ContainsKey(computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            if (peripherals.ContainsKey(id))
            {
                throw new ArgumentException("Peripheral with this id already exists.");
            }

            IPeripheral peripheral = null;
            if (peripheralType == "Headset")
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance,connectionType);
            }
            else if (peripheralType == "Keyboard")
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Monitor")
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Mouse")
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else
            {
                throw new ArgumentException("Peripheral type is invalid.");
            }

            computers[id].AddPeripheral(peripheral);
            peripherals.Add(id, peripheral);
            return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            if (!computers.ContainsKey(computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            IPeripheral peripheral = computers[computerId].RemovePeripheral(peripheralType);
            peripherals.Remove(peripherals.FirstOrDefault(c => c.GetType().Name == peripheralType));
            return $"Successfully removed {peripheralType} with id {peripheral.Id}.";
        }

        public string BuyComputer(int id)
        {
            if (!computers.ContainsKey(id))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            IComputer computer = computers[id];
            computers.Remove(id);
            return computer.ToString();
        }

        public string BuyBest(decimal budget)
        {
            var kvpComputer = computers.OrderByDescending(c => c.Value.OverallPerformance).FirstOrDefault(c=>c.Value.Price<=budget);

            if (computers.Count==0 || kvpComputer.Value==null)
            {
                throw new ArgumentException(" Can't buy a computer with a budget of ${budget}.");
            }

            return kvpComputer.Value.ToString();
        }

        public string GetComputerData(int id)
        {
            if (!computers.ContainsKey(id))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            return computers[id].ToString();
        }
    }
}