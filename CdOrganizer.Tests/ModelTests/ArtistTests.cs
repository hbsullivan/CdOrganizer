using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CdOrganizer.Models;
using System;

namespace CdOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }
    
    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artsit()
    {
      Artist newItem = new Artist("test");
      Assert.AreEqual(typeof(Artist), newItem.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Bach";
      Artist newArtist = new Artist(name);
      string result = newArtist.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string name = "Bach";
      Artist newItem = new Artist(name);
      string updatedname = "Mozart";
      newItem.Name = updatedname;
      string result = newItem.Name;
      Assert.AreEqual(updatedname, result);
    }

     [TestMethod]
    public void GetAll_ReturnsEmptyList_ArtistList()
    {
      List<Artist> newList = new List<Artist> { };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

     [TestMethod]
    public void GetAll_ReturnsArtists_ArtistList()
    {
      string name01 = "Bach";
      string name02 = "Mozart";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}