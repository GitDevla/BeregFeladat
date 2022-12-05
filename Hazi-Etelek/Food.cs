using DLib;
using System.Collections.Generic;

namespace Hazi_Etelek {
    class Food {
        public readonly int Id;
        public readonly string Name;
        public readonly int Type;
        public readonly bool Vegetarian;
        public readonly int Price;

        public Food(int id, string name, int type, bool vegetarian, int price) {
            Id = id;
            Name = name;
            Type = type;
            Vegetarian = vegetarian;
            Price = price;
        }

        public void DBCreate(SQL db) {
            db.Query("INSERT INTO `etelek` (`etel`, `kat_id`, `vega`, `ar`) VALUES ('@1', '@2', '@3', '@4');"
                , Name, Type, Vegetarian, Price);
        }

        static public List<Food> DBRead(SQL db) {
            var res = db.Query("Select * FROM `etelek`;");
            var list = new List<Food>();
            foreach (var item in res.Values) {
                var id = int.Parse(item[0]);
                var name = item[1];
                var type = int.Parse(item[2]);
                var veg = bool.Parse(item[3]);
                var price = int.Parse(item[4]);
                list.Add(new Food(id, name, type, veg, price));
            }
            return list;
        }

        public void DBUpdate(SQL db, Food to) {
            db.Query("UPDATE `etelek` SET `etel` = @2, `kat_id` = @3, `vega` = @4, `ar` = @5 WHERE `etel`.`id` = @1;",
                Id, to.Name, to.Type, to.Vegetarian, to.Price);
        }

        public void DBDelete(SQL db) {
            db.Query("DELETE FROM etel WHERE `etel`.`id` = @1;", Id);
        }

        public Type GetTType(SQL db) {
            var res = db.Query("Select * FROM `kategoria` where id = @1;",Type);
            return new Type(int.Parse(res.Values[0][0]), res.Values[0][1]);
        }
        public override string ToString() {
            return Name;
        }
    }
}
