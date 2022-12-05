using DLib;
using System.Collections.Generic;

namespace Hazi_Etelek {
    class Type {
        public readonly int Id;
        public readonly string Name;

        public Type(int id, string name) {
            Id = id;
            Name = name;
        }

        static public List<Type> DBRead(SQL db) {
            var res = db.Query("Select * FROM `kategoria`;");
            var list = new List<Type>();
            foreach (var item in res.Values) {
                var id = int.Parse(item[0]);
                var name = item[1];
                list.Add(new Type(id, name));
            }
            return list;
        }

        public override string ToString() {
            return Name;
        }
    }
}
