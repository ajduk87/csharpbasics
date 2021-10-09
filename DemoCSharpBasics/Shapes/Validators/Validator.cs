using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes.Validators
{
    public class Validator
    {

        private bool ValidateName(string name) 
        {
            //Name of Shape can not be null
            if (string.IsNullOrEmpty(name) == false)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private bool ValidateMaterial(string material) 
        {
            List<string> availableMaterials = new List<string>();
            availableMaterials.Add("PLASTIC");
            availableMaterials.Add("WOOD");
            availableMaterials.Add("METAL");
            availableMaterials.Add("GLASS");

            //Material have to be one of 4 available materials in shape store (plastic, wood, metal, glass)
            if (availableMaterials.Contains(material))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private bool ValidatePrice(double price) 
        {
            //Price should always be greater than zero
            if (price > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public List<string> Validate(Shape shape) 
        {
            List<string> errors = new List<string>();

            if (ValidateName(shape.Name) == false) 
            {
                errors.Add("Name of Shape can not be null");
            }

            if (ValidateMaterial(shape.Material) == false)
            {
                errors.Add("Material have to be one of 4 available materials in shape store (plastic, wood, metal, glass)");
            }

            if (ValidatePrice(shape.Price) == false) 
            {
                errors.Add("Price should always be greater than zero");
            }

            return errors;       }
    }
}
