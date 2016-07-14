using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_car_info.cshtml"];
      };
      Get["/view_all_cars"] = _ => {
        Car newCar = new Car(
          Request.Query["new-model"],
          Request.Query["new-price"],
          Request.Query["new-miles"]
        );
        return View["car_added.cshtml", newCar];
      };

      Post["/car_cleared"] = _ => {
        Car.ClearAll();
        return View["car_cleared.cshtml"];
      };


    }
  }
}
