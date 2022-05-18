using LSP.DataSourceSample.Bad;
using System;
using System.Collections.Generic;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbSource dbSource = new DbSource();
            ExcelDataSource excel = new ExcelDataSource();
            XMLSource xmlSource = new XMLSource();  
            List<DataSource> dataSources = new List<DataSource>();
            dataSources.Add(excel);
            dataSources.Add(xmlSource);
            dataSources.Add(dbSource);


            DataSourceProcess process = new DataSourceProcess();
            process.SaveAll(dataSources);

            Console.WriteLine("Hello World!");
        }
    }
}
