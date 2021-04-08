using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private double _overallPerformance = 0;
        private decimal _price = 0;
        private IReadOnlyCollection<IComponent> components;
        private IReadOnlyCollection<IPeripheral> peripherals;

        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>(){};
            peripherals = new List<IPeripheral>(){};
        }

        public IReadOnlyCollection<IComponent> Components { get; private set; }
        public IReadOnlyCollection<IPeripheral> Peripherals { get; private set; }
        public void AddComponent(IComponent component)
        {
            if (Components.Contains(component))
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            Components.ToList().Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (Components.Count == 0 || Components.Any(c => c.GetType().Name == componentType))
            {
                throw new ArgumentException($"Component {componentType} does not exist in {GetType().Name} with Id {Id}.");
            }

            IComponent component = Components.ToList().FirstOrDefault(c => c.GetType().Name == componentType);
            Components.ToList().Remove(component);

            return component;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (Peripherals.Contains(peripheral))
            {
                throw new ArgumentException($"Peripheral {peripheral.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            Peripherals.ToList().Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (Peripherals.Count == 0 || Peripherals.Any(c => c.GetType().Name == peripheralType))
            {
                throw new ArgumentException($"Peripheral {peripheralType} does not exist in {GetType().Name} with Id {Id}.");
            }

            IPeripheral peripheral = Peripherals.ToList().FirstOrDefault(c => c.GetType().Name == peripheralType);
            Peripherals.ToList().Remove(peripheral);

            return peripheral;
        }

        public override double OverallPerformance
        {
            get
            {
                return _overallPerformance;
            }
            protected set
            {
                if (Components.Count == 0)
                {
                    _overallPerformance = value;
                }
                else
                {
                    _overallPerformance = value + AveragePerformance();
                }
            }
        }

        public override decimal Price
        {
            get
            {
                return _price;
            }
            protected set
            {
                _price = value;

                if (components.Count > 0)
                {
                    foreach (var component in components)
                    {
                        _price += component.Price;
                    }
                }

                if (peripherals.Count>0)
                {
                    foreach (var peripheral in peripherals)
                    {
                        _price += peripheral.Price;
                    }
                }
            }
        }

        private double AveragePerformance()
        {
            double sum = 0;

            foreach (var component in Components)
            {
                sum += component.OverallPerformance;
            }

            return sum / Components.Count;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Overall Performance: {OverallPerformance}. Price: {Price} - {GetType().Name}: {Manufacturer} {Model} (Id: {Id})");
            stringBuilder.AppendLine($" Components ({Components.Count}):");
            foreach (var component in Components)
            {
                stringBuilder.AppendLine($" {component}");
            }
            stringBuilder.AppendLine($"Peripherals {Peripherals.Count}); Average Overall Performance ({AveragePerformance()}):");
            foreach (var peripheral in Peripherals)
            {
                stringBuilder.AppendLine($" {peripheral}");
            }
            return stringBuilder.ToString();
        }


    }
}