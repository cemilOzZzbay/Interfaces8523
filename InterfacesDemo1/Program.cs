using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   IDatabase dbSql = new SqlDatabase();
            dbSql.Add();
            dbSql.Update();
            dbSql.Delete();
            dbSql.List(); 
            
            IDatabase dbOracle = new OracleDatabase();
            dbOracle.Add();
            dbOracle.Update();
            dbOracle.Delete();
            dbOracle.List(); */
            
         //   Console.ReadLine();
        }
    }
    #region 1. Class: (SQL Database)   
    class SqlDatabase : IDatabase 
    { 
        public void Add() 
        {
            Console.WriteLine("Added to SQL");
        }
        public void Update() 
        {
            Console.WriteLine("Updated to SQL");
        }
        public void Delete() 
        {
            Console.WriteLine("Deleted from SQL");
        }
        public void List() 
        {
            Console.WriteLine("Listed from SQL");
        }
    }
    #endregion
    #region 2. Class: (ORACLE Database)   
    class OracleDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Added to ORACLE");
        }

        public void Update()
        {
            Console.WriteLine("Updated to ORACLE");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from ORACLE");
        }

        public void List()
        {
            Console.WriteLine("Listed from ORACLE");
        }
    }
    #endregion

    #region Interface: (IDatabase)
    interface IDatabase
    {
        void Add();
        void Update();
        void Delete();
        void List();
    }
    #endregion
}
