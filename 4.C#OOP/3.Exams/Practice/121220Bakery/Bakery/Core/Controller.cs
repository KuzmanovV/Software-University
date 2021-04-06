using System.Collections.Generic;
using System.Linq;
using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private List<IBakedFood> backedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;
        private decimal totalIncome=0;

        public Controller()
        {
            this.backedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }

        public string AddFood(string type, string name, decimal price)
        {
            if (type == "Bread")
            {
                backedFoods.Add(new Bread(name, price));
            }
            if (type == "Cake")
            {
                backedFoods.Add(new Cake(name, price));
            }

            return $"Added {name} ({type}) to the menu";
        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            if (type == "Water")
            {
                drinks.Add(new Water(name, portion, brand));
            }
            if (type == "Tea")
            {
                drinks.Add(new Tea(name, portion, brand));
            }

            return $"Added {name} ({brand}) to the drink menu";
        }
        public string AddTable(string type, int tableNumber, int capacity)
        {
            if (type == "InsideTable")
            {
                tables.Add(new InsideTable(tableNumber, capacity));
            }
            if (type == "OutsideTable")
            {
                tables.Add(new OutsideTable(tableNumber, capacity));
            }

            return $"Added table number {tableNumber} in the bakery";
        }

        public string ReserveTable(int numberOfPeople)
        {
            ITable tableToReserve = tables.FirstOrDefault(t => t.IsReserved == false && t.Capacity >= numberOfPeople);

            if (tableToReserve == null)
            {
                return $"No available table for {numberOfPeople} people";
            }

            tableToReserve.Reserve(numberOfPeople);
            return $"Table {tableToReserve.TableNumber} has been reserved for {numberOfPeople} people";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }
            else
            {
                IBakedFood food = backedFoods.FirstOrDefault(t => t.Name == foodName);
                if (food == null)
                {
                    return $"No {foodName} in the menu";
                }
                else
                {
                    table.OrderFood(food);
                    return $"Table {tableNumber} ordered {foodName}";
                }
            }
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }
            else
            {
                var drink = drinks.FirstOrDefault(t => t.Name == drinkName && t.Brand==drinkBrand);
                if (drink == null)
                {
                    return $"There is no {drinkName} {drinkBrand} available";
                }
                else
                {
                    table.OrderDrink(drink);
                    return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
                }
            }
        }

        public string LeaveTable(int tableNumber)
        {
            var table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            decimal bill = table.GetBill();

            totalIncome += bill;
            
            table.Clear();

            return $"Table: {tableNumber}\r\nBill: {bill:f2}";
        }

        public string GetFreeTablesInfo()
        {
            var freeTables = tables.Where(t => !t.IsReserved).ToList();

            string result = "";
            foreach (var freeTable in freeTables)
            {
                result+= freeTable.GetFreeTableInfo()+"\r\n";
            }

            return result.TrimEnd();
        }

        public string GetTotalIncome()
        {
            return $"Total income: {totalIncome:f2}lv";
        }
    }
}