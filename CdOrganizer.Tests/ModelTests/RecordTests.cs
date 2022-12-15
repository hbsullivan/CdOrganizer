using Microsoft.VisualStudio.TestTools.UnitTesting;
using CdOrganizer.Models;
using System.Collections.Generic;
using System;

namespace CdOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreateInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Goldberg Variations";
      Record newRecord = new Record(title);
      string result = newRecord.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetId_ReturnsRecordId_Int()
    {
      string title = "Test Title";
      Record newRecord = new Record(title);
      int result = newRecord.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllRecords_RecordList()
    {
      string title01 = "Goldberg Variations";
      string title02 = "Piano Concerto No.21";
      Record newRecord01 = new Record(title01);
      Record newRecord02 = new Record(title02);
      List<Record> newList = new List<Record> { newRecord01, newRecord02 };

      List<Record> result = Record.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
    public void Find_ReturnsCorrectRecord_Record()
    {
      string title01 = "Goldberg Variations";
      string title02 = "Piano Concerto No.21";
      Record newRecord1 = new Record(title01);
      Record newRecord2 = new Record(title02);
      Record result = Record.Find(2);
      Assert.AreEqual(newRecord2, result);
    }

  }
}