using BuilderDP.Components;
using BuilderDP.Products;

namespace BuilderDP.Builders
{
    public class VehicleBuilders : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            var result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
           vehicle.Engine = engine; 
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmission(EVehicleTransmission transmission)
        {
            vehicle.VehicleTransmission = transmission;
        }

        public void SetVehicleType(EVehicleTyple vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }
    }
}
