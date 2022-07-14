using BuilderDP.Components;
using BuilderDP.Products;

namespace BuilderDP.Builders
{
    public class SUVbuilder : ISUV
    {
        private SUV suv = new SUV();
        public Vehicle GetVehicle()
        {
            var result = suv;
            Reset();
            return result;
        }

        public void Reset()
        {
            suv = new SUV();
        }

        public void SetAirbags(int airbags)
        {
            suv.Airbags = airbags;
        }

        public void SetEngine(Engine engine)
        {
            suv.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            suv.Seats = seats;
        }

        public void SetTransmission(EVehicleTransmission transmission)
        {
            suv.VehicleTransmission = transmission;
        }

        public void SetVehicleType(EVehicleTyple vehicleType)
        {
            suv.VehicleType = vehicleType;
        }
    }
}
