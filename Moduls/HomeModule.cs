using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_car_info.cshtml"];
      Get["/view_all_cars"] = _ => {
        Car newCar = new Car(
          Request.Query["new-car"],
          Request.Query["new-price"],
          Request.Query["new-miles"]
          );
        return View["view_all_cars.cshtml", newCar];
    }
  }
}
