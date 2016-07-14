using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _MakeModel;
    private int _Price;
    private int _Miles;
    private static List<Car> _instances = new List<Car> {};


    public Car(string carModel, int carPrice, int carMiles)
    {
      _MakeModel = carModel;
      _Price = carPrice;
      _Miles = carMiles;
      _instances.Add(this);
    }

    public void SetMakeModel(string newMakeModel)
    {
      _MakeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _MakeModel;
    }

    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }
    public int GetPrice()
    {
      return _Price;
    }

    public void SetMiles(int newMiles)
    {
      _Miles = newMiles;
    }
    public int GetMiles()
    {
      return _Miles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
