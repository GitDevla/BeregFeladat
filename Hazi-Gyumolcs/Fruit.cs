using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_Gyumolcs {
    class Fruit {
        int id;
        string name;
        int price;
        int quantity;

        public Fruit(int id, string name, int price, int quantity) {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString() {
            return Name;
        }
    }
}
