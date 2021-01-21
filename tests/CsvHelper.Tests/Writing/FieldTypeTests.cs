using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.Tests.Writing
{
	[TestClass]
    public class FieldTypeTests
    {
		[TestMethod]
        public void Test1()
		{
			using (var writer = new StringWriter())
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteField(string.Empty);
				Assert.AreEqual(typeof(string), csv.FieldType);

				csv.WriteField(1);
				Assert.AreEqual(typeof(int), csv.FieldType);

				csv.WriteField(string.Empty);
				Assert.AreEqual(typeof(string), csv.FieldType);

				csv.NextRecord();
				Assert.AreEqual(null, csv.FieldType);
			}
		}
    }
}
