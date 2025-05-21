using FactoryProject.Products;
using FactoryProject.Products.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Creators.Concrete_Creators
{
    public class MacUIFactory : UIFactory
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }

        public override ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
