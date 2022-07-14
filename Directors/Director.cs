using BuilderDP.Builders;
using BuilderDP.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.Directors
{
    public class Director
    {
        public IBuilder Builder { get; set; }
        public ISUV SuvBuilder { get; set; }

        public Director(IBuilder builder)
        {
            Builder = builder;
        }
        public Director(SUVbuilder suvBuilder)
        {
            SuvBuilder = suvBuilder;
        }

        public void ConstructSedan() 
        {
            Builder.SetVehicleType(EVehicleTyple.SEDAN);
            Builder.SetEngine(new Engine(2000));
            Builder.SetSeats(2);
            Builder.SetTransmission(EVehicleTransmission.AUTOMATIC);
        }

        public void ConstructSUV() 
        {
            SuvBuilder.SetEngine(new Engine(2600));
            SuvBuilder.SetSeats(4);
            SuvBuilder.SetAirbags(2);
            SuvBuilder.SetVehicleType(EVehicleTyple.SUV);
            SuvBuilder.SetTransmission(EVehicleTransmission.AUTOMATIC_SEQUENTIAL);

        }
    }
}
