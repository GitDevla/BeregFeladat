using DLib;
using System;
using System.Collections.Generic;

namespace Hazi_Nyilvantartas {
    public class User {
        static public SQL db;
        private static readonly string dbTable = "users";

        public readonly int Id;
        public readonly string Name;
        public readonly DateTime Birth;

        public User(int id, string name, DateTime birth) {
            Id = id;
            Name = name;
            Birth = birth;
        }
        public void DBCreate() {
            db.Query($"INSERT INTO {dbTable} (name, birth) VALUES (@1, @2);"
                , Name, Birth);
        }

        public static int LastId() {
            return int.Parse(db.Query("select LAST_INSERT_ID()").Values[0][0]);
        }

        static public List<User> DBRead() {
            var res = db.Query($"Select * FROM {dbTable};");
            var list = new List<User>();
            foreach (var item in res.Values) {
                var id = int.Parse(item[0]);
                var name = item[1];
                var birth = DateTime.Parse(item[2]);
                list.Add(new User(id, name, birth));
            }
            return list;
        }

        public void DBUpdate(User to) {
            db.Query($"UPDATE {dbTable} SET name = @2, birth = @3 WHERE `id` = @1;",
                Id, to.Name, to.Birth);
        }

        public void DBDelete() {
            db.Query($"DELETE FROM {dbTable} WHERE `id` = @1;", Id);
        }

        public override string ToString() {
            return Name;
        }
    }
}
